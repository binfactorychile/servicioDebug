using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Usuario
    {
        private int _ID;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _login;
        private string _password;
        private int _privilegio;
        private int _sucursal_ID;
        private int _rol_usuario_ID;
        private string _estado_vigente;

        //CONSTRUCTOR
        public Usuario(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _nombre = data["nombre"].ToString();
                _apellido = data["apellido"].ToString();
                _email = data["email"].ToString();
                _login = data["login"].ToString();
                _password = data["password"].ToString();
                _privilegio = Utils.cint(data["privilegio"].ToString());
                _sucursal_ID = Utils.cint(data["sucursal_ID"].ToString());
                _rol_usuario_ID = Utils.cint(data["rol_usuario_ID"].ToString());
                _estado_vigente = data["estado_vigente"].ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Usuario()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public string fnombre
        {

            get { return (_nombre); }
            set { _nombre = value; }

        }

        public string fapellido
        {

            get { return (_apellido); }
            set { _apellido = value; }

        }

        public string femail
        {

            get { return (_email); }
            set { _email = value; }

        }

        public string flogin
        {

            get { return (_login); }
            set { _login = value; }

        }

        public string fpassword
        {

            get { return (_password); }
            set { _password = value; }

        }

        public int fprivilegio
        {

            get { return (_privilegio); }
            set { _privilegio = value; }

        }

        public int fsucursal_ID
        {

            get { return (_sucursal_ID); }
            set { _sucursal_ID = value; }

        }

        public int frol_usuario_ID
        {

            get { return (_rol_usuario_ID); }
            set { _rol_usuario_ID = value; }

        }

        public string festado_vigente
        {

            get { return (_estado_vigente); }
            set { _estado_vigente = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlUsuario.actualizar(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public int guardar()
        {
            try
            {
                return CtrlUsuario.guardar(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public void eliminar()
        {
            try
            {
                CtrlUsuario.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        //public Sucursal getSucursal()
        //{
        //    return CtrlSucursal.getSucursal(_sucursal_ID);
        //}

        //public Rol_usuario getRol_usuario()
        //{
        //    return CtrlRol_usuario.getRol_usuario(_rol_usuario_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Usuario
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String nombre
        {

            get { return ("nombre"); }
        }
        public static String apellido
        {

            get { return ("apellido"); }
        }
        public static String email
        {

            get { return ("email"); }
        }
        public static String login
        {

            get { return ("login"); }
        }
        public static String password
        {

            get { return ("password"); }
        }
        public static String privilegio
        {

            get { return ("privilegio"); }
        }
        public static String sucursal_ID
        {

            get { return ("sucursal_ID"); }
        }
        public static String rol_usuario_ID
        {

            get { return ("rol_usuario_ID"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
    }//Fin clase estática

}//Fin name_space
