using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlSincronizar_tablet_categoria
    {
        public static Sincronizar_tablet_categoria[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Sincronizar_tablet_categoria.estado_vigente, "vigente");
                DataSet dataset = FachadaSincronizar_tablet_categoria.getListado(query);
                Sincronizar_tablet_categoria[] arrsincronizar_tablet_categoria = new Sincronizar_tablet_categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_categoria objeto = new Sincronizar_tablet_categoria(fila);
                        arrsincronizar_tablet_categoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_categoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_categoria[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincronizar_tablet_categoria.getListado(query);
                Sincronizar_tablet_categoria[] arrsincronizar_tablet_categoria = new Sincronizar_tablet_categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_categoria objeto = new Sincronizar_tablet_categoria(fila);
                        arrsincronizar_tablet_categoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_categoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_categoria[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincronizar_tablet_categoria");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincronizar_tablet_categoria.getListado(query);
                Sincronizar_tablet_categoria[] arrsincronizar_tablet_categoria = new Sincronizar_tablet_categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_categoria objeto = new Sincronizar_tablet_categoria(fila);
                        arrsincronizar_tablet_categoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_categoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincronizar_tablet_categoria objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_categoria.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Sincronizar_tablet_categoria objeto)
        {
            try
            {
                FachadaSincronizar_tablet_categoria.actualizar(objeto);
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
                FachadaSincronizar_tablet_categoria.eliminar(query);
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
                Query query = new Query("delete", "Sincronizar_tablet_categoria");
                query.AddWhere("ID", ID.ToString());
                FachadaSincronizar_tablet_categoria.eliminar(query);
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
                FachadaSincronizar_tablet_categoria.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Sincronizar_tablet_categoria getSincronizar_tablet_categoria(int id)
        {
            try
            {
                Query query = new Query("select", "Sincronizar_tablet_categoria");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincronizar_tablet_categoria objeto = new Sincronizar_tablet_categoria();
                DataSet dataset = FachadaSincronizar_tablet_categoria.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincronizar_tablet_categoria(fila);
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
        public static void registraCambioTablets(int categoria_ID)
        {
            Query query = new Query("tablet");
            Tablet[] arrTablet = CtrlTablet.getListado(query);
            Sincronizar_tablet_categoria sincroCategoria;
            string querys = "";
            foreach (Tablet tablet in arrTablet)
            {
                sincroCategoria = new Sincronizar_tablet_categoria();
                sincroCategoria.fcategoria_ID = categoria_ID;
                sincroCategoria.ftablet_ID = tablet.fID;
                if (querys != "")
                    querys += "[#;#]" + sincroCategoria.getQueryGuardar();
                else
                    querys += sincroCategoria.getQueryGuardar();
                //sincroCategoria.getQueryGuardar();

            }
            BDConnect.EjecutaSinRetorno(querys);
        }
        public static string getQueryGuardar(Sincronizar_tablet_categoria objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_categoria.getQueryGuardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error";
            }
        }

    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
