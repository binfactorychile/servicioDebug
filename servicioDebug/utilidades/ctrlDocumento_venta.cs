using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlDocumento_venta
    {
        public static Documento_venta[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Documento_venta.estado_vigente, "vigente");
                DataSet dataset = FachadaDocumento_venta.getListado(query);
                Documento_venta[] arrdocumento_venta = new Documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Documento_venta objeto = new Documento_venta(fila);
                        arrdocumento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdocumento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Documento_venta[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaDocumento_venta.getListado(query);
                Documento_venta[] arrdocumento_venta = new Documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Documento_venta objeto = new Documento_venta(fila);
                        arrdocumento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdocumento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Documento_venta[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "documento_venta");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaDocumento_venta.getListado(query);
                Documento_venta[] arrdocumento_venta = new Documento_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Documento_venta objeto = new Documento_venta(fila);
                        arrdocumento_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdocumento_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Documento_venta objeto)
        {
            try
            {
                return FachadaDocumento_venta.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Documento_ventaJSON objeto)
        {
            try
            {
                return FachadaDocumento_venta.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Documento_venta objeto)
        {
            try
            {
                FachadaDocumento_venta.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Documento_ventaJSON objeto)
        {
            try
            {
                FachadaDocumento_venta.actualizarJSON(objeto);
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
                FachadaDocumento_venta.eliminar(query);
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
                Query query = new Query("delete", "documento_venta");
                query.AddWhere("ID", ID.ToString());
                FachadaDocumento_venta.eliminar(query);
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
                FachadaDocumento_venta.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Documento_venta getDocumento_venta(int id)
        {
            try
            {
                Query query = new Query("select", "documento_venta");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Documento_venta objeto = new Documento_venta();
                DataSet dataset = FachadaDocumento_venta.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Documento_venta(fila);
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
        //            Query query = new Query("documento_venta");
        //            query.AddWhereExacto(ST_Documento_venta.nombre, nombre);
        //            Documento_venta[] arrDocumento_venta = getListado(query);
        //            if (arrDocumento_venta.Length > 0)
        //            {
        //                return arrDocumento_venta[0].fID;
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
