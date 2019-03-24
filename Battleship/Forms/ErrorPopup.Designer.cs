namespace Battleship.Forms
{
    partial class ErrorPopup
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
            this.lbl_errorPopupLabel = new System.Windows.Forms.Label();
            this.btn_ErrorPopupOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_errorPopupLabel
            // 
            this.lbl_errorPopupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorPopupLabel.Location = new System.Drawing.Point(12, 9);
            this.lbl_errorPopupLabel.Name = "lbl_errorPopupLabel";
            this.lbl_errorPopupLabel.Size = new System.Drawing.Size(329, 92);
            this.lbl_errorPopupLabel.TabIndex = 0;
            this.lbl_errorPopupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ErrorPopupOk
            // 
            this.btn_ErrorPopupOk.Location = new System.Drawing.Point(139, 113);
            this.btn_ErrorPopupOk.Name = "btn_ErrorPopupOk";
            this.btn_ErrorPopupOk.Size = new System.Drawing.Size(75, 23);
            this.btn_ErrorPopupOk.TabIndex = 1;
            this.btn_ErrorPopupOk.Text = "Ok";
            this.btn_ErrorPopupOk.UseVisualStyleBackColor = true;
            this.btn_ErrorPopupOk.Click += new System.EventHandler(this.btn_ErrorPopupOk_Click);
            // 
            // ErrorPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 148);
            this.Controls.Add(this.btn_ErrorPopupOk);
            this.Controls.Add(this.lbl_errorPopupLabel);
            this.Name = "ErrorPopup";
            this.Text = "ErrorPopup";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_errorPopupLabel;
        private System.Windows.Forms.Button btn_ErrorPopupOk;
    }
}