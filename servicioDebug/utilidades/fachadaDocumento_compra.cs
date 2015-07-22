using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
static public class FachadaDocumento_compra {

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
	public static  int guardar(Documento_compra objeto)
	{
		try
	{
		Query query=new Query("insert","documento_compra");
		query.AddInsert("proveedor_ID", objeto.fproveedor_ID);
		query.AddInsert("tipo_documento_ID", objeto.ftipo_documento_ID);
		query.AddInsert("numero", objeto.fnumero);
		query.AddInsert("fecha_digitacion", objeto.ffecha_digitacion);
		query.AddInsert("fecha_cancelacion", objeto.ffecha_cancelacion);
		query.AddInsert("fecha_documento", objeto.ffecha_documento);
		query.AddInsert("mes_proceso", objeto.fmes_proceso);
		query.AddInsert("ano_proceso", objeto.fano_proceso);
		query.AddInsert("total_neto", objeto.ftotal_neto);
		query.AddInsert("total_impuesto", objeto.ftotal_impuesto);
		query.AddInsert("total_exento", objeto.ftotal_exento);
		query.AddInsert("total_iva", objeto.ftotal_iva);
		query.AddInsert("total_saldo", objeto.ftotal_saldo);
		query.AddInsert("total_pagos", objeto.ftotal_pagos);
		query.AddInsert("solicitud_compra_ID", objeto.fsolicitud_compra_ID);
		query.AddInsert("forma_pago_ID", objeto.fforma_pago_ID);
		query.AddInsert("observacion", objeto.fobservacion);
		query.AddInsert("fecha_vencimiento", objeto.ffecha_vencimiento);
		query.AddInsert("comprobante_contable_ID", objeto.fcomprobante_contable_ID);
		query.AddInsert("estado", objeto.festado);
		query.AddInsert("total_bruto", objeto.ftotal_bruto);
		query.AddInsert("documento_compra_ID", objeto.fdocumento_compra_ID);
		query.AddInsert("flete_unitario_constante", objeto.fflete_unitario_constante);
		query.AddInsert("sucursal_ID", objeto.fsucursal_ID);
        //query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
        string queryID = query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
    //string queryID = "SELECT ID FROM documento_compra WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Documento_compra_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
        Documento_compra_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
    //Documento_compra_ID=Utils.cint(fila["ID"].ToString());
	}
	return Documento_compra_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static  int guardarJSON(Documento_compraJSON objeto)
	{
		try
	{
		Query query=new Query("insert","documento_compra");
		query.AddInsert("proveedor_ID", objeto.getProveedor_ID());
		query.AddInsert("tipo_documento_ID", objeto.getTipo_documento_ID());
		query.AddInsert("numero", objeto.getNumero());
		query.AddInsert("fecha_digitacion", objeto.getFecha_digitacion());
		query.AddInsert("fecha_cancelacion", objeto.getFecha_cancelacion());
		query.AddInsert("fecha_documento", objeto.getFecha_documento());
		query.AddInsert("mes_proceso", objeto.getMes_proceso());
		query.AddInsert("ano_proceso", objeto.getAno_proceso());
		query.AddInsert("total_neto", objeto.getTotal_neto());
		query.AddInsert("total_impuesto", objeto.getTotal_impuesto());
		query.AddInsert("total_exento", objeto.getTotal_exento());
		query.AddInsert("total_iva", objeto.getTotal_iva());
		query.AddInsert("total_saldo", objeto.getTotal_saldo());
		query.AddInsert("total_pagos", objeto.getTotal_pagos());
		query.AddInsert("solicitud_compra_ID", objeto.getSolicitud_compra_ID());
		query.AddInsert("forma_pago_ID", objeto.getForma_pago_ID());
		query.AddInsert("observacion", objeto.getObservacion());
		query.AddInsert("fecha_vencimiento", objeto.getFecha_vencimiento());
		query.AddInsert("comprobante_contable_ID", objeto.getComprobante_contable_ID());
		query.AddInsert("estado", objeto.getEstado());
		query.AddInsert("total_bruto", objeto.getTotal_bruto());
		query.AddInsert("documento_compra_ID", objeto.getDocumento_compra_ID());
		query.AddInsert("flete_unitario_constante", objeto.getFlete_unitario_constante());
		query.AddInsert("sucursal_ID", objeto.getSucursal_ID());
		query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
        string queryID = query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
    //string queryID = "SELECT ID FROM documento_compra WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Documento_compra_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
        Documento_compra_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
    //Documento_compra_ID=Utils.cint(fila["ID"].ToString());
	}
	return Documento_compra_ID;
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
		Query query=new Query("update","documento_compra");
		query.AddSet("proveedor_ID", objeto.fproveedor_ID);
		query.AddSet("tipo_documento_ID", objeto.ftipo_documento_ID);
		query.AddSet("numero", objeto.fnumero);
		query.AddSet("fecha_digitacion", objeto.ffecha_digitacion);
		query.AddSet("fecha_cancelacion", objeto.ffecha_cancelacion);
		query.AddSet("fecha_documento", objeto.ffecha_documento);
		query.AddSet("mes_proceso", objeto.fmes_proceso);
		query.AddSet("ano_proceso", objeto.fano_proceso);
		query.AddSet("total_neto", objeto.ftotal_neto);
		query.AddSet("total_impuesto", objeto.ftotal_impuesto);
		query.AddSet("total_exento", objeto.ftotal_exento);
		query.AddSet("total_iva", objeto.ftotal_iva);
		query.AddSet("total_saldo", objeto.ftotal_saldo);
		query.AddSet("total_pagos", objeto.ftotal_pagos);
		query.AddSet("solicitud_compra_ID", objeto.fsolicitud_compra_ID);
		query.AddSet("forma_pago_ID", objeto.fforma_pago_ID);
		query.AddSet("observacion", objeto.fobservacion);
		query.AddSet("fecha_vencimiento", objeto.ffecha_vencimiento);
		query.AddSet("comprobante_contable_ID", objeto.fcomprobante_contable_ID);
		query.AddSet("estado", objeto.festado);
		query.AddSet("total_bruto", objeto.ftotal_bruto);
		query.AddSet("documento_compra_ID", objeto.fdocumento_compra_ID);
		query.AddSet("flete_unitario_constante", objeto.fflete_unitario_constante);
		query.AddSet("sucursal_ID", objeto.fsucursal_ID);
		query.AddWhere("ID", objeto.fID.ToString());
		BDConnect.EjecutaSinRetorno(query.listo());
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
		Query query=new Query("update","documento_compra");
		query.AddSet("proveedor_ID", objeto.getProveedor_ID());
		query.AddSet("tipo_documento_ID", objeto.getTipo_documento_ID());
		query.AddSet("numero", objeto.getNumero());
		query.AddSet("fecha_digitacion", objeto.getFecha_digitacion());
		query.AddSet("fecha_cancelacion", objeto.getFecha_cancelacion());
		query.AddSet("fecha_documento", objeto.getFecha_documento());
		query.AddSet("mes_proceso", objeto.getMes_proceso());
		query.AddSet("ano_proceso", objeto.getAno_proceso());
		query.AddSet("total_neto", objeto.getTotal_neto());
		query.AddSet("total_impuesto", objeto.getTotal_impuesto());
		query.AddSet("total_exento", objeto.getTotal_exento());
		query.AddSet("total_iva", objeto.getTotal_iva());
		query.AddSet("total_saldo", objeto.getTotal_saldo());
		query.AddSet("total_pagos", objeto.getTotal_pagos());
		query.AddSet("solicitud_compra_ID", objeto.getSolicitud_compra_ID());
		query.AddSet("forma_pago_ID", objeto.getForma_pago_ID());
		query.AddSet("observacion", objeto.getObservacion());
		query.AddSet("fecha_vencimiento", objeto.getFecha_vencimiento());
		query.AddSet("comprobante_contable_ID", objeto.getComprobante_contable_ID());
		query.AddSet("estado", objeto.getEstado());
		query.AddSet("total_bruto", objeto.getTotal_bruto());
		query.AddSet("documento_compra_ID", objeto.getDocumento_compra_ID());
		query.AddSet("flete_unitario_constante", objeto.getFlete_unitario_constante());
		query.AddSet("sucursal_ID", objeto.getSucursal_ID());
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
	
