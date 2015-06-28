
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Detalle_documento_ventaJSON
	{
	public int f0;//ID
	public int f1;//documento_venta_ID
	public int f2;//producto_ID
	public int f3;//cantidad
	public int f4;//monto_descuento
	public int f5;//precio_neto_unitario
	public int f6;//monto_impuesto
	public int f7;//porcentaje_descuento
	public int f8;//total_neto
	public int f9;//iva
	public int f10;//total_bruto
	public int f11;//estado
	public String f12;//es_promocion
	
	//CONSTRUCTOR
	public Detalle_documento_ventaJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =Utils.cint(data["ID"].ToString());
	f1 =Utils.cint(data["documento_venta_ID"].ToString());
	f2 =Utils.cint(data["producto_ID"].ToString());
	f3 =Utils.cint(data["cantidad"].ToString());
	f4 =Utils.cint(data["monto_descuento"].ToString());
	f5 =Utils.cint(data["precio_neto_unitario"].ToString());
	f6 =Utils.cint(data["monto_impuesto"].ToString());
	f7 =Utils.cint(data["porcentaje_descuento"].ToString());
	f8 =Utils.cint(data["total_neto"].ToString());
	f9 =Utils.cint(data["iva"].ToString());
	f10 =Utils.cint(data["total_bruto"].ToString());
	f11 =Utils.cint(data["estado"].ToString());
	f12 =data["es_promocion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_documento_ventaJSON.Constructor");
	}
	}
	public Detalle_documento_ventaJSON()
	{
	}
	public int getID(){
		return f0;
	}
	public int getDocumento_venta_ID(){
		return f1;
	}
	public int getProducto_ID(){
		return f2;
	}
	public int getCantidad(){
		return f3;
	}
	public int getMonto_descuento(){
		return f4;
	}
	public int getPrecio_neto_unitario(){
		return f5;
	}
	public int getMonto_impuesto(){
		return f6;
	}
	public int getPorcentaje_descuento(){
		return f7;
	}
	public int getTotal_neto(){
		return f8;
	}
	public int getIva(){
		return f9;
	}
	public int getTotal_bruto(){
		return f10;
	}
	public int getEstado(){
		return f11;
	}
	public String getEs_promocion(){
		if(f12!=null)
		return f12;
		else
		return "";
	}
	public void setID(int ID){
		this.f0=ID;
	}
	public void setDocumento_venta_ID(int documento_venta_ID){
		this.f1=documento_venta_ID;
	}
	public void setProducto_ID(int producto_ID){
		this.f2=producto_ID;
	}
	public void setCantidad(int cantidad){
		this.f3=cantidad;
	}
	public void setMonto_descuento(int monto_descuento){
		this.f4=monto_descuento;
	}
	public void setPrecio_neto_unitario(int precio_neto_unitario){
		this.f5=precio_neto_unitario;
	}
	public void setMonto_impuesto(int monto_impuesto){
		this.f6=monto_impuesto;
	}
	public void setPorcentaje_descuento(int porcentaje_descuento){
		this.f7=porcentaje_descuento;
	}
	public void setTotal_neto(int total_neto){
		this.f8=total_neto;
	}
	public void setIva(int iva){
		this.f9=iva;
	}
	public void setTotal_bruto(int total_bruto){
		this.f10=total_bruto;
	}
	public void setEstado(int estado){
		this.f11=estado;
	}
	public void setEs_promocion(String es_promocion){
		this.f12=es_promocion;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlDetalle_documento_venta.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_documento_venta.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlDetalle_documento_venta.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
