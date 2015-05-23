using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Sincroniza_tablet_cliente
	{
		private int _ID;
		private int _cliente_proveedor_ID;
		private int _tablet_ID;
		private string _accion;
		
	//CONSTRUCTOR
	public Sincroniza_tablet_cliente(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_cliente_proveedor_ID =Utils.cint(data["cliente_proveedor_ID"].ToString());
		_tablet_ID =Utils.cint(data["tablet_ID"].ToString());
		_accion =data["accion"].ToString();
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Sincroniza_tablet_cliente()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fcliente_proveedor_ID{
		
	get{return (_cliente_proveedor_ID);}
	set{_cliente_proveedor_ID=value;}
	
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
		CtrlSincroniza_tablet_cliente.actualizar(this);
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
		return  CtrlSincroniza_tablet_cliente.guardar(this);
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
		CtrlSincroniza_tablet_cliente.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	
	public Cliente_proveedor getCliente_proveedor()
	{
		return CtrlCliente_proveedor.getCliente_proveedor(_cliente_proveedor_ID);
	}
	
	public Tablet getTablet()
	{
		return CtrlTablet.getTablet(_tablet_ID);
	}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Sincroniza_tablet_cliente
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String cliente_proveedor_ID{
		
	get{return ("cliente_proveedor_ID");}
	}
	public static String tablet_ID{
		
	get{return ("tablet_ID");}
	}
	public static String accion{
		
	get{return ("accion");}
	}
	}//Fin clase estática
	
	}//Fin name_space
