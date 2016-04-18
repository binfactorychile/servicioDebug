using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaProducto
    {

        public static DataSet getListado(Query query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static DataSet getListado(string query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static int guardar(Producto objeto)
        {
            try
            {
                Query query = new Query("insert", "producto");
                query.AddInsert("categoria_ID", objeto.fcategoria_ID);
                query.AddInsert("codigo_barra", objeto.fcodigo_barra);
                query.AddInsert("codigo_barra_grupo", objeto.fcodigo_barra_grupo);
                query.AddInsert("nombre", objeto.fnombre);
                query.AddInsert("descripcion", objeto.fdescripcion);
                query.AddInsert("stock_actual", objeto.fstock_actual);
                query.AddInsert("stock_minimo", objeto.fstock_minimo);
                query.AddInsert("precio_venta", objeto.fprecio_venta);
                query.AddInsert("unidad", objeto.funidad);
                query.AddInsert("unidad_grupo", objeto.funidad_grupo);
                query.AddInsert("cantidad_grupo", objeto.fcantidad_grupo);
                query.AddInsert("estado", objeto.festado);
                query.AddInsert("ultimo_precio_compra", objeto.fultimo_precio_compra);
                query.AddInsert("ultimo_precio_venta", objeto.fultimo_precio_venta);
                query.AddInsert("ultima_fecha_compra", objeto.fultima_fecha_compra);
                query.AddInsert("ultima_fecha_venta", objeto.fultima_fecha_venta);
                query.AddInsert("margen_ganancia", objeto.fmargen_ganancia);
                query.AddInsert("exento", objeto.fexento);
                query.AddInsert("precio_venta_grupo", objeto.fprecio_venta_grupo);
                query.AddInsert("cantidad_grupo_adicional", objeto.fcantidad_grupo_adicional);
                query.AddInsert("producto_compuesto_ID", objeto.fproducto_compuesto_ID);
                query.AddInsert("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
                query.AddInsert("codigo_producto", objeto.fcodigo_producto);
                query.AddInsert("precio_base", objeto.fprecio_base);
                query.AddInsert("porcentaje_descuento", objeto.fporcentaje_descuento);
                query.AddInsert("impuesto_ID", objeto.fimpuesto_ID);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM producto WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Producto_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Producto_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Producto_ID = Utils.cint(fila["ID"].ToString());
                }

                query = new Query("insert", "bodega_producto");
                query.AddInsert("producto_ID", objeto.fID);
                query.AddInsert("bodega_ID", 2);
                query.AddInsert("cantidad", objeto.fstock_actual);
                BDConnect.EjecutaConRetorno(query.listo());

                return Producto_ID;
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
                Query query = new Query("insert", "producto");
                query.AddInsert("categoria_ID", objeto.getCategoria_ID());
                query.AddInsert("codigo_barra", objeto.getCodigo_barra());
                query.AddInsert("codigo_barra_grupo", objeto.getCodigo_barra_grupo());
                query.AddInsert("nombre", objeto.getNombre());
                query.AddInsert("descripcion", objeto.getDescripcion());
                query.AddInsert("stock_actual", objeto.getStock_actual());
                query.AddInsert("stock_minimo", objeto.getStock_minimo());
                query.AddInsert("precio_venta", objeto.getPrecio_venta());
                query.AddInsert("unidad", objeto.getUnidad());
                query.AddInsert("unidad_grupo", objeto.getUnidad_grupo());
                query.AddInsert("cantidad_grupo", objeto.getCantidad_grupo());
                query.AddInsert("estado", objeto.getEstado());
                query.AddInsert("ultimo_precio_compra", objeto.getUltimo_precio_compra());
                query.AddInsert("ultimo_precio_venta", objeto.getUltimo_precio_venta());
                query.AddInsert("ultima_fecha_compra", objeto.getUltima_fecha_compra());
                query.AddInsert("ultima_fecha_venta", objeto.getUltima_fecha_venta());
                query.AddInsert("margen_ganancia", objeto.getMargen_ganancia());
                query.AddInsert("exento", objeto.getExento());
                query.AddInsert("precio_venta_grupo", objeto.getPrecio_venta_grupo());
                query.AddInsert("cantidad_grupo_adicional", objeto.getCantidad_grupo_adicional());
                query.AddInsert("producto_compuesto_ID", objeto.getProducto_compuesto_ID());
                query.AddInsert("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
                query.AddInsert("codigo_producto", objeto.getCodigo_producto());
                query.AddInsert("precio_base", objeto.getPrecio_base());
                query.AddInsert("porcentaje_descuento", objeto.getPorcentaje_descuento());
                query.AddInsert("impuesto_ID", objeto.getImpuesto_ID());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM producto WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Producto_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Producto_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Producto_ID = Utils.cint(fila["ID"].ToString());
                }
                return Producto_ID;
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
                Query query = new Query("update", "producto");
                query.AddSet("categoria_ID", objeto.fcategoria_ID);
                query.AddSet("codigo_barra", objeto.fcodigo_barra);
                query.AddSet("codigo_barra_grupo", objeto.fcodigo_barra_grupo);
                query.AddSet("nombre", objeto.fnombre);
                query.AddSet("descripcion", objeto.fdescripcion);
                query.AddSet("stock_actual", objeto.fstock_actual);
                query.AddSet("stock_minimo", objeto.fstock_minimo);
                query.AddSet("precio_venta", objeto.fprecio_venta);
                query.AddSet("unidad", objeto.funidad);
                query.AddSet("unidad_grupo", objeto.funidad_grupo);
                query.AddSet("cantidad_grupo", objeto.fcantidad_grupo);
                query.AddSet("estado", objeto.festado);
                query.AddSet("ultimo_precio_compra", objeto.fultimo_precio_compra);
                query.AddSet("ultimo_precio_venta", objeto.fultimo_precio_venta);
                query.AddSet("ultima_fecha_compra", objeto.fultima_fecha_compra);
                query.AddSet("ultima_fecha_venta", objeto.fultima_fecha_venta);
                query.AddSet("margen_ganancia", objeto.fmargen_ganancia);
                query.AddSet("exento", objeto.fexento);
                query.AddSet("precio_venta_grupo", objeto.fprecio_venta_grupo);
                query.AddSet("cantidad_grupo_adicional", objeto.fcantidad_grupo_adicional);
                query.AddSet("producto_compuesto_ID", objeto.fproducto_compuesto_ID);
                query.AddSet("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
                query.AddSet("codigo_producto", objeto.fcodigo_producto);
                query.AddSet("precio_base", objeto.fprecio_base);
                query.AddSet("porcentaje_descuento", objeto.fporcentaje_descuento);
                query.AddSet("impuesto_ID", objeto.fimpuesto_ID);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
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
                Query query = new Query("update", "producto");
                query.AddSet("categoria_ID", objeto.getCategoria_ID());
                query.AddSet("codigo_barra", objeto.getCodigo_barra());
                query.AddSet("codigo_barra_grupo", objeto.getCodigo_barra_grupo());
                query.AddSet("nombre", objeto.getNombre());
                query.AddSet("descripcion", objeto.getDescripcion());
                query.AddSet("stock_actual", objeto.getStock_actual());
                query.AddSet("stock_minimo", objeto.getStock_minimo());
                query.AddSet("precio_venta", objeto.getPrecio_venta());
                query.AddSet("unidad", objeto.getUnidad());
                query.AddSet("unidad_grupo", objeto.getUnidad_grupo());
                query.AddSet("cantidad_grupo", objeto.getCantidad_grupo());
                query.AddSet("estado", objeto.getEstado());
                query.AddSet("ultimo_precio_compra", objeto.getUltimo_precio_compra());
                query.AddSet("ultimo_precio_venta", objeto.getUltimo_precio_venta());
                query.AddSet("ultima_fecha_compra", objeto.getUltima_fecha_compra());
                query.AddSet("ultima_fecha_venta", objeto.getUltima_fecha_venta());
                query.AddSet("margen_ganancia", objeto.getMargen_ganancia());
                query.AddSet("exento", objeto.getExento());
                query.AddSet("precio_venta_grupo", objeto.getPrecio_venta_grupo());
                query.AddSet("cantidad_grupo_adicional", objeto.getCantidad_grupo_adicional());
                query.AddSet("producto_compuesto_ID", objeto.getProducto_compuesto_ID());
                query.AddSet("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
                query.AddSet("codigo_producto", objeto.getCodigo_producto());
                query.AddSet("precio_base", objeto.getPrecio_base());
                query.AddSet("porcentaje_descuento", objeto.getPorcentaje_descuento());
                query.AddSet("impuesto_ID", objeto.getImpuesto_ID());
                query.AddWhere("ID", objeto.getID().ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
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
                BDConnect.EjecutaSinRetorno(query.listo());
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
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static DataSet get_stock_bodega(int bodega_ID, int producto_ID)
        {
            Query query = new Query("select", "bodega_producto");
            query.AddWhere("bodega_ID", bodega_ID.ToString());
            query.AddWhere("producto_ID", producto_ID.ToString());
            query.AddSelect("*");
            return BDConnect.Exec_cQuery(query.listo());
        }
        public static void rebajarStock(int bodega_ID, int producto_ID, double cantidad)
        {
            string _query = "UPDATE bodega_producto SET cantidad=cantidad-" + cantidad.ToString().Replace(",", ".") + " WHERE producto_ID=" + producto_ID.ToString() + " AND bodega_ID=" + bodega_ID.ToString();
            //Query query = new Query("update", "bodega_producto");
            //query.AddSet("cantidad", "cantidad-" + cantidad.ToString().Replace(",","."));
            //query.AddWhere("producto_ID", producto_ID.ToString());
            //query.AddWhere("bodega_ID", bodega_ID.ToString());
            BDConnect.Exec_sQuery(_query);
        }
        public static void AumentarStock(int bodega_ID, int producto_ID, double cantidad)
        {
            //Query query = new Query("update", "bodega_producto");
            //query.AddSet("cantidad", "cantidad+" + cantidad.ToString());
            //query.AddWhere("producto_ID", producto_ID.ToString());
            //query.AddWhere("bodega_ID", bodega_ID.ToString());
            string _query = "UPDATE bodega_producto SET cantidad=cantidad+" + cantidad.ToString().Replace(",", ".") + " WHERE producto_ID=" + producto_ID.ToString() + " AND bodega_ID=" + bodega_ID.ToString();
            BDConnect.Exec_sQuery(_query);
        }
    }//Fin Clase
}//Fin name_space

