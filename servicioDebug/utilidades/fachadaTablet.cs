using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaTablet
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
        public static int guardar(Tablet objeto)
        {
            try
            {
                Query query = new Query("insert", "tablet");
                query.AddInsert("nombre", objeto.fnombre);
                query.AddInsert("mac_address", objeto.fmac_address);
                query.AddInsert("estado_vigente", objeto.festado_vigente);
                query.AddInsert("estado_nueva", objeto.festado_nueva);
                query.AddInsert("usuario_ID", objeto.fusuario_ID);
                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM tablet WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Tablet_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Tablet_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Tablet_ID = Utils.cint(fila["ID"].ToString());
                }
                return Tablet_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Tablet objeto)
        {
            try
            {
                Query query = new Query("update", "tablet");
                query.AddSet("nombre", objeto.fnombre);
                query.AddSet("mac_address", objeto.fmac_address);
                query.AddSet("estado_vigente", objeto.festado_vigente);
                query.AddSet("estado_nueva", objeto.festado_nueva);
                query.AddSet("usuario_ID", objeto.fusuario_ID);
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

