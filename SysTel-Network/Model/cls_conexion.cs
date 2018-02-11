using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    public class cls_conexion
    {
        private static cls_conexion _instance;
        public SqlConnection _sql_con;
        private DataSet ds = new DataSet();
        private SqlCommand _comando;
        private SqlDataReader _datos;
        public int i;
        private string _str_cadena = @"data source=USUARIO-PC; initial catalog = db_Systel_Network; integrated security = true";
        public static cls_conexion _Instance{
            get {
                if (_instance == null) {
                    _instance = new cls_conexion();
                }
                return _instance;
            }
        }
        private cls_conexion() {
            _met_conexion();
        }
        private void _met_conexion() {
            _sql_con = new SqlConnection(_str_cadena);
            _sql_con.Open();
        }
        public DataTable _met_consultas(string cadena){
            _met_verifica_con();
            SqlDataAdapter ver = new SqlDataAdapter(cadena, _sql_con);
            DataTable tabla = new DataTable();
            ver.Fill(tabla);
            return tabla;
        }
        public DataSet _met_consu(string cadena)
        {
            _met_verifica_con();
            SqlDataAdapter ver = new SqlDataAdapter(cadena, _sql_con);
            DataSet tabla = new DataSet();
            ver.Fill(tabla);
            return tabla;
        }
        public SqlDataAdapter _met_consult(string cadena) {
            _met_verifica_con();
            SqlDataAdapter ver = new SqlDataAdapter(cadena, _sql_con);
            return ver;
        }
        public bool _met_acciones(string sql){
            bool bandera = false;
            _met_verifica_con();
            _comando = new SqlCommand(sql, _sql_con);
            try{
                i = _comando.ExecuteNonQuery();
                if (i > 0){
                    bandera = true;
                }
            }catch (Exception){
            }
            return bandera;
        }
        public IDataReader _met_busquedas(string sql){
            _met_verifica_con();
            SqlCommand comando = new SqlCommand(sql, _sql_con);
            _datos = comando.ExecuteReader();
            return _datos;
        }
        public SqlDataReader _met_data_cunsult(string sql){
            _met_verifica_con();
            _comando = new SqlCommand(sql, _sql_con);
            _datos = _comando.ExecuteReader();
            return _datos;
        }
        private void _met_verifica_con() {
            if (_datos != null){
                _datos.Close();
            }
        }
    }
}
