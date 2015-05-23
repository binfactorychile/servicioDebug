
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Precio_por_volumenJSON
    {
        public int f0;//ID
        public int f1;//cantidad_desde
        public int f2;//cantidad_hasta
        public int f3;//producto_ID
        public int f4;//precio_venta_unitario
        public String f5;//estado_vigente
        public string f6;//accion
        public int f7;//servidor_ID
        //CONSTRUCTOR
        public Precio_por_volumenJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["cantidad_desde"].ToString());
                f2 = Utils.cint(data["cantidad_hasta"].ToString());
                f3 = Utils.cint(data["producto_ID"].ToString());
                f4 = Utils.cint(data["precio_venta_unitario"].ToString());
                f5 = data["estado_vigente"].ToString();
                f6 = accion;
                f7 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_volumenJSON.Constructor");
            }
        }
        public Precio_por_volumenJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getCantidad_desde()
        {
            return f1;
        }
        public int getCantidad_hasta()
        {
            return f2;
        }
        public int getProducto_ID()
        {
            return f3;
        }
        public int getPrecio_venta_unitario()
        {
            return f4;
        }
        public String getEstado_vigente()
        {
            if (f5 != null)
                return f5;
            else
                return "";
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setCantidad_desde(int cantidad_desde)
        {
            this.f1 = cantidad_desde;
        }
        public void setCantidad_hasta(int cantidad_hasta)
        {
            this.f2 = cantidad_hasta;
        }
        public void setProducto_ID(int producto_ID)
        {
            this.f3 = producto_ID;
        }
        public void setPrecio_venta_unitario(int precio_venta_unitario)
        {
            this.f4 = precio_venta_unitario;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f5 = estado_vigente;
        }

        public void actualizar()
        {
            try
            {
                CtrlPrecio_por_volumen.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_volumen.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlPrecio_por_volumen.guardarJSON(this);
        }

    }//fin clase lógica

}

