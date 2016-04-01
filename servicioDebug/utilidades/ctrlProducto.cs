using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlProducto
    {
        public static Producto[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Producto.estado_vigente, "vigente");
                DataSet dataset = FachadaProducto.getListado(query);
                Producto[] arrproducto = new Producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto objeto = new Producto(fila);
                        if (dataset.Tables[0].Columns["nombreCategoria"] != null)
                            objeto.fnombreCategoria = fila["nombreCategoria"].ToString();
                        arrproducto[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Producto[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaProducto.getListado(query);
                Producto[] arrproducto = new Producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto objeto = new Producto(fila);
                        arrproducto[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Producto[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "producto");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaProducto.getListado(query);
                Producto[] arrproducto = new Producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto objeto = new Producto(fila);
                        arrproducto[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static void actualizarPrecioVenta(Producto producto)
        {
            Query query = new Query("update", "producto");
            query.AddSet("precio_venta", producto.fprecio_venta.ToString());
            query.AddWhere("ID", producto.fID.ToString());
            BDConnect.EjecutaSinRetorno(query.listo());

        }
        public static void aumentarStock(int bodega_ID, int producto_ID, double cantidadDevolucion)
        {

            FachadaProducto.AumentarStock(bodega_ID, producto_ID, cantidadDevolucion);
            Producto producto = getProducto(producto_ID);
            producto.fstock_actual = producto.fstock_actual + cantidadDevolucion;
            actualizar(producto);
        }
        private static int GetPrecioCompraProducto(Producto producto, int precioNetoUnitario, int precioFleteUnitario)
        {
            int porcentajeAcumuladosImpuestos = 0;
            //Query query = new Query("select", ST_Tablas.categoria_impuesto);
            //query.AddWhere(ST_Categoria_impuesto.categoria_ID, producto.getCategoria().fID.ToString());
            //Categoria_impuesto[] ArrCategoriaImpuesto = CtrlCategoria_impuesto.getListado(query);

            //foreach (Categoria_impuesto item in ArrCategoriaImpuesto)
            //{
            //    porcentajeAcumuladosImpuestos += item.getImpuesto().fporcentaje;
            //}
            double montoImpuestos = 0;
            if (porcentajeAcumuladosImpuestos > 0)
                montoImpuestos = (precioNetoUnitario * porcentajeAcumuladosImpuestos) / 100;

            double precioNetoDouble = Utils.cdouble(precioNetoUnitario.ToString());
            if (producto.fexento == null)
            {
                precioNetoDouble = precioNetoDouble * 1.19;
            }
            else if (producto.fexento == "no")
                precioNetoDouble = precioNetoDouble * 1.19;

            precioNetoDouble += montoImpuestos;
            precioNetoDouble = Math.Round(precioNetoDouble, 0, MidpointRounding.AwayFromZero);
            return Utils.cint(precioNetoDouble.ToString()) + precioFleteUnitario;
        }
        public static int guardar(Producto objeto)
        {
            try
            {
                return FachadaProducto.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(ProductoJSON objeto)
        {
            try
            {
                return FachadaProducto.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Producto objeto)
        {
            try
            {
                FachadaProducto.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(ProductoJSON objeto)
        {
            try
            {
                FachadaProducto.actualizarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void eliminar(Query query)
        {
            try
            {
                FachadaProducto.eliminar(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void eliminar(int ID)
        {
            try
            {
                Query query = new Query("delete", "producto");
                query.AddWhere("ID", ID.ToString());
                FachadaProducto.eliminar(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void ejecutaSin_retorno(Query query)
        {
            try
            {
                FachadaProducto.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Producto getProducto(int id)
        {
            try
            {
                Query query = new Query("select", "producto");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Producto objeto = new Producto();
                DataSet dataset = FachadaProducto.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Producto(fila);
                        contador++;
                    }
                }
                return objeto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static int getID(string nombre)
        {
            try
            {
                if (nombre.Length > 0)
                {
                    nombre = nombre.Trim();
                    Query query = new Query("producto");
                    query.AddWhereExacto(ST_Producto.nombre, nombre);
                    Producto[] arrProducto = getListado(query);
                    if (arrProducto.Length > 0)
                    {
                        return arrProducto[0].fID;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
    }
}//Fin name_space
 //------------------------------------------------------------------------------
 //	FIN CONTROLADOR
 //------------------------------------------------------------------------------
