using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaUsuario
    {

        public static DataSet getListado(Query query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static DataSet getListado(string query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static int guardar(Usuario objeto)
        {
            try
            {
                Query query = new Query("insert", "usuario");
                if (objeto.fID > 0) 
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("nombre", objeto.fnombre);
                query.AddInsert("apellido", objeto.fapellido);
                query.AddInsert("email", objeto.femail);
                query.AddInsert("login", objeto.flogin);
                query.AddInsert("password", objeto.fpassword);
                query.AddInsert("privilegio", objeto.fprivilegio);
                query.AddInsert("sucursal_ID", objeto.fsucursal_ID);
                query.AddInsert("rol_usuario_ID", objeto.frol_usuario_ID);
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM usuario WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Usuario_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Usuario_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Usuario_ID = Utils.cint(fila["ID"].ToString());
                }
                return Usuario_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(UsuarioJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "usuario");
                if (objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("nombre", objeto.getNombre());
                query.AddInsert("apellido", objeto.getApellido());
                query.AddInsert("email", objeto.getEmail());
                query.AddInsert("login", objeto.getLogin());
                query.AddInsert("password", objeto.getPassword());
                query.AddInsert("privilegio", objeto.getPrivilegio());
                query.AddInsert("sucursal_ID", objeto.getSucursal_ID());
                query.AddInsert("rol_usuario_ID", objeto.getRol_usuario_ID());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM usuario WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Usuario_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Usuario_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Usuario_ID = Utils.cint(fila["ID"].ToString());
                }
                return Usuario_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Usuario objeto)
        {
            try
            {
                Query query = new Query("update", "usuario");
                query.AddSet("nombre", objeto.fnombre);
                query.AddSet("apellido", objeto.fapellido);
                query.AddSet("email", objeto.femail);
                query.AddSet("login", objeto.flogin);
                query.AddSet("password", objeto.fpassword);
                query.AddSet("privilegio", objeto.fprivilegio);
                query.AddSet("sucursal_ID", objeto.fsucursal_ID);
                query.AddSet("rol_usuario_ID", objeto.frol_usuario_ID);
                query.AddSet("estado_vigente", objeto.festado_vigente);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(UsuarioJSON objeto)
        {
            try
            {
                Query query = new Query("update", "usuario");
                query.AddSet("nombre", objeto.getNombre());
                query.AddSet("apellido", objeto.getApellido());
                query.AddSet("email", objeto.getEmail());
                query.AddSet("login", objeto.getLogin());
                query.AddSet("password", objeto.getPassword());
                query.AddSet("privilegio", objeto.getPrivilegio());
                query.AddSet("sucursal_ID", objeto.getSucursal_ID());
                query.AddSet("rol_usuario_ID", objeto.getRol_usuario_ID());
                query.AddSet("estado_vigente", objeto.getEstado_vigente());
                query.AddWhere("ID", objeto.getID().ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
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
                BDConnect.EjecutaSinRetorno(query.listo());
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
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

    }//Fin Clase
}//Fin name_space

