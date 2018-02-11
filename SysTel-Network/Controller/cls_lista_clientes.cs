using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Controller
{
    class cls_lista_clientes
    {
        private View.Frm_lista_clientes _frm_Clientes;
        private View.Frm_ventas _frm_ventas;
        private View.Frm_servicios _frm_servicios;
        private Model.cls_dav_lista_clientes _cls_dav_list_cli;
        private SqlDataReader _SqlDataRead;
        private bool _ventas = false;
        private int _int_cont = 0;
        public cls_lista_clientes(View.Frm_lista_clientes _f_clientes,View.Frm_ventas _f_ventas) {
            _frm_Clientes = _f_clientes;
            _frm_ventas = _f_ventas;
            _cls_dav_list_cli = Model.cls_dav_lista_clientes._Instance;
            _met_evet_click();
            _ventas = true;
        }
        public cls_lista_clientes(View.Frm_lista_clientes _f_clientes, View.Frm_servicios _f_servicios) {
            _frm_Clientes = _f_clientes;
            _frm_servicios = _f_servicios;
            _cls_dav_list_cli = new Model.cls_dav_lista_clientes();
            _met_evet_click();
        }
        private void _met_evet_click() {
            _met_load_datagridview();
            _frm_Clientes.dgv_lista_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_clickcell_datagridview);
        }
        private void _met_load_datagridview() {
            _cls_dav_list_cli._met_load_datagridview();
            _SqlDataRead = _cls_dav_list_cli._Sqldataread;
            _frm_Clientes.dgv_lista_clientes.Rows.Clear();
            while (_SqlDataRead.Read()) {
                _int_cont = _frm_Clientes.dgv_lista_clientes.Rows.Add();
                _frm_Clientes.dgv_lista_clientes.Rows[_int_cont].Cells[0].Value = _SqlDataRead[0];
                _frm_Clientes.dgv_lista_clientes.Rows[_int_cont].Cells[1].Value = _SqlDataRead[1];
                _frm_Clientes.dgv_lista_clientes.Rows[_int_cont].Cells[2].Value = _SqlDataRead[4];
                _frm_Clientes.dgv_lista_clientes.Rows[_int_cont].Cells[3].Value = _SqlDataRead[2];
                _int_cont++;
            }
        }
        private void _met_event_clickcell_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_Clientes.dgv_lista_clientes.CurrentRow.Cells[0].Value) != "") {
                if (_ventas != false) {
                    _frm_ventas.txt_clave_cliente.Text = _frm_Clientes.dgv_lista_clientes.CurrentRow.Cells[0].Value.ToString();
                    _frm_ventas.txt_nom_contac.Text = _frm_Clientes.dgv_lista_clientes.CurrentRow.Cells[1].Value.ToString();
                    _frm_ventas.txt_direc.Text = _frm_Clientes.dgv_lista_clientes.CurrentRow.Cells[2].Value.ToString();
                    _frm_ventas.txt_tel.Text = _frm_Clientes.dgv_lista_clientes.CurrentRow.Cells[3].Value.ToString();
                    _frm_Clientes.Hide();
                }
            }
        }
    }   
}
