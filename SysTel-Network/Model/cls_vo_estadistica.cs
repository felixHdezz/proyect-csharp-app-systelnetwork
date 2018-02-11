using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_estadistica
    {
        private static cls_vo_estadistica _instance;
        public static cls_vo_estadistica _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_estadistica();
                }
                return _instance;
            }
        }
        private static string _str_fech_ini, _str_fech_ter;
        private static string _str_val1;
        private static double _str_val2;

        public string Str_fech_ini
        {
            get { return _str_fech_ini; }
            set { _str_fech_ini = value; }
        }
        public string Str_val1 {
            get { return _str_val1; }
            set { _str_val1 = value; }
        }
        public double Str_val2
        {
            get { return _str_val2; }
            set { _str_val2 = value; }
        }
        public string Str_fech_ter
        {
            get { return _str_fech_ter; }
            set { _str_fech_ter = value; }
        }
    }
}
