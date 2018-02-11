namespace SysTel_Network.View
{
    partial class Frm_ventas
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
            this.dgv_ventas = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_cant = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_pre_comp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cat_prod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_buscar_product = new DevComponents.DotNetBar.ButtonX();
            this.txt_marc_prod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_desc_prod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_product = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cod_product = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_no_venta = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_carg_emp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_empl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_buscar = new DevComponents.DotNetBar.ButtonX();
            this.txt_clave_cliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nom_contac = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_quitar = new DevComponents.DotNetBar.ButtonX();
            this.lbl_sub_to = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_t_compra = new System.Windows.Forms.Label();
            this.lbl_t_product = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_pago = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_cambio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_insert = new DevComponents.DotNetBar.ButtonX();
            this.btn_cancelra = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ventas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv_ventas.Location = new System.Drawing.Point(12, 338);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.RowHeadersVisible = false;
            this.dgv_ventas.Size = new System.Drawing.Size(941, 217);
            this.dgv_ventas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio $";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txt_cant);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.Controls.Add(this.txt_pre_comp);
            this.groupPanel1.Controls.Add(this.label14);
            this.groupPanel1.Controls.Add(this.txt_cat_prod);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.btn_buscar_product);
            this.groupPanel1.Controls.Add(this.txt_marc_prod);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.txt_desc_prod);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.txt_product);
            this.groupPanel1.Controls.Add(this.label10);
            this.groupPanel1.Controls.Add(this.txt_cod_product);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 187);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1135, 119);
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
            this.groupPanel1.Text = "Datos del producto";
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cant.Border.Class = "TextBoxBorder";
            this.txt_cant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cant.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cant.ForeColor = System.Drawing.Color.Black;
            this.txt_cant.Location = new System.Drawing.Point(827, 67);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.PreventEnterBeep = true;
            this.txt_cant.Size = new System.Drawing.Size(150, 22);
            this.txt_cant.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(722, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Cantidad:";
            // 
            // txt_pre_comp
            // 
            this.txt_pre_comp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pre_comp.Border.Class = "TextBoxBorder";
            this.txt_pre_comp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pre_comp.DisabledBackColor = System.Drawing.Color.White;
            this.txt_pre_comp.ForeColor = System.Drawing.Color.Black;
            this.txt_pre_comp.Location = new System.Drawing.Point(827, 39);
            this.txt_pre_comp.Name = "txt_pre_comp";
            this.txt_pre_comp.PreventEnterBeep = true;
            this.txt_pre_comp.Size = new System.Drawing.Size(150, 22);
            this.txt_pre_comp.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(722, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Precio:";
            // 
            // txt_cat_prod
            // 
            this.txt_cat_prod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cat_prod.Border.Class = "TextBoxBorder";
            this.txt_cat_prod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cat_prod.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cat_prod.ForeColor = System.Drawing.Color.Black;
            this.txt_cat_prod.Location = new System.Drawing.Point(472, 67);
            this.txt_cat_prod.Name = "txt_cat_prod";
            this.txt_cat_prod.PreventEnterBeep = true;
            this.txt_cat_prod.Size = new System.Drawing.Size(220, 22);
            this.txt_cat_prod.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Categoria:";
            // 
            // btn_buscar_product
            // 
            this.btn_buscar_product.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buscar_product.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buscar_product.Image = global::SysTel_Network.Properties.Resources.Busqueda;
            this.btn_buscar_product.Location = new System.Drawing.Point(270, 2);
            this.btn_buscar_product.Name = "btn_buscar_product";
            this.btn_buscar_product.Size = new System.Drawing.Size(85, 30);
            this.btn_buscar_product.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buscar_product.TabIndex = 26;
            this.btn_buscar_product.Text = "Buscar";
            // 
            // txt_marc_prod
            // 
            this.txt_marc_prod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_marc_prod.Border.Class = "TextBoxBorder";
            this.txt_marc_prod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_marc_prod.DisabledBackColor = System.Drawing.Color.White;
            this.txt_marc_prod.ForeColor = System.Drawing.Color.Black;
            this.txt_marc_prod.Location = new System.Drawing.Point(472, 39);
            this.txt_marc_prod.Name = "txt_marc_prod";
            this.txt_marc_prod.PreventEnterBeep = true;
            this.txt_marc_prod.Size = new System.Drawing.Size(220, 22);
            this.txt_marc_prod.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Marca:";
            // 
            // txt_desc_prod
            // 
            this.txt_desc_prod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_desc_prod.Border.Class = "TextBoxBorder";
            this.txt_desc_prod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_desc_prod.DisabledBackColor = System.Drawing.Color.White;
            this.txt_desc_prod.ForeColor = System.Drawing.Color.Black;
            this.txt_desc_prod.Location = new System.Drawing.Point(105, 67);
            this.txt_desc_prod.Name = "txt_desc_prod";
            this.txt_desc_prod.PreventEnterBeep = true;
            this.txt_desc_prod.Size = new System.Drawing.Size(250, 22);
            this.txt_desc_prod.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descripcion:";
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_product.Border.Class = "TextBoxBorder";
            this.txt_product.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_product.DisabledBackColor = System.Drawing.Color.White;
            this.txt_product.ForeColor = System.Drawing.Color.Black;
            this.txt_product.Location = new System.Drawing.Point(105, 39);
            this.txt_product.Name = "txt_product";
            this.txt_product.PreventEnterBeep = true;
            this.txt_product.Size = new System.Drawing.Size(250, 22);
            this.txt_product.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Producto:";
            // 
            // txt_cod_product
            // 
            this.txt_cod_product.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cod_product.Border.Class = "TextBoxBorder";
            this.txt_cod_product.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cod_product.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cod_product.ForeColor = System.Drawing.Color.Black;
            this.txt_cod_product.Location = new System.Drawing.Point(105, 10);
            this.txt_cod_product.Name = "txt_cod_product";
            this.txt_cod_product.PreventEnterBeep = true;
            this.txt_cod_product.Size = new System.Drawing.Size(150, 22);
            this.txt_cod_product.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Codigo:";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lbl_no_venta);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(1033, 12);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(114, 69);
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
            this.groupPanel2.TabIndex = 3;
            // 
            // lbl_no_venta
            // 
            // 
            // 
            // 
            this.lbl_no_venta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_no_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_venta.Location = new System.Drawing.Point(27, 32);
            this.lbl_no_venta.Name = "lbl_no_venta";
            this.lbl_no_venta.Size = new System.Drawing.Size(55, 23);
            this.lbl_no_venta.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(16, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "No. venta";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.txt_carg_emp);
            this.groupPanel3.Controls.Add(this.label2);
            this.groupPanel3.Controls.Add(this.txt_nom_empl);
            this.groupPanel3.Controls.Add(this.label1);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.Location = new System.Drawing.Point(12, 87);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(418, 94);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 4;
            this.groupPanel3.Text = "Atendido por";
            // 
            // txt_carg_emp
            // 
            this.txt_carg_emp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_carg_emp.Border.Class = "TextBoxBorder";
            this.txt_carg_emp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_carg_emp.DisabledBackColor = System.Drawing.Color.White;
            this.txt_carg_emp.ForeColor = System.Drawing.Color.Black;
            this.txt_carg_emp.Location = new System.Drawing.Point(254, 24);
            this.txt_carg_emp.Name = "txt_carg_emp";
            this.txt_carg_emp.PreventEnterBeep = true;
            this.txt_carg_emp.Size = new System.Drawing.Size(150, 22);
            this.txt_carg_emp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo:";
            // 
            // txt_nom_empl
            // 
            this.txt_nom_empl.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nom_empl.Border.Class = "TextBoxBorder";
            this.txt_nom_empl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nom_empl.DisabledBackColor = System.Drawing.Color.White;
            this.txt_nom_empl.ForeColor = System.Drawing.Color.Black;
            this.txt_nom_empl.Location = new System.Drawing.Point(17, 24);
            this.txt_nom_empl.Name = "txt_nom_empl";
            this.txt_nom_empl.PreventEnterBeep = true;
            this.txt_nom_empl.Size = new System.Drawing.Size(220, 22);
            this.txt_nom_empl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del empleado:";
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.btn_buscar);
            this.groupPanel4.Controls.Add(this.txt_clave_cliente);
            this.groupPanel4.Controls.Add(this.txt_tel);
            this.groupPanel4.Controls.Add(this.label6);
            this.groupPanel4.Controls.Add(this.txt_nom_contac);
            this.groupPanel4.Controls.Add(this.label4);
            this.groupPanel4.Controls.Add(this.label5);
            this.groupPanel4.Controls.Add(this.txt_direc);
            this.groupPanel4.Controls.Add(this.label3);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel4.Location = new System.Drawing.Point(436, 87);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(711, 94);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 7;
            this.groupPanel4.Text = "Datos del cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buscar.Image = global::SysTel_Network.Properties.Resources.Busqueda;
            this.btn_buscar.Location = new System.Drawing.Point(240, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 31);
            this.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            // 
            // txt_clave_cliente
            // 
            this.txt_clave_cliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_clave_cliente.Border.Class = "TextBoxBorder";
            this.txt_clave_cliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_clave_cliente.DisabledBackColor = System.Drawing.Color.White;
            this.txt_clave_cliente.ForeColor = System.Drawing.Color.Black;
            this.txt_clave_cliente.Location = new System.Drawing.Point(84, 12);
            this.txt_clave_cliente.Name = "txt_clave_cliente";
            this.txt_clave_cliente.PreventEnterBeep = true;
            this.txt_clave_cliente.Size = new System.Drawing.Size(150, 22);
            this.txt_clave_cliente.TabIndex = 12;
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
            this.txt_tel.Location = new System.Drawing.Point(420, 40);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PreventEnterBeep = true;
            this.txt_tel.Size = new System.Drawing.Size(220, 22);
            this.txt_tel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // txt_nom_contac
            // 
            this.txt_nom_contac.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nom_contac.Border.Class = "TextBoxBorder";
            this.txt_nom_contac.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nom_contac.DisabledBackColor = System.Drawing.Color.White;
            this.txt_nom_contac.ForeColor = System.Drawing.Color.Black;
            this.txt_nom_contac.Location = new System.Drawing.Point(82, 40);
            this.txt_nom_contac.Name = "txt_nom_contac";
            this.txt_nom_contac.PreventEnterBeep = true;
            this.txt_nom_contac.Size = new System.Drawing.Size(220, 22);
            this.txt_nom_contac.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
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
            this.txt_direc.Location = new System.Drawing.Point(420, 12);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.PreventEnterBeep = true;
            this.txt_direc.Size = new System.Drawing.Size(220, 22);
            this.txt_direc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            // 
            // groupPanel5
            // 
            this.groupPanel5.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.btn_quitar);
            this.groupPanel5.Controls.Add(this.lbl_sub_to);
            this.groupPanel5.Controls.Add(this.label20);
            this.groupPanel5.Controls.Add(this.label19);
            this.groupPanel5.Controls.Add(this.label18);
            this.groupPanel5.Controls.Add(this.lbl_t_compra);
            this.groupPanel5.Controls.Add(this.lbl_t_product);
            this.groupPanel5.Controls.Add(this.label8);
            this.groupPanel5.Controls.Add(this.label7);
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Location = new System.Drawing.Point(959, 338);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(188, 217);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 2;
            // 
            // btn_quitar
            // 
            this.btn_quitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_quitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.Location = new System.Drawing.Point(15, 13);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(152, 28);
            this.btn_quitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_quitar.TabIndex = 35;
            this.btn_quitar.Text = "Quitar producto ";
            // 
            // lbl_sub_to
            // 
            this.lbl_sub_to.AutoSize = true;
            this.lbl_sub_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_to.Location = new System.Drawing.Point(97, 129);
            this.lbl_sub_to.Name = "lbl_sub_to";
            this.lbl_sub_to.Size = new System.Drawing.Size(32, 16);
            this.lbl_sub_to.TabIndex = 34;
            this.lbl_sub_to.Text = "0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Subtotal $:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(99, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "0%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Descuento:";
            // 
            // lbl_t_compra
            // 
            this.lbl_t_compra.AutoSize = true;
            this.lbl_t_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t_compra.Location = new System.Drawing.Point(99, 160);
            this.lbl_t_compra.Name = "lbl_t_compra";
            this.lbl_t_compra.Size = new System.Drawing.Size(32, 16);
            this.lbl_t_compra.TabIndex = 28;
            this.lbl_t_compra.Text = "0.00";
            // 
            // lbl_t_product
            // 
            this.lbl_t_product.AutoSize = true;
            this.lbl_t_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t_product.Location = new System.Drawing.Point(97, 56);
            this.lbl_t_product.Name = "lbl_t_product";
            this.lbl_t_product.Size = new System.Drawing.Size(15, 16);
            this.lbl_t_product.TabIndex = 27;
            this.lbl_t_product.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Productos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total $:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 316);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 35;
            this.label21.Text = "Fecha de venta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(337, 316);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "Tipo de venta:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(437, 316);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 16);
            this.label23.TabIndex = 38;
            this.label23.Text = "CONTADO";
            // 
            // txt_pago
            // 
            this.txt_pago.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pago.Border.Class = "TextBoxBorder";
            this.txt_pago.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pago.DisabledBackColor = System.Drawing.Color.White;
            this.txt_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pago.ForeColor = System.Drawing.Color.Black;
            this.txt_pago.Location = new System.Drawing.Point(510, 565);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.PreventEnterBeep = true;
            this.txt_pago.Size = new System.Drawing.Size(150, 22);
            this.txt_pago.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(425, 567);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 16);
            this.label24.TabIndex = 33;
            this.label24.Text = "Pago con $:";
            // 
            // txt_cambio
            // 
            this.txt_cambio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cambio.Border.Class = "TextBoxBorder";
            this.txt_cambio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cambio.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cambio.ForeColor = System.Drawing.Color.Black;
            this.txt_cambio.Location = new System.Drawing.Point(740, 567);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.PreventEnterBeep = true;
            this.txt_cambio.Size = new System.Drawing.Size(150, 22);
            this.txt_cambio.TabIndex = 40;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(666, 569);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 16);
            this.label25.TabIndex = 39;
            this.label25.Text = "Cambio $:";
            // 
            // btn_insert
            // 
            this.btn_insert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_insert.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Image = global::SysTel_Network.Properties.Resources.accepted_48;
            this.btn_insert.Location = new System.Drawing.Point(910, 561);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(116, 35);
            this.btn_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_insert.TabIndex = 42;
            this.btn_insert.Text = "Realizar ";
            // 
            // btn_cancelra
            // 
            this.btn_cancelra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cancelra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cancelra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelra.Image = global::SysTel_Network.Properties.Resources.cancel_48;
            this.btn_cancelra.Location = new System.Drawing.Point(1032, 561);
            this.btn_cancelra.Name = "btn_cancelra";
            this.btn_cancelra.Size = new System.Drawing.Size(114, 35);
            this.btn_cancelra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cancelra.TabIndex = 41;
            this.btn_cancelra.Text = "Cancelar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SysTel_Network.Properties.Resources.full_cart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 600);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_cancelra);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_pago);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupPanel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dgv_ventas);
            this.DoubleBuffered = true;
            this.HelpButtonText = "Help System";
            this.HelpButtonVisible = true;
            this.Name = "Frm_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Realizar ventas</b>";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_carg_emp;
        private System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_nom_empl;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_tel;
        private System.Windows.Forms.Label label6;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_nom_contac;
        private System.Windows.Forms.Label label5;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_direc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_clave_cliente;
        public DevComponents.DotNetBar.ButtonX btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public DevComponents.DotNetBar.ButtonX btn_buscar_product;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_marc_prod;
        private System.Windows.Forms.Label label12;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_desc_prod;
        private System.Windows.Forms.Label label11;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_product;
        private System.Windows.Forms.Label label10;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_cod_product;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbl_sub_to;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lbl_t_compra;
        public System.Windows.Forms.Label lbl_t_product;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_pre_comp;
        private System.Windows.Forms.Label label14;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_cat_prod;
        private System.Windows.Forms.Label label13;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_cant;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_pago;
        private System.Windows.Forms.Label label24;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_cambio;
        private System.Windows.Forms.Label label25;
        public DevComponents.DotNetBar.ButtonX btn_insert;
        public DevComponents.DotNetBar.ButtonX btn_cancelra;
        public DevComponents.DotNetBar.LabelX lbl_no_venta;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgv_ventas;
        public DevComponents.DotNetBar.ButtonX btn_quitar;
    }
}