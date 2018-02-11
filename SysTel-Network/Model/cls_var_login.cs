using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_var_login
    {
        private static string _str_rfc;
        private static string _str_nom_empl;
        private static string _str_carg;
        private static int _int_clave_venta;
        private static string _str_nomserv;
        private static bool _estadoServ;

        public bool EstadoServ{
            get { return cls_var_login._estadoServ; }
            set { cls_var_login._estadoServ = value; }
        } 

        public int Int_clave_venta{
            get { return cls_var_login._int_clave_venta; }
            set { cls_var_login._int_clave_venta = value; }
        }
        public string _RFC {
            get { return _str_rfc; }
            set { _str_rfc = value; }
        }
        public string _Nom_empl {
            get { return _str_nom_empl; }
            set { _str_nom_empl = value; }
        }
        public string _Carg {
            get { return _str_carg; }
            set { _str_carg = value; }
        }
        public string _Str_nomServ {
            get { return _str_nomserv; }
            set { _str_nomserv = value; }
        }
    }
}
