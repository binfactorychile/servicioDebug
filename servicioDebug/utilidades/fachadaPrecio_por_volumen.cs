using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaPrecio_por_volumen
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
        public static int guardar(Precio_por_volumen objeto)
        {
            try
            {
                Query query = new Query("insert", "precio_por_volumen");
                if (objeto.fID > 0)
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("cantidad_desde", objeto.fcantidad_desde);
                query.AddInsert("cantidad_hasta", objeto.fcantidad_hasta);
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("precio_venta_unitario", objeto.fprecio_venta_unitario);
                query.AddInsert("porcentaje_aumento_precio_base", objeto.fporcentaje_aumento_precio_base);
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM precio_por_volumen WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Precio_por_volumen_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Precio_por_volumen_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Precio_por_volumen_ID = Utils.cint(fila["ID"].ToString());
                }
                return Precio_por_volumen_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Precio_por_volumenJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "precio_por_volumen");
                if (objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("cantidad_desde", objeto.getCantidad_desde());
                query.AddInsert("cantidad_hasta", objeto.getCantidad_hasta());
                query.AddInsert("producto_ID", objeto.getProducto_ID());
                query.AddInsert("precio_venta_unitario", objeto.getPrecio_venta_unitario());
                query.AddInsert("porcentaje_aumento_precio_base", objeto.getPorcentaje_aumento_precio_base());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM precio_por_volumen WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Precio_por_volumen_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Precio_por_volumen_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Precio_por_volumen_ID = Utils.cint(fila["ID"].ToString());
                }
                return Precio_por_volumen_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Precio_por_volumen objeto)
        {
            try
            {
                Query query = new Query("update", "precio_por_volumen");
                query.AddSet("cantidad_desde", objeto.fcantidad_desde);
                query.AddSet("cantidad_hasta", objeto.fcantidad_hasta);
                query.AddSet("producto_ID", objeto.fproducto_ID);
                query.AddSet("precio_venta_unitario", objeto.fprecio_venta_unitario);
                query.AddSet("estado_vigente", objeto.festado_vigente);
                query.AddSet("porcentaje_aumento_precio_base", objeto.fporcentaje_aumento_precio_base);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Precio_por_volumenJSON objeto)
        {
            try
            {
                Query query = new Query("update", "precio_por_volumen");
                query.AddSet("cantidad_desde", objeto.getCantidad_desde());
                query.AddSet("cantidad_hasta", objeto.getCantidad_hasta());
                query.AddSet("producto_ID", objeto.getProducto_ID());
                query.AddSet("precio_venta_unitario", objeto.getPrecio_venta_unitario());
                query.AddSet("estado_vigente", objeto.getEstado_vigente());
                query.AddSet("porcentaje_aumento_precio_base", objeto.getPorcentaje_aumento_precio_base());
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

