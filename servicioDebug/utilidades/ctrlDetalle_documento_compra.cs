using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlDetalle_documento_compra
    {
        public static Detalle_documento_compra[] getListado(Query query)
        {
            try
            {

                DataSet dataset = FachadaDetalle_documento_compra.getListado(query);
                Detalle_documento_compra[] arrdetalle_documento_compra = new Detalle_documento_compra[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_compra objeto = new Detalle_documento_compra(fila);
                        arrdetalle_documento_compra[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_compra;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_documento_compra[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaDetalle_documento_compra.getListado(query);
                Detalle_documento_compra[] arrdetalle_documento_compra = new Detalle_documento_compra[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_compra objeto = new Detalle_documento_compra(fila);
                        arrdetalle_documento_compra[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_compra;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Detalle_documento_compra[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "detalle_documento_compra");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaDetalle_documento_compra.getListado(query);
                Detalle_documento_compra[] arrdetalle_documento_compra = new Detalle_documento_compra[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Detalle_documento_compra objeto = new Detalle_documento_compra(fila);
                        arrdetalle_documento_compra[contador] = objeto;
                        contador++;
                    }
                }
                return arrdetalle_documento_compra;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Detalle_documento_compra objeto)
        {
            try
            {
                return FachadaDetalle_documento_compra.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        //public static int guardarJSON(Detalle_documento_compraJSON objeto)
        //{
        //    try
        //    {
        //        return FachadaDetalle_documento_compra.guardarJSON(objeto);
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        return 0;
        //    }
        //}
        public static void actualizar(Detalle_documento_compra objeto)
        {
            try
            {
                FachadaDetalle_documento_compra.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        //public static void actualizarJSON(Detalle_documento_compraJSON objeto)
        //{
        //    try
        //    {
        //        FachadaDetalle_documento_compra.actualizarJSON(objeto);
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //    }
        //}
        public static void eliminar(Query query)
        {
            try
            {
                FachadaDetalle_documento_compra.eliminar(query);
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
                Query query = new Query("delete", "detalle_documento_compra");
                query.AddWhere("ID", ID.ToString());
                FachadaDetalle_documento_compra.eliminar(query);
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
                FachadaDetalle_documento_compra.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Detalle_documento_compra getDetalle_documento_compra(int id)
        {
            try
            {
                Query query = new Query("select", "detalle_documento_compra");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Detalle_documento_compra objeto = new Detalle_documento_compra();
                DataSet dataset = FachadaDetalle_documento_compra.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Detalle_documento_compra(fila);
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
      
    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
