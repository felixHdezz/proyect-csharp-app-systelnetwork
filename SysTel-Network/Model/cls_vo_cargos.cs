using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_cargos
    {
        private static cls_vo_cargos _instance;
        public static cls_vo_cargos _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_cargos();
                }
                return _instance;
            }
        }
        private static string _str_clv, str_car, _str_des, _str_sal, _str_est;

        public string Str_clv
        {
            get { return _str_clv; }
            set { _str_clv = value; }
        }

        public string Str_car
        {
            get { return str_car; }
            set { str_car = value; }
        }

        public string Str_des
        {
            get { return _str_des; }
            set { _str_des = value; }
        }

        public string Str_sal
        {
            get { return _str_sal; }
            set { _str_sal = value; }
        }

        public string Str_est
        {
            get { return _str_est; }
            set { _str_est = value; }
        }
    }
}
