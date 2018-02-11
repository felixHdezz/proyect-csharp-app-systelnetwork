using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_servicios
    {
        private static cls_dav_servicios _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private SqlDataReader _sqldataread;
        private DataTable _datatable;
        private bool _action;
        public static cls_dav_servicios _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_servicios();
                }
                return _instance;
            }
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread;}
        }
        public DataTable _DataTable {
            get { return _datatable; }
        }
        public bool _Action {
            get { return _action; }
        }
        public void _met_load_clv_auto() {
            _sqldataread = _cls_con._met_data_cunsult("select max(int_id_serv)+1 from tbl_servicios");
        }
        public void _met_load_combobox() {
            _datatable = _cls_con._met_consultas("select * from tbl_tiposServicios");
        }
        public void _met_load_comb_servi_inc(string _str_val) {
            _datatable = _cls_con._met_consultas(" select * from tbl_sub_tipoServ where int_clvserv = '" + _str_val + "'");
        }
        public void _met_load_combo_cost_ser(string _str_ser) {
            _sqldataread = _cls_con._met_data_cunsult("select dc_costo_sub_serv from tbl_sub_tipoServ where int_clv_sub_serv = '" + _str_ser + "'");
        }
        public void _met_load_combo_tip_ca() {
            _datatable = _cls_con._met_consultas("select * from tbl_tipocableado");
        }
        public void _met_serch_cli_com(cls_vo_servicios _cls_ser) {
            _sqldataread = _cls_con._met_data_cunsult("exec _SP_busca_cliest_Serv '" + _cls_ser.Str_clv_cli_com + "'");
        }
        public void _met_insert_servicio(cls_vo_servicios _cls_ser) {
            if (_cls_con._met_acciones("exec _SP_servicios '" + _cls_ser.Int_id_serv + "','" + _cls_ser.Str_fechpedido_ser + "','" + _cls_ser.Str_fechatender_ser + "','" + _cls_ser.Int_tipca + "','" + _cls_ser.Int_cant_serv + "','" + _cls_ser.Str_cost_totalser + "','" + _cls_ser.Str_importe + "','" + _cls_ser.Str_clv_cli_com + "','" + _cls_ser.Str_rfc + "','" + _cls_ser.Str_desti + "','" + _cls_ser.Str_direcdesti + "','" + _cls_ser.Str_estado + "','" + _cls_ser.Str_ciudad + "'")) {
                _action = true;
            }
        }
        public void _met_insert_serviciodeta(cls_vo_servicios _cls_ser) {
            _cls_con._met_acciones("exec _SP_serviciodeta '" + _cls_ser.Int_id_serv + "','" + _cls_ser.Int_tipo_serv + "','" + _cls_ser.Str_servicio + "','" + _cls_ser.Str_costServ + "'");
        }
    }
}
