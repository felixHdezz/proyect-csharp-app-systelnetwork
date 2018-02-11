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
    class cls_categorias
    {
        private Frm_categorias _frm_cat;
        private cls_vo_categorias _cls_vo_cat = Model.cls_vo_categorias._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_contAg;
        private cls_Iterador _cls_iterador;
        public cls_categorias(View.Frm_categorias _f_cat) {
            _frm_cat = _f_cat;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_data_grid_view();
            _met_enable_textbox_button("inicio");
            _frm_cat.btn_new.Click += new EventHandler(_met_event_click_new);
            _frm_cat.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_cat.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_cat.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_cat.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_cat.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_cat.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_cat.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_cat.dgv_cat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datagridview);
            _frm_cat.txt_nom_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_cat.txt_nom_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_cat);
            _frm_cat.txt_discr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
        }
        private void _met_load_data_grid_view() {
            _cls_contAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.categorias), "DataRemember1",5);
            _cls_iterador = _cls_contAg.CreateIterador();
            _frm_cat.dgv_cat.DataSource = _cls_iterador._met_LoadData();
            _frm_cat.dgv_cat.DataMember = "DataRemember1";
            _frm_cat.dgv_cat.Columns.Add("Column4", "");
            _frm_cat.dgv_cat.Columns.Add("Column4", "");
            _frm_cat.dgv_cat.Columns[0].Width = 60;
            _frm_cat.dgv_cat.Columns[1].Width = 180;
            _frm_cat.dgv_cat.Columns[2].Width = 220;
            _met_update();
        }
        private void _met_update() {
            _frm_cat.lbl_total_reg.Text = "Total registros: " + _cls_iterador._met_countRow();
            _frm_cat.lbl_pag.Text = "Pagina: " + _cls_iterador._met_numPag() + "/" + _cls_iterador._met_lastpage();
        }
        private void _met_event_click_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (_frm_cat.dgv_cat.CurrentRow.Cells[0].Value.ToString() != "") {
                _frm_cat.txt_clv.Text = _frm_cat.dgv_cat.CurrentRow.Cells[0].Value.ToString();
                _frm_cat.txt_nom_cat.Text = _frm_cat.dgv_cat.CurrentRow.Cells[1].Value.ToString();
                _frm_cat.txt_discr.Text = _frm_cat.dgv_cat.CurrentRow.Cells[2].Value.ToString();
                _met_enable_textbox_button("click_cell");
            }
        }
        private void _met_send_data() {
            _cls_vo_cat.Str_clv = _frm_cat.txt_clv.Text;
            _cls_vo_cat.Str_cat = _frm_cat.txt_nom_cat.Text;
            _cls_vo_cat.Str_des = _frm_cat.txt_discr.Text;
        }
        private void _met_clean_textbox() {
            _frm_cat.txt_clv.Text = "";
            _frm_cat.txt_nom_cat.Text = "";
            _frm_cat.txt_discr.Text = "";
        }
        private void _met_update_data() {
            _met_clean_textbox();
            _met_load_data_grid_view();
            _met_enable_textbox_button("inicio");
        }
        private void _met_enable_textbox_button(string _str_act) {
            switch (_str_act) { 
                case "inicio":
                    _met_clean_textbox();
                    _frm_cat.txt_clv.Enabled = false;
                    _frm_cat.txt_nom_cat.Enabled = false;
                    _frm_cat.txt_discr.Enabled = false;
                    _frm_cat.btn_new.Enabled = true;
                    _frm_cat.btn_new.Text = "Nuevo";
                    _frm_cat.btn_insert.Enabled = false;
                    _frm_cat.btn_update.Enabled = false;
                    _frm_cat.btn_delete.Enabled = false;
                    break;
                case "nuevo":
                    _frm_cat.txt_clv.Enabled = false;
                    _frm_cat.txt_nom_cat.Enabled = true;
                    _frm_cat.txt_discr.Enabled = true;
                    _frm_cat.btn_new.Enabled = true;
                    _frm_cat.btn_new.Text = "Cancelar";
                    _frm_cat.btn_insert.Enabled = true;
                    _frm_cat.btn_update.Enabled = false;
                    _frm_cat.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_cat.txt_clv.Enabled = false;
                    _frm_cat.txt_nom_cat.Enabled = true;
                    _frm_cat.txt_discr.Enabled = true;
                    _frm_cat.btn_new.Enabled = true;
                    _frm_cat.btn_new.Text = "Cancelar";
                    _frm_cat.btn_insert.Enabled = false;
                    _frm_cat.btn_update.Enabled = true;
                    _frm_cat.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_event_click_new(object sender, EventArgs e) { 
            if(_frm_cat.btn_new.Text == "Nuevo"){
                _met_enable_textbox_button("nuevo");
            }else{
                _met_enable_textbox_button("inicio");
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.categorias,_cls_vo_cat)) {
                _met_update_data();
                MessageBoxEx.Show("El registro se ha guardado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_update(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.categorias,_cls_vo_cat)) {
                _met_update_data();
                MessageBoxEx.Show("El registro se ha actualizado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.categorias,_cls_vo_cat)) {
                _met_update_data();
                MessageBoxEx.Show("El registro se ha eliminado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
        private void _met_event_keypres_cat(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _frm_cat.txt_clv.Text = _frm_cat.txt_nom_cat.Text.Substring(0, 3);
                _frm_cat.txt_discr.Focus();
            }
        }
    }
}
