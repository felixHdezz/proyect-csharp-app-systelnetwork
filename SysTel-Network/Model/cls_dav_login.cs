using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_login
    {
        public cls_conexion _cls_con = new cls_conexion();
        public cls_vo_login _cls_vo_login;
        private SqlDataReader _sqldataRead;
        private IDataReader _Idataread;
        private bool _b_action;
        public cls_dav_login(cls_vo_login _cls_v_login){
            _cls_vo_login = _cls_v_login;
        }
        public bool _action {
            get { return _b_action; }
        }
        public SqlDataReader _met_busca_user() {
            _Idataread = _cls_con._Instance._met_busquedas("exec _SP_login '" + _cls_vo_login.Str_rfc + "','" + _cls_vo_login.Str_pass + "'");
            if(_Idataread.Read()){
                _sqldataRead = _cls_con._Instance._met_data_cunsult("exec _SP_login '" + _cls_vo_login.Str_rfc + "','" + _cls_vo_login.Str_pass + "'");
                _b_action = true;
            }
            return _sqldataRead;
        }
    }
}
