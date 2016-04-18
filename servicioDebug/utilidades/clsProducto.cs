using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Producto
    {
        private int _ID;
        private int _categoria_ID;
        private string _codigo_barra;
        private string _codigo_barra_grupo;
        private string _nombre;
        private string _descripcion;
        private double _stock_actual;
        private double _stock_minimo;
        private int _precio_venta;
        private string _unidad;
        private string _unidad_grupo;
        private double _cantidad_grupo;
        private int _estado;
        private int _ultimo_precio_compra;
        private int _ultimo_precio_venta;
        private DateTime _ultima_fecha_compra;
        private DateTime _ultima_fecha_venta;
        private int _margen_ganancia;
        private string _exento;
        private int _precio_venta_grupo;
        private string _nombreCategoria;
        private double _cantidad_grupo_adicional;
        private int _producto_compuesto_ID;
        private int _cliente_proveedor_ID;
        private string _codigo_producto;
        private int _precio_base;
        private int _porcentaje_descuento;
        private int _impuesto_ID;

        //CONSTRUCTOR
        public Producto(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _categoria_ID = Utils.cint(data["categoria_ID"].ToString());
                _codigo_barra = data["codigo_barra"].ToString();
                _codigo_barra_grupo = data["codigo_barra_grupo"].ToString();
                _nombre = data["nombre"].ToString();
                _descripcion = data["descripcion"].ToString();
                _stock_actual = Utils.cint(data["stock_actual"].ToString());
                _stock_minimo = Utils.cint(data["stock_minimo"].ToString());
                _precio_venta = Utils.cint(data["precio_venta"].ToString());
                _unidad = data["unidad"].ToString();
                _unidad_grupo = data["unidad_grupo"].ToString();
                _cantidad_grupo = Utils.cint(data["cantidad_grupo"].ToString());
                _estado = Utils.cint(data["estado"].ToString());
                _ultimo_precio_compra = Utils.cint(data["ultimo_precio_compra"].ToString());
                _ultimo_precio_venta = Utils.cint(data["ultimo_precio_venta"].ToString());
                _ultima_fecha_compra = Utils.cdate(data["ultima_fecha_compra"].ToString());
                _ultima_fecha_venta = Utils.cdate(data["ultima_fecha_venta"].ToString());
                _margen_ganancia = Utils.cint(data["margen_ganancia"].ToString());
                if (data["exento"] == null)
                    _exento = "no";
                else
                    _exento = data["exento"].ToString();
                _precio_venta_grupo = Utils.cint(data["precio_venta_grupo"].ToString());
                _cantidad_grupo_adicional = Utils.cdouble(data["cantidad_grupo_adicional"].ToString());
                _producto_compuesto_ID = Utils.cint(data["producto_compuesto_ID"].ToString());
                _cliente_proveedor_ID = Utils.cint(data["cliente_proveedor_ID"].ToString());
                _codigo_producto = data["codigo_producto"].ToString();
                _precio_base = Utils.cint(data["precio_base"].ToString());
                _porcentaje_descuento = Utils.cint(data["porcentaje_descuento"].ToString());
                _impuesto_ID = Utils.cint(data["impuesto_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        public Producto(ProductoJSON producto)
        {
            _ID = producto.f0;// Utils.cint(data["ID"].ToString());
            _categoria_ID = producto.f1;// Utils.cint(data["categoria_ID"].ToString());
            _codigo_barra = producto.f2;// data["codigo_barra"].ToString();
            _codigo_barra_grupo = producto.f3;// data["codigo_barra_grupo"].ToString();
            _nombre = producto.f4;// data["nombre"].ToString();
            _descripcion = producto.f5;// data["descripcion"].ToString();
            _stock_actual = Utils.cdouble(producto.f6.ToString());
            _stock_minimo = Utils.cdouble(producto.f7.ToString());
            _precio_venta = Utils.cint(producto.f8.ToString());
            _unidad = producto.f9;// data["unidad"].ToString();
            _unidad_grupo = producto.f10.ToString();// data["unidad_grupo"].ToString();
            _cantidad_grupo = Utils.cdouble(producto.f11.ToString());
            _estado = Utils.cint(producto.f12.ToString());
            _ultimo_precio_compra = Utils.cint(producto.f13.ToString());
            _ultimo_precio_venta = Utils.cint(producto.f14.ToString());
            _ultima_fecha_compra = Utils.cdate(producto.f15);
            _ultima_fecha_venta = Utils.cdate(producto.f16);
            _margen_ganancia = Utils.cint(producto.f17.ToString());
            _exento = producto.f18.ToString();
            _precio_venta_grupo = Utils.cint(producto.f19.ToString());
            _cantidad_grupo_adicional = Utils.cdouble(producto.f20.ToString());
            _producto_compuesto_ID = Utils.cint(producto.f21.ToString());
            _cliente_proveedor_ID = Utils.cint(producto.f22.ToString());
            _codigo_producto = producto.f23;
            _precio_base = Utils.cint(producto.f24);
            _porcentaje_descuento = Utils.cint(producto.f25);
            _impuesto_ID = Utils.cint(producto.f26);
        }
        public Producto()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public string fnombreCategoria
        {
            get { return (_nombreCategoria); }
            set { _nombreCategoria = value; }
        }

        public int fcategoria_ID
        {

            get { return (_categoria_ID); }
            set { _categoria_ID = value; }

        }

        public string fcodigo_barra
        {

            get { return (_codigo_barra); }
            set { _codigo_barra = value; }

        }

        public string fcodigo_barra_grupo
        {

            get { return (_codigo_barra_grupo); }
            set { _codigo_barra_grupo = value; }

        }

        public string fnombre
        {

            get { return (_nombre); }
            set { _nombre = value; }

        }

        public string fdescripcion
        {

            get { return (_descripcion); }
            set { _descripcion = value; }

        }

        public double fstock_actual
        {

            get { return (_stock_actual); }
            set { _stock_actual = value; }

        }

        public double fstock_minimo
        {

            get { return (_stock_minimo); }
            set { _stock_minimo = value; }

        }

        public int fprecio_venta
        {

            get { return (_precio_venta); }
            set { _precio_venta = value; }

        }

        public string funidad
        {

            get { return (_unidad); }
            set { _unidad = value; }

        }

        public string funidad_grupo
        {

            get { return (_unidad_grupo); }
            set { _unidad_grupo = value; }

        }

        public double fcantidad_grupo
        {

            get { return (_cantidad_grupo); }
            set { _cantidad_grupo = value; }

        }

        public int festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public int fultimo_precio_compra
        {

            get { return (_ultimo_precio_compra); }
            set { _ultimo_precio_compra = value; }

        }

        public int fultimo_precio_venta
        {

            get { return (_ultimo_precio_venta); }
            set { _ultimo_precio_venta = value; }

        }

        public DateTime fultima_fecha_compra
        {

            get { return (_ultima_fecha_compra); }
            set { _ultima_fecha_compra = value; }

        }

        public DateTime fultima_fecha_venta
        {

            get { return (_ultima_fecha_venta); }
            set { _ultima_fecha_venta = value; }

        }

        public int fmargen_ganancia
        {

            get { return (_margen_ganancia); }
            set { _margen_ganancia = value; }

        }

        public string fexento
        {

            get { return (_exento); }
            set { _exento = value; }

        }

        public int fprecio_venta_grupo
        {

            get { return (_precio_venta_grupo); }
            set { _precio_venta_grupo = value; }

        }

        public double fcantidad_grupo_adicional
        {

            get { return (_cantidad_grupo_adicional); }
            set { _cantidad_grupo_adicional = value; }

        }

        public int fproducto_compuesto_ID
        {

            get { return (_producto_compuesto_ID); }
            set { _producto_compuesto_ID = value; }

        }

        public int fcliente_proveedor_ID
        {

            get { return (_cliente_proveedor_ID); }
            set { _cliente_proveedor_ID = value; }

        }

        public string fcodigo_producto
        {

            get { return (_codigo_producto); }
            set { _codigo_producto = value; }

        }

        public int fprecio_base
        {

            get { return (_precio_base); }
            set { _precio_base = value; }

        }

        public int fporcentaje_descuento
        {

            get { return (_porcentaje_descuento); }
            set { _porcentaje_descuento = value; }

        }

        public int fimpuesto_ID
        {

            get { return (_impuesto_ID); }
            set { _impuesto_ID = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlProducto.actualizar(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public int guardar()
        {
            try
            {
                return CtrlProducto.guardar(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public void eliminar()
        {
            try
            {
                CtrlProducto.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Categoria getCategoria()
        {
            return CtrlCategoria.getCategoria(_categoria_ID);
        }

        //public Producto_compuesto getProducto_compuesto()
        //{
        //    return CtrlProducto_compuesto.getProducto_compuesto(_producto_compuesto_ID);
        //}

        public Cliente_proveedor getCliente_proveedor()
        {
            return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID);
        }

        //public Impuesto getImpuesto()
        //{
        //    return CtrlImpuesto.getImpuesto(_impuesto_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Producto
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String categoria_ID
        {

            get { return ("categoria_ID"); }
        }
        public static String codigo_barra
        {

            get { return ("codigo_barra"); }
        }
        public static String codigo_barra_grupo
        {

            get { return ("codigo_barra_grupo"); }
        }
        public static String nombre
        {

            get { return ("nombre"); }
        }
        public static String descripcion
        {

            get { return ("descripcion"); }
        }
        public static String stock_actual
        {

            get { return ("stock_actual"); }
        }
        public static String stock_minimo
        {

            get { return ("stock_minimo"); }
        }
        public static String precio_venta
        {

            get { return ("precio_venta"); }
        }
        public static String unidad
        {

            get { return ("unidad"); }
        }
        public static String unidad_grupo
        {

            get { return ("unidad_grupo"); }
        }
        public static String cantidad_grupo
        {

            get { return ("cantidad_grupo"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String ultimo_precio_compra
        {

            get { return ("ultimo_precio_compra"); }
        }
        public static String ultimo_precio_venta
        {

            get { return ("ultimo_precio_venta"); }
        }
        public static String ultima_fecha_compra
        {

            get { return ("ultima_fecha_compra"); }
        }
        public static String ultima_fecha_venta
        {

            get { return ("ultima_fecha_venta"); }
        }
        public static String margen_ganancia
        {

            get { return ("margen_ganancia"); }
        }
        public static String exento
        {

            get { return ("exento"); }
        }
        public static String precio_venta_grupo
        {

            get { return ("precio_venta_grupo"); }
        }
        public static String cantidad_grupo_adicional
        {

            get { return ("cantidad_grupo_adicional"); }
        }
        public static String producto_compuesto_ID
        {

            get { return ("producto_compuesto_ID"); }
        }
        public static String cliente_proveedor_ID
        {

            get { return ("cliente_proveedor_ID"); }
        }
        public static String codigo_producto
        {

            get { return ("codigo_producto"); }
        }
        public static String precio_base
        {

            get { return ("precio_base"); }
        }
        public static String porcentaje_descuento
        {

            get { return ("porcentaje_descuento"); }
        }
        public static String impuesto_ID
        {

            get { return ("impuesto_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
