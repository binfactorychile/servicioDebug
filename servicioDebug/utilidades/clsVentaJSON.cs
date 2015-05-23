
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class VentaJSON
    {
        public int f0;//ID
        public int f1;//forma_pago_ID
        public int f2;//tipo_documento_ID
        public int f3;//usuario_ID
        public int f4;//arqueo_caja_ID
        public int f5;//cuenta_credito_ID
        public int f6;//comprobante_contable_ID
        public String f7;//mes_proceso
        public String f8;//ano_proceso
        public String f9;//fecha_proceso
        public String f10;//fecha
        public int f11;//numero
        public int f12;//estado
        public int f13;//total_descuento
        public int f14;//total_neto
        public int f15;//total_iva
        public int f16;//total_bruto
        public int f17;//total_saldo
        public int f18;//total_pagos
        public int f19;//documento_venta_ID
        public int f20;//cliente_proveedor_ID
        public String f21;//coordenadas_GPS
        public String f22;//fecha_entrega
        public String f23;//estado_vigente
        public String f24;//observacion
        public int f25;//total_pago_efectivo
        public int f26;//total_pago_tarjeta
        public int f27;//sucursal_ID
        public int f28;//servidor_ID
        public string f29;//accion

        //CONSTRUCTOR
        public VentaJSON(DataRow data, int servidor_ID, string accion)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = Utils.cint(data["forma_pago_ID"].ToString());
                f2 = Utils.cint(data["tipo_documento_ID"].ToString());
                f3 = Utils.cint(data["usuario_ID"].ToString());
                f4 = Utils.cint(data["arqueo_caja_ID"].ToString());
                f5 = Utils.cint(data["cuenta_credito_ID"].ToString());
                f6 = Utils.cint(data["comprobante_contable_ID"].ToString());
                f7 = data["mes_proceso"].ToString();
                f8 = data["ano_proceso"].ToString();
                f9 = data["fecha_proceso"].ToString();
                f10 = data["fecha"].ToString();
                f11 = Utils.cint(data["numero"].ToString());
                f12 = Utils.cint(data["estado"].ToString());
                f13 = Utils.cint(data["total_descuento"].ToString());
                f14 = Utils.cint(data["total_neto"].ToString());
                f15 = Utils.cint(data["total_iva"].ToString());
                f16 = Utils.cint(data["total_bruto"].ToString());
                f17 = Utils.cint(data["total_saldo"].ToString());
                f18 = Utils.cint(data["total_pagos"].ToString());
                f19 = Utils.cint(data["documento_venta_ID"].ToString());
                f20 = Utils.cint(data["cliente_proveedor_ID"].ToString());
                f21 = data["coordenadas_GPS"].ToString();
                f22 = data["fecha_entrega"].ToString();
                f23 = data["estado_vigente"].ToString();
                f24 = data["observacion"].ToString();
                f25 = Utils.cint(data["total_pago_efectivo"].ToString());
                f26 = Utils.cint(data["total_pago_tarjeta"].ToString());
                f27 = Utils.cint(data["sucursal_ID"].ToString());
                f28 = servidor_ID;
                f29 = accion;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "VentaJSON.Constructor");
            }
        }
        public VentaJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public int getForma_pago_ID()
        {
            return f1;
        }
        public int getTipo_documento_ID()
        {
            return f2;
        }
        public int getUsuario_ID()
        {
            return f3;
        }
        public int getArqueo_caja_ID()
        {
            return f4;
        }
        public int getCuenta_credito_ID()
        {
            return f5;
        }
        public int getComprobante_contable_ID()
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
        public int getNumero()
        {
            return f11;
        }
        public int getEstado()
        {
            return f12;
        }
        public int getTotal_descuento()
        {
            return f13;
        }
        public int getTotal_neto()
        {
            return f14;
        }
        public int getTotal_iva()
        {
            return f15;
        }
        public int getTotal_bruto()
        {
            return f16;
        }
        public int getTotal_saldo()
        {
            return f17;
        }
        public int getTotal_pagos()
        {
            return f18;
        }
        public int getDocumento_venta_ID()
        {
            return f19;
        }
        public int getCliente_proveedor_ID()
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
        public int getTotal_pago_efectivo()
        {
            return f25;
        }
        public int getTotal_pago_tarjeta()
        {
            return f26;
        }
        public int getSucursal_ID()
        {
            return f27;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setForma_pago_ID(int forma_pago_ID)
        {
            this.f1 = forma_pago_ID;
        }
        public void setTipo_documento_ID(int tipo_documento_ID)
        {
            this.f2 = tipo_documento_ID;
        }
        public void setUsuario_ID(int usuario_ID)
        {
            this.f3 = usuario_ID;
        }
        public void setArqueo_caja_ID(int arqueo_caja_ID)
        {
            this.f4 = arqueo_caja_ID;
        }
        public void setCuenta_credito_ID(int cuenta_credito_ID)
        {
            this.f5 = cuenta_credito_ID;
        }
        public void setComprobante_contable_ID(int comprobante_contable_ID)
        {
            this.f6 = comprobante_contable_ID;
        }
        public void setMes_proceso(String mes_proceso)
        {
            this.f7 = mes_proceso;
        }
        public void setAno_proceso(String ano_proceso)
        {
            this.f8 = ano_proceso;
        }
        public void setFecha_proceso(String fecha_proceso)
        {
            this.f9 = fecha_proceso;
        }
        public void setFecha(String fecha)
        {
            this.f10 = fecha;
        }
        public void setNumero(int numero)
        {
            this.f11 = numero;
        }
        public void setEstado(int estado)
        {
            this.f12 = estado;
        }
        public void setTotal_descuento(int total_descuento)
        {
            this.f13 = total_descuento;
        }
        public void setTotal_neto(int total_neto)
        {
            this.f14 = total_neto;
        }
        public void setTotal_iva(int total_iva)
        {
            this.f15 = total_iva;
        }
        public void setTotal_bruto(int total_bruto)
        {
            this.f16 = total_bruto;
        }
        public void setTotal_saldo(int total_saldo)
        {
            this.f17 = total_saldo;
        }
        public void setTotal_pagos(int total_pagos)
        {
            this.f18 = total_pagos;
        }
        public void setDocumento_venta_ID(int documento_venta_ID)
        {
            this.f19 = documento_venta_ID;
        }
        public void setCliente_proveedor_ID(int cliente_proveedor_ID)
        {
            this.f20 = cliente_proveedor_ID;
        }
        public void setCoordenadas_GPS(String coordenadas_GPS)
        {
            this.f21 = coordenadas_GPS;
        }
        public void setFecha_entrega(String fecha_entrega)
        {
            this.f22 = fecha_entrega;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f23 = estado_vigente;
        }
        public void setObservacion(String observacion)
        {
            this.f24 = observacion;
        }
        public void setTotal_pago_efectivo(int total_pago_efectivo)
        {
            this.f25 = total_pago_efectivo;
        }
        public void setTotal_pago_tarjeta(int total_pago_tarjeta)
        {
            this.f26 = total_pago_tarjeta;
        }
        public void setSucursal_ID(int sucursal_ID)
        {
            this.f27 = sucursal_ID;
        }

        //public void actualizar()
        //{
        //    try
        //    {
        //        CtrlVenta.actualizarJSON(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex, "Venta.actualizarJSON");
        //    }
        //}
        //public int guardar()
        //{
        //    return CtrlVenta.guardarJSON(this);
        //}

    }//fin clase lógica

}

