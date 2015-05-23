
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Precio_por_clienteJSON
    {
        public int f0;//ID
        public int f1;//cliente_proveedor_ID
        public int f2;//producto_ID
        public int f3;//precio_venta_unitario
        public int f4;//cantidad_minima
        public String f5;//estado_vigente
        public string f6; //accion
        public int f7; //servidor_ID

        //CONSTRUCTOR
        public Precio_por_clienteJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["cliente_proveedor_ID"].ToString());
                f2 = Utils.cint(data["producto_ID"].ToString());
                f3 = Utils.cint(data["precio_venta_unitario"].ToString());
                f4 = Utils.cint(data["cantidad_minima"].ToString());
                f5 = data["estado_vigente"].ToString();
                f6 = accion;
                f7 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_clienteJSON.Constructor");
            }
        }
        public Precio_por_clienteJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getCliente_proveedor_ID()
        {
            return f1;
        }
        public int getProducto_ID()
        {
            return f2;
        }
        public int getPrecio_venta_unitario()
        {
            return f3;
        }
        public int getCantidad_minima()
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
        public void setCliente_proveedor_ID(int cliente_proveedor_ID)
        {
            this.f1 = cliente_proveedor_ID;
        }
        public void setProducto_ID(int producto_ID)
        {
            this.f2 = producto_ID;
        }
        public void setPrecio_venta_unitario(int precio_venta_unitario)
        {
            this.f3 = precio_venta_unitario;
        }
        public void setCantidad_minima(int cantidad_minima)
        {
            this.f4 = cantidad_minima;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f5 = estado_vigente;
        }

        public void actualizar()
        {
            try
            {
                CtrlPrecio_por_cliente.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_cliente.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlPrecio_por_cliente.guardarJSON(this);
        }

    }//fin clase lógica

}

