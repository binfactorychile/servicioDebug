
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Detalle_documento_compraJSON
	{
	public int f0;//ID
	public int f1;//producto_ID
	public int f2;//detalle_solicitud_compra_ID
	public int f3;//detalle_comprobante_contable_ID
	public int f4;//cantidad
	public int f5;//exento
	public float f6;//porcentaje_descuento
	public int f7;//monto_descuento
	public int f8;//precio_neto_unitario
	public int f9;//monto_impuesto
	public int f10;//impuesto_ID
	public int f11;//total_neto
	public float f12;//iva
	public int f13;//total_bruto
	public int f14;//estado
	public int f15;//documento_compra_ID
	public float f16;//flete_unitario
	public int f17;//precio_neto_unitario_factura
	
	//CONSTRUCTOR
	public Detalle_documento_compraJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =Utils.cint(data["ID"].ToString());
	f1 =Utils.cint(data["producto_ID"].ToString());
	f2 =Utils.cint(data["detalle_solicitud_compra_ID"].ToString());
	f3 =Utils.cint(data["detalle_comprobante_contable_ID"].ToString());
	f4 =Utils.cint(data["cantidad"].ToString());
	f5 =Utils.cint(data["exento"].ToString());
	f6 =data["porcentaje_descuento"].ToString();
	f7 =Utils.cint(data["monto_descuento"].ToString());
	f8 =Utils.cint(data["precio_neto_unitario"].ToString());
	f9 =Utils.cint(data["monto_impuesto"].ToString());
	f10 =Utils.cint(data["impuesto_ID"].ToString());
	f11 =Utils.cint(data["total_neto"].ToString());
	f12 =data["iva"].ToString();
	f13 =Utils.cint(data["total_bruto"].ToString());
	f14 =Utils.cint(data["estado"].ToString());
	f15 =Utils.cint(data["documento_compra_ID"].ToString());
	f16 =data["flete_unitario"].ToString();
	f17 =Utils.cint(data["precio_neto_unitario_factura"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_documento_compraJSON.Constructor");
	}
	}
	public Detalle_documento_compraJSON()
	{
	}
	public int getID(){
		return f0;
	}
	public int getProducto_ID(){
		return f1;
	}
	public int getDetalle_solicitud_compra_ID(){
		return f2;
	}
	public int getDetalle_comprobante_contable_ID(){
		return f3;
	}
	public int getCantidad(){
		return f4;
	}
	public int getExento(){
		return f5;
	}
	public float getPorcentaje_descuento(){
		return f6;
	}
	public int getMonto_descuento(){
		return f7;
	}
	public int getPrecio_neto_unitario(){
		return f8;
	}
	public int getMonto_impuesto(){
		return f9;
	}
	public int getImpuesto_ID(){
		return f10;
	}
	public int getTotal_neto(){
		return f11;
	}
	public float getIva(){
		return f12;
	}
	public int getTotal_bruto(){
		return f13;
	}
	public int getEstado(){
		return f14;
	}
	public int getDocumento_compra_ID(){
		return f15;
	}
	public float getFlete_unitario(){
		return f16;
	}
	public int getPrecio_neto_unitario_factura(){
		return f17;
	}
	public void setID(int ID){
		this.f0=ID;
	}
	public void setProducto_ID(int producto_ID){
		this.f1=producto_ID;
	}
	public void setDetalle_solicitud_compra_ID(int detalle_solicitud_compra_ID){
		this.f2=detalle_solicitud_compra_ID;
	}
	public void setDetalle_comprobante_contable_ID(int detalle_comprobante_contable_ID){
		this.f3=detalle_comprobante_contable_ID;
	}
	public void setCantidad(int cantidad){
		this.f4=cantidad;
	}
	public void setExento(int exento){
		this.f5=exento;
	}
	public void setPorcentaje_descuento(float porcentaje_descuento){
		this.f6=porcentaje_descuento;
	}
	public void setMonto_descuento(int monto_descuento){
		this.f7=monto_descuento;
	}
	public void setPrecio_neto_unitario(int precio_neto_unitario){
		this.f8=precio_neto_unitario;
	}
	public void setMonto_impuesto(int monto_impuesto){
		this.f9=monto_impuesto;
	}
	public void setImpuesto_ID(int impuesto_ID){
		this.f10=impuesto_ID;
	}
	public void setTotal_neto(int total_neto){
		this.f11=total_neto;
	}
	public void setIva(float iva){
		this.f12=iva;
	}
	public void setTotal_bruto(int total_bruto){
		this.f13=total_bruto;
	}
	public void setEstado(int estado){
		this.f14=estado;
	}
	public void setDocumento_compra_ID(int documento_compra_ID){
		this.f15=documento_compra_ID;
	}
	public void setFlete_unitario(float flete_unitario){
		this.f16=flete_unitario;
	}
	public void setPrecio_neto_unitario_factura(int precio_neto_unitario_factura){
		this.f17=precio_neto_unitario_factura;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlDetalle_documento_compra.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_documento_compra.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlDetalle_documento_compra.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
