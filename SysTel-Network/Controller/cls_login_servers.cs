using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevComponents.DotNetBar;

namespace SysTel_Network.Controller
{
    class cls_login_servers
    {
        private View.Frm_login_servers _frm_log_servers;
        private View.Frm_conexiones _frm_conSucu;
        private Model.cls_dav_log_servers _cls_dav_log_serv;
        private Model.cls_var_login _cls_var = new Model.cls_var_login();
        private Model.cls_vo_log_servers _cls_vo_conServ = Model.cls_vo_log_servers._Instance;
        //private cls_con_sucursales _cls_conSucu;
        private SqlDataReader _SqlDataRead;
        private DataTable _DataTable = new DataTable();
        private int _int_cont = 0,_int_logtd_cad = 0;
        public cls_login_servers(View.Frm_login_servers _f_servers,View.Frm_conexiones _frm_conSu) {
            _frm_log_servers = _f_servers;
            _frm_conSucu = _frm_conSu;
            //_cls_conSucu = new cls_con_sucursales(_frm_conSucu);
            _cls_dav_log_serv = Model.cls_dav_log_servers._Instance;
            
            _met_event_click();
        }
        private void _met_event_click() {
            _met_load_combobox_servers();
            _frm_log_servers.cmb_autentific.Enabled = false;
            _frm_log_servers.btn_conect.Click += new EventHandler(_met_event_click_btn_conect);
        }
        private void _met_load_combobox_servers() {
            _cls_dav_log_serv._met_load_comb_server();
            _SqlDataRead = _cls_dav_log_serv._SqlDataRead;
            _DataTable.Columns.Add("output");
            while (_SqlDataRead.Read())
            {
                _int_cont++;
                if (_int_cont > 2)
                {
                    if (_SqlDataRead["output"].ToString() != "")
                    {
                        _int_logtd_cad = _SqlDataRead["output"].ToString().Length;
                        _DataTable.Rows.Add(_SqlDataRead["output"].ToString().Substring(3, _int_logtd_cad - 3));
                    }
                }
            }
            _frm_log_servers.cmb_name_servers.DataSource = _DataTable;
            _frm_log_servers.cmb_name_servers.DisplayMember = "output";
        }
        private void _met_event_click_btn_conect(object sender, EventArgs e) {
            _cls_vo_conServ._Str_nom_serv = _frm_log_servers.cmb_name_servers.Text;
            _cls_vo_conServ._Str_user = _frm_log_servers.txt_users_name.Text;
            _cls_vo_conServ._Str_pass = _frm_log_servers.txt_password.Text;
            if (_cls_dav_log_serv._met_conect_servers() == true) {
                MessageBoxEx.Show("Servidor conectado al sistema","Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                _cls_var._Str_nomServ = _frm_log_servers.cmb_name_servers.Text;
                _cls_var.EstadoServ = true;
                _frm_log_servers.Hide();
                _cls_vo_conServ._Str_nom_serv = _cls_var._Str_nomServ;
                _cls_dav_log_serv._met_load_data(_cls_vo_conServ);
                _SqlDataRead = _cls_dav_log_serv._SqlDataRead;
                _frm_conSucu.lbl_estado_serv.Text = "Conectado";
                _frm_conSucu.lbl_estado_serv.ForeColor = System.Drawing.Color.Lime;
                while (_SqlDataRead.Read())
                {
                    _frm_conSucu.txt_serv.Text = _cls_var._Str_nomServ;
                    _frm_conSucu.txt_nom_su.Text = _SqlDataRead[0].ToString().ToUpper();
                    _frm_conSucu.txt_dir.Text = _SqlDataRead[1].ToString().ToUpper();
                    _frm_conSucu.txt_tel.Text = _SqlDataRead[2].ToString().ToUpper();
                    _frm_conSucu.txt_estado.Text = _SqlDataRead[3].ToString();
                }
            }else{
                MessageBoxEx.Show("Error al conectar al servidor", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
