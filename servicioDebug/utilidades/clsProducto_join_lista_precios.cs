using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Producto_join_lista_precios
    {
        private int _ID;
        private int _producto_ID;
        private int _lista_precios_ID;
        private int _precio_venta;
        private double _cantidad_limite;

        //CONSTRUCTOR
        public Producto_join_lista_precios(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _producto_ID = Utils.cint(data["producto_ID"].ToString());
                _lista_precios_ID = Utils.cint(data["lista_precios_ID"].ToString());
                _precio_venta = Utils.cint(data["precio_venta"].ToString());
                _cantidad_limite = Utils.cdouble(data["cantidad_limite"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Producto_join_lista_precios()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public double fcantidad_limite
        {

            get { return (_cantidad_limite); }
            set { _cantidad_limite = value; }

        }

        public int fproducto_ID
        {

            get { return (_producto_ID); }
            set { _producto_ID = value; }

        }

        public int flista_precios_ID
        {

            get { return (_lista_precios_ID); }
            set { _lista_precios_ID = value; }

        }

        public int fprecio_venta
        {

            get { return (_precio_venta); }
            set { _precio_venta = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlProducto_join_lista_precios.actualizar(this);
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
                return CtrlProducto_join_lista_precios.guardar(this);
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
                CtrlProducto_join_lista_precios.eliminar(this._ID);
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

        //public Lista_precios getLista_precios()
        //{
        //    return CtrlLista_precios.getLista_precios(_lista_precios_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Producto_join_lista_precios
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String producto_ID
        {

            get { return ("producto_ID"); }
        }
        public static String lista_precios_ID
        {

            get { return ("lista_precios_ID"); }
        }
        public static String precio_venta
        {

            get { return ("precio_venta"); }
        }
    }//Fin clase estática

}//Fin name_space
