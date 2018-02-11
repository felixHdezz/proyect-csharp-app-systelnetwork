using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System.Windows.Forms;
using SysTel_Network.View;
using SysTel_Network.Model;

namespace SysTel_Network.Controller
{
    class cls_productos
    {
        private Frm_productos _frm_productos;
        private cls_conexion _con = Model.cls_conexion._Instance;
        private cls_dav_productos _cls_dav_product;
        private cls_vo_productos _cls_vo_product = Model.cls_vo_productos._Instance;
        private cls_FactoryMethod _cls_factorymethod = Model.cls_FactoryMethod._Instance;
        private cls_ConcreteAggregate _cls_contAg;
        private cls_Iterador _cls_iterador;
        private SqlCommand cmd;
        private SqlDataReader _sqldata =  null;
        private DataTable _datatable;
        private byte[] _img;
        private bool _insertarImg = false;
        public cls_productos(View.Frm_productos _f_product) {
            _frm_productos = _f_product;
            _cls_dav_product = Model.cls_dav_productos._Instance;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_datagridview();
            _met_load_combobox();
            _met_clean_textbox_btn("inicio");
            _frm_productos.btn_new.Click += new EventHandler(_met_event_click_btn_new);
            _frm_productos.btn_img.Click += new EventHandler(_met_event_click_load_img);
            _frm_productos.btn_insert.Click += new EventHandler(_met_event_click_btn_insert);
            _frm_productos.btn_update.Click += new EventHandler(_met_event_click_btn_update);
            _frm_productos.btn_delete.Click += new EventHandler(_met_event_click_btn_delete);
            _frm_productos.btn_first.Click += new EventHandler(_met_event_click_btn_first);
            _frm_productos.btn_ant.Click += new EventHandler(_met_event_click_btn_ant);
            _frm_productos.btn_next.Click += new EventHandler(_met_event_click_btn_next);
            _frm_productos.btn_ult.Click += new EventHandler(_met_event_click_btn_last);
            _frm_productos.dg_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_cell_click_datagrid);
            _frm_productos.txt_codig.KeyPress += new KeyPressEventHandler(_met_event_keypress_validation_number);
            _frm_productos.txt_exis.KeyPress += new KeyPressEventHandler(_met_event_keypress_validation_number);
            _frm_productos.txt_pre_comp.KeyPress += new KeyPressEventHandler(_met_event_keypress_validation_number);
            _frm_productos.txt_pre_vent.KeyPress += new KeyPressEventHandler(_met_event_keypress_validation_number);
        }
        private void _met_load_combobox() {
            _datatable = _cls_dav_product._met_load_combobox_marcas();
            _frm_productos.cmb_mar.DataSource = _datatable;
            _frm_productos.cmb_mar.DisplayMember = "vch_marca".ToUpper();
            _frm_productos.cmb_mar.ValueMember = "nch_clv_mar";

            _datatable = _cls_dav_product._met_load_combobox_cat();
            _frm_productos.cmb_cat.DataSource = _datatable;
            _frm_productos.cmb_cat.DisplayMember = "vch_nom_cat".ToUpper();
            _frm_productos.cmb_cat.ValueMember = "nch_clv_cat";

            _datatable = _cls_dav_product._met_load_combobox_provee();
            _frm_productos.cmb_prove.DataSource = _datatable;
            _frm_productos.cmb_prove.DisplayMember = "vch_nom_prove".ToUpper();
            _frm_productos.cmb_prove.ValueMember = "nch_clv_prove";
        }
        private void _met_load_datagridview() {
            _cls_contAg = new cls_ConcreteAggregate(_cls_factorymethod._get_CRUD_SELECT(cls_FactoryMethod._TipoRegistro.productos), "DataRemember1", 18);
            _cls_iterador = _cls_contAg.CreateIterador();
            _frm_productos.dg_productos.DataSource = _cls_iterador._met_LoadData();
            _frm_productos.dg_productos.DataMember = "DataRemember1";
            _frm_productos.dg_productos.Columns[1].Width = 190;
            _frm_productos.dg_productos.Columns[2].Width = 200;
            _met_update();
        }
        private void _met_update() {
            _frm_productos.lbl_total_reg.Text = "Total registros: " + _cls_iterador._met_countRow();
            _frm_productos.lbl_pag.Text = "Pagina: " + _cls_iterador._met_numPag()+"/"+_cls_iterador._met_lastpage();
        }
        private void _met_send_data() {
            _cls_vo_product.Str_codigo = _frm_productos.txt_codig.Text;
            _cls_vo_product.Str_nom = _frm_productos.txt_nom.Text;
            _cls_vo_product.Str_descrip = _frm_productos.txt_descrip.Text;
            _cls_vo_product.Str_mar = _frm_productos.cmb_mar.SelectedValue.ToString();
            _cls_vo_product.Str_cat = _frm_productos.cmb_cat.SelectedValue.ToString();
            _cls_vo_product.Str_prove = _frm_productos.cmb_prove.SelectedValue.ToString();
            _cls_vo_product.Int_pre_vent = Convert.ToDecimal(_frm_productos.txt_pre_vent.Text);
            _cls_vo_product.Int_pre_comp = Convert.ToDecimal(_frm_productos.txt_pre_comp.Text);
            _cls_vo_product.Int_exis_uni = Convert.ToInt32(_frm_productos.txt_exis.Text);
            if (_frm_productos.cmb_estado.Text == "ACTIVO") { 
                _cls_vo_product.Str_est_pro = "act";
            }else{
                _cls_vo_product.Str_est_pro = "inac";
            }
        }
        private void _met_clean_textbox_btn(string ac) {
            switch (ac) { 
                case "inicio":
                    _frm_productos.btn_new.Enabled = true;
                    _frm_productos.btn_new.Text = "Nuevo";
                    _frm_productos.btn_insert.Enabled = false;
                    _frm_productos.btn_update.Enabled = false;
                    _frm_productos.btn_delete.Enabled = false;
                    _frm_productos.btn_img.Enabled = false;
                    _frm_productos.txt_codig.Enabled = false;
                    _frm_productos.txt_nom.Enabled = false;
                    _frm_productos.txt_descrip.Enabled = false;
                    _frm_productos.cmb_mar.Enabled = false;
                    _frm_productos.cmb_cat.Enabled = false;
                    _frm_productos.cmb_prove.Enabled = false;
                    _frm_productos.txt_pre_vent.Enabled = false;
                    _frm_productos.txt_pre_comp.Enabled = false;
                    _frm_productos.txt_exis.Enabled = false;
                    _frm_productos.cmb_estado.Enabled = false;
                    _frm_productos.txt_codig.Text = "";
                    _frm_productos.txt_nom.Text = "";
                    _frm_productos.txt_descrip.Text = "";
                    _frm_productos.txt_pre_vent.Text = "";
                    _frm_productos.txt_pre_comp.Text = "";
                    _frm_productos.txt_exis.Text = "";
                    //_frm_productos.pb_img.Controls.Clear();
                    break;
                case "nuevo":
                    _frm_productos.btn_new.Enabled = true;
                    _frm_productos.btn_new.Text = "Cancelar";
                    _frm_productos.btn_insert.Enabled = true;
                    _frm_productos.btn_update.Enabled = false;
                    _frm_productos.btn_delete.Enabled = false;
                    _frm_productos.btn_img.Enabled = true;
                    _frm_productos.txt_codig.Enabled = true;
                    _frm_productos.txt_nom.Enabled = true;
                    _frm_productos.txt_descrip.Enabled = true;
                    _frm_productos.cmb_mar.Enabled = true;
                    _frm_productos.cmb_cat.Enabled = true;
                    _frm_productos.cmb_prove.Enabled = true;
                    _frm_productos.txt_pre_vent.Enabled = true;
                    _frm_productos.txt_pre_comp.Enabled = true;
                    _frm_productos.txt_exis.Enabled = true;
                    _frm_productos.cmb_estado.Enabled = true;
                    _frm_productos.txt_codig.Text = "";
                    _frm_productos.txt_nom.Text = "";
                    _frm_productos.txt_descrip.Text = "";
                    _frm_productos.txt_pre_vent.Text = "";
                    _frm_productos.txt_pre_comp.Text = "";
                    _frm_productos.txt_exis.Text = "";
                    _frm_productos.cmb_estado.Enabled = true;
                    break;
                case "click_cell":
                    _frm_productos.btn_new.Enabled = true;
                    _frm_productos.btn_new.Text = "Cancelar";
                    _frm_productos.btn_insert.Enabled = false;
                    _frm_productos.btn_update.Enabled = true;
                    _frm_productos.btn_delete.Enabled = true;
                    _frm_productos.btn_img.Enabled = true;
                    _frm_productos.txt_codig.Enabled = true;
                    _frm_productos.txt_nom.Enabled = true;
                    _frm_productos.txt_descrip.Enabled = true;
                    _frm_productos.cmb_mar.Enabled = true;
                    _frm_productos.cmb_cat.Enabled = true;
                    _frm_productos.cmb_prove.Enabled = true;
                    _frm_productos.txt_pre_vent.Enabled = true;
                    _frm_productos.txt_pre_comp.Enabled = true;
                    _frm_productos.txt_exis.Enabled = true;
                    _frm_productos.cmb_estado.Enabled = true;
                    break;
            }
        }
        private void _met_event_click_load_img(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPEG(*.jpeg;*.jpg)| *.jpeg;*.JPEG;*.jpg;*.JPG | PNG(*.png) | *.png;*.PNG | Todos los archivos(*.*) | *.*";
            openFileDialog1.Title = "Selecciona una imagen";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                if (openFileDialog1.FileName.Equals("") == false){
                    _frm_productos.pb_img.Load(openFileDialog1.FileName);
                }
                _insertarImg = true;
            }else {
                _insertarImg = false;   
            }
        }
        private void _met_guard_img(){
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            _frm_productos.pb_img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd = new SqlCommand("update tbl_productos set img_imagen = @img where vch_codigo = @codigo", _con._sql_con);
            cmd.Parameters.Add("@img", System.Data.SqlDbType.Image);
            cmd.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@codigo"].Value = _frm_productos.txt_codig.Text;
            cmd.Parameters["@img"].Value = ms.GetBuffer();
            cmd.ExecuteNonQuery();
            ms.Close();
        }
        private void _met_event_click_btn_new(object sender, EventArgs e) {
            if (_frm_productos.btn_new.Text == "Nuevo"){
                _met_clean_textbox_btn("nuevo");
            }else {
                _met_clean_textbox_btn("inicio");
                //_frm_productos.pb_img.ImageLocation = "";
            }
        }
        private void _met_event_click_btn_insert(object sender, EventArgs e){
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_INSERTAR(Model.cls_FactoryMethod._TipoRegistro.productos,_cls_vo_product)){
                if (_insertarImg !=false){
                    _met_guard_img();
                }
                _met_clean_textbox_btn("inicio");
                _met_load_datagridview();
                MessageBoxEx.Show("El registro se ha guardado correctamente","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_update(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_UPDATE(Model.cls_FactoryMethod._TipoRegistro.productos,_cls_vo_product)) {
                if (_insertarImg != false){
                    _met_guard_img();
                }
                _met_clean_textbox_btn("inicio");
                _met_load_datagridview();
                MessageBoxEx.Show("El registro se ha modificado correctamente", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_delete(object sender, EventArgs e) {
            _met_send_data();
            if (_cls_factorymethod._get_CRUD_DELETE(Model.cls_FactoryMethod._TipoRegistro.productos,_cls_vo_product)) {
                _met_clean_textbox_btn("inicio");
                _met_load_datagridview();
                MessageBoxEx.Show("El registro se ha eliminado correctamente", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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
        private void _met_load_img(){
            cmd = new SqlCommand("select img_imagen  from tbl_productos where vch_codigo = '" + _frm_productos.txt_codig.Text + "'", _con._sql_con);
            _sqldata = cmd.ExecuteReader();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            while (_sqldata.Read())
            {
                _img = (byte[])_sqldata[0];
            }
            _sqldata.Close();
            if (_img.Length > 0){
                ms = new System.IO.MemoryStream(_img);
                _frm_productos.pb_img.Image = System.Drawing.Bitmap.FromStream(ms);
                _sqldata.Close();
            }else {
                _frm_productos.pb_img.Image = null;
            }
            _sqldata.Close();
            ms.Close();
        }
        private void _met_event_cell_click_datagrid(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToString(_frm_productos.dg_productos.CurrentRow.Cells[0].Value) != "") {
                _frm_productos.txt_codig.Text = _frm_productos.dg_productos.CurrentRow.Cells[0].Value.ToString().ToUpper();
                _frm_productos.txt_nom.Text = _frm_productos.dg_productos.CurrentRow.Cells[1].Value.ToString().ToUpper();
                _frm_productos.txt_descrip.Text = _frm_productos.dg_productos.CurrentRow.Cells[2].Value.ToString().ToUpper();
                _frm_productos.cmb_mar.Text = _frm_productos.dg_productos.CurrentRow.Cells[3].Value.ToString().ToUpper();
                _frm_productos.cmb_cat.Text = _frm_productos.dg_productos.CurrentRow.Cells[4].Value.ToString().ToUpper();
                _frm_productos.cmb_prove.Text = _frm_productos.dg_productos.CurrentRow.Cells[5].Value.ToString().ToUpper();
                _frm_productos.txt_pre_vent.Text = _frm_productos.dg_productos.CurrentRow.Cells[6].Value.ToString().ToUpper();
                _frm_productos.txt_pre_comp.Text = _frm_productos.dg_productos.CurrentRow.Cells[7].Value.ToString().ToUpper();
                _frm_productos.txt_exis.Text = _frm_productos.dg_productos.CurrentRow.Cells[8].Value.ToString().ToUpper();
                _frm_productos.cmb_estado.Text = _frm_productos.dg_productos.CurrentRow.Cells[9].Value.ToString().ToUpper();
                _met_load_img();
                _met_clean_textbox_btn("click_cell");
            }
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back) {
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
    }
}
