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
    class cls_compras
    {
        private View.Frm_compras _frm_compras;
        private Model.cls_var_login _cls_var_login = new Model.cls_var_login();
        private Model.cls_vo_compras _cls_vo_compras = Model.cls_vo_compras._Instance;
        private Model.cls_dav_compras _cls_dav_comp;
        private SqlDataReader _SqlDataRead;
        private string[] _array = new string[6];
        private int _int_con = 0,_int_cant_prod = 0;
        private static int _int_clave_compra;
        decimal _dc_total_compra;
        public cls_compras(View.Frm_compras _f_compras) {
            _frm_compras = _f_compras;
            _cls_dav_comp = Model.cls_dav_compras._Instance;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_idincrement();
            _met_enable_textbox();
            _met_load_combobox();
            _frm_compras.cmb_provee.SelectionChangeCommitted += new EventHandler(_met_event_click_cmb_pro);
            _frm_compras.btn_buscar.Click += new EventHandler(_met_event_click_btn_bus);
            _frm_compras.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_txt_cant);
            _frm_compras.btn_insert.Click += new EventHandler(_met_event_click_btn_insert_Compra);
            _frm_compras.btn_cancelra.Click += new EventHandler(_met_event_click_btn_cancelar);
        }
        private void _met_idincrement(){
            _SqlDataRead = _cls_dav_comp._met_clave_automatic();
            while (_SqlDataRead.Read()){
                _frm_compras.lbl_no_compra.Text = Convert.ToString(_SqlDataRead[0]);
            }
            if (_frm_compras.lbl_no_compra.Text == ""){
                _frm_compras.lbl_no_compra.Text = "1";
            }
        }
        private void _met_load_combobox() {
            _frm_compras.cmb_provee.DataSource = _cls_dav_comp._met_load_combobox();
            _frm_compras.cmb_provee.DisplayMember = "vch_nom_prove".ToUpper();
            _frm_compras.cmb_provee.ValueMember = "nch_clv_prove";
        }
        private void _met_enable_textbox() {
            _frm_compras.txt_nom_empl.Enabled = false;
            _frm_compras.txt_carg_emp.Enabled = false;
            _frm_compras.txt_desc_prod.Enabled = false;
            _frm_compras.txt_direc_pro.Enabled = false;
            _frm_compras.txt_marc_prod.Enabled = false;
            _frm_compras.txt_nom_contac.Enabled = false;
            _frm_compras.txt_pre_comp.Enabled = false;
            _frm_compras.txt_product.Enabled = false;
            _frm_compras.txt_tel_prove.Enabled = false;
            _frm_compras.txt_cat_prod.Enabled = false;
            _frm_compras.txt_nom_empl.Text = _cls_var_login._Nom_empl;
            _frm_compras.txt_carg_emp.Text = _cls_var_login._Carg;
        }
        private void _met_send_data() {
            _cls_vo_compras.Str_prove = _frm_compras.cmb_provee.SelectedValue.ToString();
        }
        private void _met_clean_data() {
            _frm_compras.txt_cant.Text = "";
            _frm_compras.txt_cat_prod.Text = "";
            _frm_compras.txt_cod_product.Text = "";
            _frm_compras.txt_desc_prod.Text = "";
            _frm_compras.txt_marc_prod.Text = "";
            _frm_compras.txt_pre_comp.Text = "";
            _frm_compras.txt_product.Text = "";
            _frm_compras.txt_tel_prove.Text = "";
            _frm_compras.txt_nom_contac.Text = "";
            _frm_compras.txt_direc_pro.Text = "";
            _frm_compras.lbl_sub_to.Text = "0.00";
            _frm_compras.lbl_t_product.Text = "0";
            _frm_compras.lbl_t_compra.Text = "0.00";
            _frm_compras.dgv_list_compra.Rows.Clear();
        }
        private void _met_event_click_cmb_pro(object sender, EventArgs e) {
            _met_send_data();
            _SqlDataRead = _cls_dav_comp._met_source_prove(_cls_vo_compras);
            while (_SqlDataRead.Read()) {
                _frm_compras.txt_direc_pro.Text = _SqlDataRead[2].ToString().ToUpper();
                _frm_compras.txt_nom_contac.Text = _SqlDataRead[3].ToString().ToUpper();
                _frm_compras.txt_tel_prove.Text = _SqlDataRead[5].ToString().ToUpper();
            }
        }
        private void _met_event_keypres_txt_cant(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                if(_frm_compras.txt_cod_product.Text !="" && _frm_compras.txt_cant.Text !=""){
                    _array[0] = _frm_compras.txt_cod_product.Text;
                    _array[1] = _frm_compras.txt_product.Text;
                    _array[2] = _frm_compras.txt_marc_prod.Text;
                    _array[3] = _frm_compras.txt_cat_prod.Text;
                    _array[4] = _frm_compras.txt_pre_comp.Text;
                    _array[5] = _frm_compras.txt_cant.Text;
                    _int_con = _frm_compras.dgv_list_compra.Rows.Add();
                    for (int x = 0; x < _array.Length; x++) {
                        _frm_compras.dgv_list_compra.Rows[_int_con].Cells[x].Value = _array[x];
                    }
                    _int_con++;
                    _int_cant_prod = _int_con;
                    _dc_total_compra += Convert.ToDecimal(Convert.ToDecimal(_array[4]) * Convert.ToDecimal(_array[5]));
                    _frm_compras.lbl_t_product.Text = _int_cant_prod.ToString();
                    _frm_compras.lbl_sub_to.Text = _dc_total_compra.ToString();
                    _frm_compras.lbl_t_compra.Text = _dc_total_compra.ToString();
                }else{
                    MessageBoxEx.Show("Error al agregar un producto. Verifique los datos","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }
        }
        private void _met_event_click_btn_insert_Compra(object sender, EventArgs e) {
            _int_clave_compra = Convert.ToInt32(_frm_compras.lbl_no_compra.Text);
            _cls_vo_compras.Int_id_compra = _int_clave_compra;
            _cls_vo_compras.Int_cant_product = Int32.Parse(_frm_compras.lbl_t_product.Text);
            _cls_vo_compras.Dc_total_compra = Convert.ToDecimal(_frm_compras.lbl_t_compra.Text);
            _cls_vo_compras.Str_prove = _frm_compras.cmb_provee.SelectedValue.ToString();
            _cls_dav_comp._met_insert_compra(_cls_vo_compras);
            if (_cls_dav_comp._Action != false) {
                for (int x = 0; x < _frm_compras.dgv_list_compra.RowCount -1; x++ ) {
                    _cls_vo_compras.Int_id_compra = _int_clave_compra;
                    _cls_vo_compras.Str_codigo_pro = _frm_compras.dgv_list_compra.Rows[x].Cells[0].Value.ToString();
                    _cls_vo_compras.Int_cant_uni = Convert.ToInt32(_frm_compras.dgv_list_compra.Rows[x].Cells[5].Value);
                    _cls_dav_comp._met_insert_compra_detalle(_cls_vo_compras);
                }
                _met_clean_data();
                _met_idincrement();
                MessageBoxEx.Show("La compra fue relizada con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }else{
                MessageBoxEx.Show("Error al realizar la compra", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        private void _met_event_click_btn_cancelar(object sender, EventArgs e) {
            _met_clean_data();
        }
        private void _met_event_click_btn_bus(object sender, EventArgs e) {
            View.Frm_lista_productos _frm_list = new View.Frm_lista_productos();
            Controller.cls_lista_productos _cls_con = new cls_lista_productos(_frm_list,_frm_compras);
            _frm_list.Show();
        }
    }
}
