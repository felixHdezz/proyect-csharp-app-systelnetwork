using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;      
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevComponents.WinForms;

namespace SysTel_Network.Controller
{
    class cls_con_sucursales
    {
        private View.Frm_conexiones _frm_con_serv;
        private Model.cls_var_login _cls_var_log = new Model.cls_var_login();
        private Model.cls_dav_con_sucursales _cls_dav_conSu;
        private Model.cls_vo_con_sucursales _cls_vo_conSuc = Model.cls_vo_con_sucursales.__instance;
        private ButtonX _btn_actualizar = new ButtonX();
        DataGridViewX _dgv_consult_product = new DataGridViewX();
        DataGridViewX _dgv_consult_ventas = new DataGridViewX();
        private DataTable _DataTable;
        public cls_con_sucursales(View.Frm_conexiones _frm_con_ser) {
            _frm_con_serv = _frm_con_ser;
            _cls_dav_conSu = Model.cls_dav_con_sucursales._Instance;
            _met_event_clik();
        }
        private void _met_event_clik() {
            _frm_con_serv.tcontrol.CloseButtonOnTabsVisible = true;
            _frm_con_serv.lbl_estado_serv.Text = "Desconectado";
            _frm_con_serv.lbl_estado_serv.ForeColor = System.Drawing.Color.Red;
            _met_enable_txt();
            _met_load_data();
            _frm_con_serv.btn_consul_product.Click += new EventHandler(_met_event_click_btn_consult_produc);
            _frm_con_serv.btn_consul_ventas.Click += new EventHandler(_met_event_click_btn_consul_ventas);
            _frm_con_serv.btn_grafic_ventas.Click += new EventHandler(_met_event_click_btn_grafic_ventas);
            _btn_actualizar.Click += new EventHandler(_met_update_table);
            _frm_con_serv.pb_closed.Click += new EventHandler(_met_event_click_pb_cerrar);
            _frm_con_serv.pb_conect.Click += new EventHandler(_met_event_click_pb_log);
        }
        private void _met_enable_txt() {
            _frm_con_serv.txt_serv.Enabled = false;
            _frm_con_serv.txt_nom_su.Enabled = false;
            _frm_con_serv.txt_dir.Enabled = false;
            _frm_con_serv.txt_tel.Enabled = false;
            _frm_con_serv.txt_estado.Enabled = false;
        }
        public void _met_load_data() {
            //if (_cls_var_log.EstadoServ != true){
            //    _frm_con_serv.lbl_estado_serv.Text = "Desconectado";
            //    _frm_con_serv.lbl_estado_serv.ForeColor = System.Drawing.Color.Red;
            //}else {
            //    _frm_con_serv.lbl_estado_serv.Text = "Conectado";
            //    _frm_con_serv.lbl_estado_serv.ForeColor = System.Drawing.Color.Lime;
            //    _cls_vo_conSuc._Str_nomServ = _cls_var_log._Str_nomServ;
            //    _cls_dav_conSu._met_load_data();
            //    _SqlDataRead = _cls_dav_conSu._SqlDataRead;
            //    while (_SqlDataRead.Read())
            //    {
            //        _frm_con_serv.txt_serv.Text = _cls_var_log._Str_nomServ;
            //        _frm_con_serv.txt_nom_su.Text = _SqlDataRead[0].ToString().ToUpper();
            //        _frm_con_serv.txt_dir.Text = _SqlDataRead[1].ToString().ToUpper();
            //        _frm_con_serv.txt_tel.Text = _SqlDataRead[2].ToString().ToUpper();
            //        _frm_con_serv.txt_estado.Text = _SqlDataRead[3].ToString();
            //    }
            //}
        }
        private void _met_event_click_btn_consult_produc(object sender, EventArgs e) {
            if (_frm_con_serv.tcontrol.SelectedTab.Name == "item1")
            {
                _frm_con_serv.tcontrol.Tabs.Remove(0);
            }
            else { 
                
            } 
            _frm_con_serv.tcontrol.CreateTab("Consulta de producto");
            foreach (SuperTabItem _items in _frm_con_serv.tcontrol.Tabs){
                _frm_con_serv.tcontrol.SelectedTab = _items;
            }
            //ButtonX _btn_actualizar = new ButtonX();
            _btn_actualizar.Size = new System.Drawing.Size(110, 32);
            _btn_actualizar.Left = 1040;
            _btn_actualizar.Top = 20;
            _btn_actualizar.Text = "Actualizar";
            _btn_actualizar.Name = "btn_actualizar";
            
            _dgv_consult_product.Top = 70;
            _dgv_consult_product.Margin.Left.Equals(10);
            _dgv_consult_product.Width = 1158;
            _dgv_consult_product.Height = 410;
            _dgv_consult_product.RowHeadersVisible = false;
            _cls_dav_conSu._met_carg_consul_product();
            _DataTable = _cls_dav_conSu._DataTable;
            _dgv_consult_product.DataSource = _DataTable;

            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_btn_actualizar);
            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_dgv_consult_product);
            _frm_con_serv.btn_consul_ventas.Focus();
        }
        private void _met_update_table(object sender, EventArgs e) {
            MessageBoxEx.Show("");
            _cls_dav_conSu._met_carg_consul_product();
            _DataTable = _cls_dav_conSu._DataTable;
            _dgv_consult_product.DataSource = _DataTable;
        }
        private void _met_event_click_btn_consul_ventas(object sender, EventArgs e) {
            if (_frm_con_serv.tcontrol.SelectedTab.Name == "item1")
            {
                _frm_con_serv.tcontrol.Tabs.Remove(0);
            }
            _frm_con_serv.tcontrol.CreateTab("Consulta de ventas");
            foreach (SuperTabItem _items in _frm_con_serv.tcontrol.Tabs)
            {
                _frm_con_serv.tcontrol.SelectedTab = _items;
            }
            _dgv_consult_ventas.Top = 15;
            _dgv_consult_ventas.Left = 5;
            _dgv_consult_ventas.Margin.Left.Equals(10);
            _dgv_consult_ventas.Width = 1150;
            _dgv_consult_ventas.Height = 465;
            _dgv_consult_ventas.RowHeadersVisible = false;
            _cls_dav_conSu._met_carg_ConsultVentas();
            _DataTable = _cls_dav_conSu._DataTable;
            _dgv_consult_ventas.DataSource = _DataTable;
            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_dgv_consult_ventas);
        }
        private void _met_event_click_btn_grafic_ventas(object sender, EventArgs e) {
            if (_frm_con_serv.tcontrol.SelectedTab.Name == "item1") {
                _frm_con_serv.tcontrol.Tabs.Remove(0);
            }
            _frm_con_serv.tcontrol.CreateTab("Grafica de ventas");
            foreach (SuperTabItem _items in _frm_con_serv.tcontrol.Tabs){
                _frm_con_serv.tcontrol.SelectedTab = _items;
            }
            _frm_con_serv.tcontrol.SelectedPanel.CanvasColor = System.Drawing.Color.Transparent;
            Label _lbl_text = new Label();
            _lbl_text.BackColor = System.Drawing.Color.Transparent;
            //_lbl_text.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _lbl_text.Text = "Productos mas vendidos";
            _lbl_text.Size = new System.Drawing.Size(200,23);
            _lbl_text.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            _lbl_text.Top = 10;
            _lbl_text.Left = 490;
            DataGridViewX _dgv_product_max_vent = new DataGridViewX();
            _dgv_product_max_vent.Top = 50;
            _dgv_product_max_vent.Left = 5;
            _dgv_product_max_vent.Margin.Left.Equals(10);
            _dgv_product_max_vent.Width = 1150;
            _dgv_product_max_vent.Height = 200;
            _dgv_product_max_vent.RowHeadersVisible = false;
            _cls_dav_conSu._met_carg_datos_product_Max_vendidos();
            _DataTable = _cls_dav_conSu._DataTable;
            _dgv_product_max_vent.DataSource = _DataTable;
            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_dgv_product_max_vent);
            Chart _chart = new Chart();
            _chart.Top = 250;
            _chart.Left = 320;
            _chart.ChartAreas.Add("1");
            _chart.Titles.Add("Productos mas vendidos");
            _chart.Width = 550;
            _chart.Height = 220;
            _chart.Series.Add("Prueba");
            _chart.Series.Add("Prueba2");
            //_chart.Series[0].IsVisibleInLegend = true;
            for (int x = 0; x < _dgv_product_max_vent.RowCount -1; x++)
            {
                _chart.Series[0].Palette = ChartColorPalette.BrightPastel;
                _chart.Series[0].Points.AddXY(_dgv_product_max_vent.Rows[x].Cells[2].Value.ToString(), _dgv_product_max_vent.Rows[x].Cells[0].Value.ToString());
            }
            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_lbl_text);
            _frm_con_serv.tcontrol.SelectedPanel.Controls.Add(_chart);
        }
        private void _met_event_click_btn_reportVenta(object sender, EventArgs e) { 
            if (_frm_con_serv.tcontrol.SelectedTab.Name == "item1") {
                _frm_con_serv.tcontrol.Tabs.Remove(0);
            }
            _frm_con_serv.tcontrol.CreateTab("Reporte de vantas");
            foreach (SuperTabItem _items in _frm_con_serv.tcontrol.Tabs){
                _frm_con_serv.tcontrol.SelectedTab = _items;
            }
        }
        private void _met_event_click_btn_rport_invenatrio(object sender, EventArgs e) {
            if (_frm_con_serv.tcontrol.SelectedTab.Name == "item1") {
                _frm_con_serv.tcontrol.Tabs.Remove(0);
            }
            _frm_con_serv.tcontrol.CreateTab("reporte de inventario");
            foreach (SuperTabItem _items in _frm_con_serv.tcontrol.Tabs) {
                _frm_con_serv.tcontrol.SelectedTab = _items;
            }
        }
        private void _met_event_click_pb_log(object sender, EventArgs e) {
            View.Frm_login_servers _frm_log = new View.Frm_login_servers();
            Controller.cls_login_servers _cls_log_ser = new cls_login_servers(_frm_log,_frm_con_serv);
            _frm_log.Show();
        }
        private void _met_event_click_pb_cerrar(object sender, EventArgs e) {
            _frm_con_serv.txt_dir.Text = "";
            _frm_con_serv.txt_estado.Text = "";
            _frm_con_serv.txt_nom_su.Text = "";
            _frm_con_serv.txt_serv.Text = "";
            _frm_con_serv.txt_tel.Text = "";
            _frm_con_serv.tcontrol.Tabs.Clear();
            _frm_con_serv.tcontrol.CreateTab("Nueva pestaña").Name ="item1";
            _frm_con_serv.lbl_estado_serv.Text = "Desconectado";
            _frm_con_serv.lbl_estado_serv.ForeColor = System.Drawing.Color.Red;
        }
    }
}
