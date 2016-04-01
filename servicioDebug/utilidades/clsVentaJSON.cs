
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class VentaJSON
    {
        public string f0;//ID
        public string f1;//forma_pago_ID
        public string f2;//tipo_documento_ID
        public string f3;//usuario_ID
        public string f4;//arqueo_caja_ID
        public string f5;//cuenta_credito_ID
        public string f6;//comprobante_contable_ID
        public string f7;//mes_proceso
        public string f8;//ano_proceso
        public string f9;//fecha_proceso
        public string f10;//fecha
        public string f11;//numero
        public string f12;//estado
        public string f13;//total_descuento
        public string f14;//total_neto
        public string f15;//total_iva
        public string f16;//total_bruto
        public string f17;//total_saldo
        public string f18;//total_pagos
        public string f19;//documento_venta_ID
        public string f20;//cliente_proveedor_ID
        public string f21;//coordenadas_GPS
        public string f22;//fecha_entrega
        public string f23;//estado_vigente
        public string f24;//observacion
        public string f25;//total_pago_efectivo
        public string f26;//total_pago_tarjeta
        public string f27;//sucursal_ID
        public string f28;//tablet_ID
        public string f29;//banco_ID
        public string f30;//tipo_cheque_ID
        public int f31;//servidor_ID
        public string f32;//accion

        //CONSTRUCTOR
        public VentaJSON(DataRow data, int servidor_ID, string accion)
        {
            try
            {
                //cursor.getString(11)
                f0 = data["ID"].ToString();
                f1 = data["forma_pago_ID"].ToString();
                f2 = data["tipo_documento_ID"].ToString();
                f3 = data["usuario_ID"].ToString();
                f4 = data["arqueo_caja_ID"].ToString();
                f5 = data["cuenta_credito_ID"].ToString();
                f6 = data["comprobante_contable_ID"].ToString();
                f7 = data["mes_proceso"].ToString();
                f8 = data["ano_proceso"].ToString();
                f9 = data["fecha_proceso"].ToString();
                f10 = data["fecha"].ToString();
                f11 = data["numero"].ToString();
                f12 = data["estado"].ToString();
                f13 = data["total_descuento"].ToString();
                f14 = data["total_neto"].ToString();
                f15 = data["total_iva"].ToString();
                f16 = data["total_bruto"].ToString();
                f17 = data["total_saldo"].ToString();
                f18 = data["total_pagos"].ToString();
                f19 = data["documento_venta_ID"].ToString();
                f20 = data["cliente_proveedor_ID"].ToString();
                f21 = data["coordenadas_GPS"].ToString();
                f22 = data["fecha_entrega"].ToString();
                f23 = data["estado_vigente"].ToString();
                f24 = data["observacion"].ToString();
                f25 = data["total_pago_efectivo"].ToString();
                f26 = data["total_pago_tarjeta"].ToString();
                f27 = data["sucursal_ID"].ToString();
                f28 = data["tablet_ID"].ToString();
                f29 = data["banco_ID"].ToString();
                f30 = data["tipo_cheque_ID"].ToString();
                f31 = servidor_ID;
                f32 = accion;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "VentaJSON.Constructor");
            }
        }
        //CONSTRUCTOR
        public VentaJSON(Venta venta)
        {
            try
            {
                //cursor.getString(11)
                f0 = venta.fID.ToString();
                f1 = venta.fforma_pago_ID.ToString();
                f2 = venta.ftipo_documento_ID.ToString();
                f3 = venta.fusuario_ID.ToString();
                f4 = venta.farqueo_caja_ID.ToString();
                f5 = venta.fcuenta_credito_ID.ToString();
                f6 = venta.fcomprobante_contable_ID.ToString();
                f7 = venta.fmes_proceso.ToString();
                f8 = venta.fano_proceso.ToString();
                f9 = venta.ffecha_proceso.ToString();
                f10 = venta.ffecha.ToString();
                f11 = venta.fnumero.ToString();
                f12 = venta.festado.ToString();
                f13 = venta.ftotal_descuento.ToString();
                f14 = venta.ftotal_neto.ToString();
                f15 = venta.ftotal_iva.ToString();
                f16 = venta.ftotal_bruto.ToString();
                f17 = venta.ftotal_saldo.ToString();
                f18 = venta.ftotal_pagos.ToString();
                f19 = venta.fdocumento_venta_ID.ToString();
                f20 = venta.fcliente_proveedor_ID.ToString();
                f21 = venta.fcoordenadas_GPS.ToString();
                f22 = venta.ffecha_entrega.ToString();
                f23 = venta.festado_vigente.ToString();
                f24 = venta.fobservacion.ToString();
                f25 = venta.ftotal_pago_efectivo.ToString();
                f26 = venta.ftotal_pago_tarjeta.ToString();
                f27 = venta.fsucursal_ID.ToString();
                f28 = venta.ftablet_ID.ToString();
                f29 = venta.fbanco_ID.ToString();
                f30 = venta.ftipo_cheque_ID.ToString();
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "VentaJSON.Constructor");
            }
        }
        public VentaJSON()
        {
        }
        public String getID()
        {
            return f0;
        }
        public String getForma_pago_ID()
        {
            return f1;
        }
        public String getTipo_documento_ID()
        {
            return f2;
        }
        public String getUsuario_ID()
        {
            return f3;
        }
        public String getArqueo_caja_ID()
        {
            return f4;
        }
        public String getCuenta_credito_ID()
        {
            return f5;
        }
        public String getComprobante_contable_ID()
        {
            return f6;
        }
        public String getMes_proceso()
        {
            if (f7 != null)
                return f7;
            else
                return "";
        }
        public String getAno_proceso()
        {
            if (f8 != null)
                return f8;
            else
                return "";
        }
        public String getFecha_proceso()
        {
            if (f9 != null)
                return f9;
            else
                return "";
        }
        public String getFecha()
        {
            if (f10 != null)
                return f10;
            else
                return "";
        }
        public String getNumero()
        {
            return f11;
        }
        public String getEstado()
        {
            return f12;
        }
        public String getTotal_descuento()
        {
            return f13;
        }
        public String getTotal_neto()
        {
            return f14;
        }
        public String getTotal_iva()
        {
            return f15;
        }
        public String getTotal_bruto()
        {
            return f16;
        }
        public String getTotal_saldo()
        {
            return f17;
        }
        public String getTotal_pagos()
        {
            return f18;
        }
        public String getDocumento_venta_ID()
        {
            return f19;
        }
        public String getCliente_proveedor_ID()
        {
            return f20;
        }
        public String getCoordenadas_GPS()
        {
            if (f21 != null)
                return f21;
            else
                return "";
        }
        public String getFecha_entrega()
        {
            if (f22 != null)
                return f22;
            else
                return "";
        }
        public String getEstado_vigente()
        {
            if (f23 != null)
                return f23;
            else
                return "";
        }
        public String getObservacion()
        {
            if (f24 != null)
                return f24;
            else
                return "";
        }
        public String getTotal_pago_efectivo()
        {
            return f25;
        }
        public String getTotal_pago_tarjeta()
        {
            return f26;
        }
        public String getSucursal_ID()
        {
            return f27;
        }
        public String getTablet_ID()
        {
            return f28;
        }
        public String getBanco_ID()
        {
            return f29;
        }
        public String getTipo_cheque_ID()
        {
            return f30;
        }
        public void setID(string ID)
        {
            this.f0 = ID;
        }
        public void setForma_pago_ID(string forma_pago_ID)
        {
            this.f1 = forma_pago_ID;
        }
        public void setTipo_documento_ID(string tipo_documento_ID)
        {
            this.f2 = tipo_documento_ID;
        }
        public void setUsuario_ID(string usuario_ID)
        {
            this.f3 = usuario_ID;
        }
        public void setArqueo_caja_ID(string arqueo_caja_ID)
        {
            this.f4 = arqueo_caja_ID;
        }
        public void setCuenta_credito_ID(string cuenta_credito_ID)
        {
            this.f5 = cuenta_credito_ID;
        }
        public void setComprobante_contable_ID(string comprobante_contable_ID)
        {
            this.f6 = comprobante_contable_ID;
        }
        public void setMes_proceso(string mes_proceso)
        {
            this.f7 = mes_proceso;
        }
        public void setAno_proceso(string ano_proceso)
        {
            this.f8 = ano_proceso;
        }
        public void setFecha_proceso(string fecha_proceso)
        {
            this.f9 = fecha_proceso;
        }
        public void setFecha(string fecha)
        {
            this.f10 = fecha;
        }
        public void setNumero(string numero)
        {
            this.f11 = numero;
        }
        public void setEstado(string estado)
        {
            this.f12 = estado;
        }
        public void setTotal_descuento(string total_descuento)
        {
            this.f13 = total_descuento;
        }
        public void setTotal_neto(string total_neto)
        {
            this.f14 = total_neto;
        }
        public void setTotal_iva(string total_iva)
        {
            this.f15 = total_iva;
        }
        public void setTotal_bruto(string total_bruto)
        {
            this.f16 = total_bruto;
        }
        public void setTotal_saldo(string total_saldo)
        {
            this.f17 = total_saldo;
        }
        public void setTotal_pagos(string total_pagos)
        {
            this.f18 = total_pagos;
        }
        public void setDocumento_venta_ID(string documento_venta_ID)
        {
            this.f19 = documento_venta_ID;
        }
        public void setCliente_proveedor_ID(string cliente_proveedor_ID)
        {
            this.f20 = cliente_proveedor_ID;
        }
        public void setCoordenadas_GPS(string coordenadas_GPS)
        {
            this.f21 = coordenadas_GPS;
        }
        public void setFecha_entrega(string fecha_entrega)
        {
            this.f22 = fecha_entrega;
        }
        public void setEstado_vigente(string estado_vigente)
        {
            this.f23 = estado_vigente;
        }
        public void setObservacion(string observacion)
        {
            this.f24 = observacion;
        }
        public void setTotal_pago_efectivo(string total_pago_efectivo)
        {
            this.f25 = total_pago_efectivo;
        }
        public void setTotal_pago_tarjeta(string total_pago_tarjeta)
        {
            this.f26 = total_pago_tarjeta;
        }
        public void setSucursal_ID(string sucursal_ID)
        {
            this.f27 = sucursal_ID;
        }
        public void setTablet_ID(string tablet_ID)
        {
            this.f28 = tablet_ID;
        }
        public void setBanco_ID(string banco_ID)
        {
            this.f29 = banco_ID;
        }
        public void setTipo_cheque_ID(string tipo_cheque_ID)
        {
            this.f30 = tipo_cheque_ID;
        }

        public void actualizar()
        {
            try
            {
                CtrlVenta.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Venta.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlVenta.guardarJSON(this);
        }

    }//fin clase lógica

}

