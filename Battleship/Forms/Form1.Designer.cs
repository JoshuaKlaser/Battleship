namespace Battleship
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid = new System.Windows.Forms.Panel();
            this.StateSection = new System.Windows.Forms.TabControl();
            this.tab_Player1Name = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_player1Name = new System.Windows.Forms.TextBox();
            this.Player1Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_Player1Select = new System.Windows.Forms.TabPage();
            this.btn_addShipPlayer1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_player1LastPosY = new System.Windows.Forms.TextBox();
            this.txt_player1LastPosX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_player1FirstPosY = new System.Windows.Forms.TextBox();
            this.txt_player1FirstPosX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_player1Place = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_Player2Name = new System.Windows.Forms.TabPage();
            this.btn_player2NameSubmit = new System.Windows.Forms.Button();
            this.txt_Player2Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tab_Player2Select = new System.Windows.Forms.TabPage();
            this.btn_addShipPlayer2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_player2LastPosY = new System.Windows.Forms.TextBox();
            this.txt_player2LastPosX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_player2FirstPosY = new System.Windows.Forms.TextBox();
            this.txt_player2FirstPosX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_player2Place = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tab_playerAttacks = new System.Windows.Forms.TabPage();
            this.pnl_nextTurn = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_nextPlayersTurn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnl_revealAttackGrid = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_revealGrid = new System.Windows.Forms.Button();
            this.lbl_playerAttack = new System.Windows.Forms.Label();
            this.tab_Finish = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.StateSection.SuspendLayout();
            this.tab_Player1Name.SuspendLayout();
            this.tab_Player1Select.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_Player2Name.SuspendLayout();
            this.tab_Player2Select.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_playerAttacks.SuspendLayout();
            this.pnl_nextTurn.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_revealAttackGrid.SuspendLayout();
            this.tab_Finish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.Location = new System.Drawing.Point(12, 12);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(644, 644);
            this.Grid.TabIndex = 0;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPanel_Paint);
            // 
            // StateSection
            // 
            this.StateSection.Controls.Add(this.tab_Player1Name);
            this.StateSection.Controls.Add(this.tab_Player1Select);
            this.StateSection.Controls.Add(this.tab_Player2Name);
            this.StateSection.Controls.Add(this.tab_Player2Select);
            this.StateSection.Controls.Add(this.tab_playerAttacks);
            this.StateSection.Controls.Add(this.tab_Finish);
            this.StateSection.Location = new System.Drawing.Point(668, 12);
            this.StateSection.Name = "StateSection";
            this.StateSection.SelectedIndex = 0;
            this.StateSection.Size = new System.Drawing.Size(384, 648);
            this.StateSection.TabIndex = 1;
            // 
            // tab_Player1Name
            // 
            this.tab_Player1Name.Controls.Add(this.button1);
            this.tab_Player1Name.Controls.Add(this.txt_player1Name);
            this.tab_Player1Name.Controls.Add(this.Player1Name);
            this.tab_Player1Name.Controls.Add(this.label2);
            this.tab_Player1Name.Location = new System.Drawing.Point(4, 22);
            this.tab_Player1Name.Name = "tab_Player1Name";
            this.tab_Player1Name.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player1Name.Size = new System.Drawing.Size(376, 622);
            this.tab_Player1Name.TabIndex = 0;
            this.tab_Player1Name.Text = "Player1Name";
            this.tab_Player1Name.UseVisualStyleBackColor = true;
            this.tab_Player1Name.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_player1Name
            // 
            this.txt_player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1Name.Location = new System.Drawing.Point(186, 149);
            this.txt_player1Name.Name = "txt_player1Name";
            this.txt_player1Name.Size = new System.Drawing.Size(100, 23);
            this.txt_player1Name.TabIndex = 2;
            // 
            // Player1Name
            // 
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(72, 147);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(73, 25);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.Text = "Name:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 104);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player 1 Choose Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Player1Select
            // 
            this.tab_Player1Select.Controls.Add(this.btn_addShipPlayer1);
            this.tab_Player1Select.Controls.Add(this.panel2);
            this.tab_Player1Select.Controls.Add(this.panel1);
            this.tab_Player1Select.Controls.Add(this.btn_player1Place);
            this.tab_Player1Select.Controls.Add(this.label3);
            this.tab_Player1Select.Location = new System.Drawing.Point(4, 22);
            this.tab_Player1Select.Name = "tab_Player1Select";
            this.tab_Player1Select.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player1Select.Size = new System.Drawing.Size(376, 622);
            this.tab_Player1Select.TabIndex = 1;
            this.tab_Player1Select.Text = "Player1Select";
            this.tab_Player1Select.UseVisualStyleBackColor = true;
            // 
            // btn_addShipPlayer1
            // 
            this.btn_addShipPlayer1.Location = new System.Drawing.Point(142, 334);
            this.btn_addShipPlayer1.Name = "btn_addShipPlayer1";
            this.btn_addShipPlayer1.Size = new System.Drawing.Size(75, 23);
            this.btn_addShipPlayer1.TabIndex = 5;
            this.btn_addShipPlayer1.Text = "Add Ship";
            this.btn_addShipPlayer1.UseVisualStyleBackColor = true;
            this.btn_addShipPlayer1.Click += new System.EventHandler(this.btn_addShip_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_player1LastPosY);
            this.panel2.Controls.Add(this.txt_player1LastPosX);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(7, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 77);
            this.panel2.TabIndex = 9;
            // 
            // txt_player1LastPosY
            // 
            this.txt_player1LastPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1LastPosY.Location = new System.Drawing.Point(199, 29);
            this.txt_player1LastPosY.Name = "txt_player1LastPosY";
            this.txt_player1LastPosY.Size = new System.Drawing.Size(100, 26);
            this.txt_player1LastPosY.TabIndex = 4;
            // 
            // txt_player1LastPosX
            // 
            this.txt_player1LastPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1LastPosX.Location = new System.Drawing.Point(26, 29);
            this.txt_player1LastPosX.Name = "txt_player1LastPosX";
            this.txt_player1LastPosX.Size = new System.Drawing.Size(100, 26);
            this.txt_player1LastPosX.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "X:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Last Piece Position";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_player1FirstPosY);
            this.panel1.Controls.Add(this.txt_player1FirstPosX);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 77);
            this.panel1.TabIndex = 8;
            // 
            // txt_player1FirstPosY
            // 
            this.txt_player1FirstPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1FirstPosY.Location = new System.Drawing.Point(199, 29);
            this.txt_player1FirstPosY.Name = "txt_player1FirstPosY";
            this.txt_player1FirstPosY.Size = new System.Drawing.Size(100, 26);
            this.txt_player1FirstPosY.TabIndex = 2;
            // 
            // txt_player1FirstPosX
            // 
            this.txt_player1FirstPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player1FirstPosX.Location = new System.Drawing.Point(26, 29);
            this.txt_player1FirstPosX.Name = "txt_player1FirstPosX";
            this.txt_player1FirstPosX.Size = new System.Drawing.Size(100, 26);
            this.txt_player1FirstPosX.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "X:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Piece Position";
            // 
            // btn_player1Place
            // 
            this.btn_player1Place.Location = new System.Drawing.Point(142, 380);
            this.btn_player1Place.Name = "btn_player1Place";
            this.btn_player1Place.Size = new System.Drawing.Size(75, 23);
            this.btn_player1Place.TabIndex = 6;
            this.btn_player1Place.Text = "Finalise";
            this.btn_player1Place.UseVisualStyleBackColor = true;
            this.btn_player1Place.Click += new System.EventHandler(this.btn_player1Place_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 104);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1 Place Pieces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Player2Name
            // 
            this.tab_Player2Name.Controls.Add(this.btn_player2NameSubmit);
            this.tab_Player2Name.Controls.Add(this.txt_Player2Name);
            this.tab_Player2Name.Controls.Add(this.label9);
            this.tab_Player2Name.Controls.Add(this.label10);
            this.tab_Player2Name.Location = new System.Drawing.Point(4, 22);
            this.tab_Player2Name.Name = "tab_Player2Name";
            this.tab_Player2Name.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player2Name.Size = new System.Drawing.Size(376, 622);
            this.tab_Player2Name.TabIndex = 2;
            this.tab_Player2Name.Text = "Player2Name";
            this.tab_Player2Name.UseVisualStyleBackColor = true;
            // 
            // btn_player2NameSubmit
            // 
            this.btn_player2NameSubmit.Location = new System.Drawing.Point(140, 207);
            this.btn_player2NameSubmit.Name = "btn_player2NameSubmit";
            this.btn_player2NameSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_player2NameSubmit.TabIndex = 7;
            this.btn_player2NameSubmit.Text = "Submit";
            this.btn_player2NameSubmit.UseVisualStyleBackColor = true;
            this.btn_player2NameSubmit.Click += new System.EventHandler(this.btn_player2NameSubmit_Click);
            // 
            // txt_Player2Name
            // 
            this.txt_Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Player2Name.Location = new System.Drawing.Point(183, 149);
            this.txt_Player2Name.Name = "txt_Player2Name";
            this.txt_Player2Name.Size = new System.Drawing.Size(100, 23);
            this.txt_Player2Name.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 104);
            this.label10.TabIndex = 4;
            this.label10.Text = "Player 2 Choose Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Player2Select
            // 
            this.tab_Player2Select.Controls.Add(this.btn_addShipPlayer2);
            this.tab_Player2Select.Controls.Add(this.panel3);
            this.tab_Player2Select.Controls.Add(this.panel4);
            this.tab_Player2Select.Controls.Add(this.btn_player2Place);
            this.tab_Player2Select.Controls.Add(this.label17);
            this.tab_Player2Select.Location = new System.Drawing.Point(4, 22);
            this.tab_Player2Select.Name = "tab_Player2Select";
            this.tab_Player2Select.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player2Select.Size = new System.Drawing.Size(376, 622);
            this.tab_Player2Select.TabIndex = 3;
            this.tab_Player2Select.Text = "Player2Select";
            this.tab_Player2Select.UseVisualStyleBackColor = true;
            // 
            // btn_addShipPlayer2
            // 
            this.btn_addShipPlayer2.Location = new System.Drawing.Point(143, 334);
            this.btn_addShipPlayer2.Name = "btn_addShipPlayer2";
            this.btn_addShipPlayer2.Size = new System.Drawing.Size(75, 23);
            this.btn_addShipPlayer2.TabIndex = 5;
            this.btn_addShipPlayer2.Text = "Add Ship";
            this.btn_addShipPlayer2.UseVisualStyleBackColor = true;
            this.btn_addShipPlayer2.Click += new System.EventHandler(this.btn_addShipPlayer2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_player2LastPosY);
            this.panel3.Controls.Add(this.txt_player2LastPosX);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(8, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 77);
            this.panel3.TabIndex = 14;
            // 
            // txt_player2LastPosY
            // 
            this.txt_player2LastPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2LastPosY.Location = new System.Drawing.Point(199, 29);
            this.txt_player2LastPosY.Name = "txt_player2LastPosY";
            this.txt_player2LastPosY.Size = new System.Drawing.Size(100, 26);
            this.txt_player2LastPosY.TabIndex = 4;
            // 
            // txt_player2LastPosX
            // 
            this.txt_player2LastPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2LastPosX.Location = new System.Drawing.Point(26, 29);
            this.txt_player2LastPosX.Name = "txt_player2LastPosX";
            this.txt_player2LastPosX.Size = new System.Drawing.Size(100, 26);
            this.txt_player2LastPosX.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(177, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Y:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "X:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(99, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Last Piece Position";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_player2FirstPosY);
            this.panel4.Controls.Add(this.txt_player2FirstPosX);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(8, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 77);
            this.panel4.TabIndex = 13;
            // 
            // txt_player2FirstPosY
            // 
            this.txt_player2FirstPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2FirstPosY.Location = new System.Drawing.Point(199, 29);
            this.txt_player2FirstPosY.Name = "txt_player2FirstPosY";
            this.txt_player2FirstPosY.Size = new System.Drawing.Size(100, 26);
            this.txt_player2FirstPosY.TabIndex = 2;
            // 
            // txt_player2FirstPosX
            // 
            this.txt_player2FirstPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_player2FirstPosX.Location = new System.Drawing.Point(26, 29);
            this.txt_player2FirstPosX.Name = "txt_player2FirstPosX";
            this.txt_player2FirstPosX.Size = new System.Drawing.Size(100, 26);
            this.txt_player2FirstPosX.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(177, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Y:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "X:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(99, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "First Piece Position";
            // 
            // btn_player2Place
            // 
            this.btn_player2Place.Location = new System.Drawing.Point(143, 380);
            this.btn_player2Place.Name = "btn_player2Place";
            this.btn_player2Place.Size = new System.Drawing.Size(75, 23);
            this.btn_player2Place.TabIndex = 6;
            this.btn_player2Place.Text = "Finalise";
            this.btn_player2Place.UseVisualStyleBackColor = true;
            this.btn_player2Place.Click += new System.EventHandler(this.btn_player2Place_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(364, 104);
            this.label17.TabIndex = 11;
            this.label17.Text = "Player 2 Place Pieces";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_playerAttacks
            // 
            this.tab_playerAttacks.Controls.Add(this.pnl_nextTurn);
            this.tab_playerAttacks.Controls.Add(this.panel5);
            this.tab_playerAttacks.Controls.Add(this.pnl_revealAttackGrid);
            this.tab_playerAttacks.Controls.Add(this.lbl_playerAttack);
            this.tab_playerAttacks.Location = new System.Drawing.Point(4, 22);
            this.tab_playerAttacks.Name = "tab_playerAttacks";
            this.tab_playerAttacks.Padding = new System.Windows.Forms.Padding(3);
            this.tab_playerAttacks.Size = new System.Drawing.Size(376, 622);
            this.tab_playerAttacks.TabIndex = 4;
            this.tab_playerAttacks.Text = "PlayerAttacks";
            this.tab_playerAttacks.UseVisualStyleBackColor = true;
            // 
            // pnl_nextTurn
            // 
            this.pnl_nextTurn.Controls.Add(this.label22);
            this.pnl_nextTurn.Controls.Add(this.btn_nextPlayersTurn);
            this.pnl_nextTurn.Location = new System.Drawing.Point(4, 409);
            this.pnl_nextTurn.Name = "pnl_nextTurn";
            this.pnl_nextTurn.Size = new System.Drawing.Size(364, 127);
            this.pnl_nextTurn.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(39, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(286, 20);
            this.label22.TabIndex = 13;
            this.label22.Text = "Press the button below to end your turn";
            // 
            // btn_nextPlayersTurn
            // 
            this.btn_nextPlayersTurn.AutoSize = true;
            this.btn_nextPlayersTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextPlayersTurn.Location = new System.Drawing.Point(109, 73);
            this.btn_nextPlayersTurn.Name = "btn_nextPlayersTurn";
            this.btn_nextPlayersTurn.Size = new System.Drawing.Size(136, 27);
            this.btn_nextPlayersTurn.TabIndex = 14;
            this.btn_nextPlayersTurn.Text = "Next Turn";
            this.btn_nextPlayersTurn.UseVisualStyleBackColor = true;
            this.btn_nextPlayersTurn.Click += new System.EventHandler(this.btn_nextPlayersTurn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(4, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 127);
            this.panel5.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(53, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(254, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "If you miss it\'s the next players turn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(49, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "If you get a hit, you get another turn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(53, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(244, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "Click on a tile to make your attack";
            // 
            // pnl_revealAttackGrid
            // 
            this.pnl_revealAttackGrid.Controls.Add(this.label18);
            this.pnl_revealAttackGrid.Controls.Add(this.btn_revealGrid);
            this.pnl_revealAttackGrid.Location = new System.Drawing.Point(4, 143);
            this.pnl_revealAttackGrid.Name = "pnl_revealAttackGrid";
            this.pnl_revealAttackGrid.Size = new System.Drawing.Size(364, 127);
            this.pnl_revealAttackGrid.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(287, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Press the button below to show the grid";
            // 
            // btn_revealGrid
            // 
            this.btn_revealGrid.AutoSize = true;
            this.btn_revealGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revealGrid.Location = new System.Drawing.Point(109, 73);
            this.btn_revealGrid.Name = "btn_revealGrid";
            this.btn_revealGrid.Size = new System.Drawing.Size(136, 27);
            this.btn_revealGrid.TabIndex = 14;
            this.btn_revealGrid.Text = "Reveal Attack Grid";
            this.btn_revealGrid.UseVisualStyleBackColor = true;
            this.btn_revealGrid.Click += new System.EventHandler(this.btn_revealGrid_Click);
            // 
            // lbl_playerAttack
            // 
            this.lbl_playerAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_playerAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerAttack.Location = new System.Drawing.Point(4, 5);
            this.lbl_playerAttack.Name = "lbl_playerAttack";
            this.lbl_playerAttack.Size = new System.Drawing.Size(364, 104);
            this.lbl_playerAttack.TabIndex = 12;
            this.lbl_playerAttack.Text = "Player Attacks";
            this.lbl_playerAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_Finish
            // 
            this.tab_Finish.Controls.Add(this.label23);
            this.tab_Finish.Location = new System.Drawing.Point(4, 22);
            this.tab_Finish.Name = "tab_Finish";
            this.tab_Finish.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Finish.Size = new System.Drawing.Size(376, 622);
            this.tab_Finish.TabIndex = 5;
            this.tab_Finish.Text = "Finished";
            this.tab_Finish.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(339, 124);
            this.label23.TabIndex = 0;
            this.label23.Text = "Congratulations";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 671);
            this.Controls.Add(this.StateSection);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "Player2Name";
            this.StateSection.ResumeLayout(false);
            this.tab_Player1Name.ResumeLayout(false);
            this.tab_Player1Name.PerformLayout();
            this.tab_Player1Select.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_Player2Name.ResumeLayout(false);
            this.tab_Player2Name.PerformLayout();
            this.tab_Player2Select.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_playerAttacks.ResumeLayout(false);
            this.pnl_nextTurn.ResumeLayout(false);
            this.pnl_nextTurn.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnl_revealAttackGrid.ResumeLayout(false);
            this.pnl_revealAttackGrid.PerformLayout();
            this.tab_Finish.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Grid;
        private System.Windows.Forms.TabControl StateSection;
        private System.Windows.Forms.TabPage tab_Player1Name;
        private System.Windows.Forms.TabPage tab_Player1Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_player1Name;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Button btn_player1Place;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addShipPlayer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_player1LastPosY;
        private System.Windows.Forms.TextBox txt_player1LastPosX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_player1FirstPosY;
        private System.Windows.Forms.TextBox txt_player1FirstPosX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Player2Name;
        private System.Windows.Forms.Button btn_player2NameSubmit;
        private System.Windows.Forms.TextBox txt_Player2Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tab_Player2Select;
        private System.Windows.Forms.Button btn_addShipPlayer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_player2LastPosY;
        private System.Windows.Forms.TextBox txt_player2LastPosX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_player2FirstPosY;
        private System.Windows.Forms.TextBox txt_player2FirstPosX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_player2Place;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tab_playerAttacks;
        private System.Windows.Forms.Button btn_revealGrid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_playerAttack;
        private System.Windows.Forms.Panel pnl_revealAttackGrid;
        private System.Windows.Forms.Panel pnl_nextTurn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_nextPlayersTurn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tab_Finish;
        private System.Windows.Forms.Label label23;
    }
}

