using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace SysTel_Network.Controller
{
    class cls_ventas
    {
        private Model.cls_var_login _cls_var_login = new Model.cls_var_login();
        private View.Frm_ventas _frm_ventas;
        private Model.cls_dav_ventas _cls_dav_ventas;
        private Model.cls_vo_ventas _cls_vo_ventas = Model.cls_vo_ventas._Instance;
        private View.Frm_lista_productos _frm_list_pro;
        private View.Frm_fact_vent _frm_fact_vent = new View.Frm_fact_vent();
        private View.Frm_lista_clientes _frm_lista_clientes;
        private SqlDataReader _SqlDataRead;
        private int _int_cont = 0, _int_num_product = 0, _int_cant, _int_num_fila;
        private double _total_venta, _precio_product;
        public cls_ventas(View.Frm_ventas _f_ventas) {
            _frm_ventas= _f_ventas;
            _cls_dav_ventas = Model.cls_dav_ventas._Instance;
            _met_event_click();
        }
        private void _met_event_click() {
            _frm_ventas.txt_nom_empl.Text = _cls_var_login._Nom_empl;
            _frm_ventas.txt_carg_emp.Text = _cls_var_login._Carg;
            _met_load_clave_autoincre();
            _met_enable_text_and_btn();
            _frm_ventas.btn_insert.Enabled = false;
            _frm_ventas.btn_buscar.Click += new EventHandler(_met_event_click_btn_bus_cli);
            _frm_ventas.btn_buscar_product.Click += new EventHandler(_met_event_click_btn_bus_product);
            _frm_ventas.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_add_product);
            _frm_ventas.btn_quitar.Click += new EventHandler(_met_event_click_btn_quitar_product);
            _frm_ventas.txt_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_pago);
            _frm_ventas.btn_insert.Click += new EventHandler(_met_event_click_btn_insert_venta);
        }
        private void _met_enable_text_and_btn() {
            _frm_ventas.txt_nom_empl.Enabled = false;
            _frm_ventas.txt_nom_contac.Enabled = false;
            _frm_ventas.txt_pre_comp.Enabled = false;
            _frm_ventas.txt_product.Enabled = false;
            _frm_ventas.txt_tel.Enabled = false;
            _frm_ventas.txt_carg_emp.Enabled = false;
            _frm_ventas.txt_desc_prod.Enabled = false;
            _frm_ventas.txt_direc.Enabled = false;
            _frm_ventas.txt_marc_prod.Enabled = false;
            _frm_ventas.txt_cat_prod.Enabled = false;
        }
        private void _met_clear_data(string ac) {
            switch (ac) { 
                case "add":
                    _frm_ventas.txt_cant.Text = "";
                    _frm_ventas.txt_cat_prod.Text = "";
                    _frm_ventas.txt_cod_product.Text = "";
                    _frm_ventas.txt_desc_prod.Text = "";
                    _frm_ventas.txt_marc_prod.Text = "";
                    _frm_ventas.txt_pre_comp.Text = "";
                    _frm_ventas.txt_product.Text = "";
                    break;
                case "insert":
                    _frm_ventas.dgv_ventas.Rows.Clear();
                    _frm_ventas.txt_cambio.Text = "";
                    _frm_ventas.txt_tel.Text = "";
                    _frm_ventas.txt_pago.Text = "";
                    _frm_ventas.txt_nom_contac.Text = "";
                    _frm_ventas.txt_direc.Text = "";
                    _frm_ventas.txt_clave_cliente.Text = "";
                    _frm_ventas.lbl_t_product.Text = "";
                    _frm_ventas.lbl_t_compra.Text = "0.00";
                    _frm_ventas.lbl_sub_to.Text = "0.00";
                    break;
            }
        }
        private void _met_load_clave_autoincre() {
            _cls_dav_ventas._met_clave_autoincrement();
            _SqlDataRead = _cls_dav_ventas._SqlDataRead;
            while (_SqlDataRead.Read()){
                if (Convert.ToInt32(_SqlDataRead[0]) < 10){
                    _frm_ventas.lbl_no_venta.Text = "000" + Convert.ToString(_SqlDataRead[0]);
                }else{
                    if (Convert.ToInt32(_SqlDataRead[0]) >= 10 && Convert.ToInt32(_SqlDataRead[0]) < 100)
                    _frm_ventas.lbl_no_venta.Text = "00"+Convert.ToString(_SqlDataRead[0]);
                }
            }
            if (_frm_ventas.lbl_no_venta.Text == ""){
                _frm_ventas.lbl_no_venta.Text = "001";
            }
        }
        private void _met_send_data() {
            _cls_vo_ventas.Dc_pago = Convert.ToDecimal(_frm_ventas.txt_pago.Text);
            _cls_vo_ventas.Dc_total_vent = Convert.ToDecimal(_frm_ventas.lbl_t_compra.Text);
            _cls_vo_ventas.Int_cant_product = Convert.ToInt32(_frm_ventas.lbl_t_product.Text);
            _cls_vo_ventas.Int_id_vent = Convert.ToInt32(_frm_ventas.lbl_no_venta.Text);
            _cls_vo_ventas.Str_cli = _frm_ventas.txt_clave_cliente.Text;
            _cls_vo_ventas.Str_rfc = _cls_var_login._RFC;
        }
        private void _met_event_click_btn_bus_cli(object sender, EventArgs e) {
            _frm_lista_clientes = new View.Frm_lista_clientes();
            Controller.cls_lista_clientes _cls_cont_cli = new Controller.cls_lista_clientes(_frm_lista_clientes,_frm_ventas);
            _frm_lista_clientes.Show();
        }
        private void _met_event_click_btn_bus_product(object sender, EventArgs e) { 
            _frm_list_pro = new View.Frm_lista_productos();
            Controller.cls_lista_productos _cls_con_list = new cls_lista_productos(_frm_list_pro, _frm_ventas);
            _frm_list_pro.Show();
        }
        private void _met_event_keypres_add_product(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                if (_frm_ventas.txt_cod_product.Text != "" && _frm_ventas.txt_clave_cliente.Text != "") {
                    int _con = 0;
                    while(_con < 1){
                        _int_cont = _frm_ventas.dgv_ventas.Rows.Add();
                        _frm_ventas.dgv_ventas.Rows[_int_cont].Cells[0].Value = _frm_ventas.txt_cod_product.Text;
                        _frm_ventas.dgv_ventas.Rows[_int_cont].Cells[1].Value = _frm_ventas.txt_product.Text;
                        _frm_ventas.dgv_ventas.Rows[_int_cont].Cells[2].Value = _frm_ventas.txt_desc_prod.Text;
                        _frm_ventas.dgv_ventas.Rows[_int_cont].Cells[3].Value = _frm_ventas.txt_pre_comp.Text;
                        _frm_ventas.dgv_ventas.Rows[_int_cont].Cells[4].Value = _frm_ventas.txt_cant.Text;
                        _con++;
                    }
                    _int_cont++;
                    _int_num_product = _int_cont;
                    _precio_product = Convert.ToDouble(_frm_ventas.dgv_ventas.Rows[_int_cont - 1].Cells[3].Value);
                    _int_cant = Convert.ToInt32(_frm_ventas.dgv_ventas.Rows[_int_cont - 1].Cells[4].Value);
                    _total_venta += Convert.ToDouble(Convert.ToDouble(_frm_ventas.txt_pre_comp.Text) * _int_cant);
                    _frm_ventas.lbl_t_product.Text = _int_num_product.ToString();
                    _frm_ventas.lbl_sub_to.Text = _total_venta.ToString();
                    _frm_ventas.lbl_t_compra.Text = _total_venta.ToString();
                    _precio_product = 0;
                    _int_cant = 0;
                    _met_clear_data("add");
                }
            }
        }
        private void _met_event_click_btn_quitar_product(object sender, EventArgs e) {
            if (Convert.ToInt32(_frm_ventas.dgv_ventas.CurrentRow.Cells[0].Value) > 0) {
                _int_num_fila = _frm_ventas.dgv_ventas.CurrentRow.Index;
                _int_num_product = _int_cont;
                _precio_product = Convert.ToDouble(_frm_ventas.dgv_ventas.CurrentRow.Cells[3].Value);
                _int_cant = Convert.ToInt32(_frm_ventas.dgv_ventas.CurrentRow.Cells[4].Value);
                _total_venta -= _precio_product * _int_cant;
                _frm_ventas.lbl_t_product.Text = _int_num_product.ToString();
                _frm_ventas.lbl_sub_to.Text = _total_venta.ToString();
                _frm_ventas.lbl_t_compra.Text = _total_venta.ToString();
                _frm_ventas.dgv_ventas.Rows.RemoveAt(_int_num_fila);
            }
        }
        private void _met_event_keypres_pago(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                if (_frm_ventas.txt_pago.Text != "") {
                    if (Convert.ToDecimal(_frm_ventas.txt_pago.Text) >= Convert.ToDecimal(_frm_ventas.lbl_t_compra.Text)) {
                        _frm_ventas.txt_cambio.Text = Convert.ToString(Convert.ToDecimal(_frm_ventas.txt_pago.Text) - Convert.ToDecimal(_frm_ventas.lbl_t_compra.Text));
                        _frm_ventas.btn_insert.Enabled = true;
                    }else{
                        _frm_ventas.txt_pago.Text = "";
                        _frm_ventas.txt_pago.Focus();
                    }
                }
            }
        }
        private void _met_event_click_btn_insert_venta(object sender, EventArgs e) {
            if (_frm_ventas.txt_clave_cliente.Text != "" && _frm_ventas.dgv_ventas.RowCount > 1) {
                _met_send_data();
                _cls_dav_ventas._met_insert_venta(_cls_vo_ventas);
                if (_cls_dav_ventas._Action != false) {
                    for (int x = 0; x < _frm_ventas.dgv_ventas.RowCount - 1; x++) {
                        _cls_vo_ventas.Str_codigo = _frm_ventas.dgv_ventas.Rows[x].Cells[0].Value.ToString();
                        _cls_vo_ventas.Dc_precXuni = Convert.ToDecimal(_frm_ventas.dgv_ventas.Rows[x].Cells[3].Value.ToString());
                        _cls_vo_ventas.Int_cant = Convert.ToInt32(_frm_ventas.dgv_ventas.Rows[x].Cells[4].Value.ToString());
                        _cls_dav_ventas._met_insert_venta_detalle(_cls_vo_ventas);
                    }
                    _cls_var_login.Int_clave_venta = Convert.ToInt32(_frm_ventas.lbl_no_venta.Text);
                    _met_clear_data("insert");
                    _met_load_clave_autoincre();
                    _total_venta = 0;
                    MessageBoxEx.Show("La venta se ha realizado con exito","Mensaje dese el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                    View.Frm_fact_vent _frm_fact_vent = new View.Frm_fact_vent();
                    _frm_fact_vent.Show();
                }else{
                    MessageBoxEx.Show("Error al realizar la venta. Verifique los datos","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }else{
                MessageBoxEx.Show("Error... Por favor vefirique los datos","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
