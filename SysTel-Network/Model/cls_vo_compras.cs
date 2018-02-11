using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_compras
    {
        private static cls_vo_compras _instance;
        public static cls_vo_compras _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_compras();
                }
                return _instance;
            }
        }
        private static string _str_prove, _str_codigo_pro;
        private static int _int_id_compra, _int_cant_product, _int_cant_uni;
        private static decimal _dc_total_compra;

        public string Str_codigo_pro
        {
            get { return _str_codigo_pro; }
            set { _str_codigo_pro = value; }
        }

        public int Int_id_compra
        {
            get { return _int_id_compra; }
            set { _int_id_compra = value; }
        }

        public int Int_cant_product
        {
            get { return _int_cant_product; }
            set { _int_cant_product = value; }
        }

        public int Int_cant_uni
        {
            get { return _int_cant_uni; }
            set { _int_cant_uni = value; }
        }

        public decimal Dc_total_compra
        {
            get { return _dc_total_compra; }
            set { _dc_total_compra = value; }
        }

        public string Str_prove{
            get { return _str_prove; }
            set { _str_prove = value; }
        }

    }
}
