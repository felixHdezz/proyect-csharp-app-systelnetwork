using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_lista_clientes
    {
        private static cls_dav_lista_clientes _instance; 
        cls_conexion _cls_con = cls_conexion._Instance;
        private SqlDataReader _SqlDataRead;
        public static cls_dav_lista_clientes _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_lista_clientes();
                }
                return _instance;
            }
        }
        public SqlDataReader _Sqldataread {
            get { return _SqlDataRead; }
        }
        public void _met_load_datagridview() {
            _SqlDataRead = _cls_con._met_data_cunsult("exec _SP_clientes '4','','','','','','','','','',''");
        }
    }
}
