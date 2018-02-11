using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysTel_Network.Model;
using SysTel_Network.View;
using System.Windows.Forms;

namespace SysTel_Network.Controller
{
    class cls_principal
    {
        private View.Frm_principal _form_princi;
        private cls_var_login _cls_var = new cls_var_login();
        private static Frm_empleados _frm_empl;
        private static Frm_clientes _frm_clientes;
        private static Frm_companias _frm_companias;
        private static Frm_proveedores _frm_provee;
        private static Frm_sucursales _frm_sucu;
        private static Frm_cargos _frm_carg;
        private static Frm_productos _frm_produt;
        private static Frm_categorias _frm_cat;
        private static Frm_marcas _frm_mar;
        private static Frm_ventas _frm_ventas;
        private static Frm_compras _frm_compras;
        private static Frm_servicios _frm_serv;
        private static Frm_estadistica _frm_est;
        private static Frm_reporte_ventas _frm_r_ven;
        private static Frm_reporte_inventario _frm_invetarioRe;
        private static Frm_acercade _acerca;
        public cls_principal(View.Frm_principal _prin) {
            _form_princi = _prin;
            _met_event_click();
            _form_princi.lbl_datos.Text = "Usuario: " + _cls_var._Nom_empl + "   Puesto: " + _cls_var._Carg;
            _form_princi.timer1.Tick += new EventHandler(_met_event_timer);
            _form_princi.timer1.Enabled = true;
        }
        private void _met_event_click() {
            _form_princi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_click_form);
            _form_princi.salirToolStripMenuItem.Click += new EventHandler(_met_event_clik_close);
            _form_princi.cerrarSesionToolStripMenuItem.Click += new EventHandler(_met_event_click_cerrarsesion);
            _form_princi.empleadosToolStripMenuItem.Click += new EventHandler(_met_event_click_empl);
            _form_princi.clientesToolStripMenuItem.Click += new EventHandler(_met_event_click_clientes);
            _form_princi.proveedoresToolStripMenuItem.Click += new EventHandler(_met_event_click_proveedores);
            _form_princi.registrarNuevoSucursalToolStripMenuItem.Click += new EventHandler(_met_event_click_suscur);
            _form_princi.registrarNuevoCargosToolStripMenuItem.Click += new EventHandler(_met_event_click_cargos);
            _form_princi.registarNuevoProductoToolStripMenuItem.Click += new EventHandler(_met_event_click_productos);
            _form_princi.registrarNuevoCategoriaToolStripMenuItem.Click += new EventHandler(_met_event_click_cate);
            _form_princi.registrarNuevoMarcaToolStripMenuItem.Click += new EventHandler(_met_event_click_marcas);
            _form_princi.ventasToolStripMenuItem.Click += new EventHandler(_met_event_click_ventas);
            _form_princi.comprasToolStripMenuItem.Click += new EventHandler(_met_event_click_compras);
            _form_princi.realizarNuevoServicioToolStripMenuItem.Click += new EventHandler(_met_event_click_servicio);
            _form_princi.estadisticaToolStripMenuItem.Click += new EventHandler(_met_event_click_esta);
            _form_princi.registrarNuevoClienteCompaniaToolStripMenuItem.Click += new EventHandler(_met_event_click_clientesCompanias);
            _form_princi.conexionConLossucursalesToolStripMenuItem.Click += new EventHandler(_met_event_click_conectServer);
            _form_princi.reporteDeVentasToolStripMenuItem.Click += new EventHandler(_met_event_click_reporteventas);
            _form_princi.reporteDelInventarioToolStripMenuItem.Click += new EventHandler(_met_event_click_reporteInven);
            _form_princi.acercaDeSystelNetworkToolStripMenuItem.Click += new EventHandler(_met_event_click_acercade);
        }
        private void _met_event_click_form(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                System.Windows.Forms.MessageBox.Show("prueba");
            }
        }
        private void _met_event_click_cerrarsesion(object sender, EventArgs e) {
            _form_princi.Hide();
            View.Frm_login _frm_lgin = new View.Frm_login();
            Controller.cls_login _cont_login = new Controller.cls_login(_frm_lgin);
            _frm_lgin.Show();
        }
        private void _met_event_clik_close(object sender, EventArgs e){
            System.Windows.Forms.Application.Exit();
        }
        private void _met_event_click_empl(object sender, EventArgs e) {
            _frm_empl = _instance_empleados;
            Controller.cls_empleados _cont_empl = new cls_empleados(_frm_empl);
            _frm_empl.MdiParent = _form_princi;
            _frm_empl.Show();
        }
        private void _met_event_click_clientes(object sender, EventArgs e) {
            _frm_clientes = _instance_clientes;
            Controller.cls_clientes _con_cli = new cls_clientes(_frm_clientes);
            _frm_clientes.MdiParent = _form_princi;
            _frm_clientes.Show();
        }
        private void _met_event_click_clientesCompanias(object sender, EventArgs e) {
            _frm_companias = _instance_companias;
            Controller.cls_companias _cls_con_compa = new cls_companias(_frm_companias);
            _frm_companias.MdiParent = _form_princi;
            _frm_companias.Show();
        }
        private void _met_event_click_proveedores(object sender, EventArgs e) {
            _frm_provee = _instance_proveed;
            Controller.cls_proveedores _con_pro = new cls_proveedores(_frm_provee);
            _frm_provee.MdiParent = _form_princi;
            _frm_provee.Show();
        }
        private void _met_event_click_suscur(object sender, EventArgs e) {
            _frm_sucu = _instance_sucursals;
            Controller.cls_sucursales _cls_con = new cls_sucursales(_frm_sucu);
            _frm_sucu.MdiParent = _form_princi;
            _frm_sucu.Show();
        }
        private void _met_event_click_cargos(object sender, EventArgs e) {
            _frm_carg = _insatance_cargos;
            Controller.cls_cargos _cls_con = new cls_cargos(_frm_carg);
            _frm_carg.MdiParent = _form_princi;
            _frm_carg.Show();
        }
        private void _met_event_click_productos(object sender, EventArgs e) {
            _frm_produt = _instance_product;
            Controller.cls_productos _cls_con_product = new Controller.cls_productos(_frm_produt);
            _frm_produt.MdiParent = _form_princi;
            _frm_produt.Show();
        }
        private void _met_event_click_cate(object sender, EventArgs e) {
            _frm_cat = _instance_cat;
            Controller.cls_categorias _cls_con = new cls_categorias(_frm_cat);
            _frm_cat.MdiParent = _form_princi;
            _frm_cat.Show();
        }
        private void _met_event_click_marcas(object sneder, EventArgs e) {
            _frm_mar = _instance_marcas;
            Controller.cls_marcas _cls_con = new cls_marcas(_frm_mar);
            _frm_mar.MdiParent = _form_princi;
            _frm_mar.Show();
        }
        private void _met_event_click_ventas(object sender, EventArgs e) {
            _frm_ventas = _instance_ventas;
            Controller.cls_ventas _cls_con_vent = new Controller.cls_ventas(_frm_ventas);
            _frm_ventas.MdiParent = _form_princi;
            _frm_ventas.Show();
        }
        private void _met_event_click_compras(object sender, EventArgs e) {
            _frm_compras = _instance_compras;
            Controller.cls_compras _cls_con_compra = new Controller.cls_compras(_frm_compras);
            _frm_compras.MdiParent = _form_princi;
            _frm_compras.Show();
        }
        private void _met_event_click_servicio(object sender, EventArgs e) {
            _frm_serv = _instance_service;
            Controller.cls_servicios _cls_con_ser = new cls_servicios(_frm_serv);
            _frm_serv.MdiParent = _form_princi;
            _frm_serv.Show();
        }
        private void _met_event_click_esta(object sender, EventArgs e) {
            _frm_est = _instance_estadistic;
            Controller.cls_estadistica _cls_con_esta = new cls_estadistica(_frm_est);
            _frm_est.MdiParent = _form_princi;
            _frm_est.Show();
        }
        private void _met_event_click_conectServer(object sender, EventArgs e) {
            View.Frm_conexiones _frm_servers = new View.Frm_conexiones();
            Controller.cls_con_sucursales _cls_conSucu = new cls_con_sucursales(_frm_servers);
            _frm_servers.MdiParent = _form_princi;
            _frm_servers.Show();
            View.Frm_login_servers _frm_log_serv = new View.Frm_login_servers();
            Controller.cls_login_servers _cls_con_log_ser = new cls_login_servers(_frm_log_serv, _frm_servers);
            _frm_log_serv.MdiParent = _form_princi;
            _frm_log_serv.Show();
        }
        private void _met_event_click_reporteventas(object sender, EventArgs e) {
            View.Frm_reporte_ventas _frm_r_ven = _instance_reportVent;
            _frm_r_ven.MdiParent = _form_princi;
            _frm_r_ven.Show();
        }
        private void _met_event_click_reporteInven(object sender, EventArgs e) {
            _frm_invetarioRe = _instance_reportInevent;
            Controller.cls_reporte_inventario _cls_invent = new cls_reporte_inventario(_frm_invetarioRe);
            _frm_invetarioRe.MdiParent = _form_princi;
            _frm_invetarioRe.Show();
        }
        private void _met_event_click_acercade(object sender, EventArgs e) {
            _acerca = _instance_Acerca();
            _acerca.MdiParent = _form_princi;
            _acerca.Show();
        }
        private void _met_event_timer(object sender, EventArgs e){
            _form_princi.horaToolStripMenuItem.Text = Convert.ToString(System.DateTime.Now);
        }

        private static Frm_empleados _instance_empleados {
            get {
                if (_frm_empl == null || _frm_empl.IsDisposed) {
                    _frm_empl = new Frm_empleados();
                }
                _frm_empl.BringToFront();
                return _frm_empl;
            }
        }
        private static Frm_clientes _instance_clientes {
            get {
                if (_frm_clientes == null || _frm_clientes.IsDisposed) {
                    _frm_clientes = new Frm_clientes();
                }
                _frm_clientes.BringToFront();
                return _frm_clientes;
            }
        }
        private static Frm_companias _instance_companias {
            get {
                if (_frm_companias == null || _frm_companias.IsDisposed) {
                    _frm_companias = new Frm_companias();
                }
                _frm_companias.BringToFront();
                return _frm_companias;
            }
        }
        private static Frm_proveedores _instance_proveed {
            get {
                if (_frm_provee == null || _frm_provee.IsDisposed) {
                    _frm_provee = new Frm_proveedores();
                }
                _frm_provee.BringToFront();
                return _frm_provee;
            }
        }
        private static Frm_sucursales _instance_sucursals {
            get {
                if (_frm_sucu == null || _frm_sucu.IsDisposed) {
                    _frm_sucu = new Frm_sucursales();
                }
                _frm_sucu.BringToFront();
                return _frm_sucu;
            }
        }
        private static Frm_cargos _insatance_cargos {
            get {
                if (_frm_carg == null || _frm_carg.IsDisposed) {
                    _frm_carg = new Frm_cargos();
                }
                _frm_carg.BringToFront();
                return _frm_carg;
            }
        }
        private static Frm_productos _instance_product {
            get {
                if (_frm_produt == null || _frm_produt.IsDisposed) {
                    _frm_produt = new Frm_productos();
                }
                _frm_produt.BringToFront();
                return _frm_produt;
            }
        }
        private static Frm_categorias _instance_cat {
            get {
                if (_frm_cat == null || _frm_cat.IsDisposed) {
                    _frm_cat = new Frm_categorias();
                }
                _frm_cat.BringToFront();
                return _frm_cat;
            }
        }
        private static Frm_marcas _instance_marcas {
            get {
                if (_frm_mar == null || _frm_mar.IsDisposed) {
                    _frm_mar = new Frm_marcas();
                }
                _frm_mar.BringToFront();
                return _frm_mar;
            }
        }
        private static Frm_ventas _instance_ventas {
            get { 
                if(_frm_ventas == null || _frm_ventas.IsDisposed){
                    _frm_ventas = new Frm_ventas();
                }
                _frm_ventas.BringToFront();
                return _frm_ventas;
            }
        }
        private static Frm_compras _instance_compras {
            get {
                if (_frm_compras == null || _frm_compras.IsDisposed) {
                    _frm_compras = new Frm_compras();
                }
                _frm_compras.BringToFront();
                return _frm_compras;
            }
        }
        private static Frm_servicios _instance_service {
            get { 
                if(_frm_serv == null || _frm_serv.IsDisposed){
                    _frm_serv = new Frm_servicios();
                }
                _frm_serv.BringToFront();
                return _frm_serv;
            }
        }
        private static Frm_estadistica _instance_estadistic {
            get {
                if (_frm_est == null || _frm_est.IsDisposed) {
                    _frm_est = new Frm_estadistica();
                }
                _frm_est.BringToFront();
                return _frm_est;
            }
        }
        private static Frm_reporte_ventas _instance_reportVent {
            get {
                if (_frm_r_ven == null || _frm_r_ven.IsDisposed) {
                    _frm_r_ven = new Frm_reporte_ventas();
                }
                _frm_r_ven.BringToFront();
                return _frm_r_ven;
            }
        }
        private static Frm_reporte_inventario _instance_reportInevent {
            get {
                if (_frm_invetarioRe == null || _frm_invetarioRe.IsDisposed) {
                    _frm_invetarioRe = new Frm_reporte_inventario();
                }
                _frm_invetarioRe.BringToFront();
                return _frm_invetarioRe;
            }
        }
        private static Frm_acercade _instance_Acerca() {
            if (_acerca == null || _acerca.IsDisposed){
                _acerca = new Frm_acercade();
            }
            _acerca.BringToFront();
            return _acerca;
        }
    }
}
