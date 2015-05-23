using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Tablet
	{
		private int _ID;
		private string _nombre;
		private string _mac_address;
		private string _estado_vigente;
		private string _estado_nueva;
		private int _usuario_ID;
		
	//CONSTRUCTOR
	public Tablet(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_nombre =data["nombre"].ToString();
		_mac_address =data["mac_address"].ToString();
		_estado_vigente =data["estado_vigente"].ToString();
		_estado_nueva =data["estado_nueva"].ToString();
		_usuario_ID =Utils.cint(data["usuario_ID"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Tablet()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public string fnombre{
		
	get{return (_nombre);}
	set{_nombre=value;}
	
	}
	
	public string fmac_address{
		
	get{return (_mac_address);}
	set{_mac_address=value;}
	
	}
	
	public string festado_vigente{
		
	get{return (_estado_vigente);}
	set{_estado_vigente=value;}
	
	}
	
	public string festado_nueva{
		
	get{return (_estado_nueva);}
	set{_estado_nueva=value;}
	
	}
	
	public int fusuario_ID{
		
	get{return (_usuario_ID);}
	set{_usuario_ID=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlTablet.actualizar(this);
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
		return  CtrlTablet.guardar(this);
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
		CtrlTablet.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Sincroniza_tablet_cliente[] getSincroniza_tablet_cliente()
	{
		Query query=new Query("select","sincroniza_tablet_cliente");
		query.AddWhere("tablet_ID",this.fID.ToString());
		return CtrlSincroniza_tablet_cliente.getListado(query);
	}
	
	public Sincronizar_tablet_categoria[] getSincronizar_tablet_categoria()
	{
		Query query=new Query("select","sincronizar_tablet_categoria");
		query.AddWhere("tablet_ID",this.fID.ToString());
		return CtrlSincronizar_tablet_categoria.getListado(query);
	}
	
	public Sincronizar_tablet_producto[] getSincronizar_tablet_producto()
	{
		Query query=new Query("select","sincronizar_tablet_producto");
		query.AddWhere("tablet_ID",this.fID.ToString());
		return CtrlSincronizar_tablet_producto.getListado(query);
	}
	
	public Sincronizar_tablet_usuario[] getSincronizar_tablet_usuario()
	{
		Query query=new Query("select","sincronizar_tablet_usuario");
		query.AddWhere("tablet_ID",this.fID.ToString());
		return CtrlSincronizar_tablet_usuario.getListado(query);
	}
	
	
	public Usuario getUsuario()
	{
		return CtrlUsuario.getUsuario(_usuario_ID);
	}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Tablet
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String nombre{
		
	get{return ("nombre");}
	}
	public static String mac_address{
		
	get{return ("mac_address");}
	}
	public static String estado_vigente{
		
	get{return ("estado_vigente");}
	}
	public static String estado_nueva{
		
	get{return ("estado_nueva");}
	}
	public static String usuario_ID{
		
	get{return ("usuario_ID");}
	}
	}//Fin clase estática
	
	}//Fin name_space
