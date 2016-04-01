using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
static public class FachadaVenta {

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
	public static  int guardar(Venta objeto)
	{
		try
	{
		Query query=new Query("insert","venta");
		query.AddInsert("forma_pago_ID", objeto.fforma_pago_ID);
		query.AddInsert("tipo_documento_ID", objeto.ftipo_documento_ID);
		query.AddInsert("usuario_ID", objeto.fusuario_ID);
		query.AddInsert("arqueo_caja_ID", objeto.farqueo_caja_ID);
		query.AddInsert("cuenta_credito_ID", objeto.fcuenta_credito_ID);
		query.AddInsert("comprobante_contable_ID", objeto.fcomprobante_contable_ID);
		query.AddInsert("mes_proceso", objeto.fmes_proceso);
		query.AddInsert("ano_proceso", objeto.fano_proceso);
		query.AddInsert("fecha_proceso", objeto.ffecha_proceso);
		query.AddInsert("fecha", objeto.ffecha);
		query.AddInsert("numero", objeto.fnumero);
		query.AddInsert("estado", objeto.festado);
		query.AddInsert("total_descuento", objeto.ftotal_descuento);
		query.AddInsert("total_neto", objeto.ftotal_neto);
		query.AddInsert("total_iva", objeto.ftotal_iva);
		query.AddInsert("total_bruto", objeto.ftotal_bruto);
		query.AddInsert("total_saldo", objeto.ftotal_saldo);
		query.AddInsert("total_pagos", objeto.ftotal_pagos);
		query.AddInsert("documento_venta_ID", objeto.fdocumento_venta_ID);
		query.AddInsert("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
		query.AddInsert("coordenadas_GPS", objeto.fcoordenadas_GPS);
		query.AddInsert("fecha_entrega", objeto.ffecha_entrega);
		query.AddInsert("observacion", objeto.fobservacion);
		query.AddInsert("total_pago_efectivo", objeto.ftotal_pago_efectivo);
		query.AddInsert("total_pago_tarjeta", objeto.ftotal_pago_tarjeta);
		query.AddInsert("sucursal_ID", objeto.fsucursal_ID);
		query.AddInsert("tablet_ID", objeto.ftablet_ID);
		query.AddInsert("banco_ID", objeto.fbanco_ID);
		query.AddInsert("tipo_cheque_ID", objeto.ftipo_cheque_ID);
		query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
	string queryID=query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
	//string queryID = "SELECT ID FROM venta WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Venta_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
	Venta_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
	//Venta_ID=Utils.cint(fila["ID"].ToString());
	}
	return Venta_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static  int guardarJSON(VentaJSON objeto)
	{
		try
	{
		Query query=new Query("insert","venta");
		query.AddInsert("forma_pago_ID", objeto.getForma_pago_ID());
		query.AddInsert("tipo_documento_ID", objeto.getTipo_documento_ID());
		query.AddInsert("usuario_ID", objeto.getUsuario_ID());
		query.AddInsert("arqueo_caja_ID", objeto.getArqueo_caja_ID());
		query.AddInsert("cuenta_credito_ID", objeto.getCuenta_credito_ID());
		query.AddInsert("comprobante_contable_ID", objeto.getComprobante_contable_ID());
		query.AddInsert("mes_proceso", objeto.getMes_proceso());
		query.AddInsert("ano_proceso", objeto.getAno_proceso());
		query.AddInsert("fecha_proceso", objeto.getFecha_proceso());
		query.AddInsert("fecha", objeto.getFecha());
		query.AddInsert("numero", objeto.getNumero());
		query.AddInsert("estado", objeto.getEstado());
		query.AddInsert("total_descuento", objeto.getTotal_descuento());
		query.AddInsert("total_neto", objeto.getTotal_neto());
		query.AddInsert("total_iva", objeto.getTotal_iva());
		query.AddInsert("total_bruto", objeto.getTotal_bruto());
		query.AddInsert("total_saldo", objeto.getTotal_saldo());
		query.AddInsert("total_pagos", objeto.getTotal_pagos());
		query.AddInsert("documento_venta_ID", objeto.getDocumento_venta_ID());
		query.AddInsert("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
		query.AddInsert("coordenadas_GPS", objeto.getCoordenadas_GPS());
		query.AddInsert("fecha_entrega", objeto.getFecha_entrega());
		query.AddInsert("observacion", objeto.getObservacion());
		query.AddInsert("total_pago_efectivo", objeto.getTotal_pago_efectivo());
		query.AddInsert("total_pago_tarjeta", objeto.getTotal_pago_tarjeta());
		query.AddInsert("sucursal_ID", objeto.getSucursal_ID());
		query.AddInsert("tablet_ID", objeto.getTablet_ID());
		query.AddInsert("banco_ID", objeto.getBanco_ID());
		query.AddInsert("tipo_cheque_ID", objeto.getTipo_cheque_ID());
		query.AddInsert("estado_vigente", "vigente");
		
	//BDConnect.EjecutaSinRetorno(query.listo());
	//string queryID=query.lastInsertID();
	//DataSet dataset=BDConnect.EjecutaConRetorno(queryID);
	
	string queryID = "SELECT ID FROM venta WHERE ID = @@IDENTITY";
	DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);
	
	int Venta_ID=0;
	foreach(DataRow fila in dataset.Tables[0].Rows)
	{
	//Venta_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
	Venta_ID=Utils.cint(fila["ID"].ToString());
	}
	return Venta_ID;
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
		return 0;
	}
	}
	
	public static void actualizar(Venta objeto)
	{
		try
	{
		Query query=new Query("update","venta");
		query.AddSet("forma_pago_ID", objeto.fforma_pago_ID);
		query.AddSet("tipo_documento_ID", objeto.ftipo_documento_ID);
		query.AddSet("usuario_ID", objeto.fusuario_ID);
		query.AddSet("arqueo_caja_ID", objeto.farqueo_caja_ID);
		query.AddSet("cuenta_credito_ID", objeto.fcuenta_credito_ID);
		query.AddSet("comprobante_contable_ID", objeto.fcomprobante_contable_ID);
		query.AddSet("mes_proceso", objeto.fmes_proceso);
		query.AddSet("ano_proceso", objeto.fano_proceso);
		query.AddSet("fecha_proceso", objeto.ffecha_proceso);
		query.AddSet("fecha", objeto.ffecha);
		query.AddSet("numero", objeto.fnumero);
		query.AddSet("estado", objeto.festado);
		query.AddSet("total_descuento", objeto.ftotal_descuento);
		query.AddSet("total_neto", objeto.ftotal_neto);
		query.AddSet("total_iva", objeto.ftotal_iva);
		query.AddSet("total_bruto", objeto.ftotal_bruto);
		query.AddSet("total_saldo", objeto.ftotal_saldo);
		query.AddSet("total_pagos", objeto.ftotal_pagos);
		query.AddSet("documento_venta_ID", objeto.fdocumento_venta_ID);
		query.AddSet("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
		query.AddSet("coordenadas_GPS", objeto.fcoordenadas_GPS);
		query.AddSet("fecha_entrega", objeto.ffecha_entrega);
		query.AddSet("estado_vigente", objeto.festado_vigente);
		query.AddSet("observacion", objeto.fobservacion);
		query.AddSet("total_pago_efectivo", objeto.ftotal_pago_efectivo);
		query.AddSet("total_pago_tarjeta", objeto.ftotal_pago_tarjeta);
		query.AddSet("sucursal_ID", objeto.fsucursal_ID);
		query.AddSet("tablet_ID", objeto.ftablet_ID);
		query.AddSet("banco_ID", objeto.fbanco_ID);
		query.AddSet("tipo_cheque_ID", objeto.ftipo_cheque_ID);
		query.AddWhere("ID", objeto.fID.ToString());
		BDConnect.EjecutaSinRetorno(query.listo());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public static void actualizarJSON(VentaJSON objeto)
	{
		try
	{
		Query query=new Query("update","venta");
		query.AddSet("forma_pago_ID", objeto.getForma_pago_ID());
		query.AddSet("tipo_documento_ID", objeto.getTipo_documento_ID());
		query.AddSet("usuario_ID", objeto.getUsuario_ID());
		query.AddSet("arqueo_caja_ID", objeto.getArqueo_caja_ID());
		query.AddSet("cuenta_credito_ID", objeto.getCuenta_credito_ID());
		query.AddSet("comprobante_contable_ID", objeto.getComprobante_contable_ID());
		query.AddSet("mes_proceso", objeto.getMes_proceso());
		query.AddSet("ano_proceso", objeto.getAno_proceso());
		query.AddSet("fecha_proceso", objeto.getFecha_proceso());
		query.AddSet("fecha", objeto.getFecha());
		query.AddSet("numero", objeto.getNumero());
		query.AddSet("estado", objeto.getEstado());
		query.AddSet("total_descuento", objeto.getTotal_descuento());
		query.AddSet("total_neto", objeto.getTotal_neto());
		query.AddSet("total_iva", objeto.getTotal_iva());
		query.AddSet("total_bruto", objeto.getTotal_bruto());
		query.AddSet("total_saldo", objeto.getTotal_saldo());
		query.AddSet("total_pagos", objeto.getTotal_pagos());
		query.AddSet("documento_venta_ID", objeto.getDocumento_venta_ID());
		query.AddSet("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
		query.AddSet("coordenadas_GPS", objeto.getCoordenadas_GPS());
		query.AddSet("fecha_entrega", objeto.getFecha_entrega());
		query.AddSet("estado_vigente", objeto.getEstado_vigente());
		query.AddSet("observacion", objeto.getObservacion());
		query.AddSet("total_pago_efectivo", objeto.getTotal_pago_efectivo());
		query.AddSet("total_pago_tarjeta", objeto.getTotal_pago_tarjeta());
		query.AddSet("sucursal_ID", objeto.getSucursal_ID());
		query.AddSet("tablet_ID", objeto.getTablet_ID());
		query.AddSet("banco_ID", objeto.getBanco_ID());
		query.AddSet("tipo_cheque_ID", objeto.getTipo_cheque_ID());
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
	
