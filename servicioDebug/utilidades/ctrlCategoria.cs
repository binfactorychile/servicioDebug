using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlCategoria
    {
        public static Categoria[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Categoria.estado_vigente, "vigente");
                DataSet dataset = FachadaCategoria.getListado(query);
                Categoria[] arrcategoria = new Categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Categoria objeto = new Categoria(fila);
                        arrcategoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrcategoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Categoria[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaCategoria.getListado(query);
                Categoria[] arrcategoria = new Categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Categoria objeto = new Categoria(fila);
                        arrcategoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrcategoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Categoria[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "categoria");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaCategoria.getListado(query);
                Categoria[] arrcategoria = new Categoria[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Categoria objeto = new Categoria(fila);
                        arrcategoria[contador] = objeto;
                        contador++;
                    }
                }
                return arrcategoria;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Categoria objeto)
        {
            try
            {
                return FachadaCategoria.guardar(objeto);
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
                return FachadaCategoria.guardarJSON(objeto);
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
                FachadaCategoria.actualizar(objeto);
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
                FachadaCategoria.actualizarJSON(objeto);
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
                FachadaCategoria.eliminar(query);
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
                Query query = new Query("delete", "categoria");
                query.AddWhere("ID", ID.ToString());
                FachadaCategoria.eliminar(query);
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
                FachadaCategoria.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Categoria getCategoria(int id)
        {
            try
            {
                Query query = new Query("select", "categoria");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Categoria objeto = new Categoria();
                DataSet dataset = FachadaCategoria.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Categoria(fila);
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
                    Query query = new Query("categoria");
                    query.AddWhereExacto(ST_Categoria.nombre, nombre);
                    Categoria[] arrCategoria = getListado(query);
                    if (arrCategoria.Length > 0)
                    {
                        return arrCategoria[0].fID;
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
