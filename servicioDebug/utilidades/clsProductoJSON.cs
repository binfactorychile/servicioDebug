
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
        public string f2;//codigo_barra
        public string f3;//codigo_barra_grupo
        public string f4;//nombre
        public string f5;//descripcion
        public string f6;//stock_actual
        public string f7;//stock_minimo
        public string f8;//precio_venta
        public string f9;//unidad
        public string f10;//unidad_grupo
        public string f11;//cantidad_grupo
        public string f12;//estado
        public string f13;//ultimo_precio_compra
        public string f14;//ultimo_precio_venta
        public string f15;//ultima_fecha_compra
        public string f16;//ultima_fecha_venta
        public string f17;//margen_ganancia
        public string f18;//exento
        public string f19;//precio_venta_grupo
        public string f20;//cantidad_grupo_adicional
        public string f21;//producto_compuesto_ID
        public string f22;//cliente_proveedor_ID
        public string f23;//codigo_producto
        public string f24;//precio_base
        public string f25;//porcentaje_descuento
        public string f26;//impuesto_ID
        public string f30;//subcategoria_ID
        public string f98;
        public int f99;

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
                f6 = data["stock_actual"].ToString();
                f7 = data["stock_minimo"].ToString();
                double porcentaje_variacion =Utils.cdouble( data["porcentaje_variacion"].ToString());
                double precio_venta = Utils.cdouble(data["precio_venta"].ToString());
                precio_venta = precio_venta + (precio_venta * (porcentaje_variacion/100));
                f8 = precio_venta.ToString();
                f9 = data["unidad"].ToString();
                f10 = data["unidad_grupo"].ToString();
                f11 = data["cantidad_grupo"].ToString();
                f12 = data["estado"].ToString();
                f13 = data["ultimo_precio_compra"].ToString();
                f14 = data["ultimo_precio_venta"].ToString();
                f15 = data["ultima_fecha_compra"].ToString();
                f16 = data["ultima_fecha_venta"].ToString();
                f17 = data["margen_ganancia"].ToString();
                f18 = data["exento"].ToString();
                f19 = data["precio_venta_grupo"].ToString();
                f20 = data["cantidad_grupo_adicional"].ToString();
                f21 = data["producto_compuesto_ID"].ToString();
                f22 = data["cliente_proveedor_ID"].ToString();
                f23 = data["codigo_producto"].ToString();
                f24 = data["precio_base"].ToString();
                f25 = data["porcentaje_descuento"].ToString();
                f26 = data["impuesto_ID"].ToString();
                f30 = data["subcategoria_ID"].ToString();
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "ProductoJSON.Constructor");
            }
        }
        //CONSTRUCTOR
        public ProductoJSON(Producto producto)
        {
            try
            {
                //cursor.getString(11)
                f0 = producto.fID;
                f1 = producto.fcategoria_ID;
                f2 = producto.fcodigo_barra.ToString();
                f3 = producto.fcodigo_barra_grupo.ToString();
                f4 = producto.fnombre.ToString();
                f5 = producto.fdescripcion.ToString();
                f6 = producto.fstock_actual.ToString();
                f7 = producto.fstock_minimo.ToString();
                f8 = producto.fprecio_venta.ToString();
                f9 = producto.funidad.ToString();
                f10 = producto.funidad_grupo.ToString();
                f11 = producto.fcantidad_grupo.ToString();
                f12 = producto.festado.ToString();
                f13 = producto.fultimo_precio_compra.ToString();
                f14 = producto.fultimo_precio_venta.ToString();
                f15 = producto.fultima_fecha_compra.ToString();
                f16 = producto.fultima_fecha_venta.ToString();
                f17 = producto.fmargen_ganancia.ToString();
                f18 = producto.fexento.ToString();
                f19 = producto.fprecio_venta_grupo.ToString();
                f20 = producto.fcantidad_grupo_adicional.ToString();
                f21 = producto.fproducto_compuesto_ID.ToString();
                f22 = producto.fcliente_proveedor_ID.ToString();
                f23 = producto.fcodigo_producto.ToString();
                f24 = producto.fprecio_base.ToString();
                f25 = producto.fporcentaje_descuento.ToString();
                f26 = producto.fimpuesto_ID.ToString();
                f30 = producto.fsubcategoria_ID.ToString();
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
        public String getStock_actual()
        {
            return f6;
        }
        public String getStock_minimo()
        {
            return f7;
        }
        public String getPrecio_venta()
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
        public String getCantidad_grupo()
        {
            return f11;
        }
        public String getEstado()
        {
            return f12;
        }
        public String getUltimo_precio_compra()
        {
            return f13;
        }
        public String getUltimo_precio_venta()
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
        public String getMargen_ganancia()
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
        public String getPrecio_venta_grupo()
        {
            return f19;
        }
        public String getCantidad_grupo_adicional()
        {
            return f20;
        }
        public String getProducto_compuesto_ID()
        {
            return f21;
        }
        public String getCliente_proveedor_ID()
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
        public String getPrecio_base()
        {
            return f24;
        }
        public String getPorcentaje_descuento()
        {
            return f25;
        }
        public String getImpuesto_ID()
        {
            return f26;
        }
        public String getSubcategoria_ID()
        {
            return f30;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setCategoria_ID(int categoria_ID)
        {
            this.f1 = categoria_ID;
        }
        public void setCodigo_barra(string codigo_barra)
        {
            this.f2 = codigo_barra;
        }
        public void setCodigo_barra_grupo(string codigo_barra_grupo)
        {
            this.f3 = codigo_barra_grupo;
        }
        public void setNombre(string nombre)
        {
            this.f4 = nombre;
        }
        public void setDescripcion(string descripcion)
        {
            this.f5 = descripcion;
        }
        public void setStock_actual(string stock_actual)
        {
            this.f6 = stock_actual;
        }
        public void setStock_minimo(string stock_minimo)
        {
            this.f7 = stock_minimo;
        }
        public void setPrecio_venta(string precio_venta)
        {
            this.f8 = precio_venta;
        }
        public void setUnidad(string unidad)
        {
            this.f9 = unidad;
        }
        public void setUnidad_grupo(string unidad_grupo)
        {
            this.f10 = unidad_grupo;
        }
        public void setCantidad_grupo(string cantidad_grupo)
        {
            this.f11 = cantidad_grupo;
        }
        public void setEstado(string estado)
        {
            this.f12 = estado;
        }
        public void setUltimo_precio_compra(string ultimo_precio_compra)
        {
            this.f13 = ultimo_precio_compra;
        }
        public void setUltimo_precio_venta(string ultimo_precio_venta)
        {
            this.f14 = ultimo_precio_venta;
        }
        public void setUltima_fecha_compra(string ultima_fecha_compra)
        {
            this.f15 = ultima_fecha_compra;
        }
        public void setUltima_fecha_venta(string ultima_fecha_venta)
        {
            this.f16 = ultima_fecha_venta;
        }
        public void setMargen_ganancia(string margen_ganancia)
        {
            this.f17 = margen_ganancia;
        }
        public void setExento(string exento)
        {
            this.f18 = exento;
        }
        public void setPrecio_venta_grupo(string precio_venta_grupo)
        {
            this.f19 = precio_venta_grupo;
        }
        public void setCantidad_grupo_adicional(string cantidad_grupo_adicional)
        {
            this.f20 = cantidad_grupo_adicional;
        }
        public void setProducto_compuesto_ID(string producto_compuesto_ID)
        {
            this.f21 = producto_compuesto_ID;
        }
        public void setCliente_proveedor_ID(string cliente_proveedor_ID)
        {
            this.f22 = cliente_proveedor_ID;
        }
        public void setCodigo_producto(string codigo_producto)
        {
            this.f23 = codigo_producto;
        }
        public void setPrecio_base(string precio_base)
        {
            this.f24 = precio_base;
        }
        public void setPorcentaje_descuento(string porcentaje_descuento)
        {
            this.f25 = porcentaje_descuento;
        }
        public void setImpuesto_ID(string impuesto_ID)
        {
            this.f26 = impuesto_ID;
        }

        public void actualizar()
        {
            try
            {
                CtrlProducto.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Producto.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlProducto.guardarJSON(this);
        }

    }//fin clase lógica

}

