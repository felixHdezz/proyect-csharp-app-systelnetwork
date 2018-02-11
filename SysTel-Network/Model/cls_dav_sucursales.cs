using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_sucursales : cls_CRUD
    {
        private static cls_dav_sucursales _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        public static cls_dav_sucursales _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_sucursales();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_sucursales 's','','','','',''");
        }
        public override bool _met_insert(object _object) {
            cls_vo_sucursales _cls_suc = (cls_vo_sucursales)_object;
            return _cls_con._met_acciones("exec _SP_sucursales 'i','" + _cls_suc.Str_clv + "','" + _cls_suc.Str_sucur + "','" + _cls_suc.Str_direc + "','" + _cls_suc.Str_tel + "','" + _cls_suc.Str_est_sucu + "' ");
        }
        public override bool _met_update(object _object) {
            cls_vo_sucursales _cls_suc = (cls_vo_sucursales)_object;
            return _cls_con._met_acciones("exec _SP_sucursales 'u','" + _cls_suc.Str_clv + "','" + _cls_suc.Str_sucur + "','" + _cls_suc.Str_direc + "','" + _cls_suc.Str_tel + "','" + _cls_suc.Str_est_sucu + "' ");
        }
        public override bool _met_delete(object _object){
            cls_vo_sucursales _cls_suc = (cls_vo_sucursales)_object;
            return _cls_con._met_acciones("exec _SP_sucursales 'd','" + _cls_suc.Str_clv + "','" + _cls_suc.Str_sucur + "','" + _cls_suc.Str_direc + "','" + _cls_suc.Str_tel + "','" + _cls_suc.Str_est_sucu + "' ");
        }
    }
}
