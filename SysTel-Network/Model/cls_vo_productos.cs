using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_productos
    {
        private static cls_vo_productos _instance;
        public static cls_vo_productos _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_productos();
                }
                return _instance;
            }
        }
        private static string _str_codigo, _str_nom, _str_descrip, _str_mar, _str_cat, _str_prove, str_est_pro;
        private static int _int_exis_uni;
        private static decimal _int_pre_vent, int_pre_comp;
        public string Str_codigo
        {
            get { return _str_codigo; }
            set { _str_codigo = value; }
        }

        public string Str_nom
        {
            get { return _str_nom; }
            set { _str_nom = value; }
        }

        public string Str_descrip
        {
            get { return _str_descrip; }
            set { _str_descrip = value; }
        }

        public string Str_mar
        {
            get { return _str_mar; }
            set { _str_mar = value; }
        }

        public string Str_cat
        {
            get { return _str_cat; }
            set { _str_cat = value; }
        }

        public string Str_prove
        {
            get { return _str_prove; }
            set { _str_prove = value; }
        }

        public string Str_est_pro
        {
            get { return str_est_pro; }
            set { str_est_pro = value; }
        }


        public decimal Int_pre_vent
        {
            get { return _int_pre_vent; }
            set { _int_pre_vent = value; }
        }

        public decimal Int_pre_comp
        {
            get { return int_pre_comp; }
            set { int_pre_comp = value; }
        }

        public int Int_exis_uni
        {
            get { return _int_exis_uni; }
            set { _int_exis_uni = value; }
        }
    }
}
