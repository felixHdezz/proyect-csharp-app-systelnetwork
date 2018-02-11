using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Controller
{
    class cls_lista_productos
    {
        private Model.cls_conexion _cls_con = Model.cls_conexion._Instance;
        private View.Frm_lista_productos _frm_list_prod;
        private View.Frm_compras _frm_compras;
        private View.Frm_ventas _frm_ventas;
        private int _int_cont;
        private bool _compras;
        public cls_lista_productos(View.Frm_lista_productos _f_list_prod,View.Frm_compras _f_comp) {
            _frm_list_prod = _f_list_prod;
            _frm_compras = _f_comp;
            _met_event_click();
            _compras = true;
        }
        public cls_lista_productos(View.Frm_lista_productos _f_list_prod, View.Frm_ventas _f_vent){
            _frm_list_prod = _f_list_prod;
            _frm_ventas = _f_vent;
            _met_event_click();
            _compras = false;
        }
        private void _met_event_click() {
            _met_load_data_grid_view();
            _frm_list_prod.dgv_list_prod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_cell_click);
        }
        private void _met_load_data_grid_view() {
            SqlDataReader _SqlDataRead = _cls_con._met_data_cunsult("exec _SP_productos '4','','','','','','','0.00','0.00','',''");
            _frm_list_prod.dgv_list_prod.Rows.Clear();
            while (_SqlDataRead.Read()) {
                _int_cont = _frm_list_prod.dgv_list_prod.Rows.Add();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[0].Value = _SqlDataRead[0].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[1].Value = _SqlDataRead[1].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[2].Value = _SqlDataRead[2].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[3].Value = _SqlDataRead[3].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[4].Value = _SqlDataRead[4].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[5].Value = _SqlDataRead[6].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[6].Value = _SqlDataRead[7].ToString().ToUpper();
                _frm_list_prod.dgv_list_prod.Rows[_int_cont].Cells[7].Value = _SqlDataRead[8].ToString().ToUpper();
                _int_cont++;
            }
        }
        private void _met_event_cell_click(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_list_prod.dgv_list_prod.CurrentRow.Cells[0].Value) != "") {
                if (_compras != false) {
                    _frm_compras.txt_cod_product.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[0].Value.ToString().ToUpper();
                    _frm_compras.txt_product.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[1].Value.ToString().ToUpper();
                    _frm_compras.txt_desc_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[2].Value.ToString().ToUpper();
                    _frm_compras.txt_marc_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[3].Value.ToString().ToUpper();
                    _frm_compras.txt_cat_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[4].Value.ToString().ToUpper();
                    _frm_compras.txt_pre_comp.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[6].Value.ToString().ToUpper();
                    _frm_compras.txt_cant.Focus();
                    _frm_list_prod.Hide();
                }else{
                    _frm_ventas.txt_cod_product.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[0].Value.ToString().ToUpper();
                    _frm_ventas.txt_product.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[1].Value.ToString().ToUpper();
                    _frm_ventas.txt_desc_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[2].Value.ToString().ToUpper();
                    _frm_ventas.txt_marc_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[3].Value.ToString().ToUpper();
                    _frm_ventas.txt_cat_prod.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[4].Value.ToString().ToUpper();
                    _frm_ventas.txt_pre_comp.Text = _frm_list_prod.dgv_list_prod.CurrentRow.Cells[5].Value.ToString().ToUpper();
                    _frm_ventas.txt_cant.Focus();
                    _frm_list_prod.Hide();
                }
            }
        }
    }
}
