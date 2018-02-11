namespace SysTel_Network.View
{
    partial class Frm_login_servers
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
            this.txt_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_users_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmb_name_servers = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_conect = new DevComponents.DotNetBar.ButtonX();
            this.txt_cancel = new DevComponents.DotNetBar.ButtonX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmb_autentific = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_password.Border.Class = "TextBoxBorder";
            this.txt_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_password.DisabledBackColor = System.Drawing.Color.White;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(183, 193);
            this.txt_password.Name = "txt_password";
            this.txt_password.PreventEnterBeep = true;
            this.txt_password.Size = new System.Drawing.Size(200, 22);
            this.txt_password.TabIndex = 11;
            // 
            // txt_users_name
            // 
            this.txt_users_name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_users_name.Border.Class = "TextBoxBorder";
            this.txt_users_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_users_name.DisabledBackColor = System.Drawing.Color.White;
            this.txt_users_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_users_name.ForeColor = System.Drawing.Color.Black;
            this.txt_users_name.Location = new System.Drawing.Point(183, 167);
            this.txt_users_name.Name = "txt_users_name";
            this.txt_users_name.PreventEnterBeep = true;
            this.txt_users_name.Size = new System.Drawing.Size(200, 22);
            this.txt_users_name.TabIndex = 10;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(12, 192);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(113, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Contraseña:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 167);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(113, 23);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Nombre usuario:";
            // 
            // cmb_name_servers
            // 
            this.cmb_name_servers.DisplayMember = "Text";
            this.cmb_name_servers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_name_servers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_name_servers.ForeColor = System.Drawing.Color.Black;
            this.cmb_name_servers.FormattingEnabled = true;
            this.cmb_name_servers.ItemHeight = 16;
            this.cmb_name_servers.Items.AddRange(new object[] {
            this.comboItem2});
            this.cmb_name_servers.Location = new System.Drawing.Point(183, 94);
            this.cmb_name_servers.Name = "cmb_name_servers";
            this.cmb_name_servers.Size = new System.Drawing.Size(200, 22);
            this.cmb_name_servers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_name_servers.TabIndex = 7;
            this.cmb_name_servers.Text = "USUARIO-PC";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 93);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Nombre del servidor:";
            // 
            // btn_conect
            // 
            this.btn_conect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_conect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_conect.Location = new System.Drawing.Point(81, 247);
            this.btn_conect.Name = "btn_conect";
            this.btn_conect.Size = new System.Drawing.Size(103, 24);
            this.btn_conect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_conect.TabIndex = 12;
            this.btn_conect.Text = "Conectar";
            // 
            // txt_cancel
            // 
            this.txt_cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txt_cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txt_cancel.Location = new System.Drawing.Point(218, 247);
            this.txt_cancel.Name = "txt_cancel";
            this.txt_cancel.Size = new System.Drawing.Size(103, 24);
            this.txt_cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txt_cancel.TabIndex = 13;
            this.txt_cancel.Text = "Cancelar";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(12, 218);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(371, 23);
            this.line1.TabIndex = 14;
            this.line1.Text = "line1";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(12, 121);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(113, 23);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Autentificacion:";
            // 
            // cmb_autentific
            // 
            this.cmb_autentific.DisplayMember = "Autenficacion de Sql Server";
            this.cmb_autentific.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_autentific.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_autentific.ForeColor = System.Drawing.Color.Black;
            this.cmb_autentific.FormattingEnabled = true;
            this.cmb_autentific.ItemHeight = 16;
            this.cmb_autentific.Items.AddRange(new object[] {
            this.comboItem1});
            this.cmb_autentific.Location = new System.Drawing.Point(183, 122);
            this.cmb_autentific.Name = "cmb_autentific";
            this.cmb_autentific.Size = new System.Drawing.Size(200, 22);
            this.cmb_autentific.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_autentific.TabIndex = 16;
            this.cmb_autentific.Text = "Autenficacion de Sql Server";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Autenficacion de Sql Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysTel_Network.Properties.Resources.Logotipo_Sistel_Network;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SysTel_Network.Properties.Resources.shutterstock_62213497_790x340;
            this.pictureBox2.Location = new System.Drawing.Point(102, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "USUARIO-PC";
            // 
            // Frm_login_servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_autentific);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.txt_cancel);
            this.Controls.Add(this.btn_conect);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_users_name);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmb_name_servers);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.HelpButtonText = "Help";
            this.HelpButtonVisible = true;
            this.Name = "Frm_login_servers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Conectar al servidor</b>";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_password;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_users_name;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_name_servers;
        public DevComponents.DotNetBar.ButtonX btn_conect;
        public DevComponents.DotNetBar.ButtonX txt_cancel;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_autentific;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}