using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_empleados
    {
        private static cls_vo_empleados _instance;
        public static cls_vo_empleados _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_empleados();
                }
                return _instance;
            }
        }
        private static string _str_rfc, _str_nom, _str_ap, _str_am, _str_sexo, _str_curp, _str_tel, _str_email, _str_direc, _str_ciud, _str_est_re, str_carg, _str_depa, _str_est_cli, _str_grado_esc, _str_foto, _str_sucur, _str_user, _str_pass;
        private static string _str_f_nac, _str_f_contra, _str_id;

        public string Str_id
        {
            get { return _str_id; }
            set { _str_id = value; }
        }

        public string Str_user {
            get { return _str_user; }
            set { _str_user = value; }
        }
        public string Str_pass {
            get { return _str_pass; }
            set { _str_pass = value; }
        }
        public string Str_sucur {
            get { return _str_sucur; }
            set { _str_sucur = value; }
        }
        public string Str_grado_esco {
            get { return _str_grado_esc; }
            set { _str_grado_esc = value; }
        }
        public string Str_foto {
            get { return _str_foto; }
            set { _str_foto = value; }
        }
        public string Str_rfc
        {
            get { return _str_rfc; }
            set { _str_rfc = value; }
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

        public string Str_sexo
        {
            get { return _str_sexo; }
            set { _str_sexo = value; }
        }

        public string Str_f_nac
        {
            get { return _str_f_nac; }
            set { _str_f_nac = value; }
        }

        public string Str_f_contra
        {
            get { return _str_f_contra; }
            set { _str_f_contra = value; }
        }
        public string Str_curp
        {
            get { return _str_curp; }
            set { _str_curp = value; }
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

        public string Str_est_re
        {
            get { return _str_est_re; }
            set { _str_est_re = value; }
        }

        public string Str_carg
        {
            get { return str_carg; }
            set { str_carg = value; }
        }

        public string Str_depa
        {
            get { return _str_depa; }
            set { _str_depa = value; }
        }

        public string Str_est_cli
        {
            get { return _str_est_cli; }
            set { _str_est_cli = value; }
        }
    }
}
