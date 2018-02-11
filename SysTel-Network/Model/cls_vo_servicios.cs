using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTel_Network.Model
{
    class cls_vo_servicios
    {
        private static cls_vo_servicios _instance;
        public static cls_vo_servicios _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_servicios();
                }
                return _instance;
            }
        }
        private static string _str_clv_cli_com, _str_fechpedido_ser, _str_fechatender_ser, _str_clv_cli, _str_rfc, _str_desti, _str_direcdesti, _str_estado, _str_ciudad, _str_servicio,_str_cost_totalser, _str_importe, str_costServ;
        private static int _int_id_serv, _int_tipca, _int_cant_serv, _int_tipo_serv;

        public string Str_cost_totalser
        {
            get { return _str_cost_totalser; }
            set { _str_cost_totalser = value; }
        }

        public string Str_importe
        {
            get { return _str_importe; }
            set { _str_importe = value; }
        }

        public string Str_costServ
        {
            get { return str_costServ; }
            set { str_costServ = value; }
        }

        public int Int_id_serv
        {
            get { return _int_id_serv; }
            set { _int_id_serv = value; }
        }

        public int Int_tipca
        {
            get { return _int_tipca; }
            set { _int_tipca = value; }
        }

        public int Int_cant_serv
        {
            get { return _int_cant_serv; }
            set { _int_cant_serv = value; }
        }

        public int Int_tipo_serv
        {
            get { return _int_tipo_serv; }
            set { _int_tipo_serv = value; }
        }
        public string Str_servicio
        {
            get { return _str_servicio; }
            set { _str_servicio = value; }
        }

        public string Str_fechpedido_ser
        {
            get { return _str_fechpedido_ser; }
            set { _str_fechpedido_ser = value; }
        }

        public string Str_fechatender_ser
        {
            get { return _str_fechatender_ser; }
            set { _str_fechatender_ser = value; }
        }

        public string Str_clv_cli
        {
            get { return _str_clv_cli; }
            set { _str_clv_cli = value; }
        }

        public string Str_rfc
        {
            get { return _str_rfc; }
            set { _str_rfc = value; }
        }

        public string Str_desti
        {
            get { return _str_desti; }
            set { _str_desti = value; }
        }

        public string Str_direcdesti
        {
            get { return _str_direcdesti; }
            set { _str_direcdesti = value; }
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

        public string Str_clv_cli_com
        {
            get { return _str_clv_cli_com; }
            set { _str_clv_cli_com = value; }
        }
    }
}
