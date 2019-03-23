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
            this.tab_Player1Select = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StateSection.SuspendLayout();
            this.tab_Player1Name.SuspendLayout();
            this.tab_Player1Select.SuspendLayout();
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
            this.StateSection.Location = new System.Drawing.Point(668, 12);
            this.StateSection.Name = "StateSection";
            this.StateSection.SelectedIndex = 0;
            this.StateSection.Size = new System.Drawing.Size(384, 648);
            this.StateSection.TabIndex = 1;
            // 
            // tab_Player1Name
            // 
            this.tab_Player1Name.Controls.Add(this.button1);
            this.tab_Player1Name.Controls.Add(this.textBox1);
            this.tab_Player1Name.Controls.Add(this.Player1Name);
            this.tab_Player1Name.Controls.Add(this.label2);
            this.tab_Player1Name.Location = new System.Drawing.Point(4, 22);
            this.tab_Player1Name.Name = "tab_Player1Name";
            this.tab_Player1Name.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player1Name.Size = new System.Drawing.Size(376, 622);
            this.tab_Player1Name.TabIndex = 0;
            this.tab_Player1Name.Text = "tabPage1";
            this.tab_Player1Name.UseVisualStyleBackColor = true;
            this.tab_Player1Name.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tab_Player1Select
            // 
            this.tab_Player1Select.Controls.Add(this.label1);
            this.tab_Player1Select.Location = new System.Drawing.Point(4, 22);
            this.tab_Player1Select.Name = "tab_Player1Select";
            this.tab_Player1Select.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Player1Select.Size = new System.Drawing.Size(376, 622);
            this.tab_Player1Select.TabIndex = 1;
            this.tab_Player1Select.Text = "Player1Select";
            this.tab_Player1Select.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MLOKJM";
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
            // Player1Name
            // 
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(72, 147);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(73, 25);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(186, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 671);
            this.Controls.Add(this.StateSection);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.StateSection.ResumeLayout(false);
            this.tab_Player1Name.ResumeLayout(false);
            this.tab_Player1Name.PerformLayout();
            this.tab_Player1Select.ResumeLayout(false);
            this.tab_Player1Select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Grid;
        private System.Windows.Forms.TabControl StateSection;
        private System.Windows.Forms.TabPage tab_Player1Name;
        private System.Windows.Forms.TabPage tab_Player1Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Player1Name;
    }
}

