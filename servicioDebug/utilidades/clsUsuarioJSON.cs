
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class UsuarioJSON
    {
        public int f0;//ID
        public String f1;//nombre
        public String f2;//apellido
        public String f3;//email
        public String f4;//login
        public String f5;//password
        public int f6;//privilegio
        public int f7;//sucursal_ID
        public int f8;//rol_usuario_ID
        public String f9;//estado_vigente
        public string f10;
        public int f11;
        //CONSTRUCTOR
        public UsuarioJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = data["nombre"].ToString();
                f2 = data["apellido"].ToString();
                f3 = data["email"].ToString();
                f4 = data["login"].ToString();
                f5 = data["password"].ToString();
                f6 = Utils.cint(data["privilegio"].ToString());
                f7 = Utils.cint(data["sucursal_ID"].ToString());
                f8 = Utils.cint(data["rol_usuario_ID"].ToString());
                f9 = data["estado_vigente"].ToString();
                f10 = accion;
                f11 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "UsuarioJSON.Constructor");
            }
        }
        public UsuarioJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public String getNombre()
        {
            if (f1 != null)
                return f1;
            else
                return "";
        }
        public String getApellido()
        {
            if (f2 != null)
                return f2;
            else
                return "";
        }
        public String getEmail()
        {
            if (f3 != null)
                return f3;
            else
                return "";
        }
        public String getLogin()
        {
            if (f4 != null)
                return f4;
            else
                return "";
        }
        public String getPassword()
        {
            if (f5 != null)
                return f5;
            else
                return "";
        }
        public int getPrivilegio()
        {
            return f6;
        }
        public int getSucursal_ID()
        {
            return f7;
        }
        public int getRol_usuario_ID()
        {
            return f8;
        }
        public String getEstado_vigente()
        {
            if (f9 != null)
                return f9;
            else
                return "";
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setNombre(String nombre)
        {
            this.f1 = nombre;
        }
        public void setApellido(String apellido)
        {
            this.f2 = apellido;
        }
        public void setEmail(String email)
        {
            this.f3 = email;
        }
        public void setLogin(String login)
        {
            this.f4 = login;
        }
        public void setPassword(String password)
        {
            this.f5 = password;
        }
        public void setPrivilegio(int privilegio)
        {
            this.f6 = privilegio;
        }
        public void setSucursal_ID(int sucursal_ID)
        {
            this.f7 = sucursal_ID;
        }
        public void setRol_usuario_ID(int rol_usuario_ID)
        {
            this.f8 = rol_usuario_ID;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f9 = estado_vigente;
        }

        public void actualizar()
        {
            try
            {
                CtrlUsuario.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Usuario.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlUsuario.guardarJSON(this);
        }

    }//fin clase lógica

}

