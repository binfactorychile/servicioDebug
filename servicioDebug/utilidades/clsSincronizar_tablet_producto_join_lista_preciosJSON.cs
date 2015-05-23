
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Sincronizar_tablet_producto_join_lista_preciosJSON
	{
	public int f0;//ID
	public int f1;//producto_join_lista_precios_ID
	public int f2;//tablet_ID
	public String f3;//accion
	
	//CONSTRUCTOR
	public Sincronizar_tablet_producto_join_lista_preciosJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =Utils.cint(data["ID"].ToString());
	f1 =Utils.cint(data["producto_join_lista_precios_ID"].ToString());
	f2 =Utils.cint(data["tablet_ID"].ToString());
	f3 =data["accion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Sincronizar_tablet_producto_join_lista_preciosJSON.Constructor");
	}
	}
	public Sincronizar_tablet_producto_join_lista_preciosJSON()
	{
	}
	public int getID(){
		return f0;
	}
	public int getProducto_join_lista_precios_ID(){
		return f1;
	}
	public int getTablet_ID(){
		return f2;
	}
	public String getAccion(){
		if(f3!=null)
		return f3;
		else
		return "";
	}
	public void setID(int ID){
		this.f0=ID;
	}
	public void setProducto_join_lista_precios_ID(int producto_join_lista_precios_ID){
		this.f1=producto_join_lista_precios_ID;
	}
	public void setTablet_ID(int tablet_ID){
		this.f2=tablet_ID;
	}
	public void setAccion(String accion){
		this.f3=accion;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlSincronizar_tablet_producto_join_lista_precios.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Sincronizar_tablet_producto_join_lista_precios.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlSincronizar_tablet_producto_join_lista_precios.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
