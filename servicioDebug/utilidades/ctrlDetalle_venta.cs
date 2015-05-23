using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlDetalle_venta
    {
        public static Detalle_venta[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Detalle_venta.estado_vigente, "vigente");
                DataSet dataset = FachadaDetalle_venta.getListado(query);
                Detalle_venta[] arrdetalle_venta = new Detalle_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_venta objeto = new Detalle_venta(fila);
                        arrdetalle_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_venta[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaDetalle_venta.getListado(query);
                Detalle_venta[] arrdetalle_venta = new Detalle_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_venta objeto = new Detalle_venta(fila);
                        arrdetalle_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_venta[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "detalle_venta");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaDetalle_venta.getListado(query);
                Detalle_venta[] arrdetalle_venta = new Detalle_venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_venta objeto = new Detalle_venta(fila);
                        arrdetalle_venta[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_venta;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Detalle_venta objeto)
        {
            try
            {
                return FachadaDetalle_venta.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Detalle_ventaJSON objeto)
        {
            try
            {
                return FachadaDetalle_venta.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Detalle_venta objeto)
        {
            try
            {
                FachadaDetalle_venta.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Detalle_ventaJSON objeto)
        {
            try
            {
                FachadaDetalle_venta.actualizarJSON(objeto);
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
                FachadaDetalle_venta.eliminar(query);
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
                Query query = new Query("delete", "detalle_venta");
                query.AddWhere("ID", ID.ToString());
                FachadaDetalle_venta.eliminar(query);
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
                FachadaDetalle_venta.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Detalle_venta getDetalle_venta(int id)
        {
            try
            {
                Query query = new Query("select", "detalle_venta");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Detalle_venta objeto = new Detalle_venta();
                DataSet dataset = FachadaDetalle_venta.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Detalle_venta(fila);
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
        //            Query query = new Query("detalle_venta");
        //            query.AddWhereExacto(ST_Detalle_venta.nombre, nombre);
        //            Detalle_venta[] arrDetalle_venta = getListado(query);
        //            if (arrDetalle_venta.Length > 0)
        //            {
        //                return arrDetalle_venta[0].fID;
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
