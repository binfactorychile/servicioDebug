using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Detalle_documento_venta
    {
        private int _ID;
        private int _documento_venta_ID;
        private int _producto_ID;
        private int _cantidad;
        private int _monto_descuento;
        private int _precio_neto_unitario;
        private int _monto_impuesto;
        private int _porcentaje_descuento;
        private int _total_neto;
        private int _iva;
        private int _total_bruto;
        private int _estado;
        private string _es_promocion;

        //CONSTRUCTOR
        public Detalle_documento_venta(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _documento_venta_ID = Utils.cint(data["documento_venta_ID"].ToString());
                _producto_ID = Utils.cint(data["producto_ID"].ToString());
                _cantidad = Utils.cint(data["cantidad"].ToString());
                _monto_descuento = Utils.cint(data["monto_descuento"].ToString());
                _precio_neto_unitario = Utils.cint(data["precio_neto_unitario"].ToString());
                _monto_impuesto = Utils.cint(data["monto_impuesto"].ToString());
                _porcentaje_descuento = Utils.cint(data["porcentaje_descuento"].ToString());
                _total_neto = Utils.cint(data["total_neto"].ToString());
                _iva = Utils.cint(data["iva"].ToString());
                _total_bruto = Utils.cint(data["total_bruto"].ToString());
                _estado = Utils.cint(data["estado"].ToString());
                _es_promocion = data["es_promocion"].ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Detalle_documento_venta()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public int fdocumento_venta_ID
        {

            get { return (_documento_venta_ID); }
            set { _documento_venta_ID = value; }

        }

        public int fproducto_ID
        {

            get { return (_producto_ID); }
            set { _producto_ID = value; }

        }

        public int fcantidad
        {

            get { return (_cantidad); }
            set { _cantidad = value; }

        }

        public int fmonto_descuento
        {

            get { return (_monto_descuento); }
            set { _monto_descuento = value; }

        }

        public int fprecio_neto_unitario
        {

            get { return (_precio_neto_unitario); }
            set { _precio_neto_unitario = value; }

        }

        public int fmonto_impuesto
        {

            get { return (_monto_impuesto); }
            set { _monto_impuesto = value; }

        }

        public int fporcentaje_descuento
        {

            get { return (_porcentaje_descuento); }
            set { _porcentaje_descuento = value; }

        }

        public int ftotal_neto
        {

            get { return (_total_neto); }
            set { _total_neto = value; }

        }

        public int fiva
        {

            get { return (_iva); }
            set { _iva = value; }

        }

        public int ftotal_bruto
        {

            get { return (_total_bruto); }
            set { _total_bruto = value; }

        }

        public int festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public string fes_promocion
        {

            get { return (_es_promocion); }
            set { _es_promocion = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlDetalle_documento_venta.actualizar(this);
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
                return CtrlDetalle_documento_venta.guardar(this);
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
                CtrlDetalle_documento_venta.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Documento_venta getDocumento_venta()
        {
            return CtrlDocumento_venta.getDocumento_venta(_documento_venta_ID);
        }

        //public Producto getProducto()
        //{
        //    //return CtrlProducto.getProducto(_producto_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Detalle_documento_venta
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String documento_venta_ID
        {

            get { return ("documento_venta_ID"); }
        }
        public static String producto_ID
        {

            get { return ("producto_ID"); }
        }
        public static String cantidad
        {

            get { return ("cantidad"); }
        }
        public static String monto_descuento
        {

            get { return ("monto_descuento"); }
        }
        public static String precio_neto_unitario
        {

            get { return ("precio_neto_unitario"); }
        }
        public static String monto_impuesto
        {

            get { return ("monto_impuesto"); }
        }
        public static String porcentaje_descuento
        {

            get { return ("porcentaje_descuento"); }
        }
        public static String total_neto
        {

            get { return ("total_neto"); }
        }
        public static String iva
        {

            get { return ("iva"); }
        }
        public static String total_bruto
        {

            get { return ("total_bruto"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String es_promocion
        {

            get { return ("es_promocion"); }
        }
    }//Fin clase estática

}//Fin name_space
