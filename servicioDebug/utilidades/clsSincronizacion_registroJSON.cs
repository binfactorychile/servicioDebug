
using System;
using System.Collections;
using System.Data;

using querytor;

namespace utilidades
{

    public class Sincronizacion_registroJSON
    {
        public int f0;//ID
        public int f1;//registro_ID
        public String f2;//tabla
        public String f3;//accion
        public int f4;//sincronizacion_ID
        public int f5;//tablet_ID
        public int f6;//servidor_ID

        //CONSTRUCTOR
        public Sincronizacion_registroJSON(DataRow data)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["registro_ID"].ToString());
                f2 = data["tabla"].ToString();
                f3 = data["accion"].ToString();
                f4 = Utils.cint(data["sincronizacion_ID"].ToString());
                f5 = Utils.cint(data["tablet_ID"].ToString());
                f6 = Utils.cint(data["servidor_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Sincronizacion_registroJSON.Constructor");
            }
        }
        public Sincronizacion_registroJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getRegistro_ID()
        {
            return f1;
        }
        public String getTabla()
        {
            if (f2 != null)
                return f2;
            else
                return "";
        }
        public String getAccion()
        {
            if (f3 != null)
                return f3;
            else
                return "";
        }
        public int getSincronizacion_ID()
        {
            return f4;
        }
        public int getTablet_ID()
        {
            return f5;
        }
        public int getServidor_ID()
        {
            return f6;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setRegistro_ID(int registro_ID)
        {
            this.f1 = registro_ID;
        }
        public void setTabla(String tabla)
        {
            this.f2 = tabla;
        }
        public void setAccion(String accion)
        {
            this.f3 = accion;
        }
        public void setSincronizacion_ID(int sincronizacion_ID)
        {
            this.f4 = sincronizacion_ID;
        }
        public void setTablet_ID(int tablet_ID)
        {
            this.f5 = tablet_ID;
        }
        public void setServidor_ID(int servidor_ID)
        {
            this.f6 = servidor_ID;
        }

        //public void actualizar()
        //{
        //    try
        //{
        //    CtrlSincronizacion_registro.actualizarJSON(this);
        //}
        //catch(Exception ex)
        //{
        //    Utils.EscribeLog(ex,"Sincronizacion_registro.actualizarJSON");
        //}
        //}
        //public int guardar()
        //{
        //    return  CtrlSincronizacion_registro.guardarJSON(this);
        //}

    }//fin clase lógica

}

