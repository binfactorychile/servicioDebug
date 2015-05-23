using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlPrecio_por_volumen
    {
        public static Precio_por_volumen[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Precio_por_volumen.estado_vigente, "vigente");
                DataSet dataset = FachadaPrecio_por_volumen.getListado(query);
                Precio_por_volumen[] arrprecio_por_volumen = new Precio_por_volumen[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_volumen objeto = new Precio_por_volumen(fila);
                        arrprecio_por_volumen[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_volumen;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Precio_por_volumen[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaPrecio_por_volumen.getListado(query);
                Precio_por_volumen[] arrprecio_por_volumen = new Precio_por_volumen[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_volumen objeto = new Precio_por_volumen(fila);
                        arrprecio_por_volumen[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_volumen;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Precio_por_volumen[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "precio_por_volumen");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaPrecio_por_volumen.getListado(query);
                Precio_por_volumen[] arrprecio_por_volumen = new Precio_por_volumen[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_volumen objeto = new Precio_por_volumen(fila);
                        arrprecio_por_volumen[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_volumen;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Precio_por_volumen objeto)
        {
            try
            {
                return FachadaPrecio_por_volumen.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Precio_por_volumenJSON objeto)
        {
            try
            {
                return FachadaPrecio_por_volumen.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Precio_por_volumen objeto)
        {
            try
            {
                FachadaPrecio_por_volumen.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Precio_por_volumenJSON objeto)
        {
            try
            {
                FachadaPrecio_por_volumen.actualizarJSON(objeto);
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
                FachadaPrecio_por_volumen.eliminar(query);
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
                Query query = new Query("delete", "precio_por_volumen");
                query.AddWhere("ID", ID.ToString());
                FachadaPrecio_por_volumen.eliminar(query);
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
                FachadaPrecio_por_volumen.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Precio_por_volumen getPrecio_por_volumen(int id)
        {
            try
            {
                Query query = new Query("select", "precio_por_volumen");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Precio_por_volumen objeto = new Precio_por_volumen();
                DataSet dataset = FachadaPrecio_por_volumen.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Precio_por_volumen(fila);
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
                    Query query = new Query("precio_por_volumen");
                    //query.AddWhereExacto(ST_Precio_por_volumen.nombre, nombre);
                    Precio_por_volumen[] arrPrecio_por_volumen = getListado(query);
                    if (arrPrecio_por_volumen.Length > 0)
                    {
                        return arrPrecio_por_volumen[0].fID;
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
