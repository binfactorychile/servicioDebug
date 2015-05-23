using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlSincronizar_tablet
    {
        public static Sincronizar_tablet[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Sincronizar_tablet.estado_vigente, "vigente");
                DataSet dataset = FachadaSincronizar_tablet.getListado(query);
                Sincronizar_tablet[] arrsincronizar_tablet = new Sincronizar_tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet objeto = new Sincronizar_tablet(fila);
                        arrsincronizar_tablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincronizar_tablet.getListado(query);
                Sincronizar_tablet[] arrsincronizar_tablet = new Sincronizar_tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet objeto = new Sincronizar_tablet(fila);
                        arrsincronizar_tablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincronizar_tablet");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincronizar_tablet.getListado(query);
                Sincronizar_tablet[] arrsincronizar_tablet = new Sincronizar_tablet[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet objeto = new Sincronizar_tablet(fila);
                        arrsincronizar_tablet[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincronizar_tablet objeto)
        {
            try
            {
                return FachadaSincronizar_tablet.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardar(string accion, string tabla, int registro_ID)
        {
            try
            {
                Sincronizar_tablet sincronizar;
                Query query = new Query("tablet");
                query.AddWhere(ST_Tablet.estado_vigente, "vigente");

                Tablet[] arrTablet = CtrlTablet.getListado(query);
                foreach (Tablet tablet in arrTablet)
                {
                    sincronizar = new Sincronizar_tablet();
                    sincronizar.faccion = accion;
                    sincronizar.fnombre_tabla = tabla.ToLower();
                    sincronizar.fregistro_ID = registro_ID;
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
        public static int guardarJSON(Sincronizar_tabletJSON objeto)
        {
            try
            {
                return FachadaSincronizar_tablet.guardarJSON(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void actualizar(Sincronizar_tablet objeto)
        {
            try
            {
                FachadaSincronizar_tablet.actualizar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Sincronizar_tabletJSON objeto)
        {
            try
            {
                FachadaSincronizar_tablet.actualizarJSON(objeto);
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
                FachadaSincronizar_tablet.eliminar(query);
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
                Query query = new Query("delete", "sincronizar_tablet");
                query.AddWhere("ID", ID.ToString());
                FachadaSincronizar_tablet.eliminar(query);
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
                FachadaSincronizar_tablet.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Sincronizar_tablet getSincronizar_tablet(int id)
        {
            try
            {
                Query query = new Query("select", "sincronizar_tablet");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincronizar_tablet objeto = new Sincronizar_tablet();
                DataSet dataset = FachadaSincronizar_tablet.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincronizar_tablet(fila);
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
