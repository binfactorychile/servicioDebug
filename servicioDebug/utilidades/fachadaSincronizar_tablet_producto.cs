using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaSincronizar_tablet_producto
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
        public static int guardar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                Query query = new Query("insert", "sincronizar_tablet_producto");
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("tablet_ID", objeto.ftablet_ID);
                query.AddInsert("accion", objeto.faccion);


                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Sincronizar_tablet_producto_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Sincronizar_tablet_producto_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                }
                return Sincronizar_tablet_producto_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static string getQueryGuardar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                Query query = new Query("insert", "sincronizar_tablet_producto");
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("tablet_ID", objeto.ftablet_ID);
                query.AddInsert("accion", objeto.faccion);
                return query.listo() + ";";
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error";
            }
        }
        public static void actualizar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                Query query = new Query("update", "sincronizar_tablet_producto");
                query.AddSet("producto_ID", objeto.fproducto_ID);
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

