using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Categoria
    {
        private int _ID;
        private string _nombre;
        private string _descripcion;
        private int _categoria_ID;
        private int _estado;
        private int _cuenta_contable_ID;
        private string _exento;
        private string _codigo;
        private int _correlativo_actual;

        //CONSTRUCTOR
        public Categoria(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _nombre = data["nombre"].ToString();
                _descripcion = data["descripcion"].ToString();
                _categoria_ID = Utils.cint(data["categoria_ID"].ToString());
                _estado = Utils.cint(data["estado"].ToString());
                _cuenta_contable_ID = Utils.cint(data["cuenta_contable_ID"].ToString());
                _exento = data["exento"].ToString();
                _codigo = data["codigo"].ToString();
                _correlativo_actual = Utils.cint(data["correlativo_actual"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Categoria()
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

        public string fdescripcion
        {

            get { return (_descripcion); }
            set { _descripcion = value; }

        }

        public int fcategoria_ID
        {

            get { return (_categoria_ID); }
            set { _categoria_ID = value; }

        }

        public int festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public int fcuenta_contable_ID
        {

            get { return (_cuenta_contable_ID); }
            set { _cuenta_contable_ID = value; }

        }

        public string fexento
        {

            get { return (_exento); }
            set { _exento = value; }

        }

        public string fcodigo
        {

            get { return (_codigo); }
            set { _codigo = value; }

        }

        public int fcorrelativo_actual
        {

            get { return (_correlativo_actual); }
            set { _correlativo_actual = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlCategoria.actualizar(this);
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
                return CtrlCategoria.guardar(this);
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
                CtrlCategoria.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Categoria getCategoria()
        {
            return CtrlCategoria.getCategoria(_categoria_ID);
        }


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Categoria
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String nombre
        {

            get { return ("nombre"); }
        }
        public static String descripcion
        {

            get { return ("descripcion"); }
        }
        public static String categoria_ID
        {

            get { return ("categoria_ID"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String cuenta_contable_ID
        {

            get { return ("cuenta_contable_ID"); }
        }
        public static String exento
        {

            get { return ("exento"); }
        }
        public static String codigo
        {

            get { return ("codigo"); }
        }
        public static String correlativo_actual
        {

            get { return ("correlativo_actual"); }
        }
    }//Fin clase estática

}//Fin name_space
