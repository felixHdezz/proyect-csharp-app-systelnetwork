namespace SysTel_Network.View
{
    partial class Frm_sucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmb_est_sucu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.txt_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_direc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_nom_sucu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_clv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv_sucur = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_insert = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.btn_nuevo = new DevComponents.DotNetBar.ButtonX();
            this.lbl_pag = new DevComponents.DotNetBar.LabelX();
            this.btn_first = new DevComponents.DotNetBar.ButtonX();
            this.btn_ult = new DevComponents.DotNetBar.ButtonX();
            this.btn_ant = new DevComponents.DotNetBar.ButtonX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.lbl_total_reg = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmb_est_sucu);
            this.groupPanel1.Controls.Add(this.txt_tel);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_direc);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_nom_sucu);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txt_clv);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(679, 167);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Registro de sucursales";
            // 
            // cmb_est_sucu
            // 
            this.cmb_est_sucu.DisplayMember = "Text";
            this.cmb_est_sucu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_est_sucu.ForeColor = System.Drawing.Color.Black;
            this.cmb_est_sucu.FormattingEnabled = true;
            this.cmb_est_sucu.ItemHeight = 15;
            this.cmb_est_sucu.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmb_est_sucu.Location = new System.Drawing.Point(432, 91);
            this.cmb_est_sucu.Name = "cmb_est_sucu";
            this.cmb_est_sucu.Size = new System.Drawing.Size(220, 21);
            this.cmb_est_sucu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_est_sucu.TabIndex = 9;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "ACTIVO";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "INACTIVO";
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
            this.txt_tel.Location = new System.Drawing.Point(432, 64);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PreventEnterBeep = true;
            this.txt_tel.Size = new System.Drawing.Size(220, 21);
            this.txt_tel.TabIndex = 8;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(354, 89);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(87, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Estado:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(354, 62);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(87, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Telefono:";
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
            this.txt_direc.Location = new System.Drawing.Point(109, 90);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.PreventEnterBeep = true;
            this.txt_direc.Size = new System.Drawing.Size(220, 21);
            this.txt_direc.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(16, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Direccion:";
            // 
            // txt_nom_sucu
            // 
            this.txt_nom_sucu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nom_sucu.Border.Class = "TextBoxBorder";
            this.txt_nom_sucu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nom_sucu.DisabledBackColor = System.Drawing.Color.White;
            this.txt_nom_sucu.ForeColor = System.Drawing.Color.Black;
            this.txt_nom_sucu.Location = new System.Drawing.Point(109, 63);
            this.txt_nom_sucu.Name = "txt_nom_sucu";
            this.txt_nom_sucu.PreventEnterBeep = true;
            this.txt_nom_sucu.Size = new System.Drawing.Size(220, 21);
            this.txt_nom_sucu.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Sucursal:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Clave sucursal:";
            // 
            // txt_clv
            // 
            this.txt_clv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_clv.Border.Class = "TextBoxBorder";
            this.txt_clv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_clv.DisabledBackColor = System.Drawing.Color.White;
            this.txt_clv.ForeColor = System.Drawing.Color.Black;
            this.txt_clv.Location = new System.Drawing.Point(109, 34);
            this.txt_clv.Name = "txt_clv";
            this.txt_clv.PreventEnterBeep = true;
            this.txt_clv.Size = new System.Drawing.Size(150, 21);
            this.txt_clv.TabIndex = 0;
            // 
            // dgv_sucur
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sucur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sucur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sucur.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sucur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv_sucur.Location = new System.Drawing.Point(12, 185);
            this.dgv_sucur.Name = "dgv_sucur";
            this.dgv_sucur.RowHeadersVisible = false;
            this.dgv_sucur.Size = new System.Drawing.Size(786, 195);
            this.dgv_sucur.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_insert.Image = global::SysTel_Network.Properties.Resources.accepted_48;
            this.btn_insert.Location = new System.Drawing.Point(711, 62);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(87, 35);
            this.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Registrar";
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Image = global::SysTel_Network.Properties.Resources.refresh_48;
            this.btn_update.Location = new System.Drawing.Point(711, 103);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 35);
            this.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Modificar";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Image = global::SysTel_Network.Properties.Resources.cancel_48;
            this.btn_delete.Location = new System.Drawing.Point(711, 144);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Eliminar";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_nuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_nuevo.Image = global::SysTel_Network.Properties.Resources.add_48;
            this.btn_nuevo.Location = new System.Drawing.Point(711, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(87, 35);
            this.btn_nuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            // 
            // lbl_pag
            // 
            // 
            // 
            // 
            this.lbl_pag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pag.Location = new System.Drawing.Point(503, 385);
            this.lbl_pag.Name = "lbl_pag";
            this.lbl_pag.Size = new System.Drawing.Size(95, 23);
            this.lbl_pag.TabIndex = 41;
            this.lbl_pag.Text = "Pagina:";
            // 
            // btn_first
            // 
            this.btn_first.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_first.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_first.Location = new System.Drawing.Point(604, 386);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(44, 22);
            this.btn_first.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_first.TabIndex = 40;
            this.btn_first.Text = "Pri";
            // 
            // btn_ult
            // 
            this.btn_ult.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ult.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ult.Location = new System.Drawing.Point(754, 386);
            this.btn_ult.Name = "btn_ult";
            this.btn_ult.Size = new System.Drawing.Size(44, 22);
            this.btn_ult.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ult.TabIndex = 39;
            this.btn_ult.Text = "Ult";
            // 
            // btn_ant
            // 
            this.btn_ant.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ant.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ant.Location = new System.Drawing.Point(654, 386);
            this.btn_ant.Name = "btn_ant";
            this.btn_ant.Size = new System.Drawing.Size(44, 22);
            this.btn_ant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ant.TabIndex = 38;
            this.btn_ant.Text = "Ant";
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Location = new System.Drawing.Point(704, 386);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(44, 22);
            this.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_next.TabIndex = 37;
            this.btn_next.Text = "Sig";
            // 
            // lbl_total_reg
            // 
            // 
            // 
            // 
            this.lbl_total_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_total_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_reg.Location = new System.Drawing.Point(12, 386);
            this.lbl_total_reg.Name = "lbl_total_reg";
            this.lbl_total_reg.Size = new System.Drawing.Size(144, 23);
            this.lbl_total_reg.TabIndex = 42;
            this.lbl_total_reg.Text = "Total registros:";
            // 
            // Frm_sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 410);
            this.Controls.Add(this.lbl_total_reg);
            this.Controls.Add(this.lbl_pag);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_ult);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dgv_sucur);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Registrar sucursales</b>";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.ButtonX btn_insert;
        public DevComponents.DotNetBar.ButtonX btn_update;
        public DevComponents.DotNetBar.ButtonX btn_delete;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_clv;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_nom_sucu;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_est_sucu;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_tel;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_direc;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgv_sucur;
        public DevComponents.DotNetBar.ButtonX btn_nuevo;
        public DevComponents.DotNetBar.LabelX lbl_pag;
        public DevComponents.DotNetBar.ButtonX btn_first;
        public DevComponents.DotNetBar.ButtonX btn_ult;
        public DevComponents.DotNetBar.ButtonX btn_ant;
        public DevComponents.DotNetBar.ButtonX btn_next;
        public DevComponents.DotNetBar.LabelX lbl_total_reg;
    }
}