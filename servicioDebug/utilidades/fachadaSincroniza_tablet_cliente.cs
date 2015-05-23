using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaSincroniza_tablet_cliente
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
        public static int guardar(Sincroniza_tablet_cliente objeto)
        {
            try
            {
                Query query = new Query("insert", "sincroniza_tablet_cliente");
                query.AddInsert("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
                query.AddInsert("tablet_ID", objeto.ftablet_ID);
                query.AddInsert("accion", objeto.faccion);
                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM sincroniza_tablet_cliente WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Sincroniza_tablet_cliente_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Sincroniza_tablet_cliente_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Sincroniza_tablet_cliente_ID = Utils.cint(fila["ID"].ToString());
                }
                return Sincroniza_tablet_cliente_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Sincroniza_tablet_cliente objeto)
        {
            try
            {
                Query query = new Query("update", "sincroniza_tablet_cliente");
                query.AddSet("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
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

