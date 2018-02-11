using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using DevComponents.DotNetBar.Metro;
using System.Data.SqlClient;
using System.Data;
using itextsharp;
using itextsharp.pdfa;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace SysTel_Network.Controller
{
    class cls_estadistica
    {
        private View.Frm_estadistica _frm_estadistica;
        private Model.cls_dav_estadistica _cls_dav_estadis;
        private Model.cls_vo_estadistica _cls_vo_estadis = Model.cls_vo_estadistica._Instance;
        private SqlDataReader _SqlDataRead;
        private DataTable _DataTable = new DataTable();
        private double _db_tam_muestra= 0,_db_errormues,_num_clase,_rango,_anchura;
        private decimal _dc_tam_muestra = 0, _int_num_interv, _sum_media, _media, _sum_f, _varianza, _desv_esntad;
        private int _int_poblacion = 0, _int_cont = 0, _int_cont_dat = 0, _int_val = 0, _int_aux = 0,_int_n_acum, _int_sum_fre;
        private static int[] _array,_array2;
        private string[] _ArrayTi = new string[5];
        private bool _act = false;
        private static int _int_contpdf = 0;
        private Random _ran = new Random();
        private string _str_conclusio1;
        private string _str_conclusio2;
        public cls_estadistica(View.Frm_estadistica _f_estad) {
            _frm_estadistica = _f_estad;
            _frm_estadistica.cmb_nivelConfianza.Text = "95%";
            _frm_estadistica.cmb_nivelConfianza.Enabled = false;
            _frm_estadistica.txt_poblacion.Enabled = false;
            _frm_estadistica.txt_tam_muestra.Enabled = false;
            _cls_dav_estadis = Model.cls_dav_estadistica._Instance;
            _met_event_click();
            _met_Initialize_grafics();
        }
        private void _met_Initialize_grafics() {
            _frm_estadistica.chart_histogram.Series.Add("Barra");
            _frm_estadistica.chart_histogram.Series[0].IsVisibleInLegend = false;
            for (int x = 0; x < 5; x++){
                _frm_estadistica.chart_histogram.Series[0].Points.AddY(x);
                _frm_estadistica.chart_histogram.Series[0].Palette = ChartColorPalette.BrightPastel;
            }
            _frm_estadistica.chart_distrubution_normal.Series.Add("line");
            _frm_estadistica.chart_distrubution_normal.Series[0].IsVisibleInLegend = false;
            for (int x = 0; x < 5; x++)
            {
                _frm_estadistica.chart_distrubution_normal.Series[0].Points.AddXY(x,x);
                //_frm_estadistica.chart_distrubution_normal.Series[0].Palette = ChartColorPalette.BrightPastel;
                _frm_estadistica.chart_distrubution_normal.Series[0].ChartType = SeriesChartType.Line;
                _frm_estadistica.chart_distrubution_normal.Series[0].Color = System.Drawing.Color.White;
            }
        }
        private void _met_event_click() {
            _ArrayTi[0] = "Cableado de alto nivel se seguridad";
            _ArrayTi[1] = "Cableado de cobre";
            _ArrayTi[2] = "Cableado de fibra optica";
            _ArrayTi[3] = "Cableado UTP";
            _ArrayTi[4] = "Cableado por trenzado";
            _frm_estadistica.dt_fecha_ter.TextChanged += new EventHandler(_met_event_click_dt_termino);
            _frm_estadistica.cmb_error_muestra.SelectionChangeCommitted += new EventHandler(_met_event_click_cmb_error_mues);
            _frm_estadistica.btn_load_data.Click += new EventHandler(_met_event_click_load_datagridview);
            _frm_estadistica.btn_grafic.Click += new EventHandler(_met_load_gafric);
            _frm_estadistica.btn_normalDistri.Click += new EventHandler(_met_event_click_btn_losd_chsrd_normalDis);
            _frm_estadistica.cmb_val_x.SelectionChangeCommitted += new EventHandler(_met_event_click_cmb_val_x);
            _frm_estadistica.btn_pdf.Click += new EventHandler(_met_event_click_btn_pdf);
            _frm_estadistica.txt_val1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_txtval1);
            _frm_estadistica.txt_val2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_txtval1);
            _met_enable_txt();
        }
        private void _met_enable_txt() {
            _frm_estadistica.txt_anchura.Enabled = false;
            _frm_estadistica.txt_des_estad.Enabled = false;
            _frm_estadistica.txt_dis_nor_d_estd.Enabled = false;
            _frm_estadistica.txt_dis_nor_media.Enabled = false;
            _frm_estadistica.txt_media.Enabled = false;
            _frm_estadistica.txt_mediana.Enabled = false;
            _frm_estadistica.txt_moda.Enabled = false;
            _frm_estadistica.txt_num_clases.Enabled = false;
            _frm_estadistica.txt_poblacion.Enabled = false;
            _frm_estadistica.txt_probalilibad.Enabled = false;
            _frm_estadistica.txt_rango.Enabled = false;
            _frm_estadistica.txt_sum_f.Enabled = false;
            _frm_estadistica.txt_sum_frecuencia.Enabled = false;
            _frm_estadistica.txt_sum_media.Enabled = false;
            _frm_estadistica.txt_tam_muestra.Enabled = false;
            _frm_estadistica.txt_val_z.Enabled = false;
            _frm_estadistica.txt_val1.Enabled = false;
            _frm_estadistica.txt_val2.Enabled = false;
            _frm_estadistica.txt_varianza.Enabled = false;
        }
        private void _met_event_click_dt_termino(object sender, EventArgs e) {
            _int_cont = 0;
            _int_cont_dat = 0;
            _cls_vo_estadis.Str_fech_ini = _frm_estadistica.dt_fecha_ini.Text;
            _cls_vo_estadis.Str_fech_ter = _frm_estadistica.dt_fecha_ter.Text;
            _cls_dav_estadis._met_load_data_poblacion(_cls_vo_estadis);
            _SqlDataRead = _cls_dav_estadis._SqlDataRead;
            while (_SqlDataRead.Read()){
                //_array[_int_cont] = Convert.ToInt32(_SqlDataRead[0]);
                _int_cont++;
            }
            _cls_dav_estadis._met_load_data_poblacion(_cls_vo_estadis);
            _SqlDataRead = _cls_dav_estadis._SqlDataRead;
            _array = new int[_int_cont];
            while(_SqlDataRead.Read()){
                _array[_int_cont_dat] = Convert.ToInt32(_SqlDataRead[0]);
                _int_cont_dat++;
            }
            _frm_estadistica.txt_poblacion.Text = _int_cont.ToString();
        }
        private void _met_event_click_cmb_error_mues(object sender, EventArgs e) { 
            if(_frm_estadistica.cmb_error_muestra.Text == "1%"){
                _db_errormues = 0.01;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "2%"){
                _db_errormues = 0.02;
            }
            if (_frm_estadistica.cmb_error_muestra.Text == "3%") {
                _db_errormues = 0.03;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "4%"){
                _db_errormues = 0.04;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "5%"){
                _db_errormues = 0.05;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "6%"){
                _db_errormues = 0.06;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "7%"){
                _db_errormues = 0.07;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "8%"){
                _db_errormues = 0.08;
            }
            if(_frm_estadistica.cmb_error_muestra.Text == "9%"){
                _db_errormues = 0.09;
            }
            _int_poblacion = Convert.ToInt32(_frm_estadistica.txt_poblacion.Text);
            _db_tam_muestra = (_int_poblacion * (Math.Pow(0.5, 2)) * (Math.Pow(1.96, 2))) / ((_int_poblacion - 1) * (Math.Pow(_db_errormues, 2)) + Math.Pow(0.5, 2) * (Math.Pow(1.96, 2)));
            _dc_tam_muestra = decimal.Round(Convert.ToDecimal(_db_tam_muestra), 0, MidpointRounding.AwayFromZero);
            _frm_estadistica.txt_tam_muestra.Text = _dc_tam_muestra.ToString();
        }
        private void _met_event_click_load_datagridview(object sender, EventArgs e) {
            _frm_estadistica.dgv_datos_esta.Rows.Clear();
            decimal _tam_data = decimal.Round(_dc_tam_muestra / 12,0,MidpointRounding.ToEven);
            _array2 = new int[Convert.ToInt32(_dc_tam_muestra)];
            for (int x = 0; x < _dc_tam_muestra; x++){
                _int_val = _ran.Next(0, _array.Length);
                _array2[x] = _array[_int_val];
            }
            _int_val = 0;
             //Metodo burbuja
            for (int x = 0; x < _array2.Length; x++){
                for (int y = 0; y < _array2.Length - 1; y++){
                    if (_array2[y] > _array2[y + 1]){
                        _int_aux = _array2[y];
                        _array2[y] = _array2[y + 1];
                        _array2[y + 1] = _int_aux;
                    }
                }
            }
            if ((_tam_data * 12) < _dc_tam_muestra) {
                _tam_data += 1;
            }
            for (int x = 0; x < _tam_data; x++){
                x = _frm_estadistica.dgv_datos_esta.Rows.Add();
                for (int y = 0; y < 12; y++){
                    if (_int_val < _array2.Length){
                        _frm_estadistica.dgv_datos_esta.Rows[x].Cells[y].Value = _array2[_int_val].ToString();
                    }
                    _int_val++;
                }
            }
            _met_load_table_distribution_frecu();
        }
        private void _met_load_table_distribution_frecu() {
            _frm_estadistica.dgv_distrub_frec.Rows.Clear();
            _int_sum_fre = 0;
            _media = 0;
            _sum_f = 0;
            _sum_media = 0;
            _varianza = 0;
            _desv_esntad = 0;
            _num_clase = Convert.ToDouble(decimal.Round(Convert.ToDecimal(1 + 3.3 * Math.Log10(_array2.Length - 1)),0,MidpointRounding.AwayFromZero));
            _rango = _array2[_array2.Length - 1] - _array2[0];
            _anchura = Convert.ToDouble(decimal.Round(Convert.ToDecimal(_rango / _num_clase),2,MidpointRounding.AwayFromZero));
            _frm_estadistica.txt_num_clases.Text = _num_clase.ToString();
            _frm_estadistica.txt_rango.Text = _rango.ToString();
            _frm_estadistica.txt_anchura.Text = _anchura.ToString();
            _int_num_interv = _array2[0];
            for (int x = 0; x < _num_clase; x++) {
                x = _frm_estadistica.dgv_distrub_frec.Rows.Add();
                for (int y = 0; y < 8; y++) {
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[0].Value = x + 1;
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[1].Value = Convert.ToString(_int_num_interv + "-" + (_int_num_interv + Convert.ToDecimal(_anchura)));
                    for (int z = 0; z < _array2.Length; z++)  {
                        if (_array2[z] >= _int_num_interv && _array2[z] <= _int_num_interv + Convert.ToDecimal(_anchura)) {
                            _int_n_acum++;
                        }
                    }
                    if (x > 1) {
                        if (Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[x - 1].Cells[2].Value) == _int_n_acum)
                        {
                            _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value = "0";
                        }else{
                            _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value = _int_n_acum;
                        }
                    }else{
                        _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value = _int_n_acum;
                    }
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[3].Value = Convert.ToString(decimal.Round((_int_num_interv + (_int_num_interv + Convert.ToDecimal(_anchura)))/2,2));
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[4].Value = Convert.ToString(decimal.Round(Convert.ToDecimal(Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value) * Convert.ToDecimal( _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[3].Value)),2));
                    _int_n_acum = 0;
                }
                if (x + 1 == _num_clase){
                    if ((_int_num_interv + Convert.ToDecimal(_anchura)) < Convert.ToDecimal(_array2[_array2.Length -1]))
                    {
                        _num_clase = _num_clase + 1;
                    }
                }
                _int_sum_fre += Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value);
                //_sum_media += Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[4].Value);
                _int_num_interv = _int_num_interv + Convert.ToDecimal(_anchura);
            }
            _frm_estadistica.txt_sum_frecuencia.Text = _int_sum_fre.ToString();
            //_frm_estadistica.txt_sum_media.Text = _sum_media.ToString();
            _met_sum_media();
            _met_calcula_media();
            _met_calcula_moda();
            _met_calcula_mediana();
        }
        private void _met_sum_media() {
            for (int x = 0; x < _num_clase; x++) {
                _sum_media += Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[4].Value);
            }
            _frm_estadistica.txt_sum_media.Text = _sum_media.ToString();
            _media = decimal.Round(_sum_media / _dc_tam_muestra, 2);
            _frm_estadistica.txt_media.Text = _media.ToString();
        }
        private void _met_calcula_media() {
            for (int x = 0; x < _num_clase; x++){
                _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[5].Value = decimal.Round(Convert.ToDecimal(Math.Pow(Convert.ToDouble(Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[3].Value) - _media), 2)),2).ToString();
                _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[6].Value = decimal.Round(Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[5].Value) * Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value),2).ToString();
                _sum_f += Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[6].Value);
                if (x == 0) {
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[7].Value = _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value.ToString();
                }else{
                    _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[7].Value = Convert.ToString(Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x - 1].Cells[7].Value) + Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value));
                }
            }
            _frm_estadistica.txt_sum_f.Text = _sum_f.ToString();
            _varianza = _sum_f / (_dc_tam_muestra - 1);
            _frm_estadistica.txt_varianza.Text = decimal.Round(_varianza,2).ToString();
            _desv_esntad = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(_varianza)));
            _frm_estadistica.txt_des_estad.Text = decimal.Round(_desv_esntad,2).ToString();
            _frm_estadistica.txt_dis_nor_media.Text = _frm_estadistica.txt_media.Text;
            _frm_estadistica.txt_dis_nor_d_estd.Text = _frm_estadistica.txt_des_estad.Text;
        }
        private void _met_calcula_mediana() {
            decimal _media_fre = 0, _media_interv = 0, _interv_1, _interv_2,_fa,_mediana;
            if (_num_clase > 7){
                _media_fre = (Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3].Cells[2].Value) + Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[4].Cells[2].Value) / 2);
                _interv_1 = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3].Cells[1].Value.ToString().Substring(0, 4));
                _interv_2 = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[4].Cells[1].Value.ToString().Substring(0, 4));
                _fa = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3 -1].Cells[7].Value);
                _media_interv = (_interv_1 + _interv_2) / 2;
            }else {
                _media_fre = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3].Cells[2].Value);
                _media_interv = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3].Cells[1].Value.ToString().Substring(0, 4));
                _fa = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[3 - 1].Cells[7].Value);
            }
            _frm_estadistica.dgv_distrub_frec.Rows[3].DefaultCellStyle.BackColor = System.Drawing.Color.Lime;
            _mediana = ((((Convert.ToInt32(_frm_estadistica.txt_tam_muestra.Text) + 1) / 2) - (_fa - 1)) / _media_fre) * Convert.ToDecimal(_frm_estadistica.txt_anchura.Text) + _media_interv;
            _mediana = decimal.Round(_mediana, 2);
            _frm_estadistica.txt_mediana.Text = _mediana.ToString();
        }
        private void _met_calcula_moda() {
            decimal _moda = 0, _int_lm =0;
            int _int_num_max = 0, _int_fila = 0, _int_d1, _int_d2; 
            for (int x = 0; x < _num_clase; x++) {
                if (Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value) > _int_num_max) {
                    _int_num_max = Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value);
                    _int_fila = x;
                }
            }
            _frm_estadistica.dgv_distrub_frec.Rows[_int_fila].DefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            if (_frm_estadistica.dgv_distrub_frec.Rows[_int_fila].Cells[1].Value.ToString().Length <= 5){
                _int_lm = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila].Cells[1].Value.ToString().Substring(0, 3));
            }else{
                _int_lm = Convert.ToDecimal(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila].Cells[1].Value.ToString().Substring(0, 4));
            }
            _int_d1 = Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila].Cells[2].Value) - Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila + 1].Cells[2].Value);
            _int_d2 = Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila].Cells[2].Value) - Convert.ToInt32(_frm_estadistica.dgv_distrub_frec.Rows[_int_fila - 1].Cells[2].Value);
            _moda = _int_lm + (_int_d1 / (_int_d1 + _int_d2)) * Convert.ToDecimal(_anchura);
            _moda = decimal.Round(_moda, 2);
            _frm_estadistica.txt_moda.Text = _moda.ToString();
        }
        private void _met_load_gafric(object sender, EventArgs e) {
            _frm_estadistica.chart_histogram.Series.Clear();
            _frm_estadistica.chart_histogram.Update();
            _frm_estadistica.chart_histogram.Series.Add("Barra");
            _frm_estadistica.chart_histogram.Series.Add("Frecuencia");
            _frm_estadistica.chart_histogram.Series[0].IsVisibleInLegend = false;
            _frm_estadistica.chart_histogram.Series[1].IsVisibleInLegend = false;
            _frm_estadistica.chart_histogram.Series["Frecuencia"].IsVisibleInLegend = false;
            for (int x = 0; x < _num_clase; x++) {
                _frm_estadistica.chart_histogram.Series[0].Points.AddXY(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[1].Value.ToString(), _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value.ToString());
                _frm_estadistica.chart_histogram.Series[0].Palette = ChartColorPalette.BrightPastel;
                _frm_estadistica.chart_histogram.Series[1].Points.AddXY(_frm_estadistica.dgv_distrub_frec.Rows[x].Cells[1].Value.ToString(), _frm_estadistica.dgv_distrub_frec.Rows[x].Cells[2].Value.ToString());
                _frm_estadistica.chart_histogram.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                _frm_estadistica.chart_histogram.Series[1].Color = System.Drawing.Color.Red;
                _frm_estadistica.chart_histogram.Series[1].BorderWidth = 2;
            }
            _str_conclusio1 = "El promedio de la encuesta aplicada de los tipos de cableado mas solicidato por el cliente es de "+_frm_estadistica.txt_media.Text +" y se dispersa un total de "+_frm_estadistica.txt_dis_nor_d_estd;
            MessageBoxEx.Show(""+_str_conclusio1,"Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
        }
        private void _met_event_click_btn_losd_chsrd_normalDis(object sender, EventArgs e) {
            decimal _val1, _val2 = 0;
            if (_frm_estadistica.txt_val2.Enabled == false) {
                _act = false;
                _val1 = (Convert.ToDecimal(_frm_estadistica.txt_val1.Text) - Convert.ToDecimal(_frm_estadistica.txt_dis_nor_media.Text)) / Convert.ToDecimal(_frm_estadistica.txt_dis_nor_d_estd.Text);
                _val1 = decimal.Round(Convert.ToDecimal(_val1), 2);
                if (_val1 > 0) {
                    if (_val1.ToString().Length < 4) {
                        _val1 = Convert.ToDecimal(_val1 + "0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 3));
                    _cls_vo_estadis.Str_val1 = ".0"+_val1.ToString().Substring(3,1);
                    _cls_dav_estadis._met_busca_Zpositivo(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read()) {
                        _frm_estadistica.txt_val_z.Text = _SqlDataRead[0].ToString();
                    }
                }else{
                    if (_val1.ToString().Length <= 4) {
                        _val1 = Convert.ToDecimal(_val1 + "0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 4));
                    _cls_vo_estadis.Str_val1 = ".0" + _val1.ToString().Substring(4, 1);
                    _cls_dav_estadis._met_busca_Znegativa(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read()){
                        _frm_estadistica.txt_val_z.Text = _SqlDataRead[0].ToString();
                    }
                }
                if (_frm_estadistica.cmb_val_x.SelectedIndex == 1){
                    _frm_estadistica.txt_probalilibad.Text = Convert.ToString(100 -(Convert.ToDouble(_frm_estadistica.txt_val_z.Text) * 100)) + "%";
                }else {
                    _frm_estadistica.txt_probalilibad.Text = Convert.ToString(Convert.ToDouble(_frm_estadistica.txt_val_z.Text) * 100) + "%";
                }
            }else{
                _act = true;
                double _z1 = 0, _z2 = 0, _result = 0;
                _val1 = (Convert.ToDecimal(_frm_estadistica.txt_val1.Text) - Convert.ToDecimal(_frm_estadistica.txt_dis_nor_media.Text)) / Convert.ToDecimal(_frm_estadistica.txt_dis_nor_d_estd.Text);
                _val2 = (Convert.ToDecimal(_frm_estadistica.txt_val2.Text) - Convert.ToDecimal(_frm_estadistica.txt_dis_nor_media.Text)) / Convert.ToDecimal(_frm_estadistica.txt_dis_nor_d_estd.Text);
                _val1 = Convert.ToDecimal(decimal.Round(Convert.ToDecimal(_val1), 2));
                _val2 = Convert.ToDecimal(decimal.Round(Convert.ToDecimal(_val2), 2));
                if (_val1 > 0){
                    if (_val1.ToString().Length < 4) {
                        _val1 = Convert.ToDecimal(_val1 +"0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 3));
                    _cls_vo_estadis.Str_val1 = ".0" + _val1.ToString().Substring(3, 1);
                    _cls_dav_estadis._met_busca_Zpositivo(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read()){
                        _z1 = Convert.ToDouble(_SqlDataRead[0]);
                    }
                }else {
                    if (_val1.ToString().Length <= 4){
                        _val1 = Convert.ToDecimal(_val1 + "0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 4));
                    _cls_vo_estadis.Str_val1 = ".0" + _val1.ToString().Substring(4, 1);
                    _cls_dav_estadis._met_busca_Znegativa(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read()){
                        _z1 = Convert.ToDouble(_SqlDataRead[0]);
                    }
                }
                if (_val2 > 0) {
                    if (_val2.ToString().Length < 4){
                        _val2 = Convert.ToDecimal(_val2 + "0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 3));
                    _cls_vo_estadis.Str_val1 = ".0" + _val2.ToString().Substring(3, 1);
                    _cls_dav_estadis._met_busca_Zpositivo(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read())
                    {
                        _z2 = Convert.ToDouble(_SqlDataRead[0]);
                    }
                } else {
                    if (_val2.ToString().Length <= 4){
                        _val2 = Convert.ToDecimal(_val2 + "0");
                    }
                    _cls_vo_estadis.Str_val2 = double.Parse(_val1.ToString().Substring(0, 4));
                    _cls_vo_estadis.Str_val1 = ".0" + _val2.ToString().Substring(4, 1);
                    _cls_dav_estadis._met_busca_Znegativa(_cls_vo_estadis);
                    _SqlDataRead = _cls_dav_estadis._SqlDataRead;
                    while (_SqlDataRead.Read()){
                        _z2 = Convert.ToDouble(_SqlDataRead[0]);
                    }
                }
                _result = _z2 - _z1;
                _frm_estadistica.txt_val_z.Text = _result.ToString();
                _frm_estadistica.txt_probalilibad.Text = Convert.ToString(_result * 100)+"%";
            }
            double _tamArray = Convert.ToDouble(_frm_estadistica.txt_dis_nor_media.Text) * 2;
            double _dd = 0;
            double[,] _ArrayD = new double[Convert.ToInt32(_tamArray * 5),2];
            for (int x = 0; x < _ArrayD.Length / 2; x++) { 
                _dd = _dd + 0.2;
                _ArrayD[x, 0] = _dd;
                _ArrayD[x, 1] = _met_NormsDist(_dd,Convert.ToDouble(_frm_estadistica.txt_dis_nor_media.Text),Convert.ToDouble(_frm_estadistica.txt_dis_nor_d_estd.Text));
            }
            double _dEst = Convert.ToDouble(_frm_estadistica.txt_dis_nor_d_estd.Text);
            _frm_estadistica.chart_distrubution_normal.Series.Clear();
            if (_act != true){
                _frm_estadistica.chart_distrubution_normal.Series.Add("Area");
                _frm_estadistica.chart_distrubution_normal.Series.Add("col");
                _frm_estadistica.chart_distrubution_normal.Series[0].IsVisibleInLegend = false;
                _frm_estadistica.chart_distrubution_normal.Series[1].IsVisibleInLegend = false;
                _frm_estadistica.chart_distrubution_normal.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                double _acum = 0;
                for (int x = 0; x < _ArrayD.Length / 2; x++){
                    _acum = _acum + 0.2;
                    if (_frm_estadistica.cmb_val_x.SelectedIndex == 0){
                        _frm_estadistica.chart_distrubution_normal.Series[0].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                        if (_acum <= Convert.ToDouble(_frm_estadistica.txt_val1.Text) + 0.1){
                            _frm_estadistica.chart_distrubution_normal.Series[1].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                            _frm_estadistica.chart_distrubution_normal.Series[1].Color = System.Drawing.Color.Lime;
                        }
                        _str_conclusio2 = "Existe una probabilidad de " + _frm_estadistica.txt_probalilibad.Text + " de que la preferencia de tipo de cableaado sea al menos de "+_frm_estadistica.txt_val1.Text +" paquetes";
                    }
                    if (_frm_estadistica.cmb_val_x.SelectedIndex == 1){
                        _frm_estadistica.chart_distrubution_normal.Series[0].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                        _frm_estadistica.chart_distrubution_normal.Series[1].Color = System.Drawing.Color.Lime;
                        if (_acum <= Convert.ToDouble(_frm_estadistica.txt_val1.Text) + 0.1){
                            _frm_estadistica.chart_distrubution_normal.Series[1].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                        }
                        _str_conclusio2 = "Existe una probabilidad de " + _frm_estadistica.txt_probalilibad.Text + " de que la preferencia de tipo de cableado sea a lo mas  de " + _frm_estadistica.txt_val1.Text + " paquetes";
                    }
                    _frm_estadistica.chart_distrubution_normal.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    //_frm_estadistica.chart_distrubution_normal.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
                }
                MessageBoxEx.Show("" + _str_conclusio2, "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }else{
                _frm_estadistica.chart_distrubution_normal.Series.Add("Area");
                _frm_estadistica.chart_distrubution_normal.Series.Add("col");
                _frm_estadistica.chart_distrubution_normal.Series.Add("serie2");
                _frm_estadistica.chart_distrubution_normal.Series[0].IsVisibleInLegend = false;
                _frm_estadistica.chart_distrubution_normal.Series[1].IsVisibleInLegend = false;
                _frm_estadistica.chart_distrubution_normal.Series[2].IsVisibleInLegend = false;
                double _acum = 0;
                for (int x = 0; x < _ArrayD.Length / 2; x++){
                    _acum = _acum + 0.2;
                    _frm_estadistica.chart_distrubution_normal.Series[0].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                    if (_acum <= Convert.ToDouble(_frm_estadistica.txt_val2.Text) + 0.1){
                        _frm_estadistica.chart_distrubution_normal.Series[1].Points.AddY(_ArrayD[x, 1]);
                    }
                    if (_acum <= Convert.ToDouble(_frm_estadistica.txt_val1.Text) + 0.1){
                        _frm_estadistica.chart_distrubution_normal.Series[2].Points.AddXY(_acum.ToString(), _ArrayD[x, 1]);
                    }
                    _frm_estadistica.chart_distrubution_normal.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    _frm_estadistica.chart_distrubution_normal.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    _frm_estadistica.chart_distrubution_normal.Series[1].Color = System.Drawing.Color.Lime;
                    _frm_estadistica.chart_distrubution_normal.Series[2].Color = System.Drawing.Color.Orange;
                    _frm_estadistica.chart_distrubution_normal.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                _str_conclusio2 = "Existe una probalilidad de: " + _frm_estadistica.txt_probalilibad.Text + " de que los clientes eligan el tipo de cableado entre: " +_frm_estadistica.txt_val1.Text+" y "+_frm_estadistica.txt_val2.Text;
                MessageBoxEx.Show(""+_str_conclusio2, "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private double _met_NormsDist(double _x,double _media,double _DesStd) {
            double _val;
            _val = (1 / ((Math.Sqrt(2 * Math.PI)) * _DesStd)) * Math.Exp(-(Math.Pow(_x - _media, 2)) / (2 * (_DesStd * _DesStd)));
            return _val;
        }
        private void _met_event_click_cmb_val_x(object sender, EventArgs e) {
            if (_frm_estadistica.cmb_val_x.SelectedIndex != 2){
                _frm_estadistica.txt_val1.Enabled = true;
                _frm_estadistica.txt_val2.Enabled = false;
            } else {
                _frm_estadistica.txt_val1.Enabled = true;
                _frm_estadistica.txt_val2.Enabled = true;
            }
        }
        private void _met_event_click_btn_pdf(object sender, EventArgs e){
            _int_contpdf++;
            Document _pdf = new Document(iTextSharp.text.PageSize.LETTER,10,10,10,10);
            string _fecha = System.DateTime.Today.Day.ToString()+""+System.DateTime.Today.Month.ToString()+""+System.DateTime.Today.Year.ToString();
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Visual Studio 2012\\Projects\\SysTel-Network\\SysTel-Network\\pdf\\RPED"+_fecha+".pdf";
            FileStream _file = new FileStream(filename,FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
            PdfWriter _wri = PdfWriter.GetInstance(_pdf,_file);
            _pdf.Open();
            Image _img = Image.GetInstance("Logo.png");
            //_img.SetAbsolutePosition(50, 710);
            _img.IndentationLeft = 60f;
            _img.PaddingTop = 80f;
            _img.ScalePercent(55f);
            Paragraph _parag = new Paragraph("                                                                                                    ");
            Paragraph _parag2, _parag3,_parag4,_parag5,_parag6,_parag7,_parag8,_parag9,_parag10,_parag11,_parag12,_parag13,_parag14;
            _parag2 = new Paragraph("                                      Tipos de instalaciones de cableado mas solicitados por el cliente");
            _parag4 = new Paragraph("                      Datos                                                                                  Tipos de cableado");
            _parag5 = new Paragraph("            N = Tamaño de poblacion : "+_frm_estadistica.txt_poblacion.Text+"                                       1.- Cableado de alto nivel de seguridad  ");
            _parag6 = new Paragraph("            a = Desviacion estandar    : 0.5                                        2.- Cableado coaxial                     ");
            _parag7 = new Paragraph("            z = Nivel de confianza       : "+_frm_estadistica.cmb_nivelConfianza.Text + "                                      3.- Cableado de fibra optica             ");
            _parag8 = new Paragraph("            e = Error muestral             : "+_frm_estadistica.cmb_error_muestra.Text + "                                        4.- Cableado UTP                         ");
            _parag9 = new Paragraph("            n = Tamaño muestral        : "+ _frm_estadistica.txt_tam_muestra.Text + "                                         5.- Cableado por trenzado                ");
            
            _parag11 = new Paragraph("                                                                                                             ");
            PdfPTable _table = new PdfPTable(_frm_estadistica.dgv_distrub_frec.Columns.Count);
            _table.PaddingTop = 400f;
            _table.HorizontalAlignment = Element.ALIGN_CENTER;
            for (int x = 0; x < _frm_estadistica.dgv_distrub_frec.Columns.Count; x++)
            {
                _table.AddCell(new Phrase(_frm_estadistica.dgv_distrub_frec.Columns[x].HeaderText));
            }
            _table.HeaderRows = 1;
            for (int x = 0; x < _frm_estadistica.dgv_distrub_frec.Rows.Count -1; x++)
            {
                for (int y = 0; y < _frm_estadistica.dgv_distrub_frec.Columns.Count; y++)
                {
                    _table.AddCell(new Phrase(_frm_estadistica.dgv_distrub_frec[y, x].Value.ToString()));
                }
            }
            _parag3 = new Paragraph("                                                                                   ");
            _parag10 = new Paragraph("               No. clase  : "+_frm_estadistica.txt_num_clases.Text+"                        Media                        : "+_frm_estadistica.txt_media.Text+"                    Mediana  : "+_frm_estadistica.txt_mediana.Text+"");
            _parag14 = new Paragraph("               Rango      : "+_frm_estadistica.txt_rango.Text+"                        Varianza                    : "+_frm_estadistica.txt_varianza.Text+"                    Moda       : "+_frm_estadistica.txt_moda.Text+"");
            _parag12 = new Paragraph("               Anchura   : "+_frm_estadistica.txt_anchura.Text+"                    Desviacion estandar : "+_frm_estadistica.txt_des_estad.Text+"   ");
            _parag13 = new Paragraph("_________________________________________________________________________________");
            _parag13.Alignment = Element.ALIGN_CENTER;
            //grafica de Histrograma y poligono de frecuencia
            Paragraph _para = new Paragraph("                                                ");
            Paragraph _p = new Paragraph("               Histograma y poligono de frecuencia");
            var charimg = new MemoryStream();
            _frm_estadistica.chart_histogram.SaveImage(charimg, ChartImageFormat.Png);
            Image _chart_img = Image.GetInstance(charimg.GetBuffer());
            _chart_img.IndentationLeft = 70f;
            _chart_img.ScaleToFit(400, 300);
            _chart_img.Alignment = Element.ALIGN_JUSTIFIED;
            Paragraph _para2 = new Paragraph("                                                ");
            Paragraph _para3 = new Paragraph("               Conclusion: "+_str_conclusio1+"");
            //grafica de distribucion normal
            Paragraph _para1 = new Paragraph("                                                ");
            Paragraph _para6 = new Paragraph("                                                ");
            Paragraph _p1 = new Paragraph("               Grafica de distribucion normal");
            var charimg2 = new MemoryStream();
            _frm_estadistica.chart_distrubution_normal.SaveImage(charimg2, ChartImageFormat.Png);
            Image _chart_img2 = Image.GetInstance(charimg2.GetBuffer());
            _chart_img2.IndentationLeft = 70f;
            _chart_img2.ScaleToFit(400, 300);
            _chart_img2.Alignment = Element.ALIGN_JUSTIFIED;
            Paragraph _para4 = new Paragraph("                                                ");
            Paragraph _para5 = new Paragraph("               Conclusion: " + _str_conclusio2 + "");

            //end grafica
            _pdf.Add(_img);
            _pdf.Add(_parag);
            _pdf.Add(_parag2);
            _pdf.Add(_parag4);
            _pdf.Add(_parag5);
            _pdf.Add(_parag6);
            _pdf.Add(_parag7);
            _pdf.Add(_parag8);
            _pdf.Add(_parag9);
            _pdf.Add(_parag11);
            _pdf.Add(_table);
            _pdf.Add(_parag3);
            _pdf.Add(_parag10);
            _pdf.Add(_parag14);
            _pdf.Add(_parag12);
            _pdf.Add(_parag13);
            _pdf.Add(_para);
            _pdf.Add(_p);
            _pdf.Add(_chart_img);
            _pdf.Add(_para2);
            _pdf.Add(_para3);
            _pdf.Add(_para1);
            _pdf.Add(_para6);
            _pdf.Add(_p1);
            _pdf.Add(_chart_img2);
            _pdf.Add(_para4);
            _pdf.Add(_para5);
            _pdf.Close();
            System.Diagnostics.Process.Start(filename);
        }
        private void _met_event_keypres_txtval1(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back)
            {
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
    }
}