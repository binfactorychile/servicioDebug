
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Documento_compraJSON
	{
	public int f0;//ID
	public int f1;//proveedor_ID
	public int f2;//tipo_documento_ID
	public String f3;//numero
	public String f4;//fecha_digitacion
	public String f5;//fecha_cancelacion
	public String f6;//fecha_documento
	public int f7;//mes_proceso
	public int f8;//ano_proceso
	public int f9;//total_neto
	public int f10;//total_impuesto
	public int f11;//total_exento
	public int f12;//total_iva
	public int f13;//total_saldo
	public int f14;//total_pagos
	public int f15;//solicitud_compra_ID
	public int f16;//forma_pago_ID
	public String f17;//observacion
	public String f18;//fecha_vencimiento
	public int f19;//comprobante_contable_ID
	public int f20;//estado
	public int f21;//total_bruto
	public int f22;//documento_compra_ID
	public string f23;//flete_unitario_constante
	public int f24;//sucursal_ID
	
	//CONSTRUCTOR
	public Documento_compraJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =Utils.cint(data["ID"].ToString());
	f1 =Utils.cint(data["proveedor_ID"].ToString());
	f2 =Utils.cint(data["tipo_documento_ID"].ToString());
	f3 =data["numero"].ToString();
	f4 =data["fecha_digitacion"].ToString();
	f5 =data["fecha_cancelacion"].ToString();
	f6 =data["fecha_documento"].ToString();
	f7 =Utils.cint(data["mes_proceso"].ToString());
	f8 =Utils.cint(data["ano_proceso"].ToString());
	f9 =Utils.cint(data["total_neto"].ToString());
	f10 =Utils.cint(data["total_impuesto"].ToString());
	f11 =Utils.cint(data["total_exento"].ToString());
	f12 =Utils.cint(data["total_iva"].ToString());
	f13 =Utils.cint(data["total_saldo"].ToString());
	f14 =Utils.cint(data["total_pagos"].ToString());
	f15 =Utils.cint(data["solicitud_compra_ID"].ToString());
	f16 =Utils.cint(data["forma_pago_ID"].ToString());
	f17 =data["observacion"].ToString();
	f18 =data["fecha_vencimiento"].ToString();
	f19 =Utils.cint(data["comprobante_contable_ID"].ToString());
	f20 =Utils.cint(data["estado"].ToString());
	f21 =Utils.cint(data["total_bruto"].ToString());
	f22 =Utils.cint(data["documento_compra_ID"].ToString());
	f23 =data["flete_unitario_constante"].ToString();
	f24 =Utils.cint(data["sucursal_ID"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Documento_compraJSON.Constructor");
	}
	}
	public Documento_compraJSON()
	{
	}
	public int getID(){
		return f0;
	}
	public int getProveedor_ID(){
		return f1;
	}
	public int getTipo_documento_ID(){
		return f2;
	}
	public String getNumero(){
		if(f3!=null)
		return f3;
		else
		return "";
	}
	public String getFecha_digitacion(){
		if(f4!=null)
		return f4;
		else
		return "";
	}
	public String getFecha_cancelacion(){
		if(f5!=null)
		return f5;
		else
		return "";
	}
	public String getFecha_documento(){
		if(f6!=null)
		return f6;
		else
		return "";
	}
	public int getMes_proceso(){
		return f7;
	}
	public int getAno_proceso(){
		return f8;
	}
	public int getTotal_neto(){
		return f9;
	}
	public int getTotal_impuesto(){
		return f10;
	}
	public int getTotal_exento(){
		return f11;
	}
	public int getTotal_iva(){
		return f12;
	}
	public int getTotal_saldo(){
		return f13;
	}
	public int getTotal_pagos(){
		return f14;
	}
	public int getSolicitud_compra_ID(){
		return f15;
	}
	public int getForma_pago_ID(){
		return f16;
	}
	public String getObservacion(){
		if(f17!=null)
		return f17;
		else
		return "";
	}
	public String getFecha_vencimiento(){
		if(f18!=null)
		return f18;
		else
		return "";
	}
	public int getComprobante_contable_ID(){
		return f19;
	}
	public int getEstado(){
		return f20;
	}
	public int getTotal_bruto(){
		return f21;
	}
	public int getDocumento_compra_ID(){
		return f22;
	}
	public string getFlete_unitario_constante(){
		return f23;
	}
	public int getSucursal_ID(){
		return f24;
	}
	public void setID(int ID){
		this.f0=ID;
	}
	public void setProveedor_ID(int proveedor_ID){
		this.f1=proveedor_ID;
	}
	public void setTipo_documento_ID(int tipo_documento_ID){
		this.f2=tipo_documento_ID;
	}
	public void setNumero(String numero){
		this.f3=numero;
	}
	public void setFecha_digitacion(String fecha_digitacion){
		this.f4=fecha_digitacion;
	}
	public void setFecha_cancelacion(String fecha_cancelacion){
		this.f5=fecha_cancelacion;
	}
	public void setFecha_documento(String fecha_documento){
		this.f6=fecha_documento;
	}
	public void setMes_proceso(int mes_proceso){
		this.f7=mes_proceso;
	}
	public void setAno_proceso(int ano_proceso){
		this.f8=ano_proceso;
	}
	public void setTotal_neto(int total_neto){
		this.f9=total_neto;
	}
	public void setTotal_impuesto(int total_impuesto){
		this.f10=total_impuesto;
	}
	public void setTotal_exento(int total_exento){
		this.f11=total_exento;
	}
	public void setTotal_iva(int total_iva){
		this.f12=total_iva;
	}
	public void setTotal_saldo(int total_saldo){
		this.f13=total_saldo;
	}
	public void setTotal_pagos(int total_pagos){
		this.f14=total_pagos;
	}
	public void setSolicitud_compra_ID(int solicitud_compra_ID){
		this.f15=solicitud_compra_ID;
	}
	public void setForma_pago_ID(int forma_pago_ID){
		this.f16=forma_pago_ID;
	}
	public void setObservacion(String observacion){
		this.f17=observacion;
	}
	public void setFecha_vencimiento(String fecha_vencimiento){
		this.f18=fecha_vencimiento;
	}
	public void setComprobante_contable_ID(int comprobante_contable_ID){
		this.f19=comprobante_contable_ID;
	}
	public void setEstado(int estado){
		this.f20=estado;
	}
	public void setTotal_bruto(int total_bruto){
		this.f21=total_bruto;
	}
	public void setDocumento_compra_ID(int documento_compra_ID){
		this.f22=documento_compra_ID;
	}
	public void setFlete_unitario_constante(string flete_unitario_constante){
		this.f23=flete_unitario_constante;
	}
	public void setSucursal_ID(int sucursal_ID){
		this.f24=sucursal_ID;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlDocumento_compra.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Documento_compra.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlDocumento_compra.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
