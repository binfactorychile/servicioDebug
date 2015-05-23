
using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
		
public class Sincronizar_tabletJSON
	{
	public int f0;//ID
	public int f1;//registro_ID
	public int f2;//tablet_ID
	public String f3;//nombre_tabla
	public String f4;//accion
	
	//CONSTRUCTOR
	public Sincronizar_tabletJSON(DataRow data)
	{
		try
	{
	//cursor.getString(11)
	f0 =Utils.cint(data["ID"].ToString());
	f1 =Utils.cint(data["registro_ID"].ToString());
	f2 =Utils.cint(data["tablet_ID"].ToString());
	f3 =data["nombre_tabla"].ToString();
	f4 =data["accion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Sincronizar_tabletJSON.Constructor");
	}
	}
	public Sincronizar_tabletJSON()
	{
	}
	public int getID(){
		return f0;
	}
	public int getRegistro_ID(){
		return f1;
	}
	public int getTablet_ID(){
		return f2;
	}
	public String getNombre_tabla(){
		if(f3!=null)
		return f3;
		else
		return "";
	}
	public String getAccion(){
		if(f4!=null)
		return f4;
		else
		return "";
	}
	public void setID(int ID){
		this.f0=ID;
	}
	public void setRegistro_ID(int registro_ID){
		this.f1=registro_ID;
	}
	public void setTablet_ID(int tablet_ID){
		this.f2=tablet_ID;
	}
	public void setNombre_tabla(String nombre_tabla){
		this.f3=nombre_tabla;
	}
	public void setAccion(String accion){
		this.f4=accion;
	}
	
	public void actualizar()
	{
		try
	{
		CtrlSincronizar_tablet.actualizarJSON(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex,"Sincronizar_tablet.actualizarJSON");
	}
	}
	public int guardar()
	{
		return  CtrlSincronizar_tablet.guardarJSON(this);
	}
	
	}//fin clase lógica
	
	}
	
