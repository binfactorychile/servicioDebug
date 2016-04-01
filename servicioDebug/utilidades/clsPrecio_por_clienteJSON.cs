
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Precio_por_clienteJSON
    {
        public string f0;//ID
        public string f1;//cliente_proveedor_ID
        public string f2;//producto_ID
        public string f3;//precio_venta_unitario
        public string f4;//cantidad_minima
        public string f5;//estado_vigente
        public string f6;//porcentaje_aumento_precio_base
        public string f98;
        public int f99;

        //CONSTRUCTOR
        public Precio_por_clienteJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = data["ID"].ToString();
                f1 = data["cliente_proveedor_ID"].ToString();
                f2 = data["producto_ID"].ToString();
                f3 = data["precio_venta_unitario"].ToString();
                f4 = data["cantidad_minima"].ToString();
                f5 = data["estado_vigente"].ToString();
                f6 = data["porcentaje_aumento_precio_base"].ToString();
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_clienteJSON.Constructor");
            }
        }
        //CONSTRUCTOR
        public Precio_por_clienteJSON(Precio_por_cliente precio_por_cliente)
        {
            try
            {
                //cursor.getString(11)
                f0 = precio_por_cliente.fID.ToString();
                f1 = precio_por_cliente.fcliente_proveedor_ID.ToString();
                f2 = precio_por_cliente.fproducto_ID.ToString();
                f3 = precio_por_cliente.fprecio_venta_unitario.ToString();
                f4 = precio_por_cliente.fcantidad_minima.ToString();
                f5 = precio_por_cliente.festado_vigente.ToString();
                f6 = precio_por_cliente.fporcentaje_aumento_precio_base.ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Precio_por_clienteJSON.Constructor");
            }
        }
        public Precio_por_clienteJSON()
        {
        }
        public String getID()
        {
            return f0;
        }
        public String getCliente_proveedor_ID()
        {
            return f1;
        }
        public String getProducto_ID()
        {
            return f2;
        }
        public String getPrecio_venta_unitario()
        {
            return f3;
        }
        public String getCantidad_minima()
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
        public void setID(string ID)
        {
            this.f0 = ID;
        }
        public void setCliente_proveedor_ID(string cliente_proveedor_ID)
        {
            this.f1 = cliente_proveedor_ID;
        }
        public void setProducto_ID(string producto_ID)
        {
            this.f2 = producto_ID;
        }
        public void setPrecio_venta_unitario(string precio_venta_unitario)
        {
            this.f3 = precio_venta_unitario;
        }
        public void setCantidad_minima(string cantidad_minima)
        {
            this.f4 = cantidad_minima;
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

