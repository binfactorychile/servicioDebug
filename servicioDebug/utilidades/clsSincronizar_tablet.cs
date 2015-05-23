using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Sincronizar_tablet
	{
		private int _ID;
		private int _registro_ID;
		private int _tablet_ID;
		private string _nombre_tabla;
		private string _accion;
		
	//CONSTRUCTOR
	public Sincronizar_tablet(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_registro_ID =Utils.cint(data["registro_ID"].ToString());
		_tablet_ID =Utils.cint(data["tablet_ID"].ToString());
		_nombre_tabla =data["nombre_tabla"].ToString();
		_accion =data["accion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Sincronizar_tablet()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fregistro_ID{
		
	get{return (_registro_ID);}
	set{_registro_ID=value;}
	
	}
	
	public int ftablet_ID{
		
	get{return (_tablet_ID);}
	set{_tablet_ID=value;}
	
	}
	
	public string fnombre_tabla{
		
	get{return (_nombre_tabla);}
	set{_nombre_tabla=value;}
	
	}
	
	public string faccion{
		
	get{return (_accion);}
	set{_accion=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlSincronizar_tablet.actualizar(this);
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
		return  CtrlSincronizar_tablet.guardar(this);
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
		CtrlSincronizar_tablet.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}

	
	public Tablet getTablet()
	{
		return CtrlTablet.getTablet(_tablet_ID);
	}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Sincronizar_tablet
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String registro_ID{
		
	get{return ("registro_ID");}
	}
	public static String tablet_ID{
		
	get{return ("tablet_ID");}
	}
	public static String nombre_tabla{
		
	get{return ("nombre_tabla");}
	}
	public static String accion{
		
	get{return ("accion");}
	}
	}//Fin clase estática
	
	}//Fin name_space
