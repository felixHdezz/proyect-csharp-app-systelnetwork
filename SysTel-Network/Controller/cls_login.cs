using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Threading;
using DevComponents.DotNetBar.Metro;
using SysTel_Network.Model;
using SysTel_Network.View;

namespace SysTel_Network.Controller
{
    class cls_login
    {
        private Frm_login _frm_login;
        private cls_dav_loginReal _cls_dav_login;
        private cls_vo_login _cls_vo_login = Model.cls_vo_login._Instance;
        private cls_var_login _cls_var_login = new Model.cls_var_login();
        private cls_log _cls_login;
        private int _int_numeroItentos = 0;
        public cls_login(View.Frm_login _f_login) {
            _frm_login = _f_login;
            _cls_dav_login = Model.cls_dav_loginReal._Instance;
            _met_events_();
        }
        private void _met_events_() {
            _frm_login.btn_acceder.Click += new EventHandler(_met_event_clik_acc);
            _frm_login.btn_cancelar.Click += new EventHandler(_met_event_clik_cancel);
            _frm_login.txt_n_rfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_validation_letter);
            _frm_login.txt_pass.Leave += new EventHandler(_met_event_validapassword);
        }
        private void _met_send_data() {
            _cls_vo_login.Str_rfc = _frm_login.txt_n_rfc.Text;
            _cls_vo_login.Str_pass = _frm_login.txt_pass.Text;
        }
        private void _met_event_clik_acc(object sender, EventArgs e) {
            _met_send_data();
            _cls_login = new cls_loginproxy();
            if (_frm_login.txt_n_rfc.Text != "" && _frm_login.txt_pass.Text !="" && _frm_login.txt_pass.TextLength >= 8)
            {
                if (_int_numeroItentos < 3)
                {
                    if (_cls_login._met_RealizaLogin(_cls_vo_login))
                    {
                        if (_cls_var_login._Carg == "Administrador")
                        {
                            _frm_login.Hide();
                            View.Frm_principal _frm_prin = new View.Frm_principal();
                            Controller.cls_principal _cls_con_pr = new cls_principal(_frm_prin);
                            _frm_prin.Show();
                        }
                        if (_cls_var_login._Carg == "Cajero")
                        {
                            _frm_login.Hide();
                            View.Frm_principal _frm_prin = new View.Frm_principal();
                            Controller.cls_principal _cls_con_pr = new cls_principal(_frm_prin);
                            _frm_prin.catalogosToolStripMenuItem.Enabled = false;
                            _frm_prin.catalogosToolStripMenuItem1.Enabled = false;
                            _frm_prin.cONEXIONDBToolStripMenuItem.Enabled = false;
                            _frm_prin.estadisticaToolStripMenuItem.Enabled = false;
                            _frm_prin.Show();
                            View.Frm_ventas _frm_ventas = new View.Frm_ventas();
                            Controller.cls_ventas _cls_con_vent = new Controller.cls_ventas(_frm_ventas);
                            _frm_ventas.MdiParent = _frm_prin;
                            _frm_ventas.Show();
                        }
                    }
                    else
                    {
                        _int_numeroItentos++;
                        MessageBoxEx.Show("Error ! RFC y/o contraseña incorrecta", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    _frm_login.txt_n_rfc.Text = "";
                    _frm_login.txt_pass.Text = "";
                    _frm_login.btn_acceder.Enabled = false;
                    _frm_login.btn_cancelar.Enabled = false;
                    MessageBoxEx.Show("Usted ha realizado mas de 3 intentos. se suspendera temporalmente la sesion", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    Thread.Sleep(50000);
                    _frm_login.btn_acceder.Enabled = true;
                    _frm_login.btn_cancelar.Enabled = true;
                    _frm_login.txt_n_rfc.Focus();
                    _int_numeroItentos = 0;
                }
            }
        }
        private void _met_event_clik_cancel(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }
        private void _met_event_keypres_validation_letter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar)){
                e.KeyChar = char.ToUpperInvariant(e.KeyChar);
            }
        }
        private void _met_event_validapassword(object sender, EventArgs e) {
            if (_frm_login.txt_pass.TextLength < 8) {
                MessageBoxEx.Show("La contraseña debe de tener mas de 8 dijitos", "Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
