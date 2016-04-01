
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
        public string f1;//nombre
        public string f2;//descripcion
        public string f3;//categoria_ID
        public string f4;//estado
        public string f5;//cuenta_contable_ID
        public string f6;//exento
        public string f7;//codigo
        public string f8;//correlativo_actual
        public string f98;//accion
        public int f99;//extra

        //CONSTRUCTOR
        public CategoriaJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = int.Parse(data["ID"].ToString());
                f1 = data["nombre"].ToString();
                f2 = data["descripcion"].ToString();
                f3 = data["categoria_ID"].ToString();
                f4 = data["estado"].ToString();
                f5 = data["cuenta_contable_ID"].ToString();
                f6 = data["exento"].ToString();
                f7 = data["codigo"].ToString();
                f8 = data["correlativo_actual"].ToString();
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "CategoriaJSON.Constructor");
            }
        }
        //CONSTRUCTOR
        public CategoriaJSON(Categoria categoria)
        {
            try
            {
                //cursor.getString(11)
                f0 = categoria.fID;
                f1 = categoria.fnombre.ToString();
                f2 = categoria.fdescripcion.ToString();
                f3 = categoria.fcategoria_ID.ToString();
                f4 = categoria.festado.ToString();
                f5 = categoria.fcuenta_contable_ID.ToString();
                f6 = categoria.fexento.ToString();
                f7 = categoria.fcodigo.ToString();
                f8 = categoria.fcorrelativo_actual.ToString();
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
        public String getCategoria_ID()
        {
            return f3;
        }
        public String getEstado()
        {
            return f4;
        }
        public String getCuenta_contable_ID()
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
        public String getCodigo()
        {
            if (f7 != null)
                return f7;
            else
                return "";
        }
        public String getCorrelativo_actual()
        {
            return f8;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setNombre(string nombre)
        {
            this.f1 = nombre;
        }
        public void setDescripcion(string descripcion)
        {
            this.f2 = descripcion;
        }
        public void setCategoria_ID(string categoria_ID)
        {
            this.f3 = categoria_ID;
        }
        public void setEstado(string estado)
        {
            this.f4 = estado;
        }
        public void setCuenta_contable_ID(string cuenta_contable_ID)
        {
            this.f5 = cuenta_contable_ID;
        }
        public void setExento(string exento)
        {
            this.f6 = exento;
        }
        public void setCodigo(string codigo)
        {
            this.f7 = codigo;
        }
        public void setCorrelativo_actual(string correlativo_actual)
        {
            this.f8 = correlativo_actual;
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

