using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_con_sucursales
    {
        private static cls_vo_con_sucursales _instance;
        public static cls_vo_con_sucursales __instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_con_sucursales();
                }
                return _instance;
            }
        }
        private static string _str_nomServ;
        public string _Str_nomServ {
            get { return _str_nomServ; }
            set { _str_nomServ = value; }
        }
    }
}
