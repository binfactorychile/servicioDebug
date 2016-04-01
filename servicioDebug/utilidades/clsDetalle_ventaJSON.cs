
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Detalle_ventaJSON
	{
	public string f0;//ID
	public string f1;//producto_ID
	public string f2;//detalle_comprobante_contable_ID
	public string f3;//cantidad
	public string f4;//precio_unitario
	public string f5;//descuento
	public string f6;//iva
	public string f7;//total
	public string f8;//venta_ID
	public string f9;//estado
	public string f10;//es_promocion
	public string f11;//total_otros_impuestos
	public string f12;//impuesto_ID
	public string f13;//precio_unitario_neto
	
	//CONSTRUCTOR
	public Detalle_ventaJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =data["ID"].ToString();
	f1 =data["producto_ID"].ToString();
	f2 =data["detalle_comprobante_contable_ID"].ToString();
	f3 =data["cantidad"].ToString();
	f4 =data["precio_unitario"].ToString();
	f5 =data["descuento"].ToString();
	f6 =data["iva"].ToString();
	f7 =data["total"].ToString();
	f8 =data["venta_ID"].ToString();
	f9 =data["estado"].ToString();
	f10 =data["es_promocion"].ToString();
	f11 =data["total_otros_impuestos"].ToString();
	f12 =data["impuesto_ID"].ToString();
	f13 =data["precio_unitario_neto"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_ventaJSON.Constructor");
	}
	}
	//CONSTRUCTOR
	public Detalle_ventaJSON(Detalle_venta detalle_venta)
	{
		try
	{
	//cursor.getString(11)
	f0 =detalle_venta.fID.ToString();
	f1 =detalle_venta.fproducto_ID.ToString();
	f2 =detalle_venta.fdetalle_comprobante_contable_ID.ToString();
	f3 =detalle_venta.fcantidad.ToString();
	f4 =detalle_venta.fprecio_unitario.ToString();
	f5 =detalle_venta.fdescuento.ToString();
	f6 =detalle_venta.fiva.ToString();
	f7 =detalle_venta.ftotal.ToString();
	f8 =detalle_venta.fventa_ID.ToString();
	f9 =detalle_venta.festado.ToString();
	f10 =detalle_venta.fes_promocion.ToString();
	f11 =detalle_venta.ftotal_otros_impuestos.ToString();
	f12 =detalle_venta.fimpuesto_ID.ToString();
	f13 =detalle_venta.fprecio_unitario_neto.ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_ventaJSON.Constructor");
	}
	}
	public Detalle_ventaJSON()
	{
	}
	public String getID(){
		return f0;
	}
	public String getProducto_ID(){
		return f1;
	}
	public String getDetalle_comprobante_contable_ID(){
		return f2;
	}
	public String getCantidad(){
		return f3;
	}
	public String getPrecio_unitario(){
		return f4;
	}
	public String getDescuento(){
		return f5;
	}
	public String getIva(){
		return f6;
	}
	public String getTotal(){
		return f7;
	}
	public String getVenta_ID(){
		return f8;
	}
	public String getEstado(){
		return f9;
	}
	public String getEs_promocion(){
		if(f10!=null)
		return f10;
		else
		return "";
	}
	public String getTotal_otros_impuestos(){
		return f11;
	}
	public String getImpuesto_ID(){
		return f12;
	}
	public String getPrecio_unitario_neto(){
		return f13;
	}
	public void setID(string ID){
		this.f0=ID;
	}
	public void setProducto_ID(string producto_ID){
		this.f1=producto_ID;
	}
	public void setDetalle_comprobante_contable_ID(string detalle_comprobante_contable_ID){
		this.f2=detalle_comprobante_contable_ID;
	}
	public void setCantidad(string cantidad){
		this.f3=cantidad;
	}
	public void setPrecio_unitario(string precio_unitario){
		this.f4=precio_unitario;
	}
	public void setDescuento(string descuento){
		this.f5=descuento;
	}
	public void setIva(string iva){
		this.f6=iva;
	}
	public void setTotal(string total){
		this.f7=total;
	}
	public void setVenta_ID(string venta_ID){
		this.f8=venta_ID;
	}
	public void setEstado(string estado){
		this.f9=estado;
	}
	public void setEs_promocion(string es_promocion){
		this.f10=es_promocion;
	}
	public void setTotal_otros_impuestos(string total_otros_impuestos){
		this.f11=total_otros_impuestos;
	}
	public void setImpuesto_ID(string impuesto_ID){
		this.f12=impuesto_ID;
	}
	public void setPrecio_unitario_neto(string precio_unitario_neto){
		this.f13=precio_unitario_neto;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlDetalle_venta.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Detalle_venta.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlDetalle_venta.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
