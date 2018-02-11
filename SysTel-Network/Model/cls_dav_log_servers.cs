using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_log_servers
    {
        private static cls_dav_log_servers _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private cls_conexion_servidores _cls_conServ;
        private SqlDataReader _sqldataread;
        private DataTable _datatable;
        private bool _act = false;
        public static cls_dav_log_servers _Instance{
            get {
                if (_instance == null) {
                    _instance = new cls_dav_log_servers();
                }
                return _instance;
            }
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public DataTable _DataTale {
            get { return _datatable; }
        }
        public void _met_load_comb_server() {
            _sqldataread = _cls_con._met_data_cunsult("exec master ..xp_cmdshell 'osql -L'");
        }
        public void _met_load_combx_server() {
            _datatable = _cls_con._met_consultas("exec master ..xp_cmdshell 'osql -L'");
        }
        public bool _met_conect_servers() {
            _cls_conServ = new cls_conexion_servidores();
            if (_cls_conServ._Act == true){
                _act = true;
            }else {
                _act = false;
            }
            return _act;
        }
        public void _met_load_data(cls_vo_log_servers _cls_suc)
        {
            _sqldataread = _cls_con._met_data_cunsult("exec _SP_buscaServidor '" + _cls_suc._Str_nom_serv + "'");
        }
    }
}
