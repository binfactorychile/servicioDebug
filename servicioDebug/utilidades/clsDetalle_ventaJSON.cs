
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Detalle_ventaJSON
    {
        public int f0;//ID
        public int f1;//producto_ID
        public int f2;//detalle_comprobante_contable_ID
        public string f3;//cantidad
        public int f4;//precio_unitario
        public int f5;//descuento
        public int f6;//iva
        public int f7;//total
        public int f8;//venta_ID
        public int f9;//estado
        public String f10;//es_promocion

        //CONSTRUCTOR
        public Detalle_ventaJSON(DataRow data)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["producto_ID"].ToString());
                f2 = Utils.cint(data["detalle_comprobante_contable_ID"].ToString());
                f3 = data["cantidad"].ToString();
                f4 = Utils.cint(data["precio_unitario"].ToString());
                f5 = Utils.cint(data["descuento"].ToString());
                f6 = Utils.cint(data["iva"].ToString());
                f7 = Utils.cint(data["total"].ToString());
                f8 = Utils.cint(data["venta_ID"].ToString());
                f9 = Utils.cint(data["estado"].ToString());
                f10 = data["es_promocion"].ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Detalle_ventaJSON.Constructor");
            }
        }
        public Detalle_ventaJSON()
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
        public int getDetalle_comprobante_contable_ID()
        {
            return f2;
        }
        public string getCantidad()
        {
            return f3;
        }
        public int getPrecio_unitario()
        {
            return f4;
        }
        public int getDescuento()
        {
            return f5;
        }
        public int getIva()
        {
            return f6;
        }
        public int getTotal()
        {
            return f7;
        }
        public int getVenta_ID()
        {
            return f8;
        }
        public int getEstado()
        {
            return f9;
        }
        public String getEs_promocion()
        {
            if (f10 != null)
                return f10;
            else
                return "";
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setProducto_ID(int producto_ID)
        {
            this.f1 = producto_ID;
        }
        public void setDetalle_comprobante_contable_ID(int detalle_comprobante_contable_ID)
        {
            this.f2 = detalle_comprobante_contable_ID;
        }
        public void setCantidad(string cantidad)
        {
            this.f3 = cantidad;
        }
        public void setPrecio_unitario(int precio_unitario)
        {
            this.f4 = precio_unitario;
        }
        public void setDescuento(int descuento)
        {
            this.f5 = descuento;
        }
        public void setIva(int iva)
        {
            this.f6 = iva;
        }
        public void setTotal(int total)
        {
            this.f7 = total;
        }
        public void setVenta_ID(int venta_ID)
        {
            this.f8 = venta_ID;
        }
        public void setEstado(int estado)
        {
            this.f9 = estado;
        }
        public void setEs_promocion(String es_promocion)
        {
            this.f10 = es_promocion;
        }

        //public void actualizar()
        //{
        //    try
        //{
        //    CtrlDetalle_venta.actualizarJSON(this);
        //}
        //catch(Exception ex)
        //{
        //    Utils.EscribeLog(ex,"Detalle_venta.actualizarJSON");
        //}
        //}
        //public int guardar()
        //{
        //    return  CtrlDetalle_venta.guardarJSON(this);
        //}

    }
    //fin clase lógica
}


