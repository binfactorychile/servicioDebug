using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Sincronizar_tablet_producto_join_lista_precios
	{
		private int _ID;
		private int _producto_join_lista_precios_ID;
		private int _tablet_ID;
		private string _accion;
		
	//CONSTRUCTOR
	public Sincronizar_tablet_producto_join_lista_precios(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_producto_join_lista_precios_ID =Utils.cint(data["producto_join_lista_precios_ID"].ToString());
		_tablet_ID =Utils.cint(data["tablet_ID"].ToString());
		_accion =data["accion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Sincronizar_tablet_producto_join_lista_precios()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fproducto_join_lista_precios_ID{
		
	get{return (_producto_join_lista_precios_ID);}
	set{_producto_join_lista_precios_ID=value;}
	
	}
	
	public int ftablet_ID{
		
	get{return (_tablet_ID);}
	set{_tablet_ID=value;}
	
	}
	
	public string faccion{
		
	get{return (_accion);}
	set{_accion=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlSincronizar_tablet_producto_join_lista_precios.actualizar(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public int guardar()
	{
		try
	{
		return  CtrlSincronizar_tablet_producto_join_lista_precios.guardar(this);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	public void eliminar()
	{
		try
	{
		CtrlSincronizar_tablet_producto_join_lista_precios.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Producto_join_lista_precios getProducto_join_lista_precios()
	{
		return CtrlProducto_join_lista_precios.getProducto_join_lista_precios(_producto_join_lista_precios_ID);
	}
	
	public Tablet getTablet()
	{
		return CtrlTablet.getTablet(_tablet_ID);
	}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Sincronizar_tablet_producto_join_lista_precios
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String producto_join_lista_precios_ID{
		
	get{return ("producto_join_lista_precios_ID");}
	}
	public static String tablet_ID{
		
	get{return ("tablet_ID");}
	}
	public static String accion{
		
	get{return ("accion");}
	}
	}//Fin clase estática
	
	}//Fin name_space
