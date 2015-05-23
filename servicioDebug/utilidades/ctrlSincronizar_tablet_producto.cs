using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{
    static public class CtrlSincronizar_tablet_producto
    {
        public static Sincronizar_tablet_producto[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Sincronizar_tablet_producto.estado_vigente, "vigente");
                DataSet dataset = FachadaSincronizar_tablet_producto.getListado(query);
                Sincronizar_tablet_producto[] arrsincronizar_tablet_producto = new Sincronizar_tablet_producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_producto objeto = new Sincronizar_tablet_producto(fila);
                        arrsincronizar_tablet_producto[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_producto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_producto[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincronizar_tablet_producto.getListado(query);
                Sincronizar_tablet_producto[] arrsincronizar_tablet_producto = new Sincronizar_tablet_producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_producto objeto = new Sincronizar_tablet_producto(fila);
                        arrsincronizar_tablet_producto[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_producto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincronizar_tablet_producto[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincronizar_tablet_producto");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincronizar_tablet_producto.getListado(query);
                Sincronizar_tablet_producto[] arrsincronizar_tablet_producto = new Sincronizar_tablet_producto[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincronizar_tablet_producto objeto = new Sincronizar_tablet_producto(fila);
                        arrsincronizar_tablet_producto[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincronizar_tablet_producto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_producto.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static string getQueryGuardar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                return FachadaSincronizar_tablet_producto.getQueryGuardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error";
            }
        }
        public static void actualizar(Sincronizar_tablet_producto objeto)
        {
            try
            {
                FachadaSincronizar_tablet_producto.actualizar(objeto);
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
                FachadaSincronizar_tablet_producto.eliminar(query);
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
                Query query = new Query("delete", "Sincronizar_tablet_producto");
                query.AddWhere("ID", ID.ToString());
                FachadaSincronizar_tablet_producto.eliminar(query);
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
                FachadaSincronizar_tablet_producto.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Sincronizar_tablet_producto getSincronizar_tablet_producto(int id)
        {
            try
            {
                Query query = new Query("select", "Sincronizar_tablet_producto");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincronizar_tablet_producto objeto = new Sincronizar_tablet_producto();
                DataSet dataset = FachadaSincronizar_tablet_producto.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincronizar_tablet_producto(fila);
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
        public static void registraCambioTablets(int producto_ID,string accion)
        {
            Query query = new Query("tablet");
            Tablet[] arrTablet = CtrlTablet.getListado(query);
            Sincronizar_tablet_producto sincroProducto;
            string querys="";
            foreach (Tablet tablet in arrTablet)
            {
                sincroProducto = new Sincronizar_tablet_producto();
                sincroProducto.fproducto_ID = producto_ID;
                sincroProducto.ftablet_ID = tablet.fID;
                sincroProducto.faccion = accion;
                if(querys!="")
                    querys += "[#;#]" + sincroProducto.getQueryGuardar();    
                else
                    querys += sincroProducto.getQueryGuardar();
                //sincroProducto.guardar();
            
            }
            BDConnect.EjecutaSinRetorno(querys);

        }
        public static void eliminaCambioTablets(int producto_ID)
        {
            Query query = new Query("tablet");
            Tablet[] arrTablet = CtrlTablet.getListado(query);
            Sincronizar_tablet_producto sincroProducto;
            string querys = "";
            foreach (Tablet tablet in arrTablet)
            {
                sincroProducto = new Sincronizar_tablet_producto();
                sincroProducto.fproducto_ID = producto_ID;
                sincroProducto.ftablet_ID = tablet.fID;
                //sincroProducto.f
                if (querys != "")
                    querys += "[#;#]" + sincroProducto.getQueryGuardar();
                else
                    querys += sincroProducto.getQueryGuardar();
                //sincroProducto.guardar();

            }
            BDConnect.EjecutaSinRetorno(querys);

        }
    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
