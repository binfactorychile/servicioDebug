
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class CategoriaJSON
    {
        public int f0;//ID
        public String f1;//nombre
        public String f2;//descripcion
        public int f3;//categoria_ID
        public int f4;//estado
        public int f5;//cuenta_contable_ID
        public String f6;//exento
        public string f7;//accion
        public int f8;//servidor_ID

        //CONSTRUCTOR
        public CategoriaJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = data["nombre"].ToString();
                f2 = data["descripcion"].ToString();
                f3 = Utils.cint(data["categoria_ID"].ToString());
                f4 = Utils.cint(data["estado"].ToString());
                f5 = Utils.cint(data["cuenta_contable_ID"].ToString());
                f6 = data["exento"].ToString();
                f7 = accion;
                f8 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "CategoriaJSON.Constructor");
            }
        }
        public CategoriaJSON()
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
        public String getDescripcion()
        {
            if (f2 != null)
                return f2;
            else
                return "";
        }
        public int getCategoria_ID()
        {
            return f3;
        }
        public int getEstado()
        {
            return f4;
        }
        public int getCuenta_contable_ID()
        {
            return f5;
        }
        public String getExento()
        {
            if (f6 != null)
                return f6;
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
        public void setDescripcion(String descripcion)
        {
            this.f2 = descripcion;
        }
        public void setCategoria_ID(int categoria_ID)
        {
            this.f3 = categoria_ID;
        }
        public void setEstado(int estado)
        {
            this.f4 = estado;
        }
        public void setCuenta_contable_ID(int cuenta_contable_ID)
        {
            this.f5 = cuenta_contable_ID;
        }
        public void setExento(String exento)
        {
            this.f6 = exento;
        }

        public void actualizar()
        {
            try
            {
                CtrlCategoria.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Categoria.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlCategoria.guardarJSON(this);
        }

    }//fin clase lógica

}

