using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlSincronizar_tablet_usuario
    {
        public static Sincronizar_tablet_usuario[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Sincronizar_tablet_usuario.estado_vigente, "vigente");
                DataSet dataset = FachadaSincronizar_tablet_usuario.getListado(query);
                Sincronizar_tablet_usuario[] arrsincronizar_tablet_usuario = new Sincronizar_tablet_usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_usuario objeto = new Sincronizar_tablet_usuario(fila);
                        arrsincronizar_tablet_usuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_usuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_usuario[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincronizar_tablet_usuario.getListado(query);
                Sincronizar_tablet_usuario[] arrsincronizar_tablet_usuario = new Sincronizar_tablet_usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_usuario objeto = new Sincronizar_tablet_usuario(fila);
                        arrsincronizar_tablet_usuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_usuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_usuario[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincronizar_tablet_usuario");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincronizar_tablet_usuario.getListado(query);
                Sincronizar_tablet_usuario[] arrsincronizar_tablet_usuario = new Sincronizar_tablet_usuario[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_usuario objeto = new Sincronizar_tablet_usuario(fila);
                        arrsincronizar_tablet_usuario[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_usuario;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincronizar_tablet_usuario objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_usuario.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Sincronizar_tablet_usuario objeto)
        {
            try
            {
                FachadaSincronizar_tablet_usuario.actualizar(objeto);
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
                FachadaSincronizar_tablet_usuario.eliminar(query);
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
                Query query = new Query("delete", "Sincronizar_tablet_usuario");
                query.AddWhere("ID", ID.ToString());
                FachadaSincronizar_tablet_usuario.eliminar(query);
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
                FachadaSincronizar_tablet_usuario.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static string getQueryGuardar(Sincronizar_tablet_usuario objeto)
        {
          return  FachadaSincronizar_tablet_usuario.getQueryGuardar(objeto);
        }
        public static Sincronizar_tablet_usuario getSincronizar_tablet_usuario(int id)
        {
            try
            {
                Query query = new Query("select", "Sincronizar_tablet_usuario");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincronizar_tablet_usuario objeto = new Sincronizar_tablet_usuario();
                DataSet dataset = FachadaSincronizar_tablet_usuario.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincronizar_tablet_usuario(fila);
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

        public static void registraCambioTablets(int usuario_ID)
        {
            Query query = new Query("tablet");
            Tablet[] arrTablet = CtrlTablet.getListado(query);
            Sincronizar_tablet_usuario sincroUsuario;
            foreach (Tablet tablet in arrTablet)
            {
                sincroUsuario = new Sincronizar_tablet_usuario();
                sincroUsuario.fusuario_ID= usuario_ID;
                sincroUsuario.ftablet_ID = tablet.fID;
                sincroUsuario.guardar();

            }

        }

    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------