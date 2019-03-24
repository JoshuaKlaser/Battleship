using GameLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Battleship.Grid;
using Battleship.Content;
using Battleship.Forms;
using Battleship.Helpers;
using Battleship.Game;

namespace Battleship
{
    public partial class Form1 : Form
    {
        private GameController _gameController;
        private List<Ship> _placedShips;
        private GridController _gridController;
        
        public Form1()
        {
            _gameController = new GameController(ConfigurationManager.AppSettings["InMemoryDatabase"]);
            ContentResources.LoadImages();

            _placedShips = new List<Ship>();

            InitializeComponent();

            _gridController = new GridController(Grid, OnTileClick, OnMissedShot);
            _gridController.GenerateGrid();

            StateSection.TabPages.Remove(tab_Player1Select);
            StateSection.TabPages.Remove(tab_Player2Name);
            StateSection.TabPages.Remove(tab_Player2Select);
            StateSection.TabPages.Remove(tab_playerAttacks);
            StateSection.TabPages.Remove(tab_Finish);

            pnl_nextTurn.Hide();
            //tabControl1.TabPages.Remove(tabPage2);

            StateSection.SelectedTab = tab_Player1Name;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
         
        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridPanel_Click(object sender, System.EventArgs e)
        {
            StateSection.TabPages.Add(tab_Player1Name);
            StateSection.TabPages.Remove(tab_Player1Select);

            StateSection.SelectedTab = tab_Player1Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gameController.RegsiterPlayer1(txt_player1Name.Text);

            MoveToNextStep();
        }

        private void UpdateTabControl()
        {
            StateSection.TabPages.Remove(StateSection.SelectedTab);

            TabPage nextTab = null;

            switch (_gameController.CurrentState)
            {
                case Shared.Enums.StateEnum.Player1Place:
                    nextTab = tab_Player1Select;
                    break;
                case Shared.Enums.StateEnum.Player2Name:
                    nextTab = tab_Player2Name;
                    break;
                case Shared.Enums.StateEnum.Player2Place:
                    nextTab = tab_Player2Select;
                    break;
                case Shared.Enums.StateEnum.PlayerAttack:
                    nextTab = tab_playerAttacks;
                    pnl_nextTurn.Hide();
                    pnl_revealAttackGrid.Show();
                    SetAttackLabel();
                    break;
                case Shared.Enums.StateEnum.Finished:
                    nextTab = tab_Finish;
                    break;
            }

            StateSection.TabPages.Add(nextTab);
            StateSection.SelectedTab = nextTab;
        }

        private void UpdateGrid()
        {
            _gridController.GenerateGrid();

            switch (_gameController.CurrentState)
            {
                case Shared.Enums.StateEnum.Player1Place:
                case Shared.Enums.StateEnum.Player2Place:
                    _gridController.SetHoverEvents(false);
                    break;
                case Shared.Enums.StateEnum.PlayerAttack:
                    _gridController.LoadShipsToAttack(_gameController.GetEnemyShips());
                    _gridController.SetHoverEvents(true);
                    _gridController.Hide();
                    break;
                case Shared.Enums.StateEnum.Finished:
                    _gridController.LoadShipsToAttack(_gameController.GetEnemyShips());
                    _gridController.SetHoverEvents(false);
                    break;
            }
        }

        private void btn_addShip_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidatePlacementForm(txt_player1FirstPosX, txt_player1FirstPosY, txt_player1LastPosX, txt_player1LastPosY))
                return;

            var newShip = new Ship(Convert.ToInt32(txt_player1FirstPosX.Text),
                                    Convert.ToInt32(txt_player1FirstPosY.Text),
                                    Convert.ToInt32(txt_player1LastPosX.Text),
                                    Convert.ToInt32(txt_player1LastPosY.Text));

            _placedShips.Add(newShip);
            _gridController.AddShipToShow(newShip);

            ResetPlacementControls(txt_player1FirstPosX, txt_player1FirstPosY, txt_player1LastPosX, txt_player1LastPosY);
        }

        private void ResetPlacementControls(Control firstPosX, Control firstPosY, Control lastPosX, Control lastPosY)
        {
            firstPosX.Text = string.Empty;
            firstPosY.Text = string.Empty;
            lastPosX.Text = string.Empty;
            lastPosY.Text = string.Empty;
        }

        private void btn_player1Place_Click(object sender, EventArgs e)
        {
            FinaliseSelection(false);
        }

        private void MoveToNextStep()
        {
            _gameController.MoveToNextState();
            UpdateTabControl();
            UpdateGrid();
        }

        private void btn_player2NameSubmit_Click(object sender, EventArgs e)
        {
            _gameController.RegsiterPlayer2(txt_Player2Name.Text);

            MoveToNextStep();
        }

        private void btn_addShipPlayer2_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidatePlacementForm(txt_player2FirstPosX, txt_player2FirstPosY, txt_player2LastPosX, txt_player2LastPosY))
                return;

            var newShip = new Ship(Convert.ToInt32(txt_player2FirstPosX.Text),
                                    Convert.ToInt32(txt_player2FirstPosY.Text),
                                    Convert.ToInt32(txt_player2LastPosX.Text),
                                    Convert.ToInt32(txt_player2LastPosY.Text));

            _placedShips.Add(newShip);
            _gridController.AddShipToShow(newShip);

            ResetPlacementControls(txt_player2FirstPosX, txt_player2FirstPosY, txt_player2LastPosX, txt_player2LastPosY);
        }

        private void btn_player2Place_Click(object sender, EventArgs e)
        {
            FinaliseSelection(true);
        }

        private void FinaliseSelection(bool changePlayer)
        {
            foreach (var ship in _placedShips)
                _gameController.AddShip(ship.GetShipPoints());

            if (changePlayer)
                _gameController.ChangeToNextPlayer();

            _placedShips.Clear();

            MoveToNextStep();
        }

        private void btn_revealGrid_Click(object sender, EventArgs e)
        {
            _gridController.Show();
            pnl_revealAttackGrid.Hide();
        }

        private void OnMissedShot()
        {
            _gridController.SetHoverEvents(false);

            var updatedPoints = _gridController.GetUpdatedLoadedPoints();
            _gameController.UpdateEnemyShips(updatedPoints);
            pnl_nextTurn.Show();
        }

        private void OnTileClick()
        {
            var finished = _gridController.IsLoadedPointsFinished();

            if (finished)
            {
                _gridController.SetHoverEvents(false);
                _gameController.FinishGame();
                MoveToNextStep();
            }
        }

        private void btn_nextPlayersTurn_Click(object sender, EventArgs e)
        {
            _gameController.ChangeToNextPlayer();
            MoveToNextStep();
        }

        private void SetAttackLabel()
        {
             var name = _gameController.GetCurrentPlayerName();

            lbl_playerAttack.Text = $"{name} Attacks";
        }
    }
}
