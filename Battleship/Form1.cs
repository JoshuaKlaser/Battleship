using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tabPage1);
            //tabControl1.TabPages.Remove(tabPage2);

            tabControl1.SelectedTab = this.tabPage2;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
         
        private void GridPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridPanel_Click(object sender, System.EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);

            tabControl1.SelectedTab = tabPage1;
        }
    }
}
