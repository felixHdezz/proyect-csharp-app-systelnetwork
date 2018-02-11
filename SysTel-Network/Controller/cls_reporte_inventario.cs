using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysTel_Network.View;
using SysTel_Network.Model;

namespace SysTel_Network.Controller
{
    class cls_reporte_inventario
    {
        private Frm_reporte_inventario _frm_report_invent;
        public cls_reporte_inventario(Frm_reporte_inventario _frm_rep_inv) {
            _frm_report_invent = _frm_rep_inv;
            _met_load_data();
        }
        private void _met_load_data() {
            _frm_report_invent._view_inventarioTableAdapter.Fill(_frm_report_invent.dreporteInventario._view_inventario);
            // TODO: esta línea de código carga datos en la tabla 'dreporteInventario._view_inventario' Puede moverla o quitarla según sea necesario.
            _frm_report_invent._view_inventarioTableAdapter.Fill(_frm_report_invent.dreporteInventario._view_inventario);
            // TODO: esta línea de código carga datos en la tabla 'dreporteInventario._view_inventario' Puede moverla o quitarla según sea necesario.
            _frm_report_invent._view_inventarioTableAdapter.Fill(_frm_report_invent.dreporteInventario._view_inventario);
            // TODO: esta línea de código carga datos en la tabla 'dreporteInventario._view_inventario' Puede moverla o quitarla según sea necesario.
            _frm_report_invent._view_inventarioTableAdapter.Fill(_frm_report_invent.dreporteInventario._view_inventario);
            _frm_report_invent.reportViewer1.DisplayMode.Equals(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            _frm_report_invent.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            _frm_report_invent.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            _frm_report_invent.reportViewer1.ZoomPercent.Equals(100);
            _frm_report_invent.reportViewer1.RefreshReport();
        }
    }
}
