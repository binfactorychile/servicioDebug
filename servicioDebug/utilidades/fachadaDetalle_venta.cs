using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
static public class FachadaDetalle_venta {

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
	public static  int guardar(Detalle_venta objeto)
	{
		try
	{
		Query query=new Query("insert","detalle_venta");
		query.AddInsert("producto_ID", objeto.fproducto_ID);
		query.AddInsert("detalle_comprobante_contable_ID", objeto.fdetalle_comprobante_contable_ID);
		query.AddInsert("cantidad", objeto.fcantidad);
		query.AddInsert("precio_unitario", objeto.fprecio_unitario);
		query.AddInsert("descuento", objeto.fdescuento);
		query.AddInsert("iva", objeto.fiva);
		query.AddInsert("total", objeto.ftotal);
		query.AddInsert("venta_ID", objeto.fventa_ID);
		query.AddInsert("estado", objeto.festado);
		query.AddInsert("es_promocion", objeto.fes_promocion);
		query.AddInsert("total_otros_impuestos", objeto.ftotal_otros_impuestos);
		query.AddInsert("impuesto_ID", objeto.fimpuesto_ID);
		query.AddInsert("precio_unitario_neto", objeto.fprecio_unitario_neto);
		//query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
	string queryID=query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
	//string queryID = "SELECT ID FROM detalle_venta WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Detalle_venta_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
	Detalle_venta_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
	//Detalle_venta_ID=Utils.cint(fila["ID"].ToString());
	}
	return Detalle_venta_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static  int guardarJSON(Detalle_ventaJSON objeto)
	{
		try
	{
		Query query=new Query("insert","detalle_venta");
		query.AddInsert("producto_ID", objeto.getProducto_ID());
		query.AddInsert("detalle_comprobante_contable_ID", objeto.getDetalle_comprobante_contable_ID());
		query.AddInsert("cantidad", objeto.getCantidad());
		query.AddInsert("precio_unitario", objeto.getPrecio_unitario());
		query.AddInsert("descuento", objeto.getDescuento());
		query.AddInsert("iva", objeto.getIva());
		query.AddInsert("total", objeto.getTotal());
		query.AddInsert("venta_ID", objeto.getVenta_ID());
		query.AddInsert("estado", objeto.getEstado());
		query.AddInsert("es_promocion", objeto.getEs_promocion());
		query.AddInsert("total_otros_impuestos", objeto.getTotal_otros_impuestos());
		query.AddInsert("impuesto_ID", objeto.getImpuesto_ID());
		query.AddInsert("precio_unitario_neto", objeto.getPrecio_unitario_neto());
		//query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
	string queryID=query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
	//string queryID = "SELECT ID FROM detalle_venta WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Detalle_venta_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
	Detalle_venta_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
	//Detalle_venta_ID=Utils.cint(fila["ID"].ToString());
	}
	return Detalle_venta_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static void actualizar(Detalle_venta objeto)
	{
		try
	{
		Query query=new Query("update","detalle_venta");
		query.AddSet("producto_ID", objeto.fproducto_ID);
		query.AddSet("detalle_comprobante_contable_ID", objeto.fdetalle_comprobante_contable_ID);
		query.AddSet("cantidad", objeto.fcantidad);
		query.AddSet("precio_unitario", objeto.fprecio_unitario);
		query.AddSet("descuento", objeto.fdescuento);
		query.AddSet("iva", objeto.fiva);
		query.AddSet("total", objeto.ftotal);
		query.AddSet("venta_ID", objeto.fventa_ID);
		query.AddSet("estado", objeto.festado);
		query.AddSet("es_promocion", objeto.fes_promocion);
		query.AddSet("total_otros_impuestos", objeto.ftotal_otros_impuestos);
		query.AddSet("impuesto_ID", objeto.fimpuesto_ID);
		query.AddSet("precio_unitario_neto", objeto.fprecio_unitario_neto);
		query.AddWhere("ID", objeto.fID.ToString());
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void actualizarJSON(Detalle_ventaJSON objeto)
	{
		try
	{
		Query query=new Query("update","detalle_venta");
		query.AddSet("producto_ID", objeto.getProducto_ID());
		query.AddSet("detalle_comprobante_contable_ID", objeto.getDetalle_comprobante_contable_ID());
		query.AddSet("cantidad", objeto.getCantidad());
		query.AddSet("precio_unitario", objeto.getPrecio_unitario());
		query.AddSet("descuento", objeto.getDescuento());
		query.AddSet("iva", objeto.getIva());
		query.AddSet("total", objeto.getTotal());
		query.AddSet("venta_ID", objeto.getVenta_ID());
		query.AddSet("estado", objeto.getEstado());
		query.AddSet("es_promocion", objeto.getEs_promocion());
		query.AddSet("total_otros_impuestos", objeto.getTotal_otros_impuestos());
		query.AddSet("impuesto_ID", objeto.getImpuesto_ID());
		query.AddSet("precio_unitario_neto", objeto.getPrecio_unitario_neto());
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
	
