namespace SysTel_Network.View
{
    partial class Frm_cargos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmb_esta = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_salario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_descrip = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_puesto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_clave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgv_puestos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_new = new DevComponents.DotNetBar.ButtonX();
            this.btn_insert = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.btn_delete = new DevComponents.DotNetBar.ButtonX();
            this.lbl_total_reg = new DevComponents.DotNetBar.LabelX();
            this.lbl_pag = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btn_first = new DevComponents.DotNetBar.ButtonX();
            this.btn_ult = new DevComponents.DotNetBar.ButtonX();
            this.btn_ant = new DevComponents.DotNetBar.ButtonX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmb_esta);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_salario);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_descrip);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_puesto);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_clave);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(642, 168);
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
            this.groupPanel1.Text = "Registro de puestos";
            // 
            // cmb_esta
            // 
            this.cmb_esta.DisplayMember = "Text";
            this.cmb_esta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_esta.ForeColor = System.Drawing.Color.Black;
            this.cmb_esta.FormattingEnabled = true;
            this.cmb_esta.ItemHeight = 15;
            this.cmb_esta.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmb_esta.Location = new System.Drawing.Point(389, 49);
            this.cmb_esta.Name = "cmb_esta";
            this.cmb_esta.Size = new System.Drawing.Size(220, 21);
            this.cmb_esta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_esta.TabIndex = 9;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Activo";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Inactivo";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(343, 51);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(68, 17);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Estado:";
            // 
            // txt_salario
            // 
            this.txt_salario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_salario.Border.Class = "TextBoxBorder";
            this.txt_salario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_salario.DisabledBackColor = System.Drawing.Color.White;
            this.txt_salario.ForeColor = System.Drawing.Color.Black;
            this.txt_salario.Location = new System.Drawing.Point(93, 103);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.PreventEnterBeep = true;
            this.txt_salario.Size = new System.Drawing.Size(220, 21);
            this.txt_salario.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(26, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(68, 17);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Salario:";
            // 
            // txt_descrip
            // 
            this.txt_descrip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_descrip.Border.Class = "TextBoxBorder";
            this.txt_descrip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_descrip.DisabledBackColor = System.Drawing.Color.White;
            this.txt_descrip.ForeColor = System.Drawing.Color.Black;
            this.txt_descrip.Location = new System.Drawing.Point(93, 76);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.PreventEnterBeep = true;
            this.txt_descrip.Size = new System.Drawing.Size(220, 21);
            this.txt_descrip.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(26, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 17);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Desripcion:";
            // 
            // txt_puesto
            // 
            this.txt_puesto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_puesto.Border.Class = "TextBoxBorder";
            this.txt_puesto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_puesto.DisabledBackColor = System.Drawing.Color.White;
            this.txt_puesto.ForeColor = System.Drawing.Color.Black;
            this.txt_puesto.Location = new System.Drawing.Point(93, 49);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.PreventEnterBeep = true;
            this.txt_puesto.Size = new System.Drawing.Size(220, 21);
            this.txt_puesto.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 51);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(41, 17);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Puesto:";
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_clave.Border.Class = "TextBoxBorder";
            this.txt_clave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_clave.DisabledBackColor = System.Drawing.Color.White;
            this.txt_clave.ForeColor = System.Drawing.Color.Black;
            this.txt_clave.Location = new System.Drawing.Point(93, 18);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PreventEnterBeep = true;
            this.txt_clave.Size = new System.Drawing.Size(150, 21);
            this.txt_clave.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(26, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(41, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Clave:";
            // 
            // dgv_puestos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_puestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_puestos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_puestos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv_puestos.Location = new System.Drawing.Point(12, 186);
            this.dgv_puestos.Name = "dgv_puestos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_puestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_puestos.RowHeadersVisible = false;
            this.dgv_puestos.Size = new System.Drawing.Size(744, 216);
            this.dgv_puestos.TabIndex = 1;
            // 
            // btn_new
            // 
            this.btn_new.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_new.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = global::SysTel_Network.Properties.Resources.add_48;
            this.btn_new.Location = new System.Drawing.Point(669, 22);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(87, 35);
            this.btn_new.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "Nuevo";
            // 
            // btn_insert
            // 
            this.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = global::SysTel_Network.Properties.Resources.accepted_48;
            this.btn_insert.Location = new System.Drawing.Point(669, 63);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(87, 35);
            this.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Registrar";
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = global::SysTel_Network.Properties.Resources.refresh_48;
            this.btn_update.Location = new System.Drawing.Point(669, 104);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 35);
            this.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Modificar";
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_delete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::SysTel_Network.Properties.Resources.cancel_48;
            this.btn_delete.Location = new System.Drawing.Point(669, 145);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 35);
            this.btn_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Eliminar";
            // 
            // lbl_total_reg
            // 
            // 
            // 
            // 
            this.lbl_total_reg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_total_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_reg.Location = new System.Drawing.Point(12, 408);
            this.lbl_total_reg.Name = "lbl_total_reg";
            this.lbl_total_reg.Size = new System.Drawing.Size(144, 23);
            this.lbl_total_reg.TabIndex = 36;
            this.lbl_total_reg.Text = "Total registros:";
            // 
            // lbl_pag
            // 
            // 
            // 
            // 
            this.lbl_pag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_pag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pag.Location = new System.Drawing.Point(462, 408);
            this.lbl_pag.Name = "lbl_pag";
            this.lbl_pag.Size = new System.Drawing.Size(95, 23);
            this.lbl_pag.TabIndex = 42;
            this.lbl_pag.Text = "Pagina:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(-400, 410);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(144, 23);
            this.labelX6.TabIndex = 41;
            this.labelX6.Text = "Total registros:";
            // 
            // btn_first
            // 
            this.btn_first.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_first.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_first.Location = new System.Drawing.Point(563, 408);
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
            this.btn_ult.Location = new System.Drawing.Point(713, 408);
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
            this.btn_ant.Location = new System.Drawing.Point(613, 408);
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
            this.btn_next.Location = new System.Drawing.Point(663, 408);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(44, 22);
            this.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_next.TabIndex = 37;
            this.btn_next.Text = "Sig";
            // 
            // Frm_cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 430);
            this.Controls.Add(this.lbl_pag);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_ult);
            this.Controls.Add(this.btn_ant);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_total_reg);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_puestos);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_cargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Registrar puestos</b><i></i>";
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_salario;
        private DevComponents.DotNetBar.LabelX labelX4;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_descrip;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_puesto;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.ButtonX btn_new;
        public DevComponents.DotNetBar.ButtonX btn_insert;
        public DevComponents.DotNetBar.ButtonX btn_update;
        public DevComponents.DotNetBar.ButtonX btn_delete;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmb_esta;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_clave;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgv_puestos;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        public DevComponents.DotNetBar.LabelX lbl_total_reg;
        public DevComponents.DotNetBar.LabelX lbl_pag;
        public DevComponents.DotNetBar.LabelX labelX6;
        public DevComponents.DotNetBar.ButtonX btn_first;
        public DevComponents.DotNetBar.ButtonX btn_ult;
        public DevComponents.DotNetBar.ButtonX btn_ant;
        public DevComponents.DotNetBar.ButtonX btn_next;


    }
}