
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
{

    public class Cliente_proveedorJSON
    {
        public int f0;//ID
        public String f1;//nombre
        public String f2;//direccion
        public String f3;//ciudad
        public String f4;//razon_social
        public String f5;//telefono
        public String f6;//email
        public String f7;//estado
        public String f8;//giro
        public String f9;//fax
        public int f10;//tipo
        public int f11;//cuenta_credito_ID
        public int f12;//monto_credito
        public String f13;//rut
        public String f14;//coordenadas_GPS
        public int f15;//tipo_cliente_ID
        public int f16;//listado_cliente_ID
        public int f17;//sector_ID
        public String f18;//es_sucursal
        public String f19;//estado_vigente
        public String f20;//observacion
        public int f21;//sucursal_ID
        public int f22;//lista_precios_ID
        public double f23;//descuento_adicional
        public string f98;
        public int f99;

        //CONSTRUCTOR
        public Cliente_proveedorJSON(DataRow data, string accion, int servidor_ID)
        {
            try
            {
                //cursor.getString(11)
                f0 = Utils.cint(data["ID"].ToString());
                f1 = data["nombre"].ToString();
                f2 = data["direccion"].ToString();
                f3 = data["ciudad"].ToString();
                f4 = data["razon_social"].ToString();
                f5 = data["telefono"].ToString();
                f6 = data["email"].ToString();
                f7 = data["estado"].ToString();
                f8 = data["giro"].ToString();
                f9 = data["fax"].ToString();
                f10 = Utils.cint(data["tipo"].ToString());
                f11 = Utils.cint(data["cuenta_credito_ID"].ToString());
                f12 = Utils.cint(data["monto_credito"].ToString());
                f13 = data["rut"].ToString();
                f14 = data["coordenadas_GPS"].ToString();
                f15 = Utils.cint(data["tipo_cliente_ID"].ToString());
                f16 = Utils.cint(data["listado_cliente_ID"].ToString());
                f17 = Utils.cint(data["sector_ID"].ToString());
                f18 = data["es_sucursal"].ToString();
                f19 = data["estado_vigente"].ToString();
                f20 = data["observacion"].ToString();
                f21 = Utils.cint(data["sucursal_ID"].ToString());
                f22 = Utils.cint(data["lista_precios_ID"].ToString());
                f23 = Utils.cdouble(data["descuento_adicional"].ToString());
                f98 = accion;
                f99 = servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Cliente_proveedorJSON.Constructor");
            }
        }
        public Cliente_proveedorJSON()
        {
        }
        public int getID()
        {
            return f0;
        }
        public String getNombre()
        {
            if (f1 != null)
                return f1;
            else
                return "";
        }
        public String getDireccion()
        {
            if (f2 != null)
                return f2;
            else
                return "";
        }
        public String getCiudad()
        {
            if (f3 != null)
                return f3;
            else
                return "";
        }
        public String getRazon_social()
        {
            if (f4 != null)
                return f4;
            else
                return "";
        }
        public String getTelefono()
        {
            if (f5 != null)
                return f5;
            else
                return "";
        }
        public String getEmail()
        {
            if (f6 != null)
                return f6;
            else
                return "";
        }
        public String getEstado()
        {
            if (f7 != null)
                return f7;
            else
                return "";
        }
        public String getGiro()
        {
            if (f8 != null)
                return f8;
            else
                return "";
        }
        public String getFax()
        {
            if (f9 != null)
                return f9;
            else
                return "";
        }
        public int getTipo()
        {
            return f10;
        }
        public int getCuenta_credito_ID()
        {
            return f11;
        }
        public int getMonto_credito()
        {
            return f12;
        }
        public String getRut()
        {
            if (f13 != null)
                return f13;
            else
                return "";
        }
        public String getCoordenadas_GPS()
        {
            if (f14 != null)
                return f14;
            else
                return "";
        }
        public int getTipo_cliente_ID()
        {
            return f15;
        }
        public int getListado_cliente_ID()
        {
            return f16;
        }
        public int getSector_ID()
        {
            return f17;
        }
        public String getEs_sucursal()
        {
            if (f18 != null)
                return f18;
            else
                return "";
        }
        public String getEstado_vigente()
        {
            if (f19 != null)
                return f19;
            else
                return "";
        }
        public String getObservacion()
        {
            if (f20 != null)
                return f20;
            else
                return "";
        }
        public int getSucursal_ID()
        {
            return f21;
        }
        public int getLista_precios_ID()
        {
            return f22;
        }
        public double getDescuento_adicional()
        {
            return f23;
        }
        public void setID(int ID)
        {
            this.f0 = ID;
        }
        public void setNombre(String nombre)
        {
            this.f1 = nombre;
        }
        public void setDireccion(String direccion)
        {
            this.f2 = direccion;
        }
        public void setCiudad(String ciudad)
        {
            this.f3 = ciudad;
        }
        public void setRazon_social(String razon_social)
        {
            this.f4 = razon_social;
        }
        public void setTelefono(String telefono)
        {
            this.f5 = telefono;
        }
        public void setEmail(String email)
        {
            this.f6 = email;
        }
        public void setEstado(String estado)
        {
            this.f7 = estado;
        }
        public void setGiro(String giro)
        {
            this.f8 = giro;
        }
        public void setFax(String fax)
        {
            this.f9 = fax;
        }
        public void setTipo(int tipo)
        {
            this.f10 = tipo;
        }
        public void setCuenta_credito_ID(int cuenta_credito_ID)
        {
            this.f11 = cuenta_credito_ID;
        }
        public void setMonto_credito(int monto_credito)
        {
            this.f12 = monto_credito;
        }
        public void setRut(String rut)
        {
            this.f13 = rut;
        }
        public void setCoordenadas_GPS(String coordenadas_GPS)
        {
            this.f14 = coordenadas_GPS;
        }
        public void setTipo_cliente_ID(int tipo_cliente_ID)
        {
            this.f15 = tipo_cliente_ID;
        }
        public void setListado_cliente_ID(int listado_cliente_ID)
        {
            this.f16 = listado_cliente_ID;
        }
        public void setSector_ID(int sector_ID)
        {
            this.f17 = sector_ID;
        }
        public void setEs_sucursal(String es_sucursal)
        {
            this.f18 = es_sucursal;
        }
        public void setEstado_vigente(String estado_vigente)
        {
            this.f19 = estado_vigente;
        }
        public void setObservacion(String observacion)
        {
            this.f20 = observacion;
        }
        public void setSucursal_ID(int sucursal_ID)
        {
            this.f21 = sucursal_ID;
        }
        public void setLista_precios_ID(int lista_precios_ID)
        {
            this.f22 = lista_precios_ID;
        }

        public void actualizar()
        {
            try
            {
                CtrlCliente_proveedor.actualizarJSON(this);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex, "Cliente_proveedor.actualizarJSON");
            }
        }
        public int guardar()
        {
            return CtrlCliente_proveedor.guardarJSON(this);
        }

    }//fin clase lógica

}

