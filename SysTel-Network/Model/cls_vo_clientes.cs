using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_clientes
    {
        private static cls_vo_clientes _instance;
        public static cls_vo_clientes _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_clientes();
                }
                return _instance;
            }
        }
        private static string _str_clv_cli, _str_nom, _str_ap, _str_am, _str_tel, _str_email, _str_direc, _str_ciud, _str_est, _str_est_clien;

        public string Str_clv_cli
        {
            get { return _str_clv_cli; }
            set { _str_clv_cli = value; }
        }

        public string Str_nom
        {
            get { return _str_nom; }
            set { _str_nom = value; }
        }

        public string Str_ap
        {
            get { return _str_ap; }
            set { _str_ap = value; }
        }

        public string Str_am
        {
            get { return _str_am; }
            set { _str_am = value; }
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

        public string Str_direc
        {
            get { return _str_direc; }
            set { _str_direc = value; }
        }

        public string Str_ciud
        {
            get { return _str_ciud; }
            set { _str_ciud = value; }
        }

        public string Str_est
        {
            get { return _str_est; }
            set { _str_est = value; }
        }

        public string Str_est_clien
        {
            get { return _str_est_clien; }
            set { _str_est_clien = value; }
        }
    }
}
