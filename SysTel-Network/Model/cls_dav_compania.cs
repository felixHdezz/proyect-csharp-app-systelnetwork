using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_compania:cls_CRUD
    {
        private static cls_dav_compania _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        public static cls_dav_compania _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_compania();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_clientesCompanias '4','','','','','','','','','','',''");
        }
        public override DataSet _met_select(object _object)
        {
            cls_vo_compania _cls_comp = (cls_vo_compania)_object;
            return _cls_con._met_consu("select * form tbl_clientes_companias where nch_Id_cli_com like('" + _cls_comp.Str_clave + "') or vhc_nom_compania like('"+_cls_comp.Str_clave+"')");
        }
        public override bool _met_insert(object _object) {
            cls_vo_compania _cls_comp = (cls_vo_compania)_object;
            return _cls_con._met_acciones("exec _SP_clientesCompanias '1','" + _cls_comp.Str_clave + "','" + _cls_comp.Str_compa + "','" + _cls_comp.Str_contact + "','" + _cls_comp.Str_carg + "','" + _cls_comp.Str_direc + "','" + _cls_comp.Str_tel + "','" + _cls_comp.Str_email + "','" + _cls_comp.Str_pais + "','" + _cls_comp.Str_estado + "','" + _cls_comp.Str_ciudad + "','" + _cls_comp.Str_cp + "'");
        }
        public override bool _met_update(object _object) {
            cls_vo_compania _cls_comp = (cls_vo_compania)_object;
            return _cls_con._met_acciones("exec _SP_clientesCompanias '2','" + _cls_comp.Str_clave + "','" + _cls_comp.Str_compa + "','" + _cls_comp.Str_contact + "','" + _cls_comp.Str_carg + "','" + _cls_comp.Str_direc + "','" + _cls_comp.Str_tel + "','" + _cls_comp.Str_email + "','" + _cls_comp.Str_pais + "','" + _cls_comp.Str_estado + "','" + _cls_comp.Str_ciudad + "','" + _cls_comp.Str_cp + "'");
        }
        public override bool _met_delete(object _object){
            cls_vo_compania _cls_comp = (cls_vo_compania)_object;
            return _cls_con._met_acciones("exec _SP_clientesCompanias '3','" + _cls_comp.Str_clave + "','" + _cls_comp.Str_compa + "','" + _cls_comp.Str_contact + "','" + _cls_comp.Str_carg + "','" + _cls_comp.Str_direc + "','" + _cls_comp.Str_tel + "','" + _cls_comp.Str_email + "','" + _cls_comp.Str_pais + "','" + _cls_comp.Str_estado + "','" + _cls_comp.Str_ciudad + "','" + _cls_comp.Str_cp + "'");
        }
    }
}
