using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_marcas:cls_CRUD
    {
        private static cls_dav_marcas _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        public static cls_dav_marcas _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_marcas();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select() {
            return _cls_con._met_consult("exec _SP_marcas 's','',''");
        }
        public override bool _met_insert(object _object) {
            cls_vo_marcas _cls_marc = (cls_vo_marcas)_object;
            return _cls_con._met_acciones("exec _SP_marcas 'i','" + _cls_marc.Str_clv + "','" + _cls_marc.Str_marc + "'");
        }
        public override bool _met_update(object _object) {
            cls_vo_marcas _cls_marc = (cls_vo_marcas)_object;
            return _cls_con._met_acciones("exec _SP_marcas 'u','" + _cls_marc.Str_clv + "','" + _cls_marc.Str_marc + "'");
        }
        public override bool _met_delete(object _object) {
            cls_vo_marcas _cls_marc = (cls_vo_marcas)_object;
            return _cls_con._met_acciones("exec _SP_marcas 'd','" + _cls_marc.Str_clv + "','" + _cls_marc.Str_marc + "'");
        }
    }
}
