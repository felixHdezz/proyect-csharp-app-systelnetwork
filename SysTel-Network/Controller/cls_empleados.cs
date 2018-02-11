using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Timers;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using SysTel_Network.Model;
using SysTel_Network.View;

namespace SysTel_Network.Controller
{
    class cls_empleados
    {
        private Frm_empleados _frm_empleados;
        private cls_dav_empleados _cls_dav_empl;
        private cls_vo_empleados _cls_vo_empl = Model.cls_vo_empleados._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_contAg;
        private cls_Iterador _cls_iterador;
        private DataTable _datatable;
        private SqlDataReader _sqldataread;
        private string _str_est_cli, _str_id;
        private string[] _str_data;
        public cls_empleados(View.Frm_empleados _f_empl) {
            _frm_empleados = _f_empl;
            _cls_dav_empl = Model.cls_dav_empleados._Instance;
            _met_event_click();
            _met_id();
        }
        private void _met_id() {
            _sqldataread = _cls_dav_empl._met_id();
            while (_sqldataread.Read()){
                _str_id = _sqldataread[0].ToString();
            }
            if (Convert.ToInt32(_str_id) < 10) {
                _str_id = "00" + _str_id;
            }else {
                _str_id = "0" + _str_id;
            }
        }
        private void _met_event_click() {
            _met_load_datagridview();
            _met_enable_texbox_button("inicio");
            _met_load_combo_box();
            _frm_empleados.btn_fote.Click += new EventHandler(_met_event_click_btn_fote);
            _frm_empleados.btn_nuevo.Click += new EventHandler(_met_event_click_new);
            _frm_empleados.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_empleados.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_empleados.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_empleados.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_empleados.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_empleados.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_empleados.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_empleados.dgv_empleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datagridview);
            _frm_empleados.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            //_frm_empleados.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_genr_rfc);
            _frm_empleados.txt_ap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_am.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_curp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_genr_rfc);
            _frm_empleados.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_number);
            _frm_empleados.txt_sex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_grad_esco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_est.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_ciud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_empleados.txt_pass.Leave += new EventHandler(_met_event_validapassword);
        }
        private void _met_event_click_btn_fote(object sender, EventArgs e) {
            View.Frm_capture_pintures _frm_capture = new View.Frm_capture_pintures();
            Controller.cls_capture_pintures _cont_cap = new cls_capture_pintures(_frm_capture);
            _frm_capture.Show();
        }
        private void _met_load_combo_box() {
            _datatable = _cls_dav_empl._met_load_cmb_cargos();
            _frm_empleados.cmb_pues.DataSource = _datatable;
            _frm_empleados.cmb_pues.DisplayMember = "vch_cargo";
            _frm_empleados.cmb_pues.ValueMember = "nch_clv_cargo";

            _datatable = _cls_dav_empl._met_load_cmb_depa();
            _frm_empleados.cmb_depa.DataSource = _datatable;
            _frm_empleados.cmb_depa.DisplayMember = "vch_departament";
            _frm_empleados.cmb_depa.ValueMember = "nch_clv_Depert";

            _datatable = _cls_dav_empl._met_load_cmb_socur();
            _frm_empleados.cmb_sucur.DataSource = _datatable;
            _frm_empleados.cmb_sucur.DisplayMember = "vch_sucursal";
            _frm_empleados.cmb_sucur.ValueMember = "nch_clv_sucur";
        }
        private void _met_load_datagridview() {
            _cls_contAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.empleados), "DataRemember1", 18);
            _cls_iterador = _cls_contAg.CreateIterador();
            _frm_empleados.dgv_empleados.DataSource = _cls_iterador._met_LoadData();
            _frm_empleados.dgv_empleados.DataMember = "DataRemember1";
            _frm_empleados.dgv_empleados.Columns[0].Width = 60;
            _met_update();
        }
        private void _met_update() {
            _frm_empleados.lbl_total_reg.Text = "Total registros: " + _cls_iterador._met_countRow();
            _frm_empleados.lbl_pag.Text = "Pagina: " + _cls_iterador._met_numPag()+"/"+_cls_iterador._met_lastpage();
        }
        private void _met_send_data() {
            _cls_vo_empl.Str_rfc = _frm_empleados.txt_rfc.Text;
            _cls_vo_empl.Str_nom = _frm_empleados.txt_nom.Text;
            _cls_vo_empl.Str_ap = _frm_empleados.txt_ap.Text;
            _cls_vo_empl.Str_am = _frm_empleados.txt_am.Text;
            _cls_vo_empl.Str_sexo = _frm_empleados.txt_sex.Text;
            _cls_vo_empl.Str_f_nac = _frm_empleados.txt_f_na.Text;
            _cls_vo_empl.Str_f_contra = System.DateTime.Now.Date.ToString();
            _cls_vo_empl.Str_grado_esco = _frm_empleados.txt_grad_esco.Text;
            _cls_vo_empl.Str_curp = _frm_empleados.txt_curp.Text;
            _cls_vo_empl.Str_tel = _frm_empleados.txt_tel.Text;
            _cls_vo_empl.Str_email = _frm_empleados.txt_email.Text;
            _cls_vo_empl.Str_direc = _frm_empleados.txt_direc.Text;
            _cls_vo_empl.Str_ciud = _frm_empleados.txt_ciud.Text;
            _cls_vo_empl.Str_est_re = _frm_empleados.txt_est.Text;
            _cls_vo_empl.Str_carg = _frm_empleados.cmb_pues.SelectedValue.ToString();
            _cls_vo_empl.Str_depa = _frm_empleados.cmb_depa.SelectedValue.ToString();
            _cls_vo_empl.Str_sucur = _frm_empleados.cmb_sucur.SelectedValue.ToString();
            _cls_vo_empl.Str_user = _frm_empleados.txt_user.Text;
            _cls_vo_empl.Str_pass = _frm_empleados.txt_pass.Text;
            if (_frm_empleados.cmb_est_cli.Text == "ACTIVO"){
                _str_est_cli = "act"; 
            }else {
                _str_est_cli = "inac";
            }
            _cls_vo_empl.Str_est_cli = _str_est_cli;
            _cls_vo_empl.Str_id = _str_id;
        }
        private void _met_clean_textbox() {
            _frm_empleados.txt_rfc.Text = "";
            _frm_empleados.txt_nom.Text = "";
            _frm_empleados.txt_ap.Text = "";
            _frm_empleados.txt_am.Text = "";
            _frm_empleados.txt_sex.Text = "";
            _frm_empleados.txt_f_na.Text = "";
            _frm_empleados.txt_grad_esco.Text = "";
            _frm_empleados.txt_curp.Text = "";
            _frm_empleados.txt_tel.Text = "";
            _frm_empleados.txt_email.Text = "";
            _frm_empleados.txt_direc.Text = "";
            _frm_empleados.txt_ciud.Text = "";
            _frm_empleados.txt_est.Text = "";
            _frm_empleados.txt_user.Text = "";
            _frm_empleados.txt_pass.Text = "";
        }
        private void _met_enable_texbox_button(string _str_act) {
            switch (_str_act) { 
                case "inicio":
                    _met_clean_textbox();
                    _frm_empleados.txt_rfc.Enabled = false;
                    _frm_empleados.txt_nom.Enabled = false;
                    _frm_empleados.txt_ap.Enabled = false;
                    _frm_empleados.txt_am.Enabled = false;
                    _frm_empleados.txt_sex.Enabled = false;
                    _frm_empleados.txt_f_na.Enabled = false;
                    _frm_empleados.txt_grad_esco.Enabled = false;
                    _frm_empleados.txt_curp.Enabled = false;
                    _frm_empleados.txt_tel.Enabled = false;
                    _frm_empleados.txt_email.Enabled = false;
                    _frm_empleados.txt_direc.Enabled = false;
                    _frm_empleados.txt_ciud.Enabled = false;
                    _frm_empleados.txt_est.Enabled = false;
                    _frm_empleados.txt_user.Enabled = false;
                    _frm_empleados.txt_pass.Enabled = false;
                    _frm_empleados.btn_nuevo.Enabled = true;
                    _frm_empleados.btn_nuevo.Text = "Nuevo";
                    _frm_empleados.btn_insert.Enabled = false;
                    _frm_empleados.btn_update.Enabled = false;
                    _frm_empleados.btn_delete.Enabled = false;
                    break;
                case "nuevo":
                    _frm_empleados.txt_rfc.Enabled = false;
                    _frm_empleados.txt_nom.Enabled = true;
                    _frm_empleados.txt_ap.Enabled = true;
                    _frm_empleados.txt_am.Enabled = true;
                    _frm_empleados.txt_sex.Enabled = true;
                    _frm_empleados.txt_f_na.Enabled = true;
                    _frm_empleados.txt_grad_esco.Enabled = true;
                    _frm_empleados.txt_curp.Enabled = true;
                    _frm_empleados.txt_tel.Enabled = true;
                    _frm_empleados.txt_email.Enabled = true;
                    _frm_empleados.txt_direc.Enabled = true;
                    _frm_empleados.txt_ciud.Enabled = true;
                    _frm_empleados.txt_est.Enabled = true;
                    _frm_empleados.txt_user.Enabled = true;
                    _frm_empleados.txt_pass.Enabled = true;
                    _frm_empleados.btn_nuevo.Enabled = true;
                    _frm_empleados.btn_nuevo.Text = "Cancelar";
                    _frm_empleados.btn_insert.Enabled = true;
                    _frm_empleados.btn_update.Enabled = false;
                    _frm_empleados.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_empleados.txt_rfc.Enabled = false;
                    _frm_empleados.txt_nom.Enabled = true;
                    _frm_empleados.txt_ap.Enabled = true;
                    _frm_empleados.txt_am.Enabled = true;
                    _frm_empleados.txt_sex.Enabled = true;
                    _frm_empleados.txt_f_na.Enabled = true;
                    _frm_empleados.txt_grad_esco.Enabled = true;
                    _frm_empleados.txt_curp.Enabled = true;
                    _frm_empleados.txt_tel.Enabled = true;
                    _frm_empleados.txt_email.Enabled = true;
                    _frm_empleados.txt_direc.Enabled = true;
                    _frm_empleados.txt_ciud.Enabled = true;
                    _frm_empleados.txt_est.Enabled = true;
                    _frm_empleados.txt_user.Enabled = true;
                    _frm_empleados.txt_pass.Enabled = true;
                    _frm_empleados.btn_nuevo.Enabled = true;
                    _frm_empleados.btn_nuevo.Text = "Cancelar";
                    _frm_empleados.btn_insert.Enabled = false;
                    _frm_empleados.btn_update.Enabled = true;
                    _frm_empleados.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_load_data() {
            _met_clean_textbox();
            _met_load_datagridview();
            _met_enable_texbox_button("inicio");
            _met_id();
        }
        private void _met_update_data() {
            _met_clean_textbox();
            _met_load_datagridview();
            _met_enable_texbox_button("inicio");
        }
        private void _met_event_click_new(object sender, EventArgs e) { 
            if(_frm_empleados.btn_nuevo.Text == "Nuevo"){
                _met_enable_texbox_button("nuevo");
            }else{
                _met_enable_texbox_button("inicio");
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            if(_frm_empleados.txt_rfc.Text != "" && _frm_empleados.txt_nom.Text != null && _frm_empleados.txt_ap.Text != null && _frm_empleados.txt_am.Text != null && _frm_empleados.txt_ciud.Text != "" && _frm_empleados.txt_curp.Text != "" &&_frm_empleados.txt_direc.Text != "" && _frm_empleados.txt_email.Text != "" && _frm_empleados.txt_est.Text != "" && _frm_empleados.txt_f_na.Text != "" && _frm_empleados.txt_grad_esco.Text !="" && _frm_empleados.txt_pass.Text != "" && _frm_empleados.txt_user.Text != ""){
                _met_send_data();
                if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.empleados,_cls_vo_empl)) {
                    MessageBoxEx.Show("El registro se ha guardado con exito","Mensaje desd el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                    _met_load_data();
                } 
            }
        }
        private void _met_event_click_update(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.empleados,_cls_vo_empl)) {
                MessageBoxEx.Show("El registro se ha actualizado con exito", "Mensaje desd el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                _met_load_data();
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.empleados,_cls_vo_empl)) {
                MessageBoxEx.Show("El registro se ha eliminado con exito", "Mensaje desd el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                _met_load_data();
            }
        }
        private void _met_event_click_btn_first(object sender, EventArgs e){
            _cls_iterador._met_FirstPage();
            _met_update();
        }
        private void _met_event_click_btn_ant(object sender, EventArgs e){
            _cls_iterador._met_PreviousPage();
            _met_update();
        }
        private void _met_event_click_btn_next(object sender, EventArgs e){
            _cls_iterador._met_NextPage();
            _met_update();
        }
        private void _met_event_click_btn_last(object sender, EventArgs e){
            _cls_iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_click_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_empleados.dgv_empleados.CurrentRow.Cells[0].Value) != "") {
                _frm_empleados.txt_rfc.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[1].Value.ToString();
                _str_data = _frm_empleados.dgv_empleados.CurrentRow.Cells[2].Value.ToString().Split(' ');
                _frm_empleados.txt_nom.Text = _str_data[0];
                _frm_empleados.txt_ap.Text = _str_data[1];
                _frm_empleados.txt_am.Text = _str_data[2];
                _frm_empleados.txt_sex.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[3].Value.ToString();
                _frm_empleados.txt_f_na.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[4].Value.ToString();
                _frm_empleados.txt_grad_esco.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[6].Value.ToString();
                _frm_empleados.txt_curp.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[7].Value.ToString();
                _frm_empleados.txt_tel.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[8].Value.ToString();
                _frm_empleados.txt_email.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[9].Value.ToString();
                _frm_empleados.txt_direc.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[10].Value.ToString();
                _frm_empleados.txt_ciud.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[12].Value.ToString();
                _frm_empleados.txt_est.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[11].Value.ToString();
                _frm_empleados.cmb_pues.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[13].Value.ToString();
                _frm_empleados.cmb_depa.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[14].Value.ToString();
                _frm_empleados.cmb_sucur.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[15].Value.ToString();
                _frm_empleados.txt_user.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[17].Value.ToString();
                _frm_empleados.txt_pass.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[18].Value.ToString();
                _frm_empleados.cmb_est_cli.Text = _frm_empleados.dgv_empleados.CurrentRow.Cells[19].Value.ToString();
                _met_enable_texbox_button("click_cell");
            }
        }
        private void _met_event_keypres_genr_rfc(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _frm_empleados.txt_rfc.Text = _frm_empleados.txt_curp.Text.Substring(0,10);
                _frm_empleados.txt_tel.Focus();
            }
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
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
        private void _met_event_validapassword(object sender, EventArgs e) {
            if (_frm_empleados.txt_pass.TextLength >= 8){

            }else {
                MessageBoxEx.Show("Por favor ! verifique la contraseña \n la contraseña debe ser de 8 o mas dijitos","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                _frm_empleados.txt_pass.Text = "";
                _frm_empleados.txt_pass.Focus();
            }
        }
    }
}
