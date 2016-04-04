using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Precio_por_volumen
    {
        private int _ID;
        private int _cantidad_desde;
        private int _cantidad_hasta;
        private int _producto_ID;
        private int _precio_venta_unitario;
        private double _porcentaje_aumento_precio_base;
        private string _estado_vigente;

        //CONSTRUCTOR
        public Precio_por_volumen(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _cantidad_desde = Utils.cint(data["cantidad_desde"].ToString());
                _cantidad_hasta = Utils.cint(data["cantidad_hasta"].ToString());
                _producto_ID = Utils.cint(data["producto_ID"].ToString());
                _precio_venta_unitario = Utils.cint(data["precio_venta_unitario"].ToString());
                _estado_vigente = data["estado_vigente"].ToString();
                _porcentaje_aumento_precio_base = Utils.cdouble(data["porcentaje_aumento_precio_base"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Precio_por_volumen()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public int fcantidad_desde
        {

            get { return (_cantidad_desde); }
            set { _cantidad_desde = value; }

        }

        public int fcantidad_hasta
        {

            get { return (_cantidad_hasta); }
            set { _cantidad_hasta = value; }

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

        public string festado_vigente
        {

            get { return (_estado_vigente); }
            set { _estado_vigente = value; }

        }
        public double fporcentaje_aumento_precio_base
        {

            get { return (_porcentaje_aumento_precio_base); }
            set { _porcentaje_aumento_precio_base = value; }

        }

        public void actualizar()
        {
            try
            {
                CtrlPrecio_por_volumen.actualizar(this);
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
                return CtrlPrecio_por_volumen.guardar(this);
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
                CtrlPrecio_por_volumen.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        //public Producto getProducto()
        //{
        //    return CtrlProducto.getProducto(_producto_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Precio_por_volumen
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String cantidad_desde
        {

            get { return ("cantidad_desde"); }
        }
        public static String cantidad_hasta
        {

            get { return ("cantidad_hasta"); }
        }
        public static String producto_ID
        {

            get { return ("producto_ID"); }
        }
        public static String precio_venta_unitario
        {

            get { return ("precio_venta_unitario"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
    }//Fin clase estática

}//Fin name_space
