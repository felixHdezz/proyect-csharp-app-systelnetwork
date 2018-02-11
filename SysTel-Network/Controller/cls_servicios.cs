using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace SysTel_Network.Controller
{
    class cls_servicios
    {
        private View.Frm_servicios _frm_servicios;
        private Model.cls_dav_servicios _cls_dav_ser;
        private Model.cls_var_login _cls_var_log = new Model.cls_var_login();
        private Model.cls_vo_servicios _cls_vo_serv = Model.cls_vo_servicios._Instance;
        private SqlDataReader _SqlDataRead;
        private DataTable _DataTable;
        private int _int_cont = 0;
        private string _fechapedido, _fechaatender;
        private decimal _dc_total_cost_serv, _int_cost_serv;
        public cls_servicios(View.Frm_servicios _f_servicios) {
            _frm_servicios = _f_servicios;
            _cls_dav_ser = Model.cls_dav_servicios._Instance;
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_combobox();
            _met_load_clave_autoincre();
            _met_enable_();
            _frm_servicios.txt_nom_empl.Text = _cls_var_log._Nom_empl;
            _frm_servicios.txt_carg_emp.Text = _cls_var_log._Carg;
            _frm_servicios.btn_buscar.Click += new EventHandler(_met_event_click_serch_cli);
            _frm_servicios.cmb_servicios.SelectionChangeCommitted += new EventHandler(_met_event_click_combobox_serv);
            _frm_servicios.cmb_ser_inclu.SelectionChangeCommitted += new EventHandler(_met_event_click_comb_box_serv_inc);
            _frm_servicios.cmb_tip_cable.SelectionChangeCommitted += new EventHandler(_met_event_click_comb_tipoCa);
            _frm_servicios.btn_new_company.Click += new EventHandler(_met_event_click_btn_new_company);
            _frm_servicios.dateTimePicker2.TextChanged += new EventHandler(_met_event_click_datetime1);
            _frm_servicios.btn_add_ser.Click += new EventHandler(_met_add_service_in_datagridview);
            _frm_servicios.btn_aceptar.Click += new EventHandler(_met_event_click_btn_insert_serv);
        }  
        private void _met_load_clave_autoincre() {
            _cls_dav_ser._met_load_clv_auto();
            _SqlDataRead = _cls_dav_ser._SqlDataRead;
            while (_SqlDataRead.Read()){
                if (Convert.ToInt32(_SqlDataRead[0]) < 10){
                    _frm_servicios.lbl_no_venta.Text = "0000" + Convert.ToString(_SqlDataRead[0]);
                }else{
                    if (Convert.ToInt32(_SqlDataRead[0]) >= 10 && Convert.ToInt32(_SqlDataRead[0]) < 100){
                        _frm_servicios.lbl_no_venta.Text = "000" + Convert.ToString(_SqlDataRead[0]);
                    }else {
                        if (Convert.ToInt32(_SqlDataRead[0]) >= 100 && Convert.ToInt32(_SqlDataRead[0]) < 1000)
                        {
                            _frm_servicios.lbl_no_venta.Text = "0" + Convert.ToString(_SqlDataRead[0]);
                        }
                        else {
                            _frm_servicios.lbl_no_venta.Text = Convert.ToString(_SqlDataRead[0]);
                        }
                    }
                }
            }
        }
        private void _met_load_combobox() {
            _cls_dav_ser._met_load_combobox();
            _DataTable = _cls_dav_ser._DataTable;
            _frm_servicios.cmb_servicios.DataSource = _DataTable;
            _frm_servicios.cmb_servicios.DisplayMember = "vch_serv";
            _frm_servicios.cmb_servicios.ValueMember = "int_clvserv";

            _cls_dav_ser._met_load_combo_tip_ca();
            _DataTable = _cls_dav_ser._DataTable;
            _frm_servicios.cmb_tip_cable.DataSource = _DataTable;
            _frm_servicios.cmb_tip_cable.DisplayMember = "vch_tipoCable";
            _frm_servicios.cmb_tip_cable.ValueMember = "int_id_tipoCa";
        }
        private void _met_enable_(){
            _frm_servicios.txt_clv_cli.Focus();
            _frm_servicios.txt_nom_empl.Enabled = false;
            _frm_servicios.txt_carg_emp.Enabled = false;
            _frm_servicios.txt_ciudad.Enabled = false;
            _frm_servicios.txt_cost_ser.Enabled = false;
            _frm_servicios.txt_cost_total_ser.Enabled = false;
            _frm_servicios.dateTimePicker1.Enabled = false;
            _frm_servicios.txt_direc.Enabled = false;
            _frm_servicios.txt_email.Enabled = false;
            _frm_servicios.txt_estado.Enabled = false;
            //_frm_servicios.txt_importe.Enabled = false;
            _frm_servicios.txt_no_ser.Enabled = false;
            _frm_servicios.txt_nom_empr.Enabled = false;
            _frm_servicios.txt_nom_contac.Enabled = false;
            _frm_servicios.txt_pais.Enabled = false;
            _frm_servicios.txt_sub_total.Enabled = false;
            _frm_servicios.txt_tel.Enabled = false;
            _frm_servicios.txt_carg_contac.Enabled = false;
        }
        private void _met_clean_textbox(string _str_ac) {
            switch (_str_ac) { 
                case "insert":
                    _frm_servicios.txt_clv_cli.Text ="";
                    _frm_servicios.txt_clv_cli.Focus();
                    _frm_servicios.txt_nom_empl.Text = "";
                    _frm_servicios.txt_carg_emp.Enabled = false;
                    _frm_servicios.txt_ciudad.Text = "";
                    _frm_servicios.txt_cost_ser.Text = "0.00";
                    _frm_servicios.txt_cost_total_ser.Text = "0.00";
                    _frm_servicios.dateTimePicker2.Enabled = true;
                    _frm_servicios.txt_direc.Text = "";
                    _frm_servicios.txt_email.Text = "";
                    _frm_servicios.txt_estado.Text = "";
                    _frm_servicios.txt_importe.Text = "0.00";
                    _frm_servicios.txt_no_ser.Text = "0";
                    _frm_servicios.txt_nom_empr.Text = "";
                    _frm_servicios.txt_nom_contac.Text = "";
                    _frm_servicios.txt_pais.Text = "";
                    _frm_servicios.txt_sub_total.Text = "0.00";
                    _frm_servicios.txt_tel.Text = "";
                    _frm_servicios.txt_carg_contac.Text = "";
                    _frm_servicios.cmb_tip_cable.Enabled = true;
                    //_frm_servicios.cmb_ser_inclu.Items.Clear();
                    _frm_servicios.txt_cost_ser.Text = "";
                    _frm_servicios.dgv_servicios.Rows.Clear();
                    break;
                case "add":
                    //_frm_servicios.cmb_ser_inclu.Items.Clear();
                    _frm_servicios.txt_cost_ser.Text = "";
                    break;
            }
        }
        private void _met_send_data() {
            _cls_vo_serv.Int_id_serv = Convert.ToInt32(_frm_servicios.lbl_no_venta.Text);
            _fechapedido = _frm_servicios.dateTimePicker1.Text;
            _fechaatender = _frm_servicios.dateTimePicker2.Text;
            _cls_vo_serv.Str_fechpedido_ser = _fechapedido;
            _cls_vo_serv.Str_fechatender_ser = _fechaatender;
            _cls_vo_serv.Int_tipca = Convert.ToInt32(_frm_servicios.cmb_tip_cable.SelectedValue.ToString());
            _cls_vo_serv.Int_cant_serv = Convert.ToInt32(_frm_servicios.txt_no_ser.Text);
            _cls_vo_serv.Str_cost_totalser = _frm_servicios.txt_cost_total_ser.Text;
            _cls_vo_serv.Str_importe = _frm_servicios.txt_importe.Text;
            _cls_vo_serv.Str_clv_cli_com = _frm_servicios.txt_clv_cli.Text;
            _cls_vo_serv.Str_rfc = _cls_var_log._RFC;
            _cls_vo_serv.Str_desti = _frm_servicios.txt_nom_empr.Text;
            _cls_vo_serv.Str_direcdesti = _frm_servicios.txt_direc.Text;
            _cls_vo_serv.Str_estado = _frm_servicios.txt_estado.Text;
            _cls_vo_serv.Str_ciudad = _frm_servicios.txt_ciudad.Text;
        }
        private void _met_event_click_serch_cli(object sender, EventArgs e) {
            _cls_vo_serv.Str_clv_cli_com = _frm_servicios.txt_clv_cli.Text;
            _cls_dav_ser._met_serch_cli_com(_cls_vo_serv);
            _SqlDataRead = _cls_dav_ser._SqlDataRead;
            while(_SqlDataRead.Read()){
                _frm_servicios.txt_nom_empr.Text = _SqlDataRead[1].ToString();
                _frm_servicios.txt_nom_contac.Text = _SqlDataRead[2].ToString();
                _frm_servicios.txt_carg_contac.Text = _SqlDataRead[3].ToString();
                _frm_servicios.txt_direc.Text = _SqlDataRead[4].ToString();
                _frm_servicios.txt_tel.Text = _SqlDataRead[5].ToString();
                _frm_servicios.txt_email.Text = _SqlDataRead[6].ToString();
                _frm_servicios.txt_pais.Text = _SqlDataRead[7].ToString();
                _frm_servicios.txt_estado.Text = _SqlDataRead[8].ToString();
                _frm_servicios.txt_ciudad.Text = _SqlDataRead[9].ToString();
            }
        }
        private void _met_event_click_combobox_serv(object sender, EventArgs e) {
            _cls_dav_ser._met_load_comb_servi_inc(_frm_servicios.cmb_servicios.SelectedValue.ToString());
            _DataTable = _cls_dav_ser._DataTable;
            _frm_servicios.cmb_ser_inclu.DataSource = _DataTable;
            _frm_servicios.cmb_ser_inclu.DisplayMember = "vch_sub_serv";
            _frm_servicios.cmb_ser_inclu.ValueMember = "int_clv_sub_serv";
        }
        private void _met_event_click_comb_box_serv_inc(object sender, EventArgs e) {
            _cls_dav_ser._met_load_combo_cost_ser(_frm_servicios.cmb_ser_inclu.SelectedValue.ToString());
            _SqlDataRead = _cls_dav_ser._SqlDataRead;
            while (_SqlDataRead.Read()) {
                _frm_servicios.txt_cost_ser.Text = _SqlDataRead[0].ToString();
            }
        }
        private void _met_event_click_comb_tipoCa(object sender, EventArgs e) {
            _frm_servicios.cmb_tip_cable.Enabled = false;
        }
        private void _met_event_click_btn_new_company(object sender, EventArgs e) {
            View.Frm_nuevo_cliente _frm_new_company = new View.Frm_nuevo_cliente();
            _frm_new_company.Show();
        }
        private void _met_event_click_datetime1(object sender, EventArgs e) {
            _frm_servicios.dateTimePicker2.Enabled = false;
        }
        private void _met_add_service_in_datagridview(object sender, EventArgs e) {
            if (_frm_servicios.txt_clv_cli.Text != "" && _frm_servicios.txt_cost_ser.Text != "" && _frm_servicios.cmb_ser_inclu.Text != "") {
                int _int_con = 0;
                while (_int_con < 1) {
                    _int_cont = _frm_servicios.dgv_servicios.Rows.Add();
                    _frm_servicios.dgv_servicios.Rows[_int_cont].Cells[0].Value = _frm_servicios.cmb_servicios.SelectedValue.ToString();
                    _frm_servicios.dgv_servicios.Rows[_int_cont].Cells[1].Value = _frm_servicios.cmb_servicios.Text;
                    _frm_servicios.dgv_servicios.Rows[_int_cont].Cells[2].Value = _frm_servicios.cmb_ser_inclu.Text;
                    _frm_servicios.dgv_servicios.Rows[_int_cont].Cells[3].Value = _frm_servicios.cmb_tip_cable.Text;
                    _frm_servicios.dgv_servicios.Rows[_int_cont].Cells[4].Value = _frm_servicios.txt_cost_ser.Text;
                    _int_con++;
                }
                _int_cont++;
                _frm_servicios.txt_no_ser.Text = _int_cont.ToString();
                _int_cost_serv = Convert.ToDecimal(_frm_servicios.txt_cost_ser.Text);
                _dc_total_cost_serv += Convert.ToDecimal(_int_cost_serv);
                _frm_servicios.txt_sub_total.Text = _dc_total_cost_serv.ToString();
                _frm_servicios.txt_cost_total_ser.Text = _dc_total_cost_serv.ToString();
                _met_clean_textbox("add");
            }
        }
        private void _met_event_click_btn_insert_serv(object sender, EventArgs e) {
            _met_send_data();
            _cls_dav_ser._met_insert_servicio(_cls_vo_serv);
            if (_cls_dav_ser._Action != false) {
                for (int x = 0; x < _frm_servicios.dgv_servicios.RowCount - 1; x++) {
                    _cls_vo_serv.Int_tipo_serv = Convert.ToInt32(_frm_servicios.dgv_servicios.Rows[x].Cells[0].Value.ToString());
                    _cls_vo_serv.Str_servicio = _frm_servicios.dgv_servicios.Rows[x].Cells[2].Value.ToString();
                    _cls_vo_serv.Str_costServ = _frm_servicios.dgv_servicios.Rows[x].Cells[4].Value.ToString();
                    _cls_dav_ser._met_insert_serviciodeta(_cls_vo_serv);
                }
                _int_cont = 0;
                _dc_total_cost_serv = 0;
                _met_clean_textbox("insert");
                _met_load_clave_autoincre();
                MessageBoxEx.Show("El servicio se ha insertado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }else{
                MessageBoxEx.Show("Error al insertar el servicio... Verifique los datos","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
