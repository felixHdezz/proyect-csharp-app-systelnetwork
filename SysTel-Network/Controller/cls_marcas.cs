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
    class cls_marcas
    {
        private Frm_marcas _frm_mar;
        private cls_vo_marcas _cls_vo_mar = Model.cls_vo_marcas._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_contAg;
        private cls_Iterador _cls_iterador;
        public cls_marcas(View.Frm_marcas _f_mar) {
            _frm_mar = _f_mar;
            met_event_click();
        }
        private void met_event_click() {
            _met_load_datagridview();
            _met_enable_textbox_button("inicio");
            _frm_mar.btn_new.Click += new EventHandler(_met_event_click_new);
            _frm_mar.btn_insert.Click += new EventHandler(_met_event_click_insert);
            _frm_mar.btn_update.Click += new EventHandler(_met_event_click_update);
            _frm_mar.btn_delete.Click += new EventHandler(_met_event_click_delete);
            _frm_mar.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_mar.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_mar.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_mar.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_mar.dgv_marc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_data_gridview);
            _frm_mar.txt_nom_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_mar.txt_nom_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_marc);
        }
        private void _met_send_data() {
            _cls_vo_mar.Str_clv = _frm_mar.txt_clv.Text;
            _cls_vo_mar.Str_marc = _frm_mar.txt_nom_cat.Text;
        }
        private void _met_clean_textbox() {
            _frm_mar.txt_clv.Text = "";
            _frm_mar.txt_nom_cat.Text = "";
        }
        private void _met_enable_textbox_button(string _str_act) {
            switch (_str_act) { 
                case "inicio":
                    _met_clean_textbox();
                    _frm_mar.txt_clv.Enabled = false;
                    _frm_mar.txt_nom_cat.Enabled = false;
                    _frm_mar.btn_new.Enabled = true;
                    _frm_mar.btn_new.Text = "Nuevo";
                    _frm_mar.btn_insert.Enabled = false;
                    _frm_mar.btn_update.Enabled = false;
                    _frm_mar.btn_delete.Enabled = false;
                    break;
                case "nuevo":
                    _met_clean_textbox();
                    _frm_mar.txt_clv.Enabled = false;
                    _frm_mar.txt_nom_cat.Enabled = true;
                    _frm_mar.btn_new.Enabled = true;
                    _frm_mar.btn_new.Text = "Cancelar";
                    _frm_mar.btn_insert.Enabled = true;
                    _frm_mar.btn_update.Enabled = false;
                    _frm_mar.btn_delete.Enabled = false;
                    break;
                case "click_cell":
                    _frm_mar.txt_clv.Enabled = false;
                    _frm_mar.txt_nom_cat.Enabled = false;
                    _frm_mar.btn_new.Enabled = true;
                    _frm_mar.btn_new.Text = "Cancelar";
                    _frm_mar.btn_insert.Enabled = false;
                    _frm_mar.btn_update.Enabled = true;
                    _frm_mar.btn_delete.Enabled = true;
                    break;
            }
        }
        private void _met_load_data() {
            _met_clean_textbox();
            _met_load_datagridview();
            _met_enable_textbox_button("inicio");
        }
        private void _met_load_datagridview() {
            _cls_contAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.marcas), "DataRemember1", 4);
            _cls_iterador = _cls_contAg.CreateIterador();
            _frm_mar.dgv_marc.DataSource = _cls_iterador._met_LoadData();
            _frm_mar.dgv_marc.DataMember = "DataRemember1";
            _frm_mar.dgv_marc.Columns[0].Width = 60;
            _frm_mar.dgv_marc.Columns[1].Width = 200;
            _frm_mar.dgv_marc.Columns.Add("Column3", "");
            _frm_mar.dgv_marc.Columns.Add("Column4", "");
            _frm_mar.dgv_marc.Columns.Add("Column4", "");
            _met_update();
        }
        private void _met_update(){
            _frm_mar.lbl_total_reg.Text = "Total registros: " + _cls_iterador._met_countRow();
            _frm_mar.lbl_pag.Text = "Pagina: " + _cls_iterador._met_numPag() + "/" + _cls_iterador._met_lastpage();
        }
        private void _met_event_click_data_gridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            _frm_mar.txt_clv.Text = _frm_mar.dgv_marc.CurrentRow.Cells[0].Value.ToString();
            _frm_mar.txt_nom_cat.Text = _frm_mar.dgv_marc.CurrentRow.Cells[1].Value.ToString();
            _met_enable_textbox_button("click_cell");
        }
        private void _met_event_click_new(object sender, EventArgs e) { 
            if(_frm_mar.btn_new.Text  ==   "Nuevo"){
                _met_enable_textbox_button("nuevo");
            }else{
                _met_enable_textbox_button("inicio");
            }
        }
        private void _met_event_click_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.marcas,_cls_vo_mar)) {
                _met_load_data();
                MessageBoxEx.Show("El registro se ha guardado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_update(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.marcas,_cls_vo_mar)){
                _met_load_data();
                MessageBoxEx.Show("El registro se ha actualizado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_delete(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.marcas,_cls_vo_mar)){
                _met_load_data();
                MessageBoxEx.Show("El registro se ha eliminado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private void _met_event_click_btn_last(object sender, EventArgs e) {
            _cls_iterador._met_LastPage();
            _met_update();
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar)){
                e.Handled = true;
            }else{
                e.Handled = false;
            }
        }
        private void _met_event_keypres_marc(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _frm_mar.txt_clv.Text = _frm_mar.txt_nom_cat.Text.Substring(0,3);
            }
        }
    }
}
