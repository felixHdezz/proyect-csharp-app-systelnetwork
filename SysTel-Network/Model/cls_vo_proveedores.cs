using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_proveedores
    {
        private static cls_vo_proveedores _instance;
        public static cls_vo_proveedores _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_proveedores();
                }
                return _instance;
            }
        }
        private static string str_clv_pro, str_nom_pro, str_nom_contac, str_carg_contac, str_tel, _str_fax, str_direc, str_estado;

        public string Str_clv_pro
        {
            get { return str_clv_pro; }
            set { str_clv_pro = value; }
        }

        public string Str_nom_pro
        {
            get { return str_nom_pro; }
            set { str_nom_pro = value; }
        }

        public string Str_nom_contac
        {
            get { return str_nom_contac; }
            set { str_nom_contac = value; }
        }

        public string Str_carg_contac
        {
            get { return str_carg_contac; }
            set { str_carg_contac = value; }
        }

        public string Str_tel
        {
            get { return str_tel; }
            set { str_tel = value; }
        }

        public string Str_fax
        {
            get { return _str_fax; }
            set { _str_fax = value; }
        }

        public string Str_direc
        {
            get { return str_direc; }
            set { str_direc = value; }
        }

        public string Str_estado
        {
            get { return str_estado; }
            set { str_estado = value; }
        }
    }
}
