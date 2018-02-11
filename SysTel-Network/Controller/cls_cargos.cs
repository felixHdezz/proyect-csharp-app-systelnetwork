using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using SysTel_Network.Model;
using SysTel_Network.View;

namespace SysTel_Network.Controller
{
    class cls_cargos
    {
        private Frm_cargos _frm_carg;
        private cls_vo_cargos _cls_vo_carg = Model.cls_vo_cargos._Instance;
        private cls_FactoryMethod _factoryMethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _contAg;
        private cls_Iterador _iterador;
        public cls_cargos(View.Frm_cargos _f_carg) {
            _frm_carg = _f_carg;
            _met_event();
        }
        private void _met_event() {
            _met_load_datagridview();
            _met_enable_texbox_button("inicio");
            _frm_carg.dgv_puestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_cell_datagridview);
            _frm_carg.btn_new.Click += new EventHandler(_met_event_click_new);
            _frm_carg.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_carg.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_carg.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_carg.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_carg.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_carg.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_carg.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_carg.txt_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_carg.txt_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypree_ger_clv);
            _frm_carg.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_carg.txt_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypress_validation_number);
        }
        private void _met_load_datagridview() {
            _contAg = new cls_ConcreteAggregate(_factoryMethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.puesto), "DataRemember1",7);
            _iterador = _contAg.CreateIterador();
            _frm_carg.dgv_puestos.DataSource = _iterador._met_LoadData();
            _frm_carg.dgv_puestos.DataMember = "DataRemember1";
            _frm_carg.dgv_puestos.Columns[0].Width = 60;
            _frm_carg.dgv_puestos.Columns[1].Width = 190;
            _frm_carg.dgv_puestos.Columns[2].Width = 280;
            _met_update();
        }
        private void _met_update() {
            _frm_carg.lbl_total_reg.Text = "Total registros: "+_iterador._met_countRow();
            _frm_carg.lbl_pag.Text = "Pagina: " + _iterador._met_numPag() + "/" + _iterador._met_lastpage();
        }
        private void _met_event_click_cell_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_carg.dgv_puestos.CurrentRow.Cells[0].Value) != "") {
                _frm_carg.txt_clave.Text = _frm_carg.dgv_puestos.CurrentRow.Cells[0].Value.ToString();
                _frm_carg.txt_puesto.Text = _frm_carg.dgv_puestos.CurrentRow.Cells[1].Value.ToString();
                _frm_carg.txt_descrip.Text = _frm_carg.dgv_puestos.CurrentRow.Cells[2].Value.ToString();
                _frm_carg.txt_salario.Text = _frm_carg.dgv_puestos.CurrentRow.Cells[3].Value.ToString();
                _frm_carg.cmb_esta.Text = _frm_carg.dgv_puestos.CurrentRow.Cells[4].Value.ToString();
                _met_enable_texbox_button("click_cell");
            }
        }
        private void _met_clean_textbox() {
            _frm_carg.txt_clave.Text = "";
            _frm_carg.txt_puesto.Text = "";
            _frm_carg.txt_descrip.Text = "";
            _frm_carg.txt_salario.Text = "";
        }
        private void _met_enable_texbox_button(string _str_act) {
            switch (_str_act) { 
                case "inicio":
                    _frm_carg.txt_clave.Enabled = false;
                    _frm_carg.txt_puesto.Enabled = false;
                    _frm_carg.txt_descrip.Enabled = false;
                    _frm_carg.txt_salario.Enabled = false;
                    _frm_carg.cmb_esta.Enabled = false;
                    _frm_carg.btn_new.Enabled = true;
                    _frm_carg.btn_new.Text = "Nuevo";
                    _frm_carg.btn_insert.Enabled = false;
                    _frm_carg.btn_update.Enabled = false;
                    _frm_carg.btn_delete.Enabled = false;
                    break;
                case "nuevo":
                    _frm_carg.txt_clave.Enabled = false;
                    _frm_carg.txt_puesto.Enabled = true;
                    _frm_carg.txt_descrip.Enabled = true;
                    _frm_carg.txt_salario.Enabled = true;
                    _frm_carg.cmb_esta.Enabled = true;
                    _frm_carg.btn_new.Enabled = true;
                    _frm_carg.btn_new.Text = "Cancelar";
                    _frm_carg.btn_insert.Enabled = true;
                    _frm_carg.btn_update.Enabled = false;
                    _frm_carg.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_carg.txt_clave.Enabled = false;
                    _frm_carg.txt_puesto.Enabled = true;
                    _frm_carg.txt_descrip.Enabled = true;
                    _frm_carg.txt_salario.Enabled = true;
                    _frm_carg.cmb_esta.Enabled = true;
                    _frm_carg.btn_new.Enabled = true;
                    _frm_carg.btn_new.Text = "Cancelar";
                    _frm_carg.btn_insert.Enabled = false;
                    _frm_carg.btn_update.Enabled = true;
                    _frm_carg.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_send_data() {
            _cls_vo_carg.Str_clv = _frm_carg.txt_clave.Text;
            _cls_vo_carg.Str_car = _frm_carg.txt_puesto.Text;
            _cls_vo_carg.Str_des = _frm_carg.txt_descrip.Text;
            _cls_vo_carg.Str_sal = _frm_carg.txt_salario.Text;
            if(_frm_carg.cmb_esta.Text == "Activo"){
                _cls_vo_carg.Str_est = "act";
            }else{
                _cls_vo_carg.Str_est = "inac";
            }
        }
        private void _met_update_data() {
            _met_clean_textbox();
            _met_load_datagridview();
            _met_enable_texbox_button("inicio");
        }
        private void _met_event_click_new(object sneder, EventArgs e) { 
            if(_frm_carg.btn_new.Text == "Nuevo"){
                _met_enable_texbox_button("nuevo");
                _met_clean_textbox();
            }else{
                _met_enable_texbox_button("inicio");
                _met_clean_textbox();
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_factoryMethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.puesto, _cls_vo_carg)) {
                _met_update_data();
                MessageBoxEx.Show("El regisrto se ha guardado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_update(object sender, EventArgs e) {
            _met_send_data();
            if (_factoryMethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.puesto, _cls_vo_carg))
            {
                _met_update_data();
                MessageBoxEx.Show("El regisrto se ha guardado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e) {
            _met_send_data();
            if (_factoryMethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.puesto, _cls_vo_carg))
            {
                _met_update_data();
                MessageBoxEx.Show("El regisrto se ha guardado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_first(object sender, EventArgs e) {
            _iterador._met_FirstPage();
            _met_update();
        }
        private void _met_event_click_btn_ant(object sener, EventArgs e) {
            _iterador._met_PreviousPage();
            _met_update();
        }
        private void _met_event_click_btn_next(object sedner, EventArgs e) {
            _iterador._met_NextPage();
            _met_update();
        }
        private void _met_event_click_btn_last(object sender, EventArgs e) {
            _iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_keypree_ger_clv(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _frm_carg.txt_clave.Text = _frm_carg.txt_puesto.Text.Substring(0, 3);
                _frm_carg.txt_descrip.Focus();
            }
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            /*if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }*/
            if (char.IsLower(e.KeyChar)) {
                if (_frm_carg.txt_descrip.Text.Length > 0)
                {
                    string val = _frm_carg.txt_descrip.Text;
                    _frm_carg.txt_descrip.Text = Convert.ToString(val).ToUpper();
                }
            }
        }
        private void _met_event_keypress_validation_number(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
    }
}
