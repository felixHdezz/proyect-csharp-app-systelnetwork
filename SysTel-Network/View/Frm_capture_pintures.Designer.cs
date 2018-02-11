namespace SysTel_Network.View
{
    partial class Frm_capture_pintures
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
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.btn_capture_pint = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOutput.Location = new System.Drawing.Point(1, 12);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(532, 322);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutput.TabIndex = 0;
            this.pictureBoxOutput.TabStop = false;
            // 
            // btn_capture_pint
            // 
            this.btn_capture_pint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_capture_pint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_capture_pint.Location = new System.Drawing.Point(213, 340);
            this.btn_capture_pint.Name = "btn_capture_pint";
            this.btn_capture_pint.Size = new System.Drawing.Size(97, 36);
            this.btn_capture_pint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_capture_pint.TabIndex = 9;
            this.btn_capture_pint.Text = "Capturar";
            // 
            // Frm_capture_pintures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 378);
            this.Controls.Add(this.btn_capture_pint);
            this.Controls.Add(this.pictureBoxOutput);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_capture_pintures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_capture_pintures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btn_capture_pint;
        public System.Windows.Forms.PictureBox pictureBoxOutput;
    }
}