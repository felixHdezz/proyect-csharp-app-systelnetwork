namespace SysTel_Network.View
{
    partial class Frm_clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_clientes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_est_re = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ciud = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_est_cli = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_direc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_am = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_nom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_clv_cli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxX10 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_nuevo = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.btn_insert = new DevComponents.DotNetBar.ButtonX();
            this.lbl_pag = new DevComponents.DotNetBar.LabelX();
            this.lbl_total_reg = new DevComponents.DotNetBar.LabelX();
            this.btn_first = new DevComponents.DotNetBar.ButtonX();
            this.btn_ult = new DevComponents.DotNetBar.ButtonX();
            this.btn_ant = new DevComponents.DotNetBar.ButtonX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_clientes
            // 
            this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_clientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dg_clientes.Location = new System.Drawing.Point(12, 245);
            this.dg_clientes.Name = "dg_clientes";
            this.dg_clientes.RowHeadersVisible = false;
            this.dg_clientes.Size = new System.Drawing.Size(1157, 288);
            this.dg_clientes.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_est_re);
            this.groupPanel1.Controls.Add(this.txt_ciud);
            this.groupPanel1.Controls.Add(this.cb_est_cli);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_direc);
            this.groupPanel1.Controls.Add(this.txt_email);
            this.groupPanel1.Controls.Add(this.txt_tel);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_am);
            this.groupPanel1.Controls.Add(this.txt_ap);
            this.groupPanel1.Controls.Add(this.txt_nom);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_clv_cli);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(14, 14);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1067, 183);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Registro de clientes";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // txt_est_re
            // 
            this.txt_est_re.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_est_re.Border.Class = "TextBoxBorder";
            this.txt_est_re.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_est_re.DisabledBackColor = System.Drawing.Color.White;
            this.txt_est_re.ForeColor = System.Drawing.Color.Black;
            this.txt_est_re.Location = new System.Drawing.Point(483, 125);
            this.txt_est_re.Name = "txt_est_re";
            this.txt_est_re.PreventEnterBeep = true;
            this.txt_est_re.Size = new System.Drawing.Size(220, 21);
            this.txt_est_re.TabIndex = 30;
            this.txt_est_re.TextChanged += new System.EventHandler(this.txt_est_re_TextChanged);
            // 
            // txt_ciud
            // 
            this.txt_ciud.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_ciud.Border.Class = "TextBoxBorder";
            this.txt_ciud.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ciud.DisabledBackColor = System.Drawing.Color.White;
            this.txt_ciud.ForeColor = System.Drawing.Color.Black;
            this.txt_ciud.Location = new System.Drawing.Point(483, 98);
            this.txt_ciud.Name = "txt_ciud";
            this.txt_ciud.PreventEnterBeep = true;
            this.txt_ciud.Size = new System.Drawing.Size(220, 21);
            this.txt_ciud.TabIndex = 29;
            // 
            // cb_est_cli
            // 
            this.cb_est_cli.DisplayMember = "Text";
            this.cb_est_cli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_est_cli.ForeColor = System.Drawing.Color.Black;
            this.cb_est_cli.FormattingEnabled = true;
            this.cb_est_cli.ItemHeight = 15;
            this.cb_est_cli.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cb_est_cli.Location = new System.Drawing.Point(816, 41);
            this.cb_est_cli.Name = "cb_est_cli";
            this.cb_est_cli.Size = new System.Drawing.Size(220, 21);
            this.cb_est_cli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_est_cli.TabIndex = 28;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Activo";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Inactivo";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(723, 38);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(87, 27);
            this.labelX10.TabIndex = 27;
            this.labelX10.Text = "Estado cliente:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(370, 122);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(87, 27);
            this.labelX9.TabIndex = 26;
            this.labelX9.Text = "Estado:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(370, 95);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(66, 27);
            this.labelX8.TabIndex = 25;
            this.labelX8.Text = "Ciudad:";
            this.labelX8.Click += new System.EventHandler(this.labelX8_Click);
            // 
            // txt_direc
            // 
            this.txt_direc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_direc.Border.Class = "TextBoxBorder";
            this.txt_direc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_direc.DisabledBackColor = System.Drawing.Color.White;
            this.txt_direc.ForeColor = System.Drawing.Color.Black;
            this.txt_direc.Location = new System.Drawing.Point(483, 68);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.PreventEnterBeep = true;
            this.txt_direc.Size = new System.Drawing.Size(220, 21);
            this.txt_direc.TabIndex = 24;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_email.Border.Class = "TextBoxBorder";
            this.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_email.DisabledBackColor = System.Drawing.Color.White;
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(483, 41);
            this.txt_email.Name = "txt_email";
            this.txt_email.PreventEnterBeep = true;
            this.txt_email.Size = new System.Drawing.Size(220, 21);
            this.txt_email.TabIndex = 23;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_tel.Border.Class = "TextBoxBorder";
            this.txt_tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tel.DisabledBackColor = System.Drawing.Color.White;
            this.txt_tel.ForeColor = System.Drawing.Color.Black;
            this.txt_tel.Location = new System.Drawing.Point(131, 122);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PreventEnterBeep = true;
            this.txt_tel.Size = new System.Drawing.Size(220, 21);
            this.txt_tel.TabIndex = 22;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(370, 65);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(87, 27);
            this.labelX7.TabIndex = 21;
            this.labelX7.Text = "Direccion:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(370, 38);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(107, 27);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "Correo electronico:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(16, 120);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 27);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "Telefono:";
            // 
            // txt_am
            // 
            this.txt_am.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_am.Border.Class = "TextBoxBorder";
            this.txt_am.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_am.DisabledBackColor = System.Drawing.Color.White;
            this.txt_am.ForeColor = System.Drawing.Color.Black;
            this.txt_am.Location = new System.Drawing.Point(131, 95);
            this.txt_am.Name = "txt_am";
            this.txt_am.PreventEnterBeep = true;
            this.txt_am.Size = new System.Drawing.Size(220, 21);
            this.txt_am.TabIndex = 18;
            // 
            // txt_ap
            // 
            this.txt_ap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_ap.Border.Class = "TextBoxBorder";
            this.txt_ap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ap.DisabledBackColor = System.Drawing.Color.White;
            this.txt_ap.ForeColor = System.Drawing.Color.Black;
            this.txt_ap.Location = new System.Drawing.Point(131, 68);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.PreventEnterBeep = true;
            this.txt_ap.Size = new System.Drawing.Size(220, 21);
            this.txt_ap.TabIndex = 17;
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nom.Border.Class = "TextBoxBorder";
            this.txt_nom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nom.DisabledBackColor = System.Drawing.Color.White;
            this.txt_nom.ForeColor = System.Drawing.Color.Black;
            this.txt_nom.Location = new System.Drawing.Point(131, 41);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PreventEnterBeep = true;
            this.txt_nom.Size = new System.Drawing.Size(220, 21);
            this.txt_nom.TabIndex = 16;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(16, 92);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(105, 27);
            this.labelX4.TabIndex = 15;
            this.labelX4.Text = "Apellido materno:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(16, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(105, 27);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Apellido paterno:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 37);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 27);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Nombre:";
            // 
            // txt_clv_cli
            // 
            this.txt_clv_cli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_clv_cli.Border.Class = "TextBoxBorder";
            this.txt_clv_cli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_clv_cli.DisabledBackColor = System.Drawing.Color.White;
            this.txt_clv_cli.ForeColor = System.Drawing.Color.Black;
            this.txt_clv_cli.Location = new System.Drawing.Point(131, 11);
            this.txt_clv_cli.Name = "txt_clv_cli";
            this.txt_clv_cli.PreventEnterBeep = true;
            this.txt_clv_cli.Size = new System.Drawing.Size(150, 21);
            this.txt_clv_cli.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 27);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Clave:";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.textBoxX10);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(14, 203);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1157, 36);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 4;
            // 
            // textBoxX10
            // 
            this.textBoxX10.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxX10.Border.Class = "TextBoxBorder";
            this.textBoxX10.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX10.DisabledBackColor = System.Drawing.Color.White;
            this.textBoxX10.ForeColor = System.Drawing.Color.Black;
            this.textBoxX10.Location = new System.Drawing.Point(131, 4);
            this.textBoxX10.Name = "textBoxX10";
            this.textBoxX10.PreventEnterBeep = true;
            this.textBoxX10.Size = new System.Drawing.Size(292, 21);
            this.textBoxX10.TabIndex = 31;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(16, 0);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(87, 27);
            this.labelX11.TabIndex = 31;
            this.labelX11.Text = "Clave/nombre:";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Image = global::SysTel_Network.Properties.Resources.cancel_48;
            this.btn_delete.Location = new System.Drawing.Point(1087, 159);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 38);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Eiminar";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_nuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_nuevo.Image = global::SysTel_Network.Properties.Resources.add_48;
            this.btn_nuevo.Location = new System.Drawing.Point(1087, 27);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(87, 38);
            this.btn_nuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Image = global::SysTel_Network.Properties.Resources.refresh_48;
            this.btn_update.Location = new System.Drawing.Point(1087, 115);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 38);
            this.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Modificar";
            // 
            // btn_insert
            // 
            this.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_insert.Image = global::SysTel_Network.Properties.Resources.accepted_48;
            this.btn_insert.Location = new System.Drawing.Point(1087, 71);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(87, 38);
            this.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_insert.TabIndex = 5;
            this.btn_insert.Text = "Registrar";
            // 
            // lbl_pag
            // 
            // 
            // 
            // 
            this.lbl_pag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pag.Location = new System.Drawing.Point(874, 537);
            this.lbl_pag.Name = "lbl_pag";
            this.lbl_pag.Size = new System.Drawing.Size(95, 23);
            this.lbl_pag.TabIndex = 36;
            this.lbl_pag.Text = "Pagina:";
            // 
            // lbl_total_reg
            // 
            // 
            // 
            // 
            this.lbl_total_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_total_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_reg.Location = new System.Drawing.Point(12, 539);
            this.lbl_total_reg.Name = "lbl_total_reg";
            this.lbl_total_reg.Size = new System.Drawing.Size(144, 23);
            this.lbl_total_reg.TabIndex = 35;
            this.lbl_total_reg.Text = "Total registros:";
            // 
            // btn_first
            // 
            this.btn_first.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_first.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_first.Location = new System.Drawing.Point(975, 538);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(44, 22);
            this.btn_first.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_first.TabIndex = 34;
            this.btn_first.Text = "Pri";
            // 
            // btn_ult
            // 
            this.btn_ult.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ult.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ult.Location = new System.Drawing.Point(1125, 538);
            this.btn_ult.Name = "btn_ult";
            this.btn_ult.Size = new System.Drawing.Size(44, 22);
            this.btn_ult.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ult.TabIndex = 33;
            this.btn_ult.Text = "Ult";
            // 
            // btn_ant
            // 
            this.btn_ant.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ant.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ant.Location = new System.Drawing.Point(1025, 538);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(44, 22);
            this.btn_ant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ant.TabIndex = 32;
            this.btn_ant.Text = "Ant";
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Location = new System.Drawing.Point(1075, 538);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(44, 22);
            this.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_next.TabIndex = 31;
            this.btn_next.Text = "Sig";
            // 
            // Frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 563);
            this.Controls.Add(this.lbl_pag);
            this.Controls.Add(this.lbl_total_reg);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_ult);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dg_clientes);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Registrar clientes</b><i></i>";
            ((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_est_re;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_ciud;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cb_est_cli;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_direc;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_email;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_tel;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_am;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_ap;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_nom;
        public DevComponents.DotNetBar.Controls.DataGridViewX dg_clientes;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_clv_cli;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        public DevComponents.DotNetBar.ButtonX btn_delete;
        public DevComponents.DotNetBar.ButtonX btn_update;
        public DevComponents.DotNetBar.ButtonX btn_insert;
        public DevComponents.DotNetBar.ButtonX btn_nuevo;
        public DevComponents.DotNetBar.LabelX lbl_pag;
        public DevComponents.DotNetBar.LabelX lbl_total_reg;
        public DevComponents.DotNetBar.ButtonX btn_first;
        public DevComponents.DotNetBar.ButtonX btn_ult;
        public DevComponents.DotNetBar.ButtonX btn_ant;
        public DevComponents.DotNetBar.ButtonX btn_next;
    }
}