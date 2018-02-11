using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SysTel_Network.Model
{
    class cls_conexion_servidores
    {
        //private cls_conexion_servidores _instance;
        private cls_vo_log_servers _cls_vo_conServ = new cls_vo_log_servers();
        public SqlConnection _sql_con;
        private DataSet ds = new DataSet();
        private SqlCommand _comando;
        private SqlDataReader _datos;
        public int i;
        private bool _act = false;
        //public cls_conexion_servidores _Instance {
        //    get {
        //        if (_instance == null) {
        //            _instance = new cls_conexion_servidores();
        //        }
        //        return _instance;
        //    }
        //}
        public cls_conexion_servidores(){
            _met_con_serv();
        }
        public bool _Act {
            get { return _act; }
        }
        public void _met_con_serv(){
            try{
                string _con = @"data source=" + _cls_vo_conServ._Str_nom_serv + "; initial catalog = db_Systel_Network; user id=" + _cls_vo_conServ._Str_user + "; password =" + _cls_vo_conServ._Str_pass + "";
                _sql_con = new SqlConnection(_con);
                _sql_con.Close();
                _sql_con.Open();
                _act = true;
            }catch (Exception ex) {
                ex.ToString();
                _act = false;
            }
        }
        public bool _met_acciones(string sql){
            bool bandera = false;
            if (_datos != null){
                _datos.Close();
            }
            _comando = new SqlCommand(sql, _sql_con);
            try{
                i = _comando.ExecuteNonQuery();
                if (i > 0){
                    bandera = true;
                }
            }
            catch (Exception){
            }
            return bandera;
        }
        public DataTable _met_consultas(string cadena)
        {
            if (_datos != null)
            {
                _datos.Close();
            }
            SqlDataAdapter ver = new SqlDataAdapter(cadena, _sql_con);
            DataTable tabla = new DataTable();
            ver.Fill(tabla);
            return tabla;
        }
        public IDataReader _met_busquedas(string sql){
            if (_datos != null){
                _datos.Close();
            }
            SqlCommand comando = new SqlCommand(sql, _sql_con);
            _datos = comando.ExecuteReader();
            return _datos;
        }
        public SqlDataReader _met_data_cunsult(string sql){
            if (_datos != null){
                _datos.Close();
            }
            _comando = new SqlCommand(sql, _sql_con);
            _datos = _comando.ExecuteReader();
            return _datos;
        }
    }
}
