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
    class cls_sucursales
    {
        private Frm_sucursales _frm_sucur;
        private cls_vo_sucursales _cls_vo_sucu = Model.cls_vo_sucursales._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_contAg;
        private cls_Iterador _cls_iterador;
        public cls_sucursales(View.Frm_sucursales _f_sucu) {
            _frm_sucur = _f_sucu;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_datagridview();
            _met_enable_button_and_textbox("inicio");
            _frm_sucur.btn_nuevo.Click += new EventHandler(_met_event_click_new);
            _frm_sucur.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_sucur.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_sucur.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_sucur.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_sucur.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_sucur.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_sucur.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_sucur.dgv_sucur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datgridview);
            _frm_sucur.txt_nom_sucu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_sucur.txt_nom_sucu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_nom);
            _frm_sucur.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_number);
            _frm_sucur.cmb_est_sucu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_cmb);
        }
        private void _met_load_datagridview() {
            _cls_contAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.sucursales), "DataRemember1", 8);
            _cls_iterador = _cls_contAg.CreateIterador();
            _frm_sucur.dgv_sucur.DataSource = _cls_iterador._met_LoadData();
            _frm_sucur.dgv_sucur.DataMember = "DataRemember1";
            _frm_sucur.dgv_sucur.Columns.Add("Column6", "");
            _frm_sucur.dgv_sucur.Columns[0].Width = 60;
            _frm_sucur.dgv_sucur.Columns[1].Width = 190;
            _frm_sucur.dgv_sucur.Columns[2].Width = 235;
            _met_update();
        }
        private void _met_update() {
            _frm_sucur.lbl_total_reg.Text = "Total registros: "+_cls_iterador._met_countRow();
            _frm_sucur.lbl_pag.Text = "Pagina: " + _cls_iterador._met_numPag() + "/" + _cls_iterador._met_lastpage();
        }
        private void _met_event_click_datgridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            _frm_sucur.txt_clv.Text = _frm_sucur.dgv_sucur.CurrentRow.Cells[0].Value.ToString();
            _frm_sucur.txt_nom_sucu.Text = _frm_sucur.dgv_sucur.CurrentRow.Cells[1].Value.ToString();
            _frm_sucur.txt_direc.Text = _frm_sucur.dgv_sucur.CurrentRow.Cells[2].Value.ToString();
            _frm_sucur.txt_tel.Text = _frm_sucur.dgv_sucur.CurrentRow.Cells[3].Value.ToString();
            _frm_sucur.cmb_est_sucu.Text = _frm_sucur.dgv_sucur.CurrentRow.Cells[4].Value.ToString();
            _met_enable_button_and_textbox("click_cell");
        }
        private void _met_send_data() {
            _cls_vo_sucu.Str_clv = _frm_sucur.txt_clv.Text;
            _cls_vo_sucu.Str_sucur = _frm_sucur.txt_nom_sucu.Text;
            _cls_vo_sucu.Str_direc = _frm_sucur.txt_direc.Text;
            _cls_vo_sucu.Str_tel = _frm_sucur.txt_tel.Text;
            if (_frm_sucur.cmb_est_sucu.Text == "ACTIVO"){
                _cls_vo_sucu.Str_est_sucu = "act";
            }else {
                _cls_vo_sucu.Str_est_sucu = "inac";
            }
        }
        private void _met_clean_textbox() {
            _frm_sucur.txt_clv.Text = "";
            _frm_sucur.txt_nom_sucu.Text = "";
            _frm_sucur.txt_direc.Text = "";
            _frm_sucur.txt_tel.Text = "";
        }
        private void _met_enable_button_and_textbox(string _str_act) {
            switch (_str_act) { 
                case "inicio":
                    _frm_sucur.txt_clv.Enabled = false;
                    _frm_sucur.txt_nom_sucu.Enabled = false;
                    _frm_sucur.txt_direc.Enabled = false;
                    _frm_sucur.txt_tel.Enabled = false;
                    _frm_sucur.btn_nuevo.Text = "Nuevo";
                    _frm_sucur.btn_insert.Enabled = false;
                    _frm_sucur.btn_update.Enabled = false;
                    _frm_sucur.btn_delete.Enabled = false;
                    _frm_sucur.cmb_est_sucu.Enabled = false;
                    break;
                case "nuevo":
                    _frm_sucur.txt_clv.Enabled = false;
                    _frm_sucur.txt_nom_sucu.Enabled = true;
                    _frm_sucur.txt_direc.Enabled = true;
                    _frm_sucur.txt_tel.Enabled = true;
                    _frm_sucur.btn_nuevo.Text = "Cancelar";
                    _frm_sucur.btn_insert.Enabled = true;
                    _frm_sucur.btn_update.Enabled = false;
                    _frm_sucur.btn_delete.Enabled = false;
                    _frm_sucur.cmb_est_sucu.Enabled = true;
                    break;
                case "click_cell":
                    _frm_sucur.txt_clv.Enabled = false;
                    _frm_sucur.txt_nom_sucu.Enabled = true;
                    _frm_sucur.txt_direc.Enabled = true;
                    _frm_sucur.txt_tel.Enabled = true;
                    _frm_sucur.btn_nuevo.Text = "Cancelar";
                    _frm_sucur.btn_insert.Enabled = false;
                    _frm_sucur.btn_update.Enabled = true;
                    _frm_sucur.btn_delete.Enabled = true;
                    _frm_sucur.cmb_est_sucu.Enabled = true;
                    break;
            }
        }
        private void _met_update_data() {
            _met_clean_textbox();
            _met_load_datagridview();
            _met_enable_button_and_textbox("inicio");
        }
        private void _met_event_click_new(object sender, EventArgs e) { 
            if(_frm_sucur.btn_nuevo.Text == "Nuevo"){
                _met_enable_button_and_textbox("nuevo");
                _met_clean_textbox();
            }else{
                _met_enable_button_and_textbox("inicio");
                _met_clean_textbox();
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.sucursales,_cls_vo_sucu)) {
                _met_update_data();
                MessageBoxEx.Show("Registro se ha guardado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_update(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.sucursales,_cls_vo_sucu)){
                _met_update_data();
                MessageBoxEx.Show("Registro se ha actualizado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.sucursales,_cls_vo_sucu)){
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
        private void _met_event_click_btn_last(object sender, EventArgs e) {
            _cls_iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_keypres_nom(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _frm_sucur.txt_clv.Text = _frm_sucur.txt_nom_sucu.Text.Substring(0, 3);
                _frm_sucur.txt_direc.Focus();
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
        private void _met_event_keypres_cmb(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}
