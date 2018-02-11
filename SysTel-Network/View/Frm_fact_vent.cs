using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace SysTel_Network.View
{
    public partial class Frm_fact_vent : MetroForm
    {
        Model.cls_var_login _cls_var_lo = new Model.cls_var_login();
        public Frm_fact_vent()
        {
            InitializeComponent();
        }

        private void Frm_fact_vent_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_fact_venta._View_factura_venta' Puede moverla o quitarla según sea necesario.
            this._View_factura_ventaTableAdapter.Fill(this.dS_fact_venta._View_factura_venta);
            // TODO: esta línea de código carga datos en la tabla 'dS_fact_venta._View_fact_venta' Puede moverla o quitarla según sea necesario.
            this._View_factura_ventaTableAdapter.FillByID_venta(this.dS_fact_venta._View_factura_venta, ((int)(System.Convert.ChangeType(_cls_var_lo.Int_clave_venta.ToString(), typeof(int)))));
            //reportViewer1.DisplayMode = Microsoft.Reporting.WinForms.DisplayMode.PrintLayout;
            reportViewer1.DisplayMode.Equals(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            reportViewer1.ZoomPercent.Equals(100);
            this.reportViewer1.RefreshReport();
        }

        private void fillBy_ID_ventaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._View_factura_ventaTableAdapter.FillByID_venta(this.dS_fact_venta._View_factura_venta, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
