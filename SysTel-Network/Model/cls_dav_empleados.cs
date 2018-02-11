using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_dav_empleados :cls_CRUD
    {
        private static cls_dav_empleados _instance;
        cls_conexion _cls_con = cls_conexion._Instance;
        public DataTable _data_table;
        public static cls_dav_empleados _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_dav_empleados();
                }
                return _instance;
            }
        }
        public override SqlDataAdapter _met_select(){
            return _cls_con._met_consult("exec _SP_bus_cliet '1',''");
        }
        public DataTable _met_load_cmb_cargos() {
            _data_table = _cls_con._met_consultas("select * from tbl_cargos");
            return _data_table;
        }
        public SqlDataReader _met_id() {
            return _cls_con._met_data_cunsult("select MAX(id) + 1 from tbl_empleados");
        }
        public DataTable _met_load_cmb_depa(){
            _data_table = _cls_con._met_consultas("select * from tbl_departamentos");
            return _data_table;
        }
        public DataTable _met_load_cmb_socur(){
            _data_table = _cls_con._met_consultas("select * from tbl_sucursales");
            return _data_table;
        }
        public override bool _met_insert(object _object) {
            cls_vo_empleados _cls_emp = (cls_vo_empleados)_object;
            _cls_con._met_acciones("exec _SP_empleado '1','" + _cls_emp.Str_rfc + "','" + _cls_emp.Str_nom + "','" + _cls_emp.Str_ap + "','" + _cls_emp.Str_am + "','" + _cls_emp.Str_sexo + "','" + _cls_emp.Str_f_nac + "','" + _cls_emp.Str_grado_esco + "','" + _cls_emp.Str_curp + "','" + _cls_emp.Str_tel + "','" + _cls_emp.Str_email + "','" + _cls_emp.Str_direc + "','" + _cls_emp.Str_ciud + "','" + _cls_emp.Str_est_re + "','" + _cls_emp.Str_carg + "','" + _cls_emp.Str_depa + "','" + _cls_emp.Str_sucur + "','" + _cls_emp.Str_foto + "','" + _cls_emp.Str_est_cli + "','" + _cls_emp.Str_id + "'");
            return _cls_con._met_acciones("exec _SP_usuer '1','" + _cls_emp.Str_rfc + "','" + _cls_emp.Str_user + "','" + _cls_emp.Str_pass + "'");
        }
        public override bool _met_update(object _object){
            cls_vo_empleados _cls_emp = (cls_vo_empleados)_object;
            _cls_con._met_acciones("exec _SP_empleado '2','" + _cls_emp.Str_rfc + "','" + _cls_emp.Str_nom + "','" + _cls_emp.Str_ap + "','" + _cls_emp.Str_am + "','" + _cls_emp.Str_sexo + "','" + _cls_emp.Str_f_nac + "','" + _cls_emp.Str_grado_esco + "','" + _cls_emp.Str_curp + "','" + _cls_emp.Str_tel + "','" + _cls_emp.Str_email + "','" + _cls_emp.Str_direc + "','" + _cls_emp.Str_ciud + "','" + _cls_emp.Str_est_re + "','" + _cls_emp.Str_carg + "','" + _cls_emp.Str_depa + "','" + _cls_emp.Str_sucur + "','" + _cls_emp.Str_foto + "','" + _cls_emp.Str_est_cli + "','" + _cls_emp.Str_id + "'");
            return _cls_con._met_acciones("exec _SP_usuer '2','" + _cls_emp.Str_rfc + "','" + _cls_emp.Str_user + "','" + _cls_emp.Str_pass + "'");
        }
        public override bool _met_delete(object _object){
            cls_vo_empleados _cls_emp = (cls_vo_empleados)_object;
            return _cls_con._met_acciones("exec _SP_empleados 'd','" + _cls_emp.Str_rfc + "','" + _cls_emp.Str_nom + "','" + _cls_emp.Str_ap + "','" + _cls_emp.Str_am + "','" + _cls_emp.Str_sexo + "','" + _cls_emp.Str_f_nac + "','" + _cls_emp.Str_f_contra + "','" + _cls_emp.Str_grado_esco + "','" + _cls_emp.Str_curp + "','" + _cls_emp.Str_tel + "','" + _cls_emp.Str_email + "','" + _cls_emp.Str_direc + "','" + _cls_emp.Str_ciud + "','" + _cls_emp.Str_est_re + "','" + _cls_emp.Str_carg + "','" + _cls_emp.Str_depa + "','" + _cls_emp.Str_sucur + "','" + _cls_emp.Str_user + "','" + _cls_emp.Str_pass + "','" + _cls_emp.Str_foto + "','" + _cls_emp.Str_est_cli + "'");
        }
    }
}
