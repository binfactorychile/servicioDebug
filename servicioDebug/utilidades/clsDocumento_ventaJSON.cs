
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Documento_ventaJSON
    {
        public int f0;//ID
        public int f1;//documento_venta_ID
        public int f2;//cliente_ID
        public int f3;//tipo_documento_ID
        public int f4;//comprobante_contable_ID
        public int f5;//forma_pago_ID
        public int f6;//usuario_ID
        public int f7;//numero
        public int f8;//correlativo
        public String f9;//fecha_digitacion
        public String f10;//fecha_cancelacion
        public String f11;//fecha_documento
        public String f12;//fecha_vencimiento
        public String f13;//fecha_proceso
        public String f14;//mes_proceso
        public String f15;//ano_proceso
        public String f16;//condicion_venta
        public int f17;//total_neto
        public int f18;//total_impuesto
        public int f19;//total_exento
        public int f20;//total_iva
        public int f21;//total_bruto
        public int f22;//total_saldo
        public int f23;//total_pagos
        public String f24;//observacion
        public String f25;//estado
        public int f26;//estado_despacho_ID
        public int f27;//estado_pago_documento_venta_ID
        public String f28;//estado_vigente
        public int f29;//sucursal_ID
        public int f30;//servidor_ID
        public string f31;//accion

        //CONSTRUCTOR
        public Documento_ventaJSON(DataRow data, int servidor_ID, string accion)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["documento_venta_ID"].ToString());
                f2 = Utils.cint(data["cliente_ID"].ToString());
                f3 = Utils.cint(data["tipo_documento_ID"].ToString());
                f4 = Utils.cint(data["comprobante_contable_ID"].ToString());
                f5 = Utils.cint(data["forma_pago_ID"].ToString());
                f6 = Utils.cint(data["usuario_ID"].ToString());
                f7 = Utils.cint(data["numero"].ToString());
                f8 = Utils.cint(data["correlativo"].ToString());
                f9 = data["fecha_digitacion"].ToString();
                f10 = data["fecha_cancelacion"].ToString();
                f11 = data["fecha_documento"].ToString();
                f12 = data["fecha_vencimiento"].ToString();
                f13 = data["fecha_proceso"].ToString();
                f14 = data["mes_proceso"].ToString();
                f15 = data["ano_proceso"].ToString();
                f16 = data["condicion_venta"].ToString();
                f17 = Utils.cint(data["total_neto"].ToString());
                f18 = Utils.cint(data["total_impuesto"].ToString());
                f19 = Utils.cint(data["total_exento"].ToString());
                f20 = Utils.cint(data["total_iva"].ToString());
                f21 = Utils.cint(data["total_bruto"].ToString());
                f22 = Utils.cint(data["total_saldo"].ToString());
                f23 = Utils.cint(data["total_pagos"].ToString());
                f24 = data["observacion"].ToString();
                f25 = data["estado"].ToString();
                f26 = Utils.cint(data["estado_despacho_ID"].ToString());
                f27 = Utils.cint(data["estado_pago_documento_venta_ID"].ToString());
                f28 = data["estado_vigente"].ToString();
                f29 = Utils.cint(data["sucursal_ID"].ToString());
                f30 = servidor_ID;
                f31 = accion;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Documento_ventaJSON.Constructor");
            }
        }
        public Documento_ventaJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getDocumento_venta_ID()
        {
            return f1;
        }
        public int getCliente_ID()
        {
            return f2;
        }
        public int getTipo_documento_ID()
        {
            return f3;
        }
        public int getComprobante_contable_ID()
        {
            return f4;
        }
        public int getForma_pago_ID()
        {
            return f5;
        }
        public int getUsuario_ID()
        {
            return f6;
        }
        public int getNumero()
        {
            return f7;
        }
        public int getCorrelativo()
        {
            return f8;
        }
        public String getFecha_digitacion()
        {
            if (f9 != null)
                return f9;
            else
                return "";
        }
        public String getFecha_cancelacion()
        {
            if (f10 != null)
                return f10;
            else
                return "";
        }
        public String getFecha_documento()
        {
            if (f11 != null)
                return f11;
            else
                return "";
        }
        public String getFecha_vencimiento()
        {
            if (f12 != null)
                return f12;
            else
                return "";
        }
        public String getFecha_proceso()
        {
            if (f13 != null)
                return f13;
            else
                return "";
        }
        public String getMes_proceso()
        {
            if (f14 != null)
                return f14;
            else
                return "";
        }
        public String getAno_proceso()
        {
            if (f15 != null)
                return f15;
            else
                return "";
        }
        public String getCondicion_venta()
        {
            if (f16 != null)
                return f16;
            else
                return "";
        }
        public int getTotal_neto()
        {
            return f17;
        }
        public int getTotal_impuesto()
        {
            return f18;
        }
        public int getTotal_exento()
        {
            return f19;
        }
        public int getTotal_iva()
        {
            return f20;
        }
        public int getTotal_bruto()
        {
            return f21;
        }
        public int getTotal_saldo()
        {
            return f22;
        }
        public int getTotal_pagos()
        {
            return f23;
        }
        public String getObservacion()
        {
            if (f24 != null)
                return f24;
            else
                return "";
        }
        public String getEstado()
        {
            if (f25 != null)
                return f25;
            else
                return "";
        }
        public int getEstado_despacho_ID()
        {
            return f26;
        }
        public int getEstado_pago_documento_venta_ID()
        {
            return f27;
        }
        public String getEstado_vigente()
        {
            if (f28 != null)
                return f28;
            else
                return "";
        }
        public int getSucursal_ID()
        {
            return f29;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setDocumento_venta_ID(int documento_venta_ID)
        {
            this.f1 = documento_venta_ID;
        }
        public void setCliente_ID(int cliente_ID)
        {
            this.f2 = cliente_ID;
        }
        public void setTipo_documento_ID(int tipo_documento_ID)
        {
            this.f3 = tipo_documento_ID;
        }
        public void setComprobante_contable_ID(int comprobante_contable_ID)
        {
            this.f4 = comprobante_contable_ID;
        }
        public void setForma_pago_ID(int forma_pago_ID)
        {
            this.f5 = forma_pago_ID;
        }
        public void setUsuario_ID(int usuario_ID)
        {
            this.f6 = usuario_ID;
        }
        public void setNumero(int numero)
        {
            this.f7 = numero;
        }
        public void setCorrelativo(int correlativo)
        {
            this.f8 = correlativo;
        }
        public void setFecha_digitacion(String fecha_digitacion)
        {
            this.f9 = fecha_digitacion;
        }
        public void setFecha_cancelacion(String fecha_cancelacion)
        {
            this.f10 = fecha_cancelacion;
        }
        public void setFecha_documento(String fecha_documento)
        {
            this.f11 = fecha_documento;
        }
        public void setFecha_vencimiento(String fecha_vencimiento)
        {
            this.f12 = fecha_vencimiento;
        }
        public void setFecha_proceso(String fecha_proceso)
        {
            this.f13 = fecha_proceso;
        }
        public void setMes_proceso(String mes_proceso)
        {
            this.f14 = mes_proceso;
        }
        public void setAno_proceso(String ano_proceso)
        {
            this.f15 = ano_proceso;
        }
        public void setCondicion_venta(String condicion_venta)
        {
            this.f16 = condicion_venta;
        }
        public void setTotal_neto(int total_neto)
        {
            this.f17 = total_neto;
        }
        public void setTotal_impuesto(int total_impuesto)
        {
            this.f18 = total_impuesto;
        }
        public void setTotal_exento(int total_exento)
        {
            this.f19 = total_exento;
        }
        public void setTotal_iva(int total_iva)
        {
            this.f20 = total_iva;
        }
        public void setTotal_bruto(int total_bruto)
        {
            this.f21 = total_bruto;
        }
        public void setTotal_saldo(int total_saldo)
        {
            this.f22 = total_saldo;
        }
        public void setTotal_pagos(int total_pagos)
        {
            this.f23 = total_pagos;
        }
        public void setObservacion(String observacion)
        {
            this.f24 = observacion;
        }
        public void setEstado(String estado)
        {
            this.f25 = estado;
        }
        public void setEstado_despacho_ID(int estado_despacho_ID)
        {
            this.f26 = estado_despacho_ID;
        }
        public void setEstado_pago_documento_venta_ID(int estado_pago_documento_venta_ID)
        {
            this.f27 = estado_pago_documento_venta_ID;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f28 = estado_vigente;
        }
        public void setSucursal_ID(int sucursal_ID)
        {
            this.f29 = sucursal_ID;
        }

        public void actualizar()
        {
            try
            {
                CtrlDocumento_venta.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Documento_venta.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlDocumento_venta.guardarJSON(this);
        }

    }//fin clase lógica

}

