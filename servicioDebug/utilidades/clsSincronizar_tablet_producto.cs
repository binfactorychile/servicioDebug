using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Sincronizar_tablet_producto
    {
        private int _ID;
        private int _producto_ID;
        private int _tablet_ID;
        private string _accion;
        //CONSTRUCTOR
        public Sincronizar_tablet_producto(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _producto_ID = Utils.cint(data["producto_ID"].ToString());
                _tablet_ID = Utils.cint(data["tablet_ID"].ToString());
                _accion = data["accion"].ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Sincronizar_tablet_producto()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }
        public string faccion
        {

            get { return _accion;}
            set { _accion = value;}
        }
        public int fproducto_ID
        {
            get { return (_producto_ID); }
            set { _producto_ID = value; }
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
                CtrlSincronizar_tablet_producto.actualizar(this);
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
                return CtrlSincronizar_tablet_producto.guardar(this);
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
                CtrlSincronizar_tablet_producto.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        public Producto getProducto()
        {
            //Controlador_Producto CtrlProducto = new Controlador_Producto();
            return CtrlProducto.getProducto(_producto_ID);
        }

        public Tablet getTablet()
        {
            return CtrlTablet.getTablet(_tablet_ID);
        }
        public string getQueryGuardar()
        {
            return CtrlSincronizar_tablet_producto.getQueryGuardar(this);
        }

    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Sincronizar_tablet_producto
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String producto_ID
        {

            get { return ("producto_ID"); }
        }
        public static String tablet_ID
        {

            get { return ("tablet_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
