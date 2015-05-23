using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Sincronizar_tablet_usuario
	{
		private int _ID;
		private int _usuario_ID;
		private int _tablet_ID;
		
	//CONSTRUCTOR
	public Sincronizar_tablet_usuario(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_usuario_ID =Utils.cint(data["usuario_ID"].ToString());
		_tablet_ID =Utils.cint(data["tablet_ID"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Sincronizar_tablet_usuario()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fusuario_ID{
		
	get{return (_usuario_ID);}
	set{_usuario_ID=value;}
	
	}
	
	public int ftablet_ID{
		
	get{return (_tablet_ID);}
	set{_tablet_ID=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlSincronizar_tablet_usuario.actualizar(this);
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
		return  CtrlSincronizar_tablet_usuario.guardar(this);
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
		CtrlSincronizar_tablet_usuario.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	
	public Usuario getUsuario()
	{
		return CtrlUsuario.getUsuario(_usuario_ID);
	}
	
	public Tablet getTablet()
	{
		return CtrlTablet.getTablet(_tablet_ID);
	}
    public string getQueryGuardar()
    {
        return CtrlSincronizar_tablet_usuario.getQueryGuardar(this);
    }
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Sincronizar_tablet_usuario
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String usuario_ID{
		
	get{return ("usuario_ID");}
	}
	public static String tablet_ID{
		
	get{return ("tablet_ID");}
	}
	}//Fin clase estática
	
	}//Fin name_space
