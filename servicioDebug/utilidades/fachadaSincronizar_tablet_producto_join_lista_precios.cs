using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaSincronizar_tablet_producto_join_lista_precios
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
        public static int guardar(Sincronizar_tablet_producto_join_lista_precios objeto)
        {
            try
            {
                Query query = new Query("insert", "sincronizar_tablet_producto_join_lista_precios");
                query.AddInsert("producto_join_lista_precios_ID", objeto.fproducto_join_lista_precios_ID);
                query.AddInsert("tablet_ID", objeto.ftablet_ID);
                query.AddInsert("accion", objeto.faccion);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM sincronizar_tablet_producto_join_lista_precios WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Sincronizar_tablet_producto_join_lista_precios_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Sincronizar_tablet_producto_join_lista_precios_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Sincronizar_tablet_producto_join_lista_precios_ID = Utils.cint(fila["ID"].ToString());
                }
                return Sincronizar_tablet_producto_join_lista_precios_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Sincronizar_tablet_producto_join_lista_preciosJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "sincronizar_tablet_producto_join_lista_precios");
                query.AddInsert("producto_join_lista_precios_ID", objeto.getProducto_join_lista_precios_ID());
                query.AddInsert("tablet_ID", objeto.getTablet_ID());
                query.AddInsert("accion", objeto.getAccion());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                //string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                string queryID = "SELECT ID FROM sincronizar_tablet_producto_join_lista_precios WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Sincronizar_tablet_producto_join_lista_precios_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    //Sincronizar_tablet_producto_join_lista_precios_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    Sincronizar_tablet_producto_join_lista_precios_ID = Utils.cint(fila["ID"].ToString());
                }
                return Sincronizar_tablet_producto_join_lista_precios_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Sincronizar_tablet_producto_join_lista_precios objeto)
        {
            try
            {
                Query query = new Query("update", "sincronizar_tablet_producto_join_lista_precios");
                query.AddSet("producto_join_lista_precios_ID", objeto.fproducto_join_lista_precios_ID);
                query.AddSet("tablet_ID", objeto.ftablet_ID);
                query.AddSet("accion", objeto.faccion);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Sincronizar_tablet_producto_join_lista_preciosJSON objeto)
        {
            try
            {
                Query query = new Query("update", "sincronizar_tablet_producto_join_lista_precios");
                query.AddSet("producto_join_lista_precios_ID", objeto.getProducto_join_lista_precios_ID());
                query.AddSet("tablet_ID", objeto.getTablet_ID());
                query.AddSet("accion", objeto.getAccion());
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

