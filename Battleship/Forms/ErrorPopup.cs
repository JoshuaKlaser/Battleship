using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Forms
{
    public partial class ErrorPopup : Form
    {
        public ErrorPopup()
        {
            InitializeComponent();
        }

        private void btn_ErrorPopupOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
