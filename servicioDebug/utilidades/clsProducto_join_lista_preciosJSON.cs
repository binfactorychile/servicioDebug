
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Producto_join_lista_preciosJSON
    {
        public int f0;//ID
        public int f1;//producto_ID
        public int f2;//lista_precios_ID
        public double f3;//precio_venta
        public double f4;//cantidad_limite
        public string f98; //accion
        public int f99; //servidor_ID
        
        //CONSTRUCTOR
        public Producto_join_lista_preciosJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["producto_ID"].ToString());
                f2 = Utils.cint(data["lista_precios_ID"].ToString());
                f3 = Utils.cdouble(data["precio_venta"].ToString());
                f4 = Utils.cdouble(data["cantidad_limite"].ToString());
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Producto_join_lista_preciosJSON.Constructor");
            }
        }
        public Producto_join_lista_preciosJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getProducto_ID()
        {
            return f1;
        }
        public int getLista_precios_ID()
        {
            return f2;
        }
        public double getPrecio_venta()
        {
            return f3;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setProducto_ID(int producto_ID)
        {
            this.f1 = producto_ID;
        }
        public void setLista_precios_ID(int lista_precios_ID)
        {
            this.f2 = lista_precios_ID;
        }
        public void setPrecio_venta(int precio_venta)
        {
            this.f3 = precio_venta;
        }

        public double fcantidad_limite
        {

            get { return (f4); }
            set { f4 = value; }

        }

        //public void actualizar()
        //{
        //    try
        //    {
        //        CtrlProducto_join_lista_precios.actualizarJSON(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex, "Producto_join_lista_precios.actualizarJSON");
        //    }
        //}
        //public int guardar()
        //{
        //    return CtrlProducto_join_lista_precios.guardarJSON(this);
        //}

    }//fin clase lógica

}

