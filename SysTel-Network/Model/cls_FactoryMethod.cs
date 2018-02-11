using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SysTel_Network.Model
{
    class cls_FactoryMethod
    {
        private static cls_FactoryMethod _instance;
        public static cls_FactoryMethod _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_FactoryMethod();
                }
                return _instance;
            }
        }
        public enum _TipoRegistro { 
            puesto,
            categorias,
            clientes,
            companias,
            compras,
            empleados,
            marcas,
            productos,
            proveedores,
            servicios,
            sucursales
        }
        public bool _get_CRUD_INSERTAR(_TipoRegistro op, object _object) {
            switch (op) { 
                case _TipoRegistro.puesto:
                    return cls_dav_cargos._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.categorias:
                    return cls_dav_categorias._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.clientes:
                    return cls_dav_clientes._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.companias:
                    return cls_dav_compania._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.empleados:
                    return cls_dav_empleados._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.marcas:
                    return cls_dav_marcas._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.productos:
                    return cls_dav_productos._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.proveedores:
                    return cls_dav_proveedores._Instance._met_insert(_object);
                    break;
                case _TipoRegistro.sucursales:
                    return cls_dav_sucursales._Instance._met_insert(_object);
                    break;
                default:
                    return false;
            }
        }
        public bool _get_CRUD_UPDATE(_TipoRegistro op, object _object) {
            switch (op){
                case _TipoRegistro.puesto:
                    return cls_dav_cargos._Instance._met_update(_object);
                    break;
                case _TipoRegistro.categorias:
                    return cls_dav_categorias._Instance._met_update(_object);
                    break;
                case _TipoRegistro.clientes:
                    return cls_dav_clientes._Instance._met_update(_object);
                    break;
                case _TipoRegistro.companias:
                    return cls_dav_compania._Instance._met_update(_object);
                    break;
                case _TipoRegistro.empleados:
                    return cls_dav_empleados._Instance._met_update(_object);
                    break;
                case _TipoRegistro.marcas:
                    return cls_dav_marcas._Instance._met_update(_object);
                    break;
                case _TipoRegistro.productos:
                    return cls_dav_productos._Instance._met_update(_object);
                    break;
                case _TipoRegistro.proveedores:
                    return cls_dav_proveedores._Instance._met_update(_object);
                    break;
                case _TipoRegistro.sucursales:
                    return cls_dav_sucursales._Instance._met_update(_object);
                    break;
                default:
                    return false;
            }
        }
        public bool _get_CRUD_DELETE(_TipoRegistro op, object _object) {
            switch (op) {
                case _TipoRegistro.puesto:
                    return cls_dav_cargos._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.categorias:
                    return cls_dav_categorias._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.clientes:
                    return cls_dav_clientes._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.companias:
                    return cls_dav_compania._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.empleados:
                    return cls_dav_empleados._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.marcas:
                    return cls_dav_marcas._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.productos:
                    return cls_dav_productos._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.proveedores:
                    return cls_dav_proveedores._Instance._met_delete(_object);
                    break;
                case _TipoRegistro.sucursales:
                    return cls_dav_sucursales._Instance._met_delete(_object);
                    break;
                default:
                    return false;
            }
        }
        public SqlDataAdapter _get_CRUD_SELECT(_TipoRegistro op)
        {
            switch (op)
            {
                case _TipoRegistro.puesto:
                    return cls_dav_cargos._Instance._met_select();
                    break;
                case _TipoRegistro.categorias:
                    return cls_dav_categorias._Instance._met_select();
                    break;
                case _TipoRegistro.clientes:
                    return cls_dav_clientes._Instance._met_select();
                    break;
                case _TipoRegistro.companias:
                    return cls_dav_compania._Instance._met_select();
                    break;
                case _TipoRegistro.empleados:
                    return cls_dav_empleados._Instance._met_select();
                    break;
                case _TipoRegistro.marcas:
                    return cls_dav_marcas._Instance._met_select();
                    break;
                case _TipoRegistro.productos:
                    return cls_dav_productos._Instance._met_select();
                    break;
                case _TipoRegistro.proveedores:
                    return cls_dav_proveedores._Instance._met_select();
                    break;
                case _TipoRegistro.sucursales:
                    return cls_dav_sucursales._Instance._met_select();
                    break;
                default:
                    return null;
            }
        }
        public DataSet _get_CRUD_SELECT(_TipoRegistro op,object _object){
            switch (op) {
                case _TipoRegistro.puesto:
                    return null;
                    break;
                case _TipoRegistro.categorias:
                    return null;
                    break;
                case _TipoRegistro.clientes:
                    return null;
                    break;
                case _TipoRegistro.companias:
                    return cls_dav_compania._Instance._met_select(_object);
                    break;
                case _TipoRegistro.compras:
                    return null;
                    break;
                case _TipoRegistro.empleados:
                    return null;
                    break;
                case _TipoRegistro.marcas:
                    return null;
                    break;
                case _TipoRegistro.productos:
                    return null;
                    break;
                case _TipoRegistro.proveedores:
                    return null;
                    break;
                case _TipoRegistro.servicios:
                    return null;
                    break;
                case _TipoRegistro.sucursales:
                    return null;
                    break;
                default:
                    return null;
            }
        }
    }
}
