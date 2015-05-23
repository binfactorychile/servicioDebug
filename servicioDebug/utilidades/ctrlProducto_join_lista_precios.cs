using System;
using System.Collections;
using System.Data;
using querytor;

namespace utilidades
{
    static public class CtrlProducto_join_lista_precios
    {
        public static Producto_join_lista_precios[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Producto_join_lista_precios.estado_vigente, "vigente");
                DataSet dataset = FachadaProducto_join_lista_precios.getListado(query);
                Producto_join_lista_precios[] arrproducto_join_lista_precios = new Producto_join_lista_precios[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto_join_lista_precios objeto = new Producto_join_lista_precios(fila);
                        arrproducto_join_lista_precios[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto_join_lista_precios;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Producto_join_lista_precios[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaProducto_join_lista_precios.getListado(query);
                Producto_join_lista_precios[] arrproducto_join_lista_precios = new Producto_join_lista_precios[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto_join_lista_precios objeto = new Producto_join_lista_precios(fila);
                        arrproducto_join_lista_precios[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto_join_lista_precios;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Producto_join_lista_precios[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "producto_join_lista_precios");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaProducto_join_lista_precios.getListado(query);
                Producto_join_lista_precios[] arrproducto_join_lista_precios = new Producto_join_lista_precios[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Producto_join_lista_precios objeto = new Producto_join_lista_precios(fila);
                        arrproducto_join_lista_precios[contador] = objeto;
                        contador++;
                    }
                }
                return arrproducto_join_lista_precios;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Producto_join_lista_precios objeto)
        {
            try
            {
                return FachadaProducto_join_lista_precios.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Producto_join_lista_preciosJSON objeto)
        {
            try
            {
                return FachadaProducto_join_lista_precios.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Producto_join_lista_precios objeto)
        {
            try
            {
                FachadaProducto_join_lista_precios.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Producto_join_lista_preciosJSON objeto)
        {
            try
            {
                FachadaProducto_join_lista_precios.actualizarJSON(objeto);
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
                FachadaProducto_join_lista_precios.eliminar(query);
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
                Query query = new Query("delete", "producto_join_lista_precios");
                query.AddWhere("ID", ID.ToString());
                FachadaProducto_join_lista_precios.eliminar(query);
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
                FachadaProducto_join_lista_precios.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Producto_join_lista_precios getProducto_join_lista_precios(int id)
        {
            try
            {
                Query query = new Query("select", "producto_join_lista_precios");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Producto_join_lista_precios objeto = new Producto_join_lista_precios();
                DataSet dataset = FachadaProducto_join_lista_precios.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Producto_join_lista_precios(fila);
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
                    Query query = new Query("producto_join_lista_precios");
                    //query.AddWhereExacto(ST_Producto_join_lista_precios.nombre, nombre);
                    Producto_join_lista_precios[] arrProducto_join_lista_precios = getListado(query);
                    if (arrProducto_join_lista_precios.Length > 0)
                    {
                        return arrProducto_join_lista_precios[0].fID;
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
