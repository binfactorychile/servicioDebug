using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
static public class CtrlDocumento_compra {
public static Documento_compra[] getListado(Query query)
	{
		try
	{

		DataSet dataset= FachadaDocumento_compra.getListado(query);
		Documento_compra[] arrdocumento_compra = new Documento_compra[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Documento_compra objeto = new Documento_compra(fila);
		arrdocumento_compra[contador] = objeto;
		contador++;
	}
	}
	return arrdocumento_compra;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	}
	public static Documento_compra[] getListado(string query)
	{
		try
	{
		DataSet dataset= FachadaDocumento_compra.getListado(query);
		Documento_compra[] arrdocumento_compra = new Documento_compra[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Documento_compra objeto = new Documento_compra(fila);
		arrdocumento_compra[contador] = objeto;
		contador++;
	}
	}
	return arrdocumento_compra;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	}
	public static Documento_compra[] getListadoPorWhere(string where)
	{
		try
	{
		string[] arrString = where.Split('=');
		Query query = new Query("select", "documento_compra");
		query.AddWhere(arrString[0], arrString[1]);
		query.AddSelect("*");
		DataSet dataset = FachadaDocumento_compra.getListado(query);
		Documento_compra[] arrdocumento_compra = new Documento_compra[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Documento_compra objeto = new Documento_compra(fila);
		arrdocumento_compra[contador] = objeto;
		contador++;
	}
	}
	return arrdocumento_compra;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	
	}
	public static int guardar(Documento_compra objeto)
	{
		try
	{
		return FachadaDocumento_compra.guardar(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	public static int guardarJSON(Documento_compraJSON objeto)
	{
		try
	{
		return FachadaDocumento_compra.guardarJSON(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	public static void actualizar(Documento_compra objeto)
	{
		try
	{
		FachadaDocumento_compra.actualizar(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void actualizarJSON(Documento_compraJSON objeto)
	{
		try
	{
		FachadaDocumento_compra.actualizarJSON(objeto);
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
		FachadaDocumento_compra.eliminar(query);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void eliminar(int ID)
	{
		try
	{
		Query query=new Query("delete","documento_compra");
		query.AddWhere("ID",ID.ToString());
		FachadaDocumento_compra.eliminar(query);
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
		FachadaDocumento_compra.ejecutaSin_retorno(query);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static Documento_compra getDocumento_compra(int id)
	{
		try
	{
		Query query = new Query("select", "documento_compra");
		query.AddWhere("ID",id.ToString());
		query.AddSelect("*");
		Documento_compra objeto=new Documento_compra();
		DataSet dataset = FachadaDocumento_compra.getListado(query);
		int contador=0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		objeto = new Documento_compra(fila);
		contador++;
	}
	}
	return objeto;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	}

	}
	}//Fin name_space
//------------------------------------------------------------------------------
	//	FIN CONTROLADOR
//------------------------------------------------------------------------------
