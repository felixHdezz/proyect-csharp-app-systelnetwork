using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Controller
{
    class cls_splash
    {
        private View.Frm_splash _frm_splash;
        private int _int_cont = 0;
        public cls_splash(View.Frm_splash _f_splash) {
            _frm_splash = _f_splash;
            _frm_splash.Opacity = 0.83;
            _met_event();
        }
        private void _met_event() {
            _frm_splash.timer1.Tick += new EventHandler(_met_event_timer);
            _mrt_inicializate_progresbar();
        }
        private void _mrt_inicializate_progresbar() {
            _frm_splash.pgb_splash.Maximum = 100;
            _frm_splash.pgb_splash.BackColor = System.Drawing.Color.Red;
            _frm_splash.timer1.Interval = 40;
            _frm_splash.timer1.Enabled = true;
        }
        private void _met_event_timer(object sender, EventArgs e) {
            if (_int_cont < 100){
                _frm_splash.pgb_splash.Value = _int_cont;
                _int_cont++;
            }else {
                _frm_splash.timer1.Enabled = false;
                _frm_splash.Hide();
                View.Frm_login _frm_lgin = new View.Frm_login();
                Controller.cls_login _cont_login = new Controller.cls_login(_frm_lgin);
                _frm_lgin.Show();
            }
        }
    }
}
