using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_dav_compras
    {
        private static cls_dav_compras _instance;
        private cls_conexion _cls_con = cls_conexion._Instance;
        private cls_var_login _cls_var = new cls_var_login();
        private SqlDataReader _sqldataread;
        private DataTable _datatable;
        private bool _action;
        public static cls_dav_compras _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_compras();
                }
                return _instance;
            }
        }
        public DataTable _met_load_combobox() {
            _datatable = _cls_con._met_consultas("select * from tbl_proveedores");
            return _datatable;
        }
        public bool _Action {
            get { return _action; }
        }
        public SqlDataReader _met_clave_automatic() {
            _sqldataread = _cls_con._met_data_cunsult("select max(int_Id_comp)+1 from tbl_compras");
            return _sqldataread;
        }
        public SqlDataReader _met_source_prove(cls_vo_compras _cls_comp){
            _sqldataread = _cls_con._met_data_cunsult("select * from tbl_proveedores where nch_clv_prove = '" + _cls_comp.Str_prove + "'");
            return _sqldataread;
        }
        public void _met_insert_compra(cls_vo_compras _cls_comp) {
            if (_cls_con._met_acciones("exec _SP_compras '1','" + _cls_comp.Int_id_compra + "','" + _cls_comp.Int_cant_product + "','" + _cls_comp.Dc_total_compra + "','" + _cls_comp.Str_prove + "','" + _cls_var._RFC + "','" + _cls_comp.Str_codigo_pro + "','" + _cls_comp.Int_cant_uni + "'")) {
                _action = true;
            }
        }
        public void _met_insert_compra_detalle(cls_vo_compras _cls_comp) {
            if (_cls_con._met_acciones("exec _SP_compras '2','" + _cls_comp.Int_id_compra + "','" + _cls_comp.Int_cant_product + "','" + _cls_comp.Dc_total_compra + "','" + _cls_comp.Str_prove + "','" + _cls_var._RFC + "','" + _cls_comp.Str_codigo_pro + "','" + _cls_comp.Int_cant_uni + "'")) {
                _action = true;
            }
        }
    }
}
