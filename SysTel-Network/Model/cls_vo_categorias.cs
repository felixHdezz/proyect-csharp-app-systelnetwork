using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_categorias
    {
        private static cls_vo_categorias _instance;
        public static cls_vo_categorias _Instance{
            get {
                if (_instance == null) {
                    _instance = new cls_vo_categorias();
                }
                return _instance;
            }
        }
        private static string _str_clv, _str_cat, _str_des;

        public string Str_clv
        {
            get { return _str_clv; }
            set { _str_clv = value; }
        }

        public string Str_cat
        {
            get { return _str_cat; }
            set { _str_cat = value; }
        }

        public string Str_des
        {
            get { return _str_des; }
            set { _str_des = value; }
        }
    }
}
