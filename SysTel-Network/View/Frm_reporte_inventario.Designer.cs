namespace SysTel_Network.View
{
    partial class Frm_reporte_inventario
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
            this.viewinventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dreporteInventario = new SysTel_Network.Model.DreporteInventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._view_inventarioTableAdapter = new SysTel_Network.Model.DreporteInventarioTableAdapters._view_inventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewinventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreporteInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // viewinventarioBindingSource
            // 
            this.viewinventarioBindingSource.DataMember = "_view_inventario";
            this.viewinventarioBindingSource.DataSource = this.dreporteInventario;
            // 
            // dreporteInventario
            // 
            this.dreporteInventario.DataSetName = "DreporteInventario";
            this.dreporteInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewinventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SysTel_Network.View.ReportInvent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1017, 611);
            this.reportViewer1.TabIndex = 0;
            // 
            // _view_inventarioTableAdapter
            // 
            this._view_inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_reporte_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 635);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.Name = "Frm_reporte_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "<b>Reporte de inventario</b>";
            this.Load += new System.EventHandler(this.Frm_reporte_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewinventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreporteInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Model.DreporteInventario dreporteInventario;
        public System.Windows.Forms.BindingSource viewinventarioBindingSource;
        public Model.DreporteInventarioTableAdapters._view_inventarioTableAdapter _view_inventarioTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}