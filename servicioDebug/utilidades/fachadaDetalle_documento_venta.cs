using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaDetalle_documento_venta
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
        public static int guardar(Detalle_documento_venta objeto)
        {
            try
            {
                Query query = new Query("insert", "detalle_documento_venta");
             
                if (objeto.fID > 0)
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("documento_venta_ID", objeto.fdocumento_venta_ID);
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("cantidad", objeto.fcantidad);
                query.AddInsert("monto_descuento", objeto.fmonto_descuento);
                query.AddInsert("precio_neto_unitario", objeto.fprecio_neto_unitario);
                query.AddInsert("monto_impuesto", objeto.fmonto_impuesto);
                query.AddInsert("porcentaje_descuento", objeto.fporcentaje_descuento);
                query.AddInsert("total_neto", objeto.ftotal_neto);
                query.AddInsert("iva", objeto.fiva);
                query.AddInsert("total_bruto", objeto.ftotal_bruto);
                query.AddInsert("estado", objeto.festado);
                query.AddInsert("es_promocion", objeto.fes_promocion);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM detalle_documento_venta WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Detalle_documento_venta_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Detalle_documento_venta_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Detalle_documento_venta_ID = Utils.cint(fila["ID"].ToString());
                }
                return Detalle_documento_venta_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Detalle_documento_ventaJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "detalle_documento_venta");
                if (objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("documento_venta_ID", objeto.getDocumento_venta_ID());
                query.AddInsert("producto_ID", objeto.getProducto_ID());
                query.AddInsert("cantidad", objeto.getCantidad());
                query.AddInsert("monto_descuento", objeto.getMonto_descuento());
                query.AddInsert("precio_neto_unitario", objeto.getPrecio_neto_unitario());
                query.AddInsert("monto_impuesto", objeto.getMonto_impuesto());
                query.AddInsert("porcentaje_descuento", objeto.getPorcentaje_descuento());
                query.AddInsert("total_neto", objeto.getTotal_neto());
                query.AddInsert("iva", objeto.getIva());
                query.AddInsert("total_bruto", objeto.getTotal_bruto());
                query.AddInsert("estado", objeto.getEstado());
                query.AddInsert("es_promocion", objeto.getEs_promocion());
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM detalle_documento_venta WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Detalle_documento_venta_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Detalle_documento_venta_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Detalle_documento_venta_ID = Utils.cint(fila["ID"].ToString());
                }
                return Detalle_documento_venta_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Detalle_documento_venta objeto)
        {
            try
            {
                Query query = new Query("update", "detalle_documento_venta");
                query.AddSet("documento_venta_ID", objeto.fdocumento_venta_ID);
                query.AddSet("producto_ID", objeto.fproducto_ID);
                query.AddSet("cantidad", objeto.fcantidad);
                query.AddSet("monto_descuento", objeto.fmonto_descuento);
                query.AddSet("precio_neto_unitario", objeto.fprecio_neto_unitario);
                query.AddSet("monto_impuesto", objeto.fmonto_impuesto);
                query.AddSet("porcentaje_descuento", objeto.fporcentaje_descuento);
                query.AddSet("total_neto", objeto.ftotal_neto);
                query.AddSet("iva", objeto.fiva);
                query.AddSet("total_bruto", objeto.ftotal_bruto);
                query.AddSet("estado", objeto.festado);
                query.AddSet("es_promocion", objeto.fes_promocion);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Detalle_documento_ventaJSON objeto)
        {
            try
            {
                Query query = new Query("update", "detalle_documento_venta");
                query.AddSet("documento_venta_ID", objeto.getDocumento_venta_ID());
                query.AddSet("producto_ID", objeto.getProducto_ID());
                query.AddSet("cantidad", objeto.getCantidad());
                query.AddSet("monto_descuento", objeto.getMonto_descuento());
                query.AddSet("precio_neto_unitario", objeto.getPrecio_neto_unitario());
                query.AddSet("monto_impuesto", objeto.getMonto_impuesto());
                query.AddSet("porcentaje_descuento", objeto.getPorcentaje_descuento());
                query.AddSet("total_neto", objeto.getTotal_neto());
                query.AddSet("iva", objeto.getIva());
                query.AddSet("total_bruto", objeto.getTotal_bruto());
                query.AddSet("estado", objeto.getEstado());
                query.AddSet("es_promocion", objeto.getEs_promocion());
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

    }//Fin Clase
}//Fin name_space

