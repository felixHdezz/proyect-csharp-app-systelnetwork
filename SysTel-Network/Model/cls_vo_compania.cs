using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_compania
    {
        private static cls_vo_compania _instance;
        public static cls_vo_compania _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_compania();
                }
                return _instance;
            }
        }
        private static string _str_clave, _str_compa, _str_contact, _str_carg, _str_direc, _str_tel, _str_email, _str_pais, _str_estado, _str_ciudad, _str_cp;
        public string Str_clave
        {
            get { return _str_clave; }
            set { _str_clave = value; }
        }

        public string Str_compa
        {
            get { return _str_compa; }
            set { _str_compa = value; }
        }

        public string Str_contact
        {
            get { return _str_contact; }
            set { _str_contact = value; }
        }

        public string Str_carg
        {
            get { return _str_carg; }
            set { _str_carg = value; }
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

        public string Str_email
        {
            get { return _str_email; }
            set { _str_email = value; }
        }

        public string Str_pais
        {
            get { return _str_pais; }
            set { _str_pais = value; }
        }

        public string Str_estado
        {
            get { return _str_estado; }
            set { _str_estado = value; }
        }

        public string Str_ciudad
        {
            get { return _str_ciudad; }
            set { _str_ciudad = value; }
        }

        public string Str_cp
        {
            get { return _str_cp; }
            set { _str_cp = value; }
        }
    }
}
