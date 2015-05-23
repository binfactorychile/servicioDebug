using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlSincronizar_tablet_producto_join_lista_precios
    {
        //public static Sincronizar_tablet_producto_join_lista_precios[] getListado(Query query)
        //{
        //    try
        //    {
        //        query.AddWhereExacto(ST_Sincronizar_tablet_producto_join_lista_precios.estado_vigente, "vigente");
        //        DataSet dataset = FachadaSincronizar_tablet_producto_join_lista_precios.getListado(query);
        //        Sincronizar_tablet_producto_join_lista_precios[] arrsincronizar_tablet_producto_join_lista_precios = new Sincronizar_tablet_producto_join_lista_precios[dataset.Tables[0].Rows.Count];
        //        int contador = 0;
        //        if (dataset != null)
        //        {
        //            foreach (DataRow fila in dataset.Tables[0].Rows)
        //            {
        //                Sincronizar_tablet_producto_join_lista_precios objeto = new Sincronizar_tablet_producto_join_lista_precios(fila);
        //                arrsincronizar_tablet_producto_join_lista_precios[contador] = objeto;
        //                contador++;
        //            }
        //        }
        //        return arrsincronizar_tablet_producto_join_lista_precios;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        return null;
        //    }
        //}
        public static Sincronizar_tablet_producto_join_lista_precios[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincronizar_tablet_producto_join_lista_precios.getListado(query);
                Sincronizar_tablet_producto_join_lista_precios[] arrsincronizar_tablet_producto_join_lista_precios = new Sincronizar_tablet_producto_join_lista_precios[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_producto_join_lista_precios objeto = new Sincronizar_tablet_producto_join_lista_precios(fila);
                        arrsincronizar_tablet_producto_join_lista_precios[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_producto_join_lista_precios;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_producto_join_lista_precios[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincronizar_tablet_producto_join_lista_precios");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincronizar_tablet_producto_join_lista_precios.getListado(query);
                Sincronizar_tablet_producto_join_lista_precios[] arrsincronizar_tablet_producto_join_lista_precios = new Sincronizar_tablet_producto_join_lista_precios[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_producto_join_lista_precios objeto = new Sincronizar_tablet_producto_join_lista_precios(fila);
                        arrsincronizar_tablet_producto_join_lista_precios[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_producto_join_lista_precios;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincronizar_tablet_producto_join_lista_precios objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_producto_join_lista_precios.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static int guardarJSON(Sincronizar_tablet_producto_join_lista_preciosJSON objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_producto_join_lista_precios.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Sincronizar_tablet_producto_join_lista_precios objeto)
        {
            try
            {
                FachadaSincronizar_tablet_producto_join_lista_precios.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Sincronizar_tablet_producto_join_lista_preciosJSON objeto)
        {
            try
            {
                FachadaSincronizar_tablet_producto_join_lista_precios.actualizarJSON(objeto);
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
                FachadaSincronizar_tablet_producto_join_lista_precios.eliminar(query);
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
                Query query = new Query("delete", "sincronizar_tablet_producto_join_lista_precios");
                query.AddWhere("ID", ID.ToString());
                FachadaSincronizar_tablet_producto_join_lista_precios.eliminar(query);
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
                FachadaSincronizar_tablet_producto_join_lista_precios.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Sincronizar_tablet_producto_join_lista_precios getSincronizar_tablet_producto_join_lista_precios(int id)
        {
            try
            {
                Query query = new Query("select", "sincronizar_tablet_producto_join_lista_precios");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincronizar_tablet_producto_join_lista_precios objeto = new Sincronizar_tablet_producto_join_lista_precios();
                DataSet dataset = FachadaSincronizar_tablet_producto_join_lista_precios.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincronizar_tablet_producto_join_lista_precios(fila);
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
        public static int guardar(string accion, int producto_join_lista_precios_ID)
        {
            try
            {
                Sincronizar_tablet_producto_join_lista_precios sincronizar;
                Query query = new Query("tablet");
                query.AddWhere(ST_Tablet.estado_vigente, "vigente");

                Tablet[] arrTablet = CtrlTablet.getListado(query);
                foreach (Tablet tablet in arrTablet)
                {
                    sincronizar = new Sincronizar_tablet_producto_join_lista_precios();
                    sincronizar.faccion = accion;

                    sincronizar.fproducto_join_lista_precios_ID = producto_join_lista_precios_ID;
                    sincronizar.ftablet_ID = tablet.fID;
                    sincronizar.guardar();

                }


                return 1;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        //public static int getID(string nombre)
        //{
        //    try
        //    {
        //        if (nombre.Length > 0)
        //        {
        //            nombre = nombre.Trim();
        //            Query query = new Query("sincronizar_tablet_producto_join_lista_precios");
        //            query.AddWhereExacto(ST_Sincronizar_tablet_producto_join_lista_precios.nombre, nombre);
        //            Sincronizar_tablet_producto_join_lista_precios[] arrSincronizar_tablet_producto_join_lista_precios = getListado(query);
        //            if (arrSincronizar_tablet_producto_join_lista_precios.Length > 0)
        //            {
        //                return arrSincronizar_tablet_producto_join_lista_precios[0].fID;
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
