using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_con_sucursales
    {
        private static cls_dav_con_sucursales _instance;
        private cls_conexion_servidores _cls_con_serv;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private SqlDataReader _sqldataread;
        private DataTable _datatable;
        public static cls_dav_con_sucursales _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_con_sucursales();
                }
                return _instance;
            }
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public DataTable _DataTable {
            get { return _datatable; }
        }
        public void _met_load_data(cls_vo_con_sucursales _cls_con_suc) {
            _sqldataread =_cls_con._met_data_cunsult("exec _SP_buscaServidor '" + _cls_con_suc._Str_nomServ + "'");
        }
        public void _met_carg_consul_product() {
            _cls_con_serv = new cls_conexion_servidores();
            _datatable = _cls_con_serv._met_consultas("exec _SP_productos '4','','','','','','','0.00','0.00','',''");
        }
        public void _met_carg_ConsultVentas() {
            _cls_con_serv = new cls_conexion_servidores();
            _datatable = _cls_con_serv._met_consultas("exec _SP_conVentas");
        }
        public void _met_carg_datos_product_Max_vendidos() {
            _cls_con_serv = new cls_conexion_servidores();
            _datatable = _cls_con_serv._met_consultas("select * from _view_ventas");
        }
    }
}
