using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Cliente_proveedor
    {
        private int _ID;
        private string _nombre;
        private string _direccion;
        private string _ciudad;
        private string _razon_social;
        private string _telefono;
        private string _email;
        private string _estado;
        private string _giro;
        private string _fax;
        private int _tipo;
        private int _cuenta_credito_ID;
        private int _monto_credito;
        private string _rut;
        private string _coordenadas_GPS;
        private int _tipo_cliente_ID;
        private int _listado_cliente_ID;
        private int _sector_ID;
        private string _es_sucursal;
        private string _estado_vigente;
        private string _observacion;
        private int _sucursal_ID;
        private int _lista_precios_ID;

        //CONSTRUCTOR
        public Cliente_proveedor(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _nombre = data["nombre"].ToString();
                _direccion = data["direccion"].ToString();
                _ciudad = data["ciudad"].ToString();
                _razon_social = data["razon_social"].ToString();
                _telefono = data["telefono"].ToString();
                _email = data["email"].ToString();
                _estado = data["estado"].ToString();
                _giro = data["giro"].ToString();
                _fax = data["fax"].ToString();
                _tipo = Utils.cint(data["tipo"].ToString());
                _cuenta_credito_ID = Utils.cint(data["cuenta_credito_ID"].ToString());
                _monto_credito = Utils.cint(data["monto_credito"].ToString());
                _rut = data["rut"].ToString();
                _coordenadas_GPS = data["coordenadas_GPS"].ToString();
                _tipo_cliente_ID = Utils.cint(data["tipo_cliente_ID"].ToString());
                _listado_cliente_ID = Utils.cint(data["listado_cliente_ID"].ToString());
                _sector_ID = Utils.cint(data["sector_ID"].ToString());
                _es_sucursal = data["es_sucursal"].ToString();
                _estado_vigente = data["estado_vigente"].ToString();
                _observacion = data["observacion"].ToString();
                _sucursal_ID = Utils.cint(data["sucursal_ID"].ToString());
                _lista_precios_ID = Utils.cint(data["lista_precios_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Cliente_proveedor()
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

        public string fdireccion
        {

            get { return (_direccion); }
            set { _direccion = value; }

        }

        public string fciudad
        {

            get { return (_ciudad); }
            set { _ciudad = value; }

        }

        public string frazon_social
        {

            get { return (_razon_social); }
            set { _razon_social = value; }

        }

        public string ftelefono
        {

            get { return (_telefono); }
            set { _telefono = value; }

        }

        public string femail
        {

            get { return (_email); }
            set { _email = value; }

        }

        public string festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public string fgiro
        {

            get { return (_giro); }
            set { _giro = value; }

        }

        public string ffax
        {

            get { return (_fax); }
            set { _fax = value; }

        }

        public int ftipo
        {

            get { return (_tipo); }
            set { _tipo = value; }

        }

        public int fcuenta_credito_ID
        {

            get { return (_cuenta_credito_ID); }
            set { _cuenta_credito_ID = value; }

        }

        public int fmonto_credito
        {

            get { return (_monto_credito); }
            set { _monto_credito = value; }

        }

        public string frut
        {

            get { return (_rut); }
            set { _rut = value; }

        }

        public string fcoordenadas_GPS
        {

            get { return (_coordenadas_GPS); }
            set { _coordenadas_GPS = value; }

        }

        public int ftipo_cliente_ID
        {

            get { return (_tipo_cliente_ID); }
            set { _tipo_cliente_ID = value; }

        }

        public int flistado_cliente_ID
        {

            get { return (_listado_cliente_ID); }
            set { _listado_cliente_ID = value; }

        }

        public int fsector_ID
        {

            get { return (_sector_ID); }
            set { _sector_ID = value; }

        }

        public string fes_sucursal
        {

            get { return (_es_sucursal); }
            set { _es_sucursal = value; }

        }

        public string festado_vigente
        {

            get { return (_estado_vigente); }
            set { _estado_vigente = value; }

        }

        public string fobservacion
        {

            get { return (_observacion); }
            set { _observacion = value; }

        }

        public int fsucursal_ID
        {

            get { return (_sucursal_ID); }
            set { _sucursal_ID = value; }

        }

        public int flista_precios_ID
        {

            get { return (_lista_precios_ID); }
            set { _lista_precios_ID = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlCliente_proveedor.actualizar(this);
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
                return CtrlCliente_proveedor.guardar(this);
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
                CtrlCliente_proveedor.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        //public Cuenta_credito getCuenta_credito()
        //{
        //    return CtrlCuenta_credito.getCuenta_credito(_cuenta_credito_ID);
        //}

        //public Tipo_cliente getTipo_cliente()
        //{
        //    return CtrlTipo_cliente.getTipo_cliente(_tipo_cliente_ID);
        //}

        //public Listado_cliente getListado_cliente()
        //{
        //    return CtrlListado_cliente.getListado_cliente(_listado_cliente_ID);
        //}

        //public Sector getSector()
        //{
        //    return CtrlSector.getSector(_sector_ID);
        //}

        //public Sucursal getSucursal()
        //{
        //    return CtrlSucursal.getSucursal(_sucursal_ID);
        //}

        //public Lista_precios getLista_precios()
        //{
        //    return CtrlLista_precios.getLista_precios(_lista_precios_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Cliente_proveedor
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String nombre
        {

            get { return ("nombre"); }
        }
        public static String direccion
        {

            get { return ("direccion"); }
        }
        public static String ciudad
        {

            get { return ("ciudad"); }
        }
        public static String razon_social
        {

            get { return ("razon_social"); }
        }
        public static String telefono
        {

            get { return ("telefono"); }
        }
        public static String email
        {

            get { return ("email"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String giro
        {

            get { return ("giro"); }
        }
        public static String fax
        {

            get { return ("fax"); }
        }
        public static String tipo
        {

            get { return ("tipo"); }
        }
        public static String cuenta_credito_ID
        {

            get { return ("cuenta_credito_ID"); }
        }
        public static String monto_credito
        {

            get { return ("monto_credito"); }
        }
        public static String rut
        {

            get { return ("rut"); }
        }
        public static String coordenadas_GPS
        {

            get { return ("coordenadas_GPS"); }
        }
        public static String tipo_cliente_ID
        {

            get { return ("tipo_cliente_ID"); }
        }
        public static String listado_cliente_ID
        {

            get { return ("listado_cliente_ID"); }
        }
        public static String sector_ID
        {

            get { return ("sector_ID"); }
        }
        public static String es_sucursal
        {

            get { return ("es_sucursal"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
        public static String observacion
        {

            get { return ("observacion"); }
        }
        public static String sucursal_ID
        {

            get { return ("sucursal_ID"); }
        }
        public static String lista_precios_ID
        {

            get { return ("lista_precios_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
