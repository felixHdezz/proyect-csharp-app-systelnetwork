using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    public abstract class cls_aggregate
    {
        public abstract cls_Iterador CreateIterador();
    }
    public class cls_ConcreteAggregate : cls_aggregate {
        public DataSet _dataset;
        public SqlDataAdapter _DataAdapter;
        public string _dataremenber;
        public int _cantxpage;
        public cls_ConcreteAggregate(SqlDataAdapter _dataadapter,string  _str_datarember, int _cantxp) {
            this._DataAdapter = _dataadapter;
            this._dataremenber = _str_datarember;
            this._cantxpage = _cantxp;
        }
        public override cls_Iterador CreateIterador(){
            return new cls_ConcreteIterador(this);
        }
    }
    public class cls_ConcreteIterador : cls_Iterador {
        private SqlDataAdapter _DataAdapter;
        private int _inicio = 0;
        private int _tope = 0;
        private static int _numeroPagina = 1;
        private int _cantidadRegistros = 0;
        private int _ultimaPagina = 0;
        private String _datamember;
        private DataSet _datos;
        public cls_ConcreteIterador(cls_ConcreteAggregate _dataadapter){
            this._DataAdapter = _dataadapter._DataAdapter;
            this._datamember = _dataadapter._dataremenber;
            this._tope = _dataadapter._cantxpage;
        }
        public override DataSet _met_LoadData() {
            DataTable auxiliar;
            this._datos = new DataSet();
            auxiliar = new DataTable();
            this._DataAdapter.Fill(_datos, _inicio, _tope,_datamember);
            _DataAdapter.Fill(auxiliar);
            this._cantidadRegistros = auxiliar.Rows.Count;
            asignarTope();
            return _datos;
        }
        private void asignarTope()
        {
            _ultimaPagina = _cantidadRegistros / _tope;
            int aux = _cantidadRegistros % _tope;
            if (_ultimaPagina == 0){
                this._ultimaPagina = 1;
            }
            else if (_ultimaPagina >= 1 && (aux > 0)){
                this._ultimaPagina = _ultimaPagina + 1;
            }
            _numeroPagina = 1;
        }
        public override DataSet _met_FirstPage(){
            _numeroPagina = 1;
            this._inicio = 0;
            this._datos.Clear();
            this._DataAdapter.Fill(this._datos, this._inicio, this._tope, this._datamember);
            return _datos;
        }
        public override DataSet _met_LastPage(){
            _numeroPagina = _ultimaPagina;
            this._inicio = (_ultimaPagina - 1) * _tope;
            this._datos.Clear();
            this._DataAdapter.Fill(this._datos, this._inicio, this._tope, this._datamember);
            return _datos;
        }
        public override DataSet _met_PreviousPage(){
            if (_numeroPagina == 1){
                return _datos;
            }
            _numeroPagina--;
            this._inicio = _inicio - _tope;
            this._datos.Clear();
            this._DataAdapter.Fill(this._datos, this._inicio, this._tope, this._datamember);
            return _datos;
        }
        public override DataSet _met_NextPage() {
            if (this._ultimaPagina == _numeroPagina){
                return _datos;
            }
            _numeroPagina++;
            this._inicio = _inicio + _tope;
            this._datos.Clear();
            this._DataAdapter.Fill(this._datos, this._inicio, _tope, this._datamember);
            return _datos;
        }
        public DataSet actualizaTope(int i_tope){
            this._tope = i_tope;
            this._inicio = 0;
            asignarTope();
            _datos.Clear();
            this._DataAdapter.Fill(this._datos, this._inicio, _tope, this._datamember);
            return _datos;
        }
        public override int _met_countRow(){
            return _cantidadRegistros;
        }
        public override int _met_numPag() {
            return _numeroPagina;
        }
        public override int _met_lastpage(){
            return _ultimaPagina;
        }
    }
}
