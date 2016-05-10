using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaProducto_join_lista_precios
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
        public static int guardar(Producto_join_lista_precios objeto)
        {
            try
            {
                Query query = new Query("insert", "producto_join_lista_precios");
                if (objeto.fID > 0)
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("lista_precios_ID", objeto.flista_precios_ID);
                query.AddInsert("precio_venta", objeto.fprecio_venta);
                query.AddInsert("cantidad_limite", objeto.fprecio_venta);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

               // string queryID = "SELECT ID FROM producto_join_lista_precios WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Producto_join_lista_precios_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Producto_join_lista_precios_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Producto_join_lista_precios_ID = Utils.cint(fila["ID"].ToString());
                }
                return Producto_join_lista_precios_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Producto_join_lista_preciosJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "producto_join_lista_precios");
                if(objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("producto_ID", objeto.getProducto_ID());
                query.AddInsert("lista_precios_ID", objeto.getLista_precios_ID());
                query.AddInsert("precio_venta", objeto.getPrecio_venta());
                query.AddInsert("cantidad_limite", objeto.fcantidad_limite);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM producto_join_lista_precios WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Producto_join_lista_precios_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Producto_join_lista_precios_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Producto_join_lista_precios_ID = Utils.cint(fila["ID"].ToString());
                }
                return Producto_join_lista_precios_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Producto_join_lista_precios objeto)
        {
            try
            {
                Query query = new Query("update", "producto_join_lista_precios");
                query.AddSet("producto_ID", objeto.fproducto_ID);
                query.AddSet("lista_precios_ID", objeto.flista_precios_ID);
                query.AddSet("precio_venta", objeto.fprecio_venta);
                query.AddSet("cantidad_limite", objeto.fcantidad_limite);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Producto_join_lista_preciosJSON objeto)
        {
            try
            {
                Query query = new Query("update", "producto_join_lista_precios");
                query.AddSet("producto_ID", objeto.getProducto_ID());
                query.AddSet("lista_precios_ID", objeto.getLista_precios_ID());
                query.AddSet("precio_venta", objeto.getPrecio_venta());
                query.AddSet("cantidad_limite", objeto.fcantidad_limite);
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

