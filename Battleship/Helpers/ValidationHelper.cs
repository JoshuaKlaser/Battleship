using Battleship.Forms;
using Shared.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Helpers
{
    public class ValidationHelper
    {
        public static bool ValidatePlacementForm(Control firstPosX, Control firstPosY, Control lastPosX, Control lastPosY)
        {
            if (string.IsNullOrEmpty(firstPosX.Text)
                || string.IsNullOrEmpty(firstPosY.Text)
                || string.IsNullOrEmpty(lastPosX.Text)
                || string.IsNullOrEmpty(lastPosY.Text))
            {
                ShowErrorPopUp("Some fields were left blank");
                return false;
            }

            int firstNumX = 0;
            int firstNumY = 0;
            int lastNumX = 0;
            int lastNumY = 0;

            int.TryParse(firstPosX.Text, out firstNumX);
            int.TryParse(firstPosY.Text, out firstNumY);
            int.TryParse(lastPosX.Text, out lastNumX);
            int.TryParse(lastPosY.Text, out lastNumY);

            if (firstNumX == Consts.IntParseFailureNumber
                || firstNumY == Consts.IntParseFailureNumber
                || lastNumX == Consts.IntParseFailureNumber
                || lastNumY == Consts.IntParseFailureNumber)
            {
                ShowErrorPopUp("Please only use numbers.");
                return false;
            }

            return true;
        }

        private static void ShowErrorPopUp(string message)
        {
            var errorPopup = new ErrorPopup();
            errorPopup.lbl_errorPopupLabel.Text = message;
            errorPopup.ShowDialog();
        }
    }
}
