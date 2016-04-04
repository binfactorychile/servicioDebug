
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
        public string f1;//cantidad_desde
        public string f2;//cantidad_hasta
        public string f3;//producto_ID
        public string f4;//precio_venta_unitario
        public string f5;//estado_vigente
        public string f6;//porcentaje_aumento_precio_base
        public string f98;
        public int f99;

        //CONSTRUCTOR
        public Precio_por_volumenJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = data["cantidad_desde"].ToString();
                f2 = data["cantidad_hasta"].ToString();
                f3 = data["producto_ID"].ToString();
                f4 = data["precio_venta_unitario"].ToString();
                f5 = data["estado_vigente"].ToString();
                f6 = data["porcentaje_aumento_precio_base"].ToString();
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_volumenJSON.Constructor");
            }
        }
        //CONSTRUCTOR
        public Precio_por_volumenJSON(Precio_por_volumen precio_por_volumen)
        {
            try
            {
                //cursor.getString(11)
                f0 = precio_por_volumen.fID;
                f1 = precio_por_volumen.fcantidad_desde.ToString();
                f2 = precio_por_volumen.fcantidad_hasta.ToString();
                f3 = precio_por_volumen.fproducto_ID.ToString();
                f4 = precio_por_volumen.fprecio_venta_unitario.ToString();
                f5 = precio_por_volumen.festado_vigente.ToString();
                f6 = precio_por_volumen.fporcentaje_aumento_precio_base.ToString();
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
        public String getCantidad_desde()
        {
            return f1;
        }
        public String getCantidad_hasta()
        {
            return f2;
        }
        public String getProducto_ID()
        {
            return f3;
        }
        public String getPrecio_venta_unitario()
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
        public String getPorcentaje_aumento_precio_base()
        {
            return f6;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setCantidad_desde(string cantidad_desde)
        {
            this.f1 = cantidad_desde;
        }
        public void setCantidad_hasta(string cantidad_hasta)
        {
            this.f2 = cantidad_hasta;
        }
        public void setProducto_ID(string producto_ID)
        {
            this.f3 = producto_ID;
        }
        public void setPrecio_venta_unitario(string precio_venta_unitario)
        {
            this.f4 = precio_venta_unitario;
        }
        public void setEstado_vigente(string estado_vigente)
        {
            this.f5 = estado_vigente;
        }
        public void setPorcentaje_aumento_precio_base(string porcentaje_aumento_precio_base)
        {
            this.f6 = porcentaje_aumento_precio_base;
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

