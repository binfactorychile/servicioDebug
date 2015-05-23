using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlTablet
    {
        public static Tablet[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Tablet.estado_vigente, "vigente");
                DataSet dataset = FachadaTablet.getListado(query);
                Tablet[] arrtablet = new Tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Tablet objeto = new Tablet(fila);
                        arrtablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrtablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Tablet[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaTablet.getListado(query);
                Tablet[] arrtablet = new Tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Tablet objeto = new Tablet(fila);
                        arrtablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrtablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Tablet[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "tablet");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaTablet.getListado(query);
                Tablet[] arrtablet = new Tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Tablet objeto = new Tablet(fila);
                        arrtablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrtablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Tablet objeto)
        {
            try
            {
                return FachadaTablet.guardar(objeto);
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
                FachadaTablet.actualizar(objeto);
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
                FachadaTablet.eliminar(query);
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
                Query query = new Query("delete", "Tablet");
                query.AddWhere("ID", ID.ToString());
                FachadaTablet.eliminar(query);
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
                FachadaTablet.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Tablet getTablet(int id)
        {
            try
            {
                Query query = new Query("select", "Tablet");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Tablet objeto = new Tablet();
                DataSet dataset = FachadaTablet.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Tablet(fila);
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
        public static int getID(string nombre)
        {
            try
            {
                if (nombre.Length > 0)
                {
                    nombre = nombre.Trim();
                    Query query = new Query("tablet");
                    query.AddWhereExacto(ST_Tablet.nombre, nombre);
                    Tablet[] arrTablet = getListado(query);
                    if (arrTablet.Length > 0)
                    {
                        return arrTablet[0].fID;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
