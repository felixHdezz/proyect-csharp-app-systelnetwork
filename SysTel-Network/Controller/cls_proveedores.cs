using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using SysTel_Network.View;
using SysTel_Network.Model;

namespace SysTel_Network.Controller
{
    class cls_proveedores
    {
        private Frm_proveedores _frm_prove;
        private cls_vo_proveedores _vo_prove = Model.cls_vo_proveedores._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_concAg;
        private cls_Iterador _cls_iterador;
        private string _str_est;
        public cls_proveedores(View.Frm_proveedores _prove) {
            _frm_prove = _prove;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_gridview();
            _met_enable_buttons("inicio");
            _frm_prove.buttonX1.Click += new EventHandler(_met_event_click_new);
            _frm_prove.btn_insert.Click += new EventHandler(_met_event_clik_insert);
            _frm_prove.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_prove.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_prove.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_prove.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_prove.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_prove.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_prove.txt_nom_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_nom_pro);
            _frm_prove.dg_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datagridview);
            _frm_prove.txt_nom_pro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_letter);
            _frm_prove.txt_nom_contac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_letter);
            _frm_prove.txt_carg_contac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_letter);
            _frm_prove.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_number);
            _frm_prove.txt_fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_number);
            _frm_prove.cb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_key_combo);
        }
        private void _met_send_data() {
            if (_frm_prove.cb_estado.Text == "Activo"){
                _str_est = "act";
            }else{
                _str_est = "inac";
            }
            _vo_prove.Str_clv_pro = _frm_prove.txt_clv_prove.Text;
            _vo_prove.Str_nom_pro = _frm_prove.txt_nom_pro.Text;
            _vo_prove.Str_direc = _frm_prove.txt_direc.Text;
            _vo_prove.Str_nom_contac = _frm_prove.txt_nom_contac.Text;
            _vo_prove.Str_carg_contac = _frm_prove.txt_carg_contac.Text;
            _vo_prove.Str_tel = _frm_prove.txt_tel.Text;
            _vo_prove.Str_fax = _frm_prove.txt_fax.Text;
            _vo_prove.Str_estado = _str_est;
        }
        private void _met_clear_text_box() {
            _frm_prove.txt_clv_prove.Text = "";
            _frm_prove.txt_nom_pro.Text = "";
            _frm_prove.txt_direc.Text = "";
            _frm_prove.txt_nom_contac.Text = "";
            _frm_prove.txt_carg_contac.Text = "";
            _frm_prove.txt_tel.Text = "";
            _frm_prove.txt_fax.Text = "";
        }
        private void _met_enable_buttons(string _str_est) {
            switch (_str_est) { 
                case "inicio":
                    _frm_prove.txt_clv_prove.Enabled = false;
                    _frm_prove.txt_nom_pro.Enabled = false;
                    _frm_prove.txt_direc.Enabled = false;
                    _frm_prove.txt_nom_contac.Enabled = false;
                    _frm_prove.txt_tel.Enabled = false;
                    _frm_prove.txt_fax.Enabled = false;
                    _frm_prove.cb_estado.Enabled = false;
                    _frm_prove.buttonX1.Enabled = true;
                    _frm_prove.btn_insert.Enabled = false;
                    _frm_prove.btn_update.Enabled = false;
                    _frm_prove.btn_delete.Enabled = false;
                    break;
                case "nuevo":
                    _frm_prove.txt_clv_prove.Enabled = false;
                    _frm_prove.txt_nom_pro.Enabled = true;
                    _frm_prove.txt_direc.Enabled = true;
                    _frm_prove.txt_nom_contac.Enabled = true;
                    _frm_prove.txt_tel.Enabled = true;
                    _frm_prove.txt_fax.Enabled = true;
                    _frm_prove.buttonX1.Text = "Cancelar";
                    _frm_prove.cb_estado.Enabled = true;
                    _frm_prove.buttonX1.Enabled = true;
                    _frm_prove.btn_insert.Enabled = true;
                    _frm_prove.btn_update.Enabled = false;
                    _frm_prove.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_prove.txt_clv_prove.Enabled = false;
                    _frm_prove.txt_nom_pro.Enabled = true;
                    _frm_prove.txt_direc.Enabled = true;
                    _frm_prove.txt_nom_contac.Enabled = true;
                    _frm_prove.txt_tel.Enabled = true;
                    _frm_prove.txt_fax.Enabled = true;
                    _frm_prove.buttonX1.Text = "Cancelar";
                    _frm_prove.cb_estado.Enabled = true;
                    _frm_prove.buttonX1.Enabled = true;
                    _frm_prove.btn_insert.Enabled = false;
                    _frm_prove.btn_update.Enabled = true;
                    _frm_prove.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_update_data() {
            _met_clear_text_box();
            _met_load_gridview();
        }
        private void _met_load_gridview() {
            _cls_concAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.proveedores), "DataRemember1",9);
            _cls_iterador = _cls_concAg.CreateIterador();
            _frm_prove.dg_proveedores.DataSource = _cls_iterador._met_LoadData();
            _frm_prove.dg_proveedores.DataMember = "DataRemember1";
            _frm_prove.dg_proveedores.Columns[0].Width = 60;
            _frm_prove.dg_proveedores.Columns[1].Width = 150;
            _frm_prove.dg_proveedores.Columns[2].Width = 150;
            _frm_prove.dg_proveedores.Columns[3].Width = 150;
            _frm_prove.dg_proveedores.Columns[4].Width = 200;
            _met_update();
        }
        private void _met_update() {
            _frm_prove.lbl_total_reg.Text = "Total registros: " + _cls_iterador._met_countRow();
            _frm_prove.lbl_pag.Text = "Paginas: " + _cls_iterador._met_numPag() + "/" + _cls_iterador._met_lastpage();
        }
        private void _met_event_click_new(object sender, EventArgs e) {
            if (_frm_prove.buttonX1.Text == "Nuevo"){
                _met_enable_buttons("nuevo");
            }else {
                _met_enable_buttons("nuevo");
                _frm_prove.btn_insert.Enabled = false;
                _frm_prove.buttonX1.Text = "Nuevo";
                _met_clear_text_box();
            }
        }
        private void _met_event_clik_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.proveedores,_vo_prove)) {
                _met_update_data();
                MessageBoxEx.Show("Registro se ha guardado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_update(object sender, EventArgs e) {
            _met_send_data();
            if(_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.proveedores,_vo_prove)){
                _met_update_data();
                MessageBoxEx.Show("Registro se ha modificado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.proveedores,_vo_prove)) {
                _met_update_data();
                MessageBoxEx.Show("Registro se ha eliminado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_first(object sender, EventArgs e) {
            _cls_iterador._met_FirstPage();
            _met_update();
        }
        private void _met_event_click_btn_ant(object sender, EventArgs e) {
            _cls_iterador._met_PreviousPage();
            _met_update();
        }
        private void _met_event_click_btn_next(object sender, EventArgs e) {
            _cls_iterador._met_NextPage();
            _met_update();
        }
        private void _met_event_click_btn_last(object sedner, EventArgs e) {
            _cls_iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_click_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_prove.dg_proveedores.CurrentRow.Cells[0].Value) != "") {
                _frm_prove.txt_clv_prove.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[0].Value.ToString();
                _frm_prove.txt_nom_pro.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[1].Value.ToString();
                _frm_prove.txt_direc.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[2].Value.ToString();
                _frm_prove.txt_nom_contac.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[3].Value.ToString();
                _frm_prove.txt_carg_contac.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[4].Value.ToString();
                _frm_prove.txt_tel.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[5].Value.ToString();
                _frm_prove.txt_fax.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[6].Value.ToString();
                _frm_prove.cb_estado.Text = _frm_prove.dg_proveedores.CurrentRow.Cells[7].Value.ToString();
                _met_enable_buttons("click_cell");
            }
        }
        private void _met_event_keypress_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void _met_event_keypress_validation_number(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void _met_event_keypress_nom_pro(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                _frm_prove.txt_clv_prove.Text = _frm_prove.txt_nom_pro.Text.Substring(0, 3);
                _frm_prove.txt_direc.Focus();
            }
        }
        private void _met_event_key_combo(object sender, System.Windows.Forms.KeyPressEventArgs e){
            e.Handled = true;
        }

    }
}
