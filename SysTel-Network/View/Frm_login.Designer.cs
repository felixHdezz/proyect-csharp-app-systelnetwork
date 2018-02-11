namespace SysTel_Network.View
{
    partial class Frm_login
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
            this.btn_acceder = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.txt_n_rfc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_acceder
            // 
            this.btn_acceder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_acceder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.Location = new System.Drawing.Point(80, 217);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(104, 33);
            this.btn_acceder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_acceder.TabIndex = 0;
            this.btn_acceder.Text = "Acceder";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(209, 217);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(104, 33);
            this.btn_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            // 
            // txt_n_rfc
            // 
            this.txt_n_rfc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_n_rfc.Border.Class = "TextBoxBorder";
            this.txt_n_rfc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_n_rfc.DisabledBackColor = System.Drawing.Color.White;
            this.txt_n_rfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_rfc.ForeColor = System.Drawing.Color.Black;
            this.txt_n_rfc.Location = new System.Drawing.Point(142, 135);
            this.txt_n_rfc.Name = "txt_n_rfc";
            this.txt_n_rfc.PreventEnterBeep = true;
            this.txt_n_rfc.Size = new System.Drawing.Size(199, 21);
            this.txt_n_rfc.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pass.Border.Class = "TextBoxBorder";
            this.txt_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pass.DisabledBackColor = System.Drawing.Color.White;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(142, 162);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PreventEnterBeep = true;
            this.txt_pass.Size = new System.Drawing.Size(199, 21);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(46, 131);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Usuario/RFC:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(46, 160);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Contraseña:";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(12, 188);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(360, 23);
            this.line1.TabIndex = 21;
            this.line1.Text = "line1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysTel_Network.Properties.Resources.nuevologo5;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 253);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_n_rfc);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_acceder);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TitleText = "<b>Login</b>";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_n_rfc;
        public DevComponents.DotNetBar.ButtonX btn_acceder;
        public DevComponents.DotNetBar.ButtonX btn_cancelar;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.Line line1;

    }
}