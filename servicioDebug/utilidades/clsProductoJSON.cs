
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class ProductoJSON
    {
        public int f0;//ID
        public int f1;//categoria_ID
        public String f2;//codigo_barra
        public String f3;//codigo_barra_grupo
        public String f4;//nombre
        public String f5;//descripcion
        public int f6;//stock_actual
        public int f7;//stock_minimo
        public int f8;//precio_venta
        public String f9;//unidad
        public String f10;//unidad_grupo
        public int f11;//cantidad_grupo
        public int f12;//estado
        public int f13;//ultimo_precio_compra
        public int f14;//ultimo_precio_venta
        public String f15;//ultima_fecha_compra
        public String f16;//ultima_fecha_venta
        public int f17;//margen_ganancia
        public String f18;//exento
        public int f19;//precio_venta_grupo
        public string f20;//cantidad_grupo_adicional
        public int f21;//producto_compuesto_ID
        public int f22;//cliente_proveedor_ID
        public String f23;//codigo_producto
        public string f24;//tipo de accion (ingresar, eliminar)
        public int f25; //identificador del dispositivo que envio la sincronizacion o id de la sincronizacion_registro.
        //CONSTRUCTOR
        public ProductoJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["categoria_ID"].ToString());
                f2 = data["codigo_barra"].ToString();
                f3 = data["codigo_barra_grupo"].ToString();
                f4 = data["nombre"].ToString();
                f5 = data["descripcion"].ToString();
                f6 = Utils.cint(data["stock_actual"].ToString());
                f7 = Utils.cint(data["stock_minimo"].ToString());
                f8 = Utils.cint(data["precio_venta"].ToString());
                f9 = data["unidad"].ToString();
                f10 = data["unidad_grupo"].ToString();
                f11 = Utils.cint(data["cantidad_grupo"].ToString());
                f12 = Utils.cint(data["estado"].ToString());
                f13 = Utils.cint(data["ultimo_precio_compra"].ToString());
                f14 = Utils.cint(data["ultimo_precio_venta"].ToString());
                f15 = data["ultima_fecha_compra"].ToString();
                f16 = data["ultima_fecha_venta"].ToString();
                f17 = Utils.cint(data["margen_ganancia"].ToString());
                f18 = data["exento"].ToString();
                f19 = Utils.cint(data["precio_venta_grupo"].ToString());
                f20 = data["cantidad_grupo_adicional"].ToString();
                f21 = Utils.cint(data["producto_compuesto_ID"].ToString());
                f22 = Utils.cint(data["cliente_proveedor_ID"].ToString());
                f23 = data["codigo_producto"].ToString();
                f24 = accion;
                f25 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "ProductoJSON.Constructor");
            }
        }
        public ProductoJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getCategoria_ID()
        {
            return f1;
        }
        public String getCodigo_barra()
        {
            if (f2 != null)
                return f2;
            else
                return "";
        }
        public String getCodigo_barra_grupo()
        {
            if (f3 != null)
                return f3;
            else
                return "";
        }
        public String getNombre()
        {
            if (f4 != null)
                return f4;
            else
                return "";
        }
        public String getDescripcion()
        {
            if (f5 != null)
                return f5;
            else
                return "";
        }
        public int getStock_actual()
        {
            return f6;
        }
        public int getStock_minimo()
        {
            return f7;
        }
        public int getPrecio_venta()
        {
            return f8;
        }
        public String getUnidad()
        {
            if (f9 != null)
                return f9;
            else
                return "";
        }
        public String getUnidad_grupo()
        {
            if (f10 != null)
                return f10;
            else
                return "";
        }
        public int getCantidad_grupo()
        {
            return f11;
        }
        public int getEstado()
        {
            return f12;
        }
        public int getUltimo_precio_compra()
        {
            return f13;
        }
        public int getUltimo_precio_venta()
        {
            return f14;
        }
        public String getUltima_fecha_compra()
        {
            if (f15 != null)
                return f15;
            else
                return "";
        }
        public String getUltima_fecha_venta()
        {
            if (f16 != null)
                return f16;
            else
                return "";
        }
        public int getMargen_ganancia()
        {
            return f17;
        }
        public String getExento()
        {
            if (f18 != null)
                return f18;
            else
                return "";
        }
        public int getPrecio_venta_grupo()
        {
            return f19;
        }
        public string getCantidad_grupo_adicional()
        {
            return f20;
        }
        public int getProducto_compuesto_ID()
        {
            return f21;
        }
        public int getCliente_proveedor_ID()
        {
            return f22;
        }
        public String getCodigo_producto()
        {
            if (f23 != null)
                return f23;
            else
                return "";
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setCategoria_ID(int categoria_ID)
        {
            this.f1 = categoria_ID;
        }
        public void setCodigo_barra(String codigo_barra)
        {
            this.f2 = codigo_barra;
        }
        public void setCodigo_barra_grupo(String codigo_barra_grupo)
        {
            this.f3 = codigo_barra_grupo;
        }
        public void setNombre(String nombre)
        {
            this.f4 = nombre;
        }
        public void setDescripcion(String descripcion)
        {
            this.f5 = descripcion;
        }
        public void setStock_actual(int stock_actual)
        {
            this.f6 = stock_actual;
        }
        public void setStock_minimo(int stock_minimo)
        {
            this.f7 = stock_minimo;
        }
        public void setPrecio_venta(int precio_venta)
        {
            this.f8 = precio_venta;
        }
        public void setUnidad(String unidad)
        {
            this.f9 = unidad;
        }
        public void setUnidad_grupo(String unidad_grupo)
        {
            this.f10 = unidad_grupo;
        }
        public void setCantidad_grupo(int cantidad_grupo)
        {
            this.f11 = cantidad_grupo;
        }
        public void setEstado(int estado)
        {
            this.f12 = estado;
        }
        public void setUltimo_precio_compra(int ultimo_precio_compra)
        {
            this.f13 = ultimo_precio_compra;
        }
        public void setUltimo_precio_venta(int ultimo_precio_venta)
        {
            this.f14 = ultimo_precio_venta;
        }
        public void setUltima_fecha_compra(String ultima_fecha_compra)
        {
            this.f15 = ultima_fecha_compra;
        }
        public void setUltima_fecha_venta(String ultima_fecha_venta)
        {
            this.f16 = ultima_fecha_venta;
        }
        public void setMargen_ganancia(int margen_ganancia)
        {
            this.f17 = margen_ganancia;
        }
        public void setExento(String exento)
        {
            this.f18 = exento;
        }
        public void setPrecio_venta_grupo(int precio_venta_grupo)
        {
            this.f19 = precio_venta_grupo;
        }
        public void setCantidad_grupo_adicional(string cantidad_grupo_adicional)
        {
            this.f20 = cantidad_grupo_adicional;
        }
        public void setProducto_compuesto_ID(int producto_compuesto_ID)
        {
            this.f21 = producto_compuesto_ID;
        }
        public void setCliente_proveedor_ID(int cliente_proveedor_ID)
        {
            this.f22 = cliente_proveedor_ID;
        }
        public void setCodigo_producto(String codigo_producto)
        {
            this.f23 = codigo_producto;
        }

        //public void actualizar()
        //{
        //    try
        //    {
        //        CtrlProducto.actualizarJSON(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex, "Producto.actualizarJSON");
        //    }
        //}
        //public int guardar()
        //{
        //    return CtrlProducto.guardarJSON(this);
        //}

    }//fin clase lógica

}

