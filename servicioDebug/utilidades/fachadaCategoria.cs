using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaCategoria
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
        public static int guardar(Categoria objeto)
        {
            try
            {
                Query query = new Query("insert", "categoria");
                if (objeto.fID > 0)
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("nombre", objeto.fnombre);
                query.AddInsert("descripcion", objeto.fdescripcion);
                query.AddInsert("categoria_ID", objeto.fcategoria_ID);
                query.AddInsert("estado", objeto.festado);
                query.AddInsert("cuenta_contable_ID", objeto.fcuenta_contable_ID);
                query.AddInsert("exento", objeto.fexento);
                query.AddInsert("codigo", objeto.fcodigo);
                query.AddInsert("correlativo_actual", objeto.fcorrelativo_actual);
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM categoria WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Categoria_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Categoria_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Categoria_ID = Utils.cint(fila["ID"].ToString());
                }
                return Categoria_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(CategoriaJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "categoria");
                if (objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("nombre", objeto.getNombre());
                query.AddInsert("descripcion", objeto.getDescripcion());
                query.AddInsert("categoria_ID", objeto.getCategoria_ID());
                query.AddInsert("estado", objeto.getEstado());
                query.AddInsert("cuenta_contable_ID", objeto.getCuenta_contable_ID());
                query.AddInsert("exento", objeto.getExento());
                query.AddInsert("codigo", objeto.getCodigo());
                query.AddInsert("correlativo_actual", objeto.getCorrelativo_actual());
                //query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM categoria WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Categoria_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Categoria_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Categoria_ID = Utils.cint(fila["ID"].ToString());
                }
                return Categoria_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Categoria objeto)
        {
            try
            {
                Query query = new Query("update", "categoria");
                query.AddSet("nombre", objeto.fnombre);
                query.AddSet("descripcion", objeto.fdescripcion);
                query.AddSet("categoria_ID", objeto.fcategoria_ID);
                query.AddSet("estado", objeto.festado);
                query.AddSet("cuenta_contable_ID", objeto.fcuenta_contable_ID);
                query.AddSet("exento", objeto.fexento);
                query.AddSet("codigo", objeto.fcodigo);
                query.AddSet("correlativo_actual", objeto.fcorrelativo_actual);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(CategoriaJSON objeto)
        {
            try
            {
                Query query = new Query("update", "categoria");
                query.AddSet("nombre", objeto.getNombre());
                query.AddSet("descripcion", objeto.getDescripcion());
                query.AddSet("categoria_ID", objeto.getCategoria_ID());
                query.AddSet("estado", objeto.getEstado());
                query.AddSet("cuenta_contable_ID", objeto.getCuenta_contable_ID());
                query.AddSet("exento", objeto.getExento());
                query.AddSet("codigo", objeto.getCodigo());
                query.AddSet("correlativo_actual", objeto.getCorrelativo_actual());
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

