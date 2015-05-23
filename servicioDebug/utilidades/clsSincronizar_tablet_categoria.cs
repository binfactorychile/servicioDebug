using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Sincronizar_tablet_categoria
    {
        private int _ID;
        private int _categoria_ID;
        private int _tablet_ID;

        //CONSTRUCTOR
        public Sincronizar_tablet_categoria(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _categoria_ID = Utils.cint(data["categoria_ID"].ToString());
                _tablet_ID = Utils.cint(data["tablet_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Sincronizar_tablet_categoria()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public int fcategoria_ID
        {

            get { return (_categoria_ID); }
            set { _categoria_ID = value; }

        }

        public int ftablet_ID
        {

            get { return (_tablet_ID); }
            set { _tablet_ID = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlSincronizar_tablet_categoria.actualizar(this);
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
                return CtrlSincronizar_tablet_categoria.guardar(this);
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
                CtrlSincronizar_tablet_categoria.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        public Categoria getCategoria()
        {
            Controlador_Categoria CtrlCategoria = new Controlador_Categoria();
            return CtrlCategoria.getCategoria(_categoria_ID.ToString());
        }

        public Tablet getTablet()
        {
            return CtrlTablet.getTablet(_tablet_ID);
        }
        public string getQueryGuardar()
        {
            return CtrlSincronizar_tablet_categoria.getQueryGuardar(this);
        }

    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Sincronizar_tablet_categoria
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String categoria_ID
        {

            get { return ("categoria_ID"); }
        }
        public static String tablet_ID
        {

            get { return ("tablet_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
