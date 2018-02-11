using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_login
    {
        private static cls_vo_login _instance;
        public static cls_vo_login _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_login();
                }
                return _instance;
            }
        }
        private static string _str_rfc, _str_pass;

        public string Str_rfc
        {
            get { return _str_rfc; }
            set { _str_rfc = value; }
        }

        public string Str_pass
        {
            get { return _str_pass; }
            set { _str_pass = value; }
        }
    }
}
