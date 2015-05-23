using System;
using System.Collections;
using System.Data;
using querytor;

namespace utilidades
{
    static public class CtrlVenta
    {
        public static Venta[] getListado(Query query)
        {
            try
            {
                query.AddWhereExacto(ST_Venta.estado_vigente, "vigente");
                DataSet dataset = FachadaVenta.getListado(query);
                Venta[] arrventa = new Venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Venta objeto = new Venta(fila);
                        arrventa[contador] = objeto;
                        contador++;
                    }
                }
                return arrventa;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Venta[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaVenta.getListado(query);
                Venta[] arrventa = new Venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Venta objeto = new Venta(fila);
                        arrventa[contador] = objeto;
                        contador++;
                    }
                }
                return arrventa;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Venta[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "venta");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaVenta.getListado(query);
                Venta[] arrventa = new Venta[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Venta objeto = new Venta(fila);
                        arrventa[contador] = objeto;
                        contador++;
                    }
                }
                return arrventa;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Venta objeto)
        {
            try
            {
                return FachadaVenta.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(VentaJSON objeto)
        {
            try
            {
                return FachadaVenta.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Venta objeto)
        {
            try
            {
                FachadaVenta.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(VentaJSON objeto)
        {
            try
            {
                FachadaVenta.actualizarJSON(objeto);
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
                FachadaVenta.eliminar(query);
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
                Query query = new Query("delete", "venta");
                query.AddWhere("ID", ID.ToString());
                FachadaVenta.eliminar(query);
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
                FachadaVenta.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Venta getVenta(int id)
        {
            try
            {
                Query query = new Query("select", "venta");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Venta objeto = new Venta();
                DataSet dataset = FachadaVenta.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Venta(fila);
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
        //            Query query = new Query("venta");
        //            query.AddWhereExacto(ST_Venta.nombre, nombre);
        //            Venta[] arrVenta = getListado(query);
        //            if (arrVenta.Length > 0)
        //            {
        //                return arrVenta[0].fID;
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
