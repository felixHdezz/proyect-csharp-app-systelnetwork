using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_productos : cls_CRUD
    {
        private static cls_dav_productos _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private DataTable _datatable;
        public static cls_dav_productos _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_productos();
                }
                return _instance;
            }
        }
        public DataTable _met_load_combobox_marcas() {
            _datatable = _cls_con._met_consultas("select * from tbl_marcas");
            return _datatable;
        }
        public DataTable _met_load_combobox_cat() { 
            _datatable = _cls_con._met_consultas("select * from tbl_categorias");
            return _datatable;
        }
        public DataTable _met_load_combobox_provee() {
            _datatable = _cls_con._met_consultas("select * from tbl_proveedores");
            return _datatable;
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_productos '4','','','','','','','0.00','0.00','',''");
        }
        public override bool _met_insert(object _object) {
            cls_vo_productos _cls_prod = (cls_vo_productos)_object;
            return _cls_con._met_acciones("exec _SP_productos '1','" + _cls_prod.Str_codigo + "','" + _cls_prod.Str_nom + "','" + _cls_prod.Str_descrip + "','" + _cls_prod.Str_mar + "','" + _cls_prod.Str_cat + "','" + _cls_prod.Str_prove + "','" + _cls_prod.Int_pre_vent + "','" + _cls_prod.Int_pre_comp + "','" + _cls_prod.Int_exis_uni + "','" + _cls_prod.Str_est_pro + "'");
        }
        public override bool _met_update(object _object){
            cls_vo_productos _cls_prod = (cls_vo_productos)_object;
            return _cls_con._met_acciones("exec _SP_productos '2','" + _cls_prod.Str_codigo + "','" + _cls_prod.Str_nom + "','" + _cls_prod.Str_descrip + "','" + _cls_prod.Str_mar + "','" + _cls_prod.Str_cat + "','" + _cls_prod.Str_prove + "','" + _cls_prod.Int_pre_vent + "','" + _cls_prod.Int_pre_comp + "','" + _cls_prod.Int_exis_uni + "','" + _cls_prod.Str_est_pro + "'");
        }
        public override bool _met_delete(object _object) {
            cls_vo_productos _cls_prod = (cls_vo_productos)_object;
            return _cls_con._met_acciones("exec _SP_productos '3','" + _cls_prod.Str_codigo + "','" + _cls_prod.Str_nom + "','" + _cls_prod.Str_descrip + "','" + _cls_prod.Str_mar + "','" + _cls_prod.Str_cat + "','" + _cls_prod.Str_prove + "','" + _cls_prod.Int_pre_vent + "','" + _cls_prod.Int_pre_comp + "','" + _cls_prod.Int_exis_uni + "','" + _cls_prod.Str_est_pro + "'");
        }
    }
}
