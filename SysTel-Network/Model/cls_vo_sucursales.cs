using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_sucursales
    {
        private static cls_vo_sucursales _instance;
        public static cls_vo_sucursales _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_sucursales();
                }
                return _instance;
            }
        }
        private static string _str_clv, _str_sucur, _str_direc, _str_tel, _str_est_sucu;

        public string Str_clv
        {
            get { return _str_clv; }
            set { _str_clv = value; }
        }

        public string Str_sucur
        {
            get { return _str_sucur; }
            set { _str_sucur = value; }
        }

        public string Str_direc
        {
            get { return _str_direc; }
            set { _str_direc = value; }
        }

        public string Str_tel
        {
            get { return _str_tel; }
            set { _str_tel = value; }
        }

        public string Str_est_sucu
        {
            get { return _str_est_sucu; }
            set { _str_est_sucu = value; }
        }
    }
}
