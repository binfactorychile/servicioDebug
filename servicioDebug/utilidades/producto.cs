using System;
using System.Collections;
using System.Data;

namespace utilidades
{

    public class Producto
    {
        public int _ID;
        public int _categoria_ID;
        public string _codigo_barra;
        public string _codigo_barra_grupo;
        public string _nombre;
        public string _descripcion;
        public double _stock_actual;
        public double _stock_minimo;
        public int _precio_venta;
        public string _unidad;
        public string _unidad_grupo;
        public double _cantidad_grupo;
        public int _estado;
        public int _ultimo_precio_compra;
        public int _ultimo_precio_venta;
        public DateTime _ultima_fecha_compra;
        public DateTime _ultima_fecha_venta;
        public int _margen_ganancia;
        public string _exento;
        public int _precio_venta_grupo;
        private string _nombreCategoria;
        private double _cantidad_grupo_adicional;
        private int _producto_compuesto_ID;
        private int _cliente_proveedor_ID;
        private string _codigo_producto;
        //CONSTRUCTOR
        public Producto(DataRow data)
        {
            _ID = Utils.cint(data["ID"].ToString());
            _categoria_ID = Utils.cint(data["categoria_ID"].ToString());
            _codigo_barra = data["codigo_barra"].ToString();
            _codigo_barra_grupo = data["codigo_barra_grupo"].ToString();
            _nombre = data["nombre"].ToString();
            _descripcion = data["descripcion"].ToString();
            _stock_actual = Utils.cdouble(data["stock_actual"].ToString());
            _stock_minimo = Utils.cdouble(data["stock_minimo"].ToString());
            _precio_venta = Utils.cint(data["precio_venta"].ToString());
            _unidad = data["unidad"].ToString();
            _unidad_grupo = data["unidad_grupo"].ToString();
            _cantidad_grupo = Utils.cdouble(data["cantidad_grupo"].ToString());
            _estado = Utils.cint(data["estado"].ToString());
            _ultimo_precio_compra = Utils.cint(data["ultimo_precio_compra"].ToString());
            _ultimo_precio_venta = Utils.cint(data["ultimo_precio_venta"].ToString());
            _ultima_fecha_compra = Utils.cdate(data["ultima_fecha_compra"].ToString());
            _ultima_fecha_venta = Utils.cdate(data["ultima_fecha_venta"].ToString());
            _margen_ganancia = Utils.cint(data["margen_ganancia"].ToString());

            if(data["exento"]==null)
                _exento = "no";
            else
                _exento = data["exento"].ToString();

            _precio_venta_grupo = Utils.cint(data["precio_venta_grupo"].ToString());
            _cantidad_grupo_adicional = Utils.cdouble(data["cantidad_grupo_adicional"].ToString());
            _producto_compuesto_ID = Utils.cint(data["producto_compuesto_ID"].ToString());
            _cliente_proveedor_ID = Utils.cint(data["cliente_proveedor_ID"].ToString());

            _codigo_producto = data["codigo_producto"].ToString();


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
            _ultima_fecha_compra = Utils.cdate(producto.f15.ToString());
            _ultima_fecha_venta = Utils.cdate(producto.f16.ToString());
            _margen_ganancia = Utils.cint(producto.f17.ToString());
            _exento = producto.f18.ToString();
            _precio_venta_grupo = Utils.cint(producto.f19.ToString());
            _cantidad_grupo_adicional = Utils.cdouble(producto.f20.ToString());
            _producto_compuesto_ID = Utils.cint(producto.f21.ToString());
            _cliente_proveedor_ID = Utils.cint(producto.f22.ToString());
            _codigo_producto = producto.f23;
        }
        public Producto()
        {
        }
        public int fcliente_proveedorID
        {
            get {return _cliente_proveedor_ID; }
            set { _cliente_proveedor_ID = value; }
        }

        public string fcodigo_producto
        {
            get { return (_codigo_producto); }
            set { _codigo_producto = value; }
        }

        public string fnombreCategoria
        {
            get { return (_nombreCategoria); }
            set { _nombreCategoria = value; }
        }
        public int fID
        {
            get { return (_ID); }
            set { _ID = value; }
        }
        public int fproducto_compuesto_ID
        {
            get { return _producto_compuesto_ID; }
            set { _producto_compuesto_ID = value; }
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
        public double fcantidad_grupo_adicional
        {
            get { return (_cantidad_grupo_adicional); }
            set { _cantidad_grupo_adicional = value; }        
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

        //public Categoria getCategoria()
        //{
        //    Controlador_Categoria clogCategoria = new Controlador_Categoria();
        //    return clogCategoria.getCategoria(_categoria_ID.ToString());
        //}
        //public Cliente_proveedor getCliente_proveedor()
        //{
        //    //Controlador_Cliente_proveedor ctrlClienteProveedor = new Controlador_Cliente_proveedor();
        //    return CtrlCliente_proveedor.getCliente_proveedor(this._cliente_proveedor_ID);
        //}
        //public double stockBodega(int bodega_ID)
        //{
        //    Producto_Fachada producto_fachada = new Producto_Fachada();
        //    DataSet dataset = producto_fachada.get_stock_bodega(1, _ID);
        //    double stock = 0;
        //    if (dataset != null)
        //    {
        //        foreach (DataRow fila in dataset.Tables[0].Rows)
        //        {
        //            stock = Math.Round(Utils.cdouble(fila["cantidad"].ToString()), 2, MidpointRounding.AwayFromZero);
        //        }
        //    }
        //    return stock;
        //}
        public void Actualizar()
        {
            Controlador_Producto CtrlProducto = new Controlador_Producto();
            CtrlProducto.actualizar(this);
        }
        //public Producto_compuesto getProductoCompuesto()
        //{
        //    if (_producto_compuesto_ID > 0)
        //    {
        //        return CtrlProducto_compuesto.getProducto_compuesto(_producto_compuesto_ID);
        //    }
        //    else
        //        return null;
        //}
        //public Cliente_proveedor getProveedorOficial()
        //{
        //    if (_cliente_proveedor_ID > 0)
        //    {
        //        //Controlador_Cliente_proveedor CtrlClienteProveedor = new Controlador_Cliente_proveedor();
        //        return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID);
        //    }
        //    else
        //        return null;
        //}
        //public string getNombreProveedor()
        //{
        //    if (_cliente_proveedor_ID > 0)
        //    {
        //        //Controlador_Cliente_proveedor CtrlClienteProveedor = new Controlador_Cliente_proveedor();
        //        return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID).fnombre;
        //    }
        //    else
        //        return "";
        
        //}


    }

}//Fin name_space
