using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlDetalle_documento_venta
    {
        public static Detalle_documento_venta[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Detalle_documento_venta.estado_vigente, "vigente");
                DataSet dataset = FachadaDetalle_documento_venta.getListado(query);
                Detalle_documento_venta[] arrdetalle_documento_venta = new Detalle_documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_venta objeto = new Detalle_documento_venta(fila);
                        arrdetalle_documento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_documento_venta[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaDetalle_documento_venta.getListado(query);
                Detalle_documento_venta[] arrdetalle_documento_venta = new Detalle_documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_venta objeto = new Detalle_documento_venta(fila);
                        arrdetalle_documento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_documento_venta[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "detalle_documento_venta");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaDetalle_documento_venta.getListado(query);
                Detalle_documento_venta[] arrdetalle_documento_venta = new Detalle_documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_venta objeto = new Detalle_documento_venta(fila);
                        arrdetalle_documento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Detalle_documento_venta objeto)
        {
            try
            {
                return FachadaDetalle_documento_venta.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Detalle_documento_ventaJSON objeto)
        {
            try
            {
                return FachadaDetalle_documento_venta.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Detalle_documento_venta objeto)
        {
            try
            {
                FachadaDetalle_documento_venta.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Detalle_documento_ventaJSON objeto)
        {
            try
            {
                FachadaDetalle_documento_venta.actualizarJSON(objeto);
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
                FachadaDetalle_documento_venta.eliminar(query);
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
                Query query = new Query("delete", "detalle_documento_venta");
                query.AddWhere("ID", ID.ToString());
                FachadaDetalle_documento_venta.eliminar(query);
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
                FachadaDetalle_documento_venta.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Detalle_documento_venta getDetalle_documento_venta(int id)
        {
            try
            {
                Query query = new Query("select", "detalle_documento_venta");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Detalle_documento_venta objeto = new Detalle_documento_venta();
                DataSet dataset = FachadaDetalle_documento_venta.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Detalle_documento_venta(fila);
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
                    Query query = new Query("detalle_documento_venta");
                    //query.AddWhereExacto(ST_Detalle_documento_venta.nombre, nombre);
                    Detalle_documento_venta[] arrDetalle_documento_venta = getListado(query);
                    if (arrDetalle_documento_venta.Length > 0)
                    {
                        return arrDetalle_documento_venta[0].fID;
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
