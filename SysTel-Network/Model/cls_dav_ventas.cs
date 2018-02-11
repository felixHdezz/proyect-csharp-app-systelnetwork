using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_ventas
    {
        private static cls_dav_ventas _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private SqlDataReader _sqldataread;
        private bool _action = false;
        public static cls_dav_ventas _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_ventas();
                }
                return _instance;
            }
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public bool _Action {
            get { return _action; }
        }
        public void _met_clave_autoincrement() {
            _sqldataread = _cls_con._met_data_cunsult("select max(int_id_vent)+1 from tbl_ventas");
        }
        public void _met_insert_venta(cls_vo_ventas _cls_vent){
            if (_cls_con._met_acciones("exec _SP_ventas '1','" + _cls_vent.Int_id_vent + "','" + _cls_vent.Int_cant_product + "','" + _cls_vent.Dc_total_vent + "','" + _cls_vent.Dc_pago + "','" + _cls_vent.Str_rfc + "','" + _cls_vent.Str_cli + "','','0.00',''")) {
                _action = true;
            }
        }
        public void _met_insert_venta_detalle(cls_vo_ventas _cls_vent){
            _cls_con._met_acciones("exec _SP_ventas '2','" + _cls_vent.Int_id_vent + "','','0.00','0.00','','','" + _cls_vent.Str_codigo + "','" + _cls_vent.Dc_precXuni + "','" + _cls_vent.Int_cant + "'");
        }
    }
}
