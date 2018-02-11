using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_loginReal : cls_log
    {
        private static cls_dav_loginReal _instance;
        public cls_conexion _cls_con = cls_conexion._Instance;
        private cls_var_login _cls_var_log = new cls_var_login();
        private SqlDataReader _sqldataRead;
        private bool _b_action;
        public static cls_dav_loginReal _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_loginReal();
                }
                return _instance;
            }
        }
        public bool _action {
            get { return _b_action; }
        }
        public override bool _met_RealizaLogin(object _object){
            cls_vo_login _cls_log = (cls_vo_login)_object;
            if (_met_CompruebaLogin(_cls_log)) {
                _sqldataRead = _cls_con._met_data_cunsult("exec _SP_login '" + _cls_log.Str_rfc + "','" + _cls_log.Str_pass + "'");
                while (_sqldataRead.Read()) {
                    _cls_var_log._RFC = _sqldataRead.GetString(0);
                    _cls_var_log._Nom_empl = _sqldataRead.GetString(3);
                    _cls_var_log._Carg = _sqldataRead.GetString(4);
                }
                _b_action = true;
            }
            return _b_action;
        }
        public override bool _met_CompruebaLogin(object _object){
            cls_vo_login _cls_log = (cls_vo_login)_object;
            return _cls_con._met_busquedas("exec _SP_login '" + _cls_log.Str_rfc + "','" + _cls_log.Str_pass + "'").Read();
        }
    }
}
