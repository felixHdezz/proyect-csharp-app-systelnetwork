using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    public class cls_dav_cargos: cls_CRUD
    {
        //public cls_conexion _cls_con = cls_conexion._Instance;
        public cls_conexion _cls_con = cls_conexion._Instance;
        private static cls_dav_cargos _instance;
        public static cls_dav_cargos _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_cargos();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_cargos '4','','','','',''");
        }
        public override bool _met_insert(object ob){
            cls_vo_cargos _cls_carg = (cls_vo_cargos)ob;
            return _cls_con._met_acciones("exec _SP_cargos '1','" + _cls_carg.Str_clv + "','" + _cls_carg.Str_car + "','" + _cls_carg.Str_des + "','" + _cls_carg.Str_sal + "','" + _cls_carg.Str_est + "'");
        }
        public override bool _met_update(object ob){
            cls_vo_cargos _cls_carg = (cls_vo_cargos)ob;
            return _cls_con._met_acciones("exec _SP_cargos '2','" + _cls_carg.Str_clv + "','" + _cls_carg.Str_car + "','" + _cls_carg.Str_des + "','" + _cls_carg.Str_sal + "','" + _cls_carg.Str_est + "'");    
        }
        public override bool _met_delete(object ob){
            cls_vo_cargos _cls_carg = (cls_vo_cargos)ob;
            return _cls_con._met_acciones("exec _SP_cargos '3','" + _cls_carg.Str_clv + "','" + _cls_carg.Str_car + "','" + _cls_carg.Str_des + "','" + _cls_carg.Str_sal + "','" + _cls_carg.Str_est + "'");
        }
    }
}
