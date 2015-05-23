using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlPrecio_por_cliente
    {
        public static Precio_por_cliente[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Precio_por_cliente.estado_vigente, "vigente");
                DataSet dataset = FachadaPrecio_por_cliente.getListado(query);
                Precio_por_cliente[] arrprecio_por_cliente = new Precio_por_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_cliente objeto = new Precio_por_cliente(fila);
                        arrprecio_por_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Precio_por_cliente[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaPrecio_por_cliente.getListado(query);
                Precio_por_cliente[] arrprecio_por_cliente = new Precio_por_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_cliente objeto = new Precio_por_cliente(fila);
                        arrprecio_por_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Precio_por_cliente[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "precio_por_cliente");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaPrecio_por_cliente.getListado(query);
                Precio_por_cliente[] arrprecio_por_cliente = new Precio_por_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Precio_por_cliente objeto = new Precio_por_cliente(fila);
                        arrprecio_por_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrprecio_por_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Precio_por_cliente objeto)
        {
            try
            {
                return FachadaPrecio_por_cliente.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Precio_por_clienteJSON objeto)
        {
            try
            {
                return FachadaPrecio_por_cliente.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Precio_por_cliente objeto)
        {
            try
            {
                FachadaPrecio_por_cliente.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Precio_por_clienteJSON objeto)
        {
            try
            {
                FachadaPrecio_por_cliente.actualizarJSON(objeto);
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
                FachadaPrecio_por_cliente.eliminar(query);
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
                Query query = new Query("delete", "precio_por_cliente");
                query.AddWhere("ID", ID.ToString());
                FachadaPrecio_por_cliente.eliminar(query);
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
                FachadaPrecio_por_cliente.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Precio_por_cliente getPrecio_por_cliente(int id)
        {
            try
            {
                Query query = new Query("select", "precio_por_cliente");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Precio_por_cliente objeto = new Precio_por_cliente();
                DataSet dataset = FachadaPrecio_por_cliente.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Precio_por_cliente(fila);
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
        //public static int getID(string nombre)
        //{
        //    try
        //    {
        //        if (nombre.Length > 0)
        //        {
        //            nombre = nombre.Trim();
        //            Query query = new Query("precio_por_cliente");
        //            query.AddWhereExacto(ST_Precio_por_cliente.nombre, nombre);
        //            Precio_por_cliente[] arrPrecio_por_cliente = getListado(query);
        //            if (arrPrecio_por_cliente.Length > 0)
        //            {
        //                return arrPrecio_por_cliente[0].fID;
        //            }
        //            else
        //            {
        //                return 0;
        //            }
        //        }
        //        else
        //            return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        return 0;
        //    }
        //}
    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
