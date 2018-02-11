using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_proveedores : cls_CRUD
    {
        private static cls_dav_proveedores _instance;
        private cls_conexion _con = cls_conexion._Instance;
        public static cls_dav_proveedores _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_proveedores();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _con._met_consult("exec _SP_proveedores '4','','','','','','','',''");
        }
        public override bool _met_insert(object _object) {
            cls_vo_proveedores _cls_prov = (cls_vo_proveedores)_object;
            return _con._met_acciones("exec _SP_proveedores '1','" + _cls_prov.Str_clv_pro + "','" + _cls_prov.Str_nom_pro + "','" + _cls_prov.Str_direc + "','" + _cls_prov.Str_nom_contac + "','" + _cls_prov.Str_carg_contac + "','" + _cls_prov.Str_tel + "','" + _cls_prov.Str_fax + "','" + _cls_prov.Str_estado + "'");
        }
        public override bool _met_update(object _object) {
            cls_vo_proveedores _cls_prov = (cls_vo_proveedores)_object;
            return _con._met_acciones("exec _SP_proveedores '2','" + _cls_prov.Str_clv_pro + "','" + _cls_prov.Str_nom_pro + "','" + _cls_prov.Str_direc + "','" + _cls_prov.Str_nom_contac + "','" + _cls_prov.Str_carg_contac + "','" + _cls_prov.Str_tel + "','" + _cls_prov.Str_fax + "','" + _cls_prov.Str_estado + "'");
        }
        public override bool _met_delete(object _object){
            cls_vo_proveedores _cls_prov = (cls_vo_proveedores)_object;
            return _con._met_acciones("exec _SP_proveedores '3','" + _cls_prov.Str_clv_pro + "','','','','','','',''");
        }
    }
}
