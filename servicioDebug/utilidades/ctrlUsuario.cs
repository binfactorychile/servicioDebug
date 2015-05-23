using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlUsuario
    {
        public static Usuario[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Usuario.estado_vigente, "vigente");
                DataSet dataset = FachadaUsuario.getListado(query);
                Usuario[] arrusuario = new Usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Usuario objeto = new Usuario(fila);
                        arrusuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrusuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Usuario[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaUsuario.getListado(query);
                Usuario[] arrusuario = new Usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Usuario objeto = new Usuario(fila);
                        arrusuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrusuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Usuario[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "usuario");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaUsuario.getListado(query);
                Usuario[] arrusuario = new Usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Usuario objeto = new Usuario(fila);
                        arrusuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrusuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Usuario objeto)
        {
            try
            {
                return FachadaUsuario.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(UsuarioJSON objeto)
        {
            try
            {
                return FachadaUsuario.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Usuario objeto)
        {
            try
            {
                FachadaUsuario.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(UsuarioJSON objeto)
        {
            try
            {
                FachadaUsuario.actualizarJSON(objeto);
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
                FachadaUsuario.eliminar(query);
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
                Query query = new Query("delete", "usuario");
                query.AddWhere("ID", ID.ToString());
                FachadaUsuario.eliminar(query);
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
                FachadaUsuario.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Usuario getUsuario(int id)
        {
            try
            {
                Query query = new Query("select", "usuario");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Usuario objeto = new Usuario();
                DataSet dataset = FachadaUsuario.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Usuario(fila);
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
                    Query query = new Query("usuario");
                    query.AddWhereExacto(ST_Usuario.nombre, nombre);
                    Usuario[] arrUsuario = getListado(query);
                    if (arrUsuario.Length > 0)
                    {
                        return arrUsuario[0].fID;
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
