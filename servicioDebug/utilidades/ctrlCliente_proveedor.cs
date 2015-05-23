using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;

namespace utilidades
	{
static public class CtrlCliente_proveedor {
public static Cliente_proveedor[] getListado(Query query)
	{
		try
	{
		query.AddWhereExacto(ST_Cliente_proveedor.estado_vigente, "vigente");
		DataSet dataset= FachadaCliente_proveedor.getListado(query);
		Cliente_proveedor[] arrcliente_proveedor = new Cliente_proveedor[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Cliente_proveedor objeto = new Cliente_proveedor(fila);
		arrcliente_proveedor[contador] = objeto;
		contador++;
	}
	}
	return arrcliente_proveedor;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	}
	public static Cliente_proveedor[] getListado(string query)
	{
		try
	{
		DataSet dataset= FachadaCliente_proveedor.getListado(query);
		Cliente_proveedor[] arrcliente_proveedor = new Cliente_proveedor[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Cliente_proveedor objeto = new Cliente_proveedor(fila);
		arrcliente_proveedor[contador] = objeto;
		contador++;
	}
	}
	return arrcliente_proveedor;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	}
	public static Cliente_proveedor[] getListadoPorWhere(string where)
	{
		try
	{
		string[] arrString = where.Split('=');
		Query query = new Query("select", "cliente_proveedor");
		query.AddWhere(arrString[0], arrString[1]);
		query.AddSelect("*");
		DataSet dataset = FachadaCliente_proveedor.getListado(query);
		Cliente_proveedor[] arrcliente_proveedor = new Cliente_proveedor[dataset.Tables[0].Rows.Count];
		int contador = 0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		Cliente_proveedor objeto = new Cliente_proveedor(fila);
		arrcliente_proveedor[contador] = objeto;
		contador++;
	}
	}
	return arrcliente_proveedor;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return null;
	}
	
	}
	public static int guardar(Cliente_proveedor objeto)
	{
		try
	{
		return FachadaCliente_proveedor.guardar(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	public static int guardarJSON(Cliente_proveedorJSON objeto)
	{
		try
	{
		return FachadaCliente_proveedor.guardarJSON(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	public static void actualizar(Cliente_proveedor objeto)
	{
		try
	{
		FachadaCliente_proveedor.actualizar(objeto);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void actualizarJSON(Cliente_proveedorJSON objeto)
	{
		try
	{
		FachadaCliente_proveedor.actualizarJSON(objeto);
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
		FachadaCliente_proveedor.eliminar(query);
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
		Query query=new Query("delete","cliente_proveedor");
		query.AddWhere("ID",ID.ToString());
		FachadaCliente_proveedor.eliminar(query);
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
		FachadaCliente_proveedor.ejecutaSin_retorno(query);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static Cliente_proveedor getCliente_proveedor(int id)
	{
		try
	{
		Query query = new Query("select", "cliente_proveedor");
		query.AddWhere("ID",id.ToString());
		query.AddSelect("*");
		Cliente_proveedor objeto=new Cliente_proveedor();
		DataSet dataset = FachadaCliente_proveedor.getListado(query);
		int contador=0;
		if (dataset != null)
	{
		foreach (DataRow fila in dataset.Tables[0].Rows)
	{
		objeto = new Cliente_proveedor(fila);
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
	public static int getID(string nombre)
	{
		try
	{
		if (nombre.Length > 0)
	{
		nombre = nombre.Trim();
		Query query = new Query("cliente_proveedor");
		query.AddWhereExacto(ST_Cliente_proveedor.nombre, nombre);
		Cliente_proveedor[] arrCliente_proveedor = getListado(query);
		if (arrCliente_proveedor.Length > 0)
	{
		return arrCliente_proveedor[0].fID;
	}
	else
	{
		return 0;
	}
	}
	else
	return 0;
	}
	catch (Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	}
	}//Fin name_space
//------------------------------------------------------------------------------
	//	FIN CONTROLADOR
//------------------------------------------------------------------------------
