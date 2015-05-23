using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Precio_por_cliente
    {
        private int _ID;
        private int _cliente_proveedor_ID;
        private int _producto_ID;
        private int _precio_venta_unitario;
        private int _cantidad_minima;
        private string _estado_vigente;

        //CONSTRUCTOR
        public Precio_por_cliente(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _cliente_proveedor_ID = Utils.cint(data["cliente_proveedor_ID"].ToString());
                _producto_ID = Utils.cint(data["producto_ID"].ToString());
                _precio_venta_unitario = Utils.cint(data["precio_venta_unitario"].ToString());
                _cantidad_minima = Utils.cint(data["cantidad_minima"].ToString());
                _estado_vigente = data["estado_vigente"].ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Precio_por_cliente()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public int fcliente_proveedor_ID
        {

            get { return (_cliente_proveedor_ID); }
            set { _cliente_proveedor_ID = value; }

        }

        public int fproducto_ID
        {

            get { return (_producto_ID); }
            set { _producto_ID = value; }

        }

        public int fprecio_venta_unitario
        {

            get { return (_precio_venta_unitario); }
            set { _precio_venta_unitario = value; }

        }

        public int fcantidad_minima
        {

            get { return (_cantidad_minima); }
            set { _cantidad_minima = value; }

        }

        public string festado_vigente
        {

            get { return (_estado_vigente); }
            set { _estado_vigente = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlPrecio_por_cliente.actualizar(this);
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
                return CtrlPrecio_por_cliente.guardar(this);
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
                CtrlPrecio_por_cliente.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Cliente_proveedor getCliente_proveedor()
        {
            return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID);
        }

        //public Producto getProducto()
        //{
        //    return CtrlProducto.getProducto(_producto_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Precio_por_cliente
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String cliente_proveedor_ID
        {

            get { return ("cliente_proveedor_ID"); }
        }
        public static String producto_ID
        {

            get { return ("producto_ID"); }
        }
        public static String precio_venta_unitario
        {

            get { return ("precio_venta_unitario"); }
        }
        public static String cantidad_minima
        {

            get { return ("cantidad_minima"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
    }//Fin clase estática

}//Fin name_space
