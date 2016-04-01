using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Venta
    {
        private int _ID;
        private int _forma_pago_ID;
        private int _tipo_documento_ID;
        private int _usuario_ID;
        private int _arqueo_caja_ID;
        private int _cuenta_credito_ID;
        private int _comprobante_contable_ID;
        private string _mes_proceso;
        private string _ano_proceso;
        private DateTime _fecha_proceso;
        private DateTime _fecha;
        private int _numero;
        private int _estado;
        private int _total_descuento;
        private int _total_neto;
        private int _total_iva;
        private int _total_bruto;
        private int _total_saldo;
        private int _total_pagos;
        private int _documento_venta_ID;
        private int _cliente_proveedor_ID;
        private string _coordenadas_GPS;
        private string _fecha_entrega;
        private string _estado_vigente;
        private string _observacion;
        private int _total_pago_efectivo;
        private int _total_pago_tarjeta;
        private int _sucursal_ID;
        private int _tablet_ID;
        private int _banco_ID;
        private int _tipo_cheque_ID;

        //CONSTRUCTOR
        public Venta(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _forma_pago_ID = Utils.cint(data["forma_pago_ID"].ToString());
                _tipo_documento_ID = Utils.cint(data["tipo_documento_ID"].ToString());
                _usuario_ID = Utils.cint(data["usuario_ID"].ToString());
                _arqueo_caja_ID = Utils.cint(data["arqueo_caja_ID"].ToString());
                _cuenta_credito_ID = Utils.cint(data["cuenta_credito_ID"].ToString());
                _comprobante_contable_ID = Utils.cint(data["comprobante_contable_ID"].ToString());
                _mes_proceso = data["mes_proceso"].ToString();
                _ano_proceso = data["ano_proceso"].ToString();
                _fecha_proceso = Utils.cdate(data["fecha_proceso"].ToString());
                _fecha = Utils.cdate(data["fecha"].ToString());
                _numero = Utils.cint(data["numero"].ToString());
                _estado = Utils.cint(data["estado"].ToString());
                _total_descuento = Utils.cint(data["total_descuento"].ToString());
                _total_neto = Utils.cint(data["total_neto"].ToString());
                _total_iva = Utils.cint(data["total_iva"].ToString());
                _total_bruto = Utils.cint(data["total_bruto"].ToString());
                _total_saldo = Utils.cint(data["total_saldo"].ToString());
                _total_pagos = Utils.cint(data["total_pagos"].ToString());
                _documento_venta_ID = Utils.cint(data["documento_venta_ID"].ToString());
                _cliente_proveedor_ID = Utils.cint(data["cliente_proveedor_ID"].ToString());
                _coordenadas_GPS = data["coordenadas_GPS"].ToString();
                _fecha_entrega = data["fecha_entrega"].ToString();
                _estado_vigente = data["estado_vigente"].ToString();
                _observacion = data["observacion"].ToString();
                _total_pago_efectivo = Utils.cint(data["total_pago_efectivo"].ToString());
                _total_pago_tarjeta = Utils.cint(data["total_pago_tarjeta"].ToString());
                _sucursal_ID = Utils.cint(data["sucursal_ID"].ToString());
                _tablet_ID = Utils.cint(data["tablet_ID"].ToString());
                _banco_ID = Utils.cint(data["banco_ID"].ToString());
                _tipo_cheque_ID = Utils.cint(data["tipo_cheque_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Venta()
        {
        }

        public int fID
        {

            get { return (_ID); }
            set { _ID = value; }

        }

        public int fforma_pago_ID
        {

            get { return (_forma_pago_ID); }
            set { _forma_pago_ID = value; }

        }

        public int ftipo_documento_ID
        {

            get { return (_tipo_documento_ID); }
            set { _tipo_documento_ID = value; }

        }

        public int fusuario_ID
        {

            get { return (_usuario_ID); }
            set { _usuario_ID = value; }

        }

        public int farqueo_caja_ID
        {

            get { return (_arqueo_caja_ID); }
            set { _arqueo_caja_ID = value; }

        }

        public int fcuenta_credito_ID
        {

            get { return (_cuenta_credito_ID); }
            set { _cuenta_credito_ID = value; }

        }

        public int fcomprobante_contable_ID
        {

            get { return (_comprobante_contable_ID); }
            set { _comprobante_contable_ID = value; }

        }

        public string fmes_proceso
        {

            get { return (_mes_proceso); }
            set { _mes_proceso = value; }

        }

        public string fano_proceso
        {

            get { return (_ano_proceso); }
            set { _ano_proceso = value; }

        }

        public DateTime ffecha_proceso
        {

            get { return (_fecha_proceso); }
            set { _fecha_proceso = value; }

        }

        public DateTime ffecha
        {

            get { return (_fecha); }
            set { _fecha = value; }

        }

        public int fnumero
        {

            get { return (_numero); }
            set { _numero = value; }

        }

        public int festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public int ftotal_descuento
        {

            get { return (_total_descuento); }
            set { _total_descuento = value; }

        }

        public int ftotal_neto
        {

            get { return (_total_neto); }
            set { _total_neto = value; }

        }

        public int ftotal_iva
        {

            get { return (_total_iva); }
            set { _total_iva = value; }

        }

        public int ftotal_bruto
        {

            get { return (_total_bruto); }
            set { _total_bruto = value; }

        }

        public int ftotal_saldo
        {

            get { return (_total_saldo); }
            set { _total_saldo = value; }

        }

        public int ftotal_pagos
        {

            get { return (_total_pagos); }
            set { _total_pagos = value; }

        }

        public int fdocumento_venta_ID
        {

            get { return (_documento_venta_ID); }
            set { _documento_venta_ID = value; }

        }

        public int fcliente_proveedor_ID
        {

            get { return (_cliente_proveedor_ID); }
            set { _cliente_proveedor_ID = value; }

        }

        public string fcoordenadas_GPS
        {

            get { return (_coordenadas_GPS); }
            set { _coordenadas_GPS = value; }

        }

        public string ffecha_entrega
        {

            get { return (_fecha_entrega); }
            set { _fecha_entrega = value; }

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

        public int ftotal_pago_efectivo
        {

            get { return (_total_pago_efectivo); }
            set { _total_pago_efectivo = value; }

        }

        public int ftotal_pago_tarjeta
        {

            get { return (_total_pago_tarjeta); }
            set { _total_pago_tarjeta = value; }

        }

        public int fsucursal_ID
        {

            get { return (_sucursal_ID); }
            set { _sucursal_ID = value; }

        }

        public int ftablet_ID
        {

            get { return (_tablet_ID); }
            set { _tablet_ID = value; }

        }

        public int fbanco_ID
        {

            get { return (_banco_ID); }
            set { _banco_ID = value; }

        }

        public int ftipo_cheque_ID
        {

            get { return (_tipo_cheque_ID); }
            set { _tipo_cheque_ID = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlVenta.actualizar(this);
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
                return CtrlVenta.guardar(this);
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
                CtrlVenta.eliminar(this._ID);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        //public Forma_pago getForma_pago()
        //{
        //    return CtrlForma_pago.getForma_pago(_forma_pago_ID);
        //}

        //public Tipo_documento getTipo_documento()
        //{
        //    return CtrlTipo_documento.getTipo_documento(_tipo_documento_ID);
        //}

        public Usuario getUsuario()
        {
            return CtrlUsuario.getUsuario(_usuario_ID);
        }

        //public Arqueo_caja getArqueo_caja()
        //{
        //    return CtrlArqueo_caja.getArqueo_caja(_arqueo_caja_ID);
        //}

        //public Cuenta_credito getCuenta_credito()
        //{
        //    return CtrlCuenta_credito.getCuenta_credito(_cuenta_credito_ID);
        //}

        //public Comprobante_contable getComprobante_contable()
        //{
        //    return CtrlComprobante_contable.getComprobante_contable(_comprobante_contable_ID);
        //}

        public Documento_venta getDocumento_venta()
        {
            return CtrlDocumento_venta.getDocumento_venta(_documento_venta_ID);
        }

        public Cliente_proveedor getCliente_proveedor()
        {
            return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID);
        }

        //public Sucursal getSucursal()
        //{
        //    return CtrlSucursal.getSucursal(_sucursal_ID);
        //}

        public Tablet getTablet()
        {
            return CtrlTablet.getTablet(_tablet_ID);
        }

        //public Banco getBanco()
        //{
        //    return CtrlBanco.getBanco(_banco_ID);
        //}

        //public Tipo_cheque getTipo_cheque()
        //{
        //    return CtrlTipo_cheque.getTipo_cheque(_tipo_cheque_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Venta
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String forma_pago_ID
        {

            get { return ("forma_pago_ID"); }
        }
        public static String tipo_documento_ID
        {

            get { return ("tipo_documento_ID"); }
        }
        public static String usuario_ID
        {

            get { return ("usuario_ID"); }
        }
        public static String arqueo_caja_ID
        {

            get { return ("arqueo_caja_ID"); }
        }
        public static String cuenta_credito_ID
        {

            get { return ("cuenta_credito_ID"); }
        }
        public static String comprobante_contable_ID
        {

            get { return ("comprobante_contable_ID"); }
        }
        public static String mes_proceso
        {

            get { return ("mes_proceso"); }
        }
        public static String ano_proceso
        {

            get { return ("ano_proceso"); }
        }
        public static String fecha_proceso
        {

            get { return ("fecha_proceso"); }
        }
        public static String fecha
        {

            get { return ("fecha"); }
        }
        public static String numero
        {

            get { return ("numero"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String total_descuento
        {

            get { return ("total_descuento"); }
        }
        public static String total_neto
        {

            get { return ("total_neto"); }
        }
        public static String total_iva
        {

            get { return ("total_iva"); }
        }
        public static String total_bruto
        {

            get { return ("total_bruto"); }
        }
        public static String total_saldo
        {

            get { return ("total_saldo"); }
        }
        public static String total_pagos
        {

            get { return ("total_pagos"); }
        }
        public static String documento_venta_ID
        {

            get { return ("documento_venta_ID"); }
        }
        public static String cliente_proveedor_ID
        {

            get { return ("cliente_proveedor_ID"); }
        }
        public static String coordenadas_GPS
        {

            get { return ("coordenadas_GPS"); }
        }
        public static String fecha_entrega
        {

            get { return ("fecha_entrega"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
        public static String observacion
        {

            get { return ("observacion"); }
        }
        public static String total_pago_efectivo
        {

            get { return ("total_pago_efectivo"); }
        }
        public static String total_pago_tarjeta
        {

            get { return ("total_pago_tarjeta"); }
        }
        public static String sucursal_ID
        {

            get { return ("sucursal_ID"); }
        }
        public static String tablet_ID
        {

            get { return ("tablet_ID"); }
        }
        public static String banco_ID
        {

            get { return ("banco_ID"); }
        }
        public static String tipo_cheque_ID
        {

            get { return ("tipo_cheque_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
