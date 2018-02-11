using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_estadistica
    {
        private static cls_dav_estadistica _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private SqlDataReader _sqldataread;
        public static cls_dav_estadistica _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_estadistica();
                }
                return _instance;
            }
        }
        public SqlDataReader _SqlDataRead {
            get { return _sqldataread; }
        }
        public void _met_load_data_poblacion(cls_vo_estadistica _cls_esta) {
            _sqldataread = _cls_con._met_data_cunsult("exec _SP_estadistica_busca_datos '" + _cls_esta.Str_fech_ini + "','" + _cls_esta.Str_fech_ter + "'");
        }
        public void _met_busca_Zpositivo(cls_vo_estadistica _cls_esta) {
            _sqldataread = _cls_con._met_data_cunsult("select ['" + _cls_esta.Str_val1 + "'] from tbl_PuntuacionesZpositivas where z = '" + _cls_esta.Str_val2 + "'");
        }
        public void _met_busca_Znegativa(cls_vo_estadistica _cls_esta) {
            _sqldataread = _cls_con._met_data_cunsult("select ['" + _cls_esta.Str_val1 + "'] from tbl_PuntuacionesZnegativas where z = '" + _cls_esta.Str_val2 + "'");
        }
    }
}
