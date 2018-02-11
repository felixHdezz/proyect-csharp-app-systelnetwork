using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_categorias: cls_CRUD
    {
        private static cls_dav_categorias _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        public static cls_dav_categorias _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_categorias();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_categorias 's','','',''");
        }
        public override bool _met_insert(object _object){
            cls_vo_categorias _cls_cat = (cls_vo_categorias)_object;
            return _cls_con._met_acciones("exec _SP_categorias 'i','" + _cls_cat.Str_clv + "','" + _cls_cat.Str_cat + "','" + _cls_cat.Str_des + "'");
        }
        public override bool _met_update(object _object){
            cls_vo_categorias _cls_cat = (cls_vo_categorias)_object;
            return _cls_con._met_acciones("exec _SP_categorias 'u','" + _cls_cat.Str_clv + "','" + _cls_cat.Str_cat + "','" + _cls_cat.Str_des + "'");
        }
        public override bool _met_delete(object _object){
            cls_vo_categorias _cls_cat = (cls_vo_categorias)_object;
            return _cls_con._met_acciones("exec _SP_categorias 'd','" + _cls_cat.Str_clv + "','" + _cls_cat.Str_cat + "','" + _cls_cat.Str_des + "'");
        }
    }
}
