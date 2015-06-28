using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    public class Documento_venta
    {
        private int _ID;
        private int _documento_venta_ID;
        private int _cliente_ID;
        private int _tipo_documento_ID;
        private int _comprobante_contable_ID;
        private int _forma_pago_ID;
        private int _usuario_ID;
        private int _numero;
        private int _correlativo;
        private DateTime _fecha_digitacion;
        private DateTime _fecha_cancelacion;
        private DateTime _fecha_documento;
        private DateTime _fecha_vencimiento;
        private DateTime _fecha_proceso;
        private string _mes_proceso;
        private string _ano_proceso;
        private string _condicion_venta;
        private int _total_neto;
        private int _total_impuesto;
        private int _total_exento;
        private int _total_iva;
        private int _total_bruto;
        private int _total_saldo;
        private int _total_pagos;
        private string _observacion;
        private string _estado;
        private int _estado_despacho_ID;
        private int _estado_pago_documento_venta_ID;
        private string _estado_vigente;
        private int _sucursal_ID;

        //CONSTRUCTOR
        public Documento_venta(DataRow data)
        {
            try
            {
                _ID = Utils.cint(data["ID"].ToString());
                _documento_venta_ID = Utils.cint(data["documento_venta_ID"].ToString());
                _cliente_ID = Utils.cint(data["cliente_ID"].ToString());
                _tipo_documento_ID = Utils.cint(data["tipo_documento_ID"].ToString());
                _comprobante_contable_ID = Utils.cint(data["comprobante_contable_ID"].ToString());
                _forma_pago_ID = Utils.cint(data["forma_pago_ID"].ToString());
                _usuario_ID = Utils.cint(data["usuario_ID"].ToString());
                _numero = Utils.cint(data["numero"].ToString());
                _correlativo = Utils.cint(data["correlativo"].ToString());
                _fecha_digitacion = Utils.cdate(data["fecha_digitacion"].ToString());
                _fecha_cancelacion = Utils.cdate(data["fecha_cancelacion"].ToString());
                _fecha_documento = Utils.cdate(data["fecha_documento"].ToString());
                _fecha_vencimiento = Utils.cdate(data["fecha_vencimiento"].ToString());
                _fecha_proceso = Utils.cdate(data["fecha_proceso"].ToString());
                _mes_proceso = data["mes_proceso"].ToString();
                _ano_proceso = data["ano_proceso"].ToString();
                _condicion_venta = data["condicion_venta"].ToString();
                _total_neto = Utils.cint(data["total_neto"].ToString());
                _total_impuesto = Utils.cint(data["total_impuesto"].ToString());
                _total_exento = Utils.cint(data["total_exento"].ToString());
                _total_iva = Utils.cint(data["total_iva"].ToString());
                _total_bruto = Utils.cint(data["total_bruto"].ToString());
                _total_saldo = Utils.cint(data["total_saldo"].ToString());
                _total_pagos = Utils.cint(data["total_pagos"].ToString());
                _observacion = data["observacion"].ToString();
                _estado = data["estado"].ToString();
                _estado_despacho_ID = Utils.cint(data["estado_despacho_ID"].ToString());
                _estado_pago_documento_venta_ID = Utils.cint(data["estado_pago_documento_venta_ID"].ToString());
                _estado_vigente = data["estado_vigente"].ToString();
                _sucursal_ID = Utils.cint(data["sucursal_ID"].ToString());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public Documento_venta()
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

        public int fcliente_ID
        {

            get { return (_cliente_ID); }
            set { _cliente_ID = value; }

        }

        public int ftipo_documento_ID
        {

            get { return (_tipo_documento_ID); }
            set { _tipo_documento_ID = value; }

        }

        public int fcomprobante_contable_ID
        {

            get { return (_comprobante_contable_ID); }
            set { _comprobante_contable_ID = value; }

        }

        public int fforma_pago_ID
        {

            get { return (_forma_pago_ID); }
            set { _forma_pago_ID = value; }

        }

        public int fusuario_ID
        {

            get { return (_usuario_ID); }
            set { _usuario_ID = value; }

        }

        public int fnumero
        {

            get { return (_numero); }
            set { _numero = value; }

        }

        public int fcorrelativo
        {

            get { return (_correlativo); }
            set { _correlativo = value; }

        }

        public DateTime ffecha_digitacion
        {

            get { return (_fecha_digitacion); }
            set { _fecha_digitacion = value; }

        }

        public DateTime ffecha_cancelacion
        {

            get { return (_fecha_cancelacion); }
            set { _fecha_cancelacion = value; }

        }

        public DateTime ffecha_documento
        {

            get { return (_fecha_documento); }
            set { _fecha_documento = value; }

        }

        public DateTime ffecha_vencimiento
        {

            get { return (_fecha_vencimiento); }
            set { _fecha_vencimiento = value; }

        }

        public DateTime ffecha_proceso
        {

            get { return (_fecha_proceso); }
            set { _fecha_proceso = value; }

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

        public string fcondicion_venta
        {

            get { return (_condicion_venta); }
            set { _condicion_venta = value; }

        }

        public int ftotal_neto
        {

            get { return (_total_neto); }
            set { _total_neto = value; }

        }

        public int ftotal_impuesto
        {

            get { return (_total_impuesto); }
            set { _total_impuesto = value; }

        }

        public int ftotal_exento
        {

            get { return (_total_exento); }
            set { _total_exento = value; }

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

        public string fobservacion
        {

            get { return (_observacion); }
            set { _observacion = value; }

        }

        public string festado
        {

            get { return (_estado); }
            set { _estado = value; }

        }

        public int festado_despacho_ID
        {

            get { return (_estado_despacho_ID); }
            set { _estado_despacho_ID = value; }

        }

        public int festado_pago_documento_venta_ID
        {

            get { return (_estado_pago_documento_venta_ID); }
            set { _estado_pago_documento_venta_ID = value; }

        }

        public string festado_vigente
        {

            get { return (_estado_vigente); }
            set { _estado_vigente = value; }

        }

        public int fsucursal_ID
        {

            get { return (_sucursal_ID); }
            set { _sucursal_ID = value; }

        }


        public void actualizar()
        {
            try
            {
                CtrlDocumento_venta.actualizar(this);
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
                return CtrlDocumento_venta.guardar(this);
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
                CtrlDocumento_venta.eliminar(this._ID);
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

        //public Cliente getCliente()
        //{
        //    return CtrlCliente.getCliente(_cliente_ID);
        //}

        //public Tipo_documento getTipo_documento()
        //{
        //    return CtrlTipo_documento.getTipo_documento(_tipo_documento_ID);
        //}

        //public Comprobante_contable getComprobante_contable()
        //{
        //    return CtrlComprobante_contable.getComprobante_contable(_comprobante_contable_ID);
        //}

        //public Forma_pago getForma_pago()
        //{
        //    return CtrlForma_pago.getForma_pago(_forma_pago_ID);
        //}

        public Usuario getUsuario()
        {
            return CtrlUsuario.getUsuario(_usuario_ID);
        }

        //public Estado_despacho getEstado_despacho()
        //{
        //    return CtrlEstado_despacho.getEstado_despacho(_estado_despacho_ID);
        //}

        //public Estado_pago_documento_venta getEstado_pago_documento_venta()
        //{
        //    return CtrlEstado_pago_documento_venta.getEstado_pago_documento_venta(_estado_pago_documento_venta_ID);
        //}

        //public Sucursal getSucursal()
        //{
        //    return CtrlSucursal.getSucursal(_sucursal_ID);
        //}


    }//fin clase lógica

    //Inicio clase estática
    static public class ST_Documento_venta
    {
        public static String ID
        {

            get { return ("ID"); }
        }
        public static String documento_venta_ID
        {

            get { return ("documento_venta_ID"); }
        }
        public static String cliente_ID
        {

            get { return ("cliente_ID"); }
        }
        public static String tipo_documento_ID
        {

            get { return ("tipo_documento_ID"); }
        }
        public static String comprobante_contable_ID
        {

            get { return ("comprobante_contable_ID"); }
        }
        public static String forma_pago_ID
        {

            get { return ("forma_pago_ID"); }
        }
        public static String usuario_ID
        {

            get { return ("usuario_ID"); }
        }
        public static String numero
        {

            get { return ("numero"); }
        }
        public static String correlativo
        {

            get { return ("correlativo"); }
        }
        public static String fecha_digitacion
        {

            get { return ("fecha_digitacion"); }
        }
        public static String fecha_cancelacion
        {

            get { return ("fecha_cancelacion"); }
        }
        public static String fecha_documento
        {

            get { return ("fecha_documento"); }
        }
        public static String fecha_vencimiento
        {

            get { return ("fecha_vencimiento"); }
        }
        public static String fecha_proceso
        {

            get { return ("fecha_proceso"); }
        }
        public static String mes_proceso
        {

            get { return ("mes_proceso"); }
        }
        public static String ano_proceso
        {

            get { return ("ano_proceso"); }
        }
        public static String condicion_venta
        {

            get { return ("condicion_venta"); }
        }
        public static String total_neto
        {

            get { return ("total_neto"); }
        }
        public static String total_impuesto
        {

            get { return ("total_impuesto"); }
        }
        public static String total_exento
        {

            get { return ("total_exento"); }
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
        public static String observacion
        {

            get { return ("observacion"); }
        }
        public static String estado
        {

            get { return ("estado"); }
        }
        public static String estado_despacho_ID
        {

            get { return ("estado_despacho_ID"); }
        }
        public static String estado_pago_documento_venta_ID
        {

            get { return ("estado_pago_documento_venta_ID"); }
        }
        public static String estado_vigente
        {

            get { return ("estado_vigente"); }
        }
        public static String sucursal_ID
        {

            get { return ("sucursal_ID"); }
        }
    }//Fin clase estática

}//Fin name_space
