using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace SysTel_Network.Model
{
    class cls_dav_clientes : cls_CRUD
    {
        private static cls_dav_clientes _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        public static cls_dav_clientes _Instance{
            get {
                if (_instance == null) {
                    _instance = new cls_dav_clientes();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_clientes '4','','','','','','','','','',''");
        }
        public override bool _met_insert(object _object) {
            cls_vo_clientes _cls_client = (cls_vo_clientes)_object;
            return _cls_con._met_acciones("exec _SP_clientes '1','" + _cls_client.Str_clv_cli + "','" + _cls_client.Str_nom + "','" + _cls_client.Str_ap + "','" + _cls_client.Str_am + "','" + _cls_client.Str_tel + "','" + _cls_client.Str_email + "','" + _cls_client.Str_direc + "','" + _cls_client.Str_ciud + "','" + _cls_client.Str_est + "','" + _cls_client.Str_est_clien + "'");
        }
        public override bool _met_update(object _object){
            cls_vo_clientes _cls_client = (cls_vo_clientes)_object;
            return _cls_con._met_acciones("exec _SP_clientes '2','" + _cls_client.Str_clv_cli + "','" + _cls_client.Str_nom + "','" + _cls_client.Str_ap + "','" + _cls_client.Str_am + "','" + _cls_client.Str_tel + "','" + _cls_client.Str_email + "','" + _cls_client.Str_direc + "','" + _cls_client.Str_ciud + "','" + _cls_client.Str_est + "','" + _cls_client.Str_est_clien + "'");
        }
        public override bool _met_delete(object _object){
            cls_vo_clientes _cls_client = (cls_vo_clientes)_object;
            return _cls_con._met_acciones("exec _SP_clientes '3','" + _cls_client.Str_clv_cli + "','" + _cls_client.Str_nom + "','" + _cls_client.Str_ap + "','" + _cls_client.Str_am + "','" + _cls_client.Str_tel + "','" + _cls_client.Str_email + "','" + _cls_client.Str_direc + "','" + _cls_client.Str_ciud + "','" + _cls_client.Str_est + "','" + _cls_client.Str_est_clien + "'");
        }
    }
}
