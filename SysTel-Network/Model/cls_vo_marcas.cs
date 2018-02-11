using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_marcas
    {
        private static cls_vo_marcas _instance;
        public static cls_vo_marcas _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_marcas();
                }
                return _instance;
            }
        }
        private static string _str_clv, _str_marc;

        public string Str_clv
        {
            get { return _str_clv; }
            set { _str_clv = value; }
        }

        public string Str_marc
        {
            get { return _str_marc; }
            set { _str_marc = value; }
        }

    }
}
