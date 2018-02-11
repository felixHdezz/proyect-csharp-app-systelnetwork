using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_ventas
    {
        private static cls_vo_ventas _instance;
        public static cls_vo_ventas _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_ventas();
                }
                return _instance;
            }
        }
        private static string _str_rfc, _str_cli, _str_codigo;
        private static int _int_id_vent, _int_cant_product, _int_cant;
        private static decimal _dc_total_vent, _dc_pago, _dc_precXuni;

        public decimal Dc_total_vent
        {
            get { return _dc_total_vent; }
            set { _dc_total_vent = value; }
        }

        public decimal Dc_pago
        {
            get { return _dc_pago; }
            set { _dc_pago = value; }
        }

        public decimal Dc_precXuni
        {
            get { return _dc_precXuni; }
            set { _dc_precXuni = value; }
        }

        public int Int_id_vent
        {
            get { return _int_id_vent; }
            set { _int_id_vent = value; }
        }

        public int Int_cant_product
        {
            get { return _int_cant_product; }
            set { _int_cant_product = value; }
        }

        public int Int_cant
        {
            get { return _int_cant; }
            set { _int_cant = value; }
        }

        public string Str_rfc
        {
            get { return _str_rfc; }
            set { _str_rfc = value; }
        }

        public string Str_cli
        {
            get { return _str_cli; }
            set { _str_cli = value; }
        }

        public string Str_codigo
        {
            get { return _str_codigo; }
            set { _str_codigo = value; }
        }
    }
}
