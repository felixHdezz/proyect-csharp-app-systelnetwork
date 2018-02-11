namespace SysTel_Network.View
{
    partial class Frm_fact_vent
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewfacturaventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_fact_venta = new SysTel_Network.Model.DS_fact_venta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._View_factura_ventaTableAdapter = new SysTel_Network.Model.DS_fact_ventaTableAdapters._View_factura_ventaTableAdapter();
            this.fillBy_ID_ventaToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy_ID_ventaToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewfacturaventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_fact_venta)).BeginInit();
            this.fillBy_ID_ventaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewfacturaventaBindingSource
            // 
            this.viewfacturaventaBindingSource.DataMember = "_View_factura_venta";
            this.viewfacturaventaBindingSource.DataSource = this.dS_fact_venta;
            // 
            // dS_fact_venta
            // 
            this.dS_fact_venta.DataSetName = "DS_fact_venta";
            this.dS_fact_venta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewfacturaventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SysTel_Network.View.RP_fact_venta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 486);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // _View_factura_ventaTableAdapter
            // 
            this._View_factura_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy_ID_ventaToolStrip
            // 
            this.fillBy_ID_ventaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillBy_ID_ventaToolStripButton});
            this.fillBy_ID_ventaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy_ID_ventaToolStrip.Name = "fillBy_ID_ventaToolStrip";
            this.fillBy_ID_ventaToolStrip.Size = new System.Drawing.Size(927, 25);
            this.fillBy_ID_ventaToolStrip.TabIndex = 1;
            this.fillBy_ID_ventaToolStrip.Text = "fillBy_ID_ventaToolStrip";
            this.fillBy_ID_ventaToolStrip.Visible = false;
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.param1ToolStripLabel.Text = "Param1:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy_ID_ventaToolStripButton
            // 
            this.fillBy_ID_ventaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy_ID_ventaToolStripButton.Name = "fillBy_ID_ventaToolStripButton";
            this.fillBy_ID_ventaToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.fillBy_ID_ventaToolStripButton.Text = "FillBy_ID_venta";
            this.fillBy_ID_ventaToolStripButton.Click += new System.EventHandler(this.fillBy_ID_ventaToolStripButton_Click);
            // 
            // Frm_fact_vent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 518);
            this.Controls.Add(this.fillBy_ID_ventaToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.HelpButtonText = "help ";
            this.HelpButtonVisible = true;
            this.Name = "Frm_fact_vent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura de venta";
            this.Load += new System.EventHandler(this.Frm_fact_vent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewfacturaventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_fact_venta)).EndInit();
            this.fillBy_ID_ventaToolStrip.ResumeLayout(false);
            this.fillBy_ID_ventaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Model.DS_fact_venta dS_fact_venta;
        private System.Windows.Forms.BindingSource viewfacturaventaBindingSource;
        private Model.DS_fact_ventaTableAdapters._View_factura_ventaTableAdapter _View_factura_ventaTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy_ID_ventaToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy_ID_ventaToolStripButton;
    }
}