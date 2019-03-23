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

namespace Battleship
{
    public partial class Form1 : Form
    {
        private GameLogic _gameLogic;
        
        public Form1()
        {
            _gameLogic = new GameLogic(ConfigurationManager.AppSettings["InMemoryDatabase"]);
            ContentResources.LoadImages();

            InitializeComponent();

            var gridDisplay = new GridDisplay(Grid);
            gridDisplay.GenerateGrid();

            StateSection.TabPages.Remove(tab_Player1Select);
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
            _gameLogic.RegsiterPlayer1(Player1Name.Text);

            _gameLogic.MoveToNextState();
            UpdateTabControl();
        }

        private void UpdateTabControl()
        {
            StateSection.TabPages.Remove(StateSection.SelectedTab);

            TabPage nextTab = null;

            switch (_gameLogic.CurrentState)
            {
                case Shared.Enums.StateEnum.Player1Place:
                    nextTab = tab_Player1Select;
                    break;
            }

            StateSection.TabPages.Add(nextTab);
            StateSection.SelectedTab = nextTab;
        }

        private void UpdateGrid()
        {

        }
    }
}
