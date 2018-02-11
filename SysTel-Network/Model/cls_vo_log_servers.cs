using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_log_servers
    {
        private static cls_vo_log_servers _instance;
        public static cls_vo_log_servers _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_log_servers();
                }
                return _instance;
            }
        }
        private static string _str_nom_serv, _str_user, _str_pass;
        public string _Str_nom_serv {
            get { return _str_nom_serv; }
            set { _str_nom_serv = value; }
        }
        public string _Str_user {
            get { return _str_user; }
            set { _str_user = value; }
        }
        public string _Str_pass {
            get { return _str_pass; }
            set { _str_pass = value; }
        }
    }
}
