using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
static public class FachadaSincronizar_tablet {

public static  DataSet getListado(Query query)
	{
		try
	{
		return BDConnect.EjecutaConRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
		return null;
	}
	}
	public static  DataSet getListado(string query)
	{
		try
	{
		return BDConnect.EjecutaConRetorno(query);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
		return null;
	}
	}
	public static  int guardar(Sincronizar_tablet objeto)
	{
		try
	{
		Query query=new Query("insert","sincronizar_tablet");
		query.AddInsert("registro_ID", objeto.fregistro_ID);
		query.AddInsert("tablet_ID", objeto.ftablet_ID);
		query.AddInsert("nombre_tabla", objeto.fnombre_tabla);
		query.AddInsert("accion", objeto.faccion);
        //query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
        string queryID = query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
    //string queryID = "SELECT ID FROM sincronizar_tablet WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Sincronizar_tablet_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
        Sincronizar_tablet_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
    //Sincronizar_tablet_ID=Utils.cint(fila["ID"].ToString());
	}
	return Sincronizar_tablet_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static  int guardarJSON(Sincronizar_tabletJSON objeto)
	{
		try
	{
		Query query=new Query("insert","sincronizar_tablet");
		query.AddInsert("registro_ID", objeto.getRegistro_ID());
		query.AddInsert("tablet_ID", objeto.getTablet_ID());
		query.AddInsert("nombre_tabla", objeto.getNombre_tabla());
		query.AddInsert("accion", objeto.getAccion());
		query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
	//string queryID=query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
	string queryID = "SELECT ID FROM sincronizar_tablet WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Sincronizar_tablet_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
	//Sincronizar_tablet_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
	Sincronizar_tablet_ID=Utils.cint(fila["ID"].ToString());
	}
	return Sincronizar_tablet_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static void actualizar(Sincronizar_tablet objeto)
	{
		try
	{
		Query query=new Query("update","sincronizar_tablet");
		query.AddSet("registro_ID", objeto.fregistro_ID);
		query.AddSet("tablet_ID", objeto.ftablet_ID);
		query.AddSet("nombre_tabla", objeto.fnombre_tabla);
		query.AddSet("accion", objeto.faccion);
		query.AddWhere("ID", objeto.fID.ToString());
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void actualizarJSON(Sincronizar_tabletJSON objeto)
	{
		try
	{
		Query query=new Query("update","sincronizar_tablet");
		query.AddSet("registro_ID", objeto.getRegistro_ID());
		query.AddSet("tablet_ID", objeto.getTablet_ID());
		query.AddSet("nombre_tabla", objeto.getNombre_tabla());
		query.AddSet("accion", objeto.getAccion());
		query.AddWhere("ID", objeto.getID().ToString());
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void ejecutaSin_retorno(Query query)
	{
		try
	{
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void eliminar(Query query)
	{
		try
	{
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	
	}//Fin Clase
	}//Fin name_space
	
