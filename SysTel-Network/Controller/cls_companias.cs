using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System.Collections;
using System.Windows.Forms;

namespace SysTel_Network.Controller
{
    class cls_companias
    {
        private View.Frm_companias _frm_companias;
        private Model.cls_vo_compania _cls_vo_compa = Model.cls_vo_compania._Instance;
        private Model.cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private Model.cls_ConcreteAggregate _add;
        private Model.cls_Iterador _i;
        public cls_companias(View.Frm_companias _f_comp) {
            _frm_companias = _f_comp;
            _met_event_clik();
        }
        private void _met_event_clik() {
            _met_load_datagridview();
            _met_enable_txt("ini");
            _frm_companias.dgv_companias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_clickcell);
            _frm_companias.btn_nuevo.Click += new EventHandler(_met_event_click_btn_new);
            _frm_companias.btn_insert.Click += new EventHandler(_met_event_click_btn_insert);
            _frm_companias.btn_update.Click += new EventHandler(_met_event_click_btn_update);
            _frm_companias.btn_delete.Click += new EventHandler(_met_event_click_btn_delete);
            _frm_companias.btn_first.Click += new EventHandler(_met_event_click_first);
            _frm_companias.btn_next.Click += new EventHandler(_met_event_click_next);
            _frm_companias.btn_ant.Click += new EventHandler(_met_event_click_prev);
            _frm_companias.btn_ult.Click += new EventHandler(_met_event_click_last);
        }
        private void _met_enable_txt(string ac) {
            switch (ac) { 
                case "ini":
                    _frm_companias.btn_nuevo.Text = "Nuevo";
                    _frm_companias.btn_nuevo.Enabled = true;
                    _frm_companias.btn_insert.Enabled = false;
                    _frm_companias.btn_update.Enabled = false;
                    _frm_companias.btn_delete.Enabled = false;
                    _frm_companias.txt_carg.Enabled = false;
                    _frm_companias.txt_ciudad.Enabled = false;
                    _frm_companias.txt_clave.Enabled = false;
                    _frm_companias.txt_codigPos.Enabled = false;
                    _frm_companias.txt_compania.Enabled = false;
                    _frm_companias.txt_contac.Enabled = false;
                    _frm_companias.txt_direcc.Enabled = false;
                    _frm_companias.txt_email.Enabled = false;
                    _frm_companias.txt_estado.Enabled = false;
                    _frm_companias.txt_pais.Enabled = false;
                    _frm_companias.txt_telf.Enabled = false;

                    _frm_companias.txt_carg.Text = "";
                    _frm_companias.txt_ciudad.Text = "";
                    _frm_companias.txt_clave.Text = "";
                    _frm_companias.txt_codigPos.Text = "";
                    _frm_companias.txt_compania.Text = "";
                    _frm_companias.txt_contac.Text = "";
                    _frm_companias.txt_direcc.Text = "";
                    _frm_companias.txt_email.Text = "";
                    _frm_companias.txt_estado.Text = "";
                    _frm_companias.txt_pais.Text = "";
                    _frm_companias.txt_telf.Text = "";
                    _met_load_datagridview();
                    break;
                case "new":
                    _frm_companias.btn_nuevo.Text = "cancelar";
                    _frm_companias.btn_nuevo.Enabled = true;
                    _frm_companias.btn_insert.Enabled = true;
                    _frm_companias.btn_update.Enabled = false;
                    _frm_companias.btn_delete.Enabled = false;
                    _frm_companias.txt_carg.Enabled = true;
                    _frm_companias.txt_ciudad.Enabled = true;
                    _frm_companias.txt_clave.Enabled = true;
                    _frm_companias.txt_codigPos.Enabled = true;
                    _frm_companias.txt_compania.Enabled = true;
                    _frm_companias.txt_contac.Enabled = true;
                    _frm_companias.txt_direcc.Enabled = true;
                    _frm_companias.txt_email.Enabled = true;
                    _frm_companias.txt_estado.Enabled = true;
                    _frm_companias.txt_pais.Enabled = true;
                    _frm_companias.txt_telf.Enabled = true;

                    _frm_companias.txt_carg.Text = "";
                    _frm_companias.txt_ciudad.Text = "";
                    _frm_companias.txt_clave.Text = "";
                    _frm_companias.txt_codigPos.Text = "";
                    _frm_companias.txt_compania.Text = "";
                    _frm_companias.txt_contac.Text = "";
                    _frm_companias.txt_direcc.Text = "";
                    _frm_companias.txt_email.Text = "";
                    _frm_companias.txt_estado.Text = "";
                    _frm_companias.txt_pais.Text = "";
                    _frm_companias.txt_telf.Text = "";
                    break;
                case "click_cell":
                    _frm_companias.btn_nuevo.Text = "cancelar";
                    _frm_companias.btn_nuevo.Enabled = true;
                    _frm_companias.btn_insert.Enabled = false;
                    _frm_companias.btn_update.Enabled = true;
                    _frm_companias.btn_delete.Enabled = true;
                    _frm_companias.txt_carg.Enabled = true;
                    _frm_companias.txt_ciudad.Enabled = true;
                    _frm_companias.txt_clave.Enabled = true;
                    _frm_companias.txt_codigPos.Enabled = true;
                    _frm_companias.txt_compania.Enabled = true;
                    _frm_companias.txt_contac.Enabled = true;
                    _frm_companias.txt_direcc.Enabled = true;
                    _frm_companias.txt_email.Enabled = true;
                    _frm_companias.txt_estado.Enabled = true;
                    _frm_companias.txt_pais.Enabled = true;
                    _frm_companias.txt_telf.Enabled = true;
                    break;
            }
        }
        private void _met_send_data() {
            _cls_vo_compa.Str_clave = _frm_companias.txt_clave.Text;
            _cls_vo_compa.Str_compa = _frm_companias.txt_compania.Text;
            _cls_vo_compa.Str_contact = _frm_companias.txt_contac.Text;
            _cls_vo_compa.Str_carg = _frm_companias.txt_carg.Text;
            _cls_vo_compa.Str_direc = _frm_companias.txt_direcc.Text;
            _cls_vo_compa.Str_tel = _frm_companias.txt_telf.Text;
            _cls_vo_compa.Str_email = _frm_companias.txt_email.Text;
            _cls_vo_compa.Str_pais = _frm_companias.txt_pais.Text;
            _cls_vo_compa.Str_estado = _frm_companias.txt_estado.Text;
            _cls_vo_compa.Str_ciudad = _frm_companias.txt_ciudad.Text;
            _cls_vo_compa.Str_cp = _frm_companias.txt_codigPos.Text;
        }
        private void _met_load_datagridview() {
            _add = new Model.cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(Model.cls_FactoryMethod._TipoRegistro.companias), "DataRemember1", 12);
            _i = _add.CreateIterador();
            _frm_companias.dgv_companias.DataSource = _i._met_LoadData();
            _frm_companias.dgv_companias.DataMember = "DataRemember1";
            _frm_companias.dgv_companias.Columns[0].Width = 60;
            _frm_companias.dgv_companias.Columns[1].Width = 150;
            act_data();
        }
        public void act_data() {
            _frm_companias.lbl_total_reg.Text = "Total registros: "+_i._met_countRow();
            _frm_companias.lbl_pag.Text = "Pagina: " + _i._met_numPag() + "/" + _i._met_lastpage();
        }
        private void _met_event_click_first(object sender, EventArgs e)
        {
            _i._met_FirstPage();
            act_data();
        }
        private void _met_event_click_next(object sender, EventArgs e) {
            _i._met_NextPage();
            act_data();
        }
        private void _met_event_click_prev(object sender, EventArgs e)
        {
            _i._met_PreviousPage();
            act_data();
        }
        private void _met_event_click_last(object sender, EventArgs e)
        {
            _i._met_LastPage();
            act_data();
        }
        private void _met_event_click_btn_new(object sender, EventArgs e) {
            if (_frm_companias.btn_nuevo.Text == "Nuevo"){
                _met_enable_txt("new");
            }else {
                _met_enable_txt("ini");
            }
        }
        private void _met_event_click_btn_insert(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.companias,_cls_vo_compa)) {
                _met_enable_txt("ini");
                MessageBoxEx.Show("El registro se ha insertado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
            _met_load_datagridview();
        }
        private void _met_event_click_btn_update(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.companias,_cls_vo_compa)) {
                _met_enable_txt("ini");
                MessageBoxEx.Show("El registro se ha actualizado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_delete(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.companias,_cls_vo_compa)) {
                _met_enable_txt("ini");
                MessageBoxEx.Show("El registro se ha eliminado con exito", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            _met_load_datagridview();
        }
        private void _met_event_clickcell(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_companias.dgv_companias.CurrentRow.Cells[0].Value) != "") {
                _frm_companias.txt_clave.Text = _frm_companias.dgv_companias.CurrentRow.Cells[0].Value.ToString();
                _frm_companias.txt_compania.Text = _frm_companias.dgv_companias.CurrentRow.Cells[1].Value.ToString();
                _frm_companias.txt_contac.Text = _frm_companias.dgv_companias.CurrentRow.Cells[2].Value.ToString();
                _frm_companias.txt_carg.Text = _frm_companias.dgv_companias.CurrentRow.Cells[3].Value.ToString();
                _frm_companias.txt_direcc.Text = _frm_companias.dgv_companias.CurrentRow.Cells[4].Value.ToString();
                _frm_companias.txt_telf.Text = _frm_companias.dgv_companias.CurrentRow.Cells[5].Value.ToString();
                _frm_companias.txt_email.Text = _frm_companias.dgv_companias.CurrentRow.Cells[6].Value.ToString();
                _frm_companias.txt_pais.Text = _frm_companias.dgv_companias.CurrentRow.Cells[7].Value.ToString();
                _frm_companias.txt_estado.Text = _frm_companias.dgv_companias.CurrentRow.Cells[8].Value.ToString();
                _frm_companias.txt_ciudad.Text = _frm_companias.dgv_companias.CurrentRow.Cells[9].Value.ToString();
                _frm_companias.txt_codigPos.Text = _frm_companias.dgv_companias.CurrentRow.Cells[10].Value.ToString();
                _met_enable_txt("click_cell");
            }
        }
    }
}
