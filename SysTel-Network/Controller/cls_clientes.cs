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
    class cls_clientes
    {
        private View.Frm_clientes _frm_client;
        private Model.cls_vo_clientes _vo_cliet = Model.cls_vo_clientes._Instance;
        private Model.cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private Model.cls_ConcreteAggregate _add;
        private Model.cls_Iterador _iterador;
        private string _str_estado_cli;
        private string[] _str_array;
        public cls_clientes(View.Frm_clientes _f_cli) {
            _frm_client = _f_cli;
            _met_evet_click();
        }
        private void _met_evet_click() {
            _met_load_DataGridView();
            _met_enable_button("inicio");
            _frm_client.btn_nuevo.Click += new EventHandler(_met_event_click_new);
            _frm_client.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_client.btn_update.Click += new EventHandler(_met_event_clik_update);
            _frm_client.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_client.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_client.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_client.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_client.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_client.dg_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datagridview);
            _frm_client.txt_clv_cli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_number);
            _frm_client.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_number);
            _frm_client.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_client.txt_ap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_client.txt_am.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_client.txt_ciud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_client.txt_est_re.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_client.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_key_validation_email);
            _frm_client.cb_est_cli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_cmb);
        }
        private void _met_send_data() {
            if (_frm_client.cb_est_cli.Text == "Activo") {
                _str_estado_cli = "act";
            }else{
                _str_estado_cli = "inac";
            }
            _vo_cliet.Str_clv_cli = _frm_client.txt_clv_cli.Text;
            _vo_cliet.Str_nom = _frm_client.txt_nom.Text;
            _vo_cliet.Str_ap = _frm_client.txt_ap.Text;
            _vo_cliet.Str_am = _frm_client.txt_am.Text;
            _vo_cliet.Str_tel = _frm_client.txt_tel.Text;
            _vo_cliet.Str_email = _frm_client.txt_email.Text;
            _vo_cliet.Str_direc = _frm_client.txt_direc.Text;
            _vo_cliet.Str_ciud = _frm_client.txt_ciud.Text;
            _vo_cliet.Str_est = _frm_client.txt_est_re.Text;
            _vo_cliet.Str_est_clien = _str_estado_cli;
        }
        private void _met_clear_textbox() {
            _frm_client.txt_clv_cli.Text = "";
            _frm_client.txt_nom.Text = "";
            _frm_client.txt_ap.Text = "";
            _frm_client.txt_am.Text = "";
            _frm_client.txt_tel.Text = "";
            _frm_client.txt_email.Text = "";
            _frm_client.txt_direc.Text = "";
            _frm_client.txt_ciud.Text = "";
            _frm_client.txt_est_re.Text = "";
        }
        private void _met_enable_button(string _str_action) {
            switch (_str_action) { 
                case "inicio":
                    _frm_client.txt_clv_cli.Enabled = false;
                    _frm_client.txt_nom.Enabled = false;
                    _frm_client.txt_ap.Enabled = false;
                    _frm_client.txt_am.Enabled = false;
                    _frm_client.txt_direc.Enabled = false;
                    _frm_client.txt_tel.Enabled = false;
                    _frm_client.txt_email.Enabled = false;
                    _frm_client.txt_est_re.Enabled = false;
                    _frm_client.txt_ciud.Enabled = false;
                    _frm_client.cb_est_cli.Enabled = false;
                    _frm_client.btn_insert.Enabled = false;
                    _frm_client.btn_update.Enabled = false;
                    _frm_client.btn_delete.Enabled = false;
                    _frm_client.btn_nuevo.Text = "Nuevo";
                    break;
                case "nuevo":
                    _frm_client.txt_clv_cli.Enabled = true;
                    _frm_client.txt_clv_cli.Focus();
                    _frm_client.txt_nom.Enabled = true;
                    _frm_client.txt_ap.Enabled = true;
                    _frm_client.txt_am.Enabled = true;
                    _frm_client.txt_direc.Enabled = true;
                    _frm_client.txt_tel.Enabled = true;
                    _frm_client.txt_email.Enabled = true;
                    _frm_client.txt_est_re.Enabled = true;
                    _frm_client.txt_ciud.Enabled = true;
                    _frm_client.btn_nuevo.Text = "Cancelar";
                    _frm_client.cb_est_cli.Enabled = true;
                    _frm_client.btn_insert.Enabled = true;
                    _frm_client.btn_update.Enabled = false;
                    _frm_client.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_client.txt_clv_cli.Enabled = false;
                    _frm_client.txt_nom.Enabled = true;
                    _frm_client.txt_ap.Enabled = true;
                    _frm_client.txt_am.Enabled = true;
                    _frm_client.txt_direc.Enabled = true;
                    _frm_client.txt_tel.Enabled = true;
                    _frm_client.txt_email.Enabled = true;
                    _frm_client.txt_est_re.Enabled = true;
                    _frm_client.txt_ciud.Enabled = true;
                    _frm_client.btn_nuevo.Text = "Cancelar";
                    _frm_client.cb_est_cli.Enabled = true;
                    _frm_client.btn_insert.Enabled = false;
                    _frm_client.btn_update.Enabled = true;
                    _frm_client.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_load_data() { 
            _met_load_DataGridView();
            _met_clear_textbox();
            _met_enable_button("Nuevo");
        }
        private void _met_load_DataGridView() {
            _add = new Model.cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(Model.cls_FactoryMethod._TipoRegistro.clientes), "DataRemember1", 12);
            _iterador = _add.CreateIterador();
            _frm_client.dg_clientes.DataSource = _iterador._met_LoadData();
            _frm_client.dg_clientes.DataMember = "DataRemember1";
            _frm_client.dg_clientes.Columns[0].Width = 50;
            _frm_client.dg_clientes.Columns[1].Width = 280;
            _frm_client.dg_clientes.Columns[2].Width = 190;
            _frm_client.dg_clientes.Columns[4].Width = 190;
            _frm_client.dg_clientes.Columns[7].Width = 150;
            _met_update();
        }
        private void _met_update() {
            _frm_client.lbl_total_reg.Text = "Total registros: " + _iterador._met_countRow();
            _frm_client.lbl_pag.Text = "Pagina: " + _iterador._met_numPag() + "/" + _iterador._met_lastpage();
        }
        private void _met_event_click_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToInt32(_frm_client.dg_clientes.CurrentRow.Cells[0].Value) > 0) {
                _frm_client.txt_clv_cli.Text = _frm_client.dg_clientes.CurrentRow.Cells[0].Value.ToString();
                _str_array = _frm_client.dg_clientes.CurrentRow.Cells[1].Value.ToString().Split(' ');
                _frm_client.txt_nom.Text = _str_array[0];
                _frm_client.txt_ap.Text = _str_array[1];
                _frm_client.txt_am.Text = _str_array[2];
                _frm_client.txt_tel.Text = _frm_client.dg_clientes.CurrentRow.Cells[3].Value.ToString();
                _frm_client.txt_email.Text = _frm_client.dg_clientes.CurrentRow.Cells[4].Value.ToString();
                _frm_client.txt_direc.Text = _frm_client.dg_clientes.CurrentRow.Cells[2].Value.ToString();
                _frm_client.txt_ciud.Text = _frm_client.dg_clientes.CurrentRow.Cells[5].Value.ToString();
                _frm_client.txt_est_re.Text = _frm_client.dg_clientes.CurrentRow.Cells[6].Value.ToString();
                _frm_client.cb_est_cli.Text = _frm_client.dg_clientes.CurrentRow.Cells[7].Value.ToString();
                _met_enable_button("click_cell");
            }else{
                MessageBoxEx.Show("Por favor seleccione un registro","Mensaje desd el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        private void _met_event_click_new(object sender, EventArgs e) { 
            if(_frm_client.btn_nuevo.Text == "Nuevo"){
                _met_enable_button("nuevo");
                _met_clear_textbox();
            }else{
                _met_enable_button("inicio");
                _met_clear_textbox();
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.clientes,_vo_cliet)) {
                MessageBoxEx.Show("El registro se ha guardado con exito","Mesaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                _met_load_data();
            }
        }
        private void _met_event_clik_update(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.clientes,_vo_cliet)) {
                MessageBoxEx.Show("El registro se ha modificado con exito", "Mesaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                _met_load_data();
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.clientes,_vo_cliet)) {
                MessageBoxEx.Show("El registro se ha eliminado con exito", "Mesaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                _met_load_data();
            }
        }
        private void _met_event_click_btn_first(object sender, EventArgs e) {
            _iterador._met_FirstPage();
            _met_update();
        }
        private void _met_event_click_btn_ant(object sedner, EventArgs e) {
            _iterador._met_PreviousPage();
            _met_update();
        }
        private void _met_event_click_btn_next(object sender, EventArgs e) {
            _iterador._met_NextPage();
            _met_update();
        }
        private void _met_event_click_btn_last(object sedner, EventArgs e) {
            _iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else {
                e.Handled = true;
            }
        }
        private void _met_event_keypres_validation_number(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void _met_event_key_validation_email(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (_frm_client.txt_email.Text.Contains('@') == true){
                if (e.KeyChar == '@'){
                    e.Handled = true;
                }
            }
            if (_frm_client.txt_email.Text.Contains('.') == true){
                if (e.KeyChar == '.'){
                    e.Handled = true;
                }
            }
        }
        private void _met_event_keypres_cmb(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}
