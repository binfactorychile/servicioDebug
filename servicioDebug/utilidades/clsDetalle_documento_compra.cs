using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Detalle_documento_compra
	{
		private int _ID;
		private int _producto_ID;
		private int _detalle_solicitud_compra_ID;
		private int _detalle_comprobante_contable_ID;
		private int _cantidad;
		private int _exento;
		private decimal _porcentaje_descuento;
		private int _monto_descuento;
		private int _precio_neto_unitario;
		private int _monto_impuesto;
		private int _impuesto_ID;
		private int _total_neto;
		private decimal _iva;
		private int _total_bruto;
		private int _estado;
		private int _documento_compra_ID;
		private decimal _flete_unitario;
		private int _precio_neto_unitario_factura;
		
	//CONSTRUCTOR
	public Detalle_documento_compra(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_producto_ID =Utils.cint(data["producto_ID"].ToString());
		_detalle_solicitud_compra_ID =Utils.cint(data["detalle_solicitud_compra_ID"].ToString());
		_detalle_comprobante_contable_ID =Utils.cint(data["detalle_comprobante_contable_ID"].ToString());
		_cantidad =Utils.cint(data["cantidad"].ToString());
		_exento =Utils.cint(data["exento"].ToString());
		_porcentaje_descuento =Utils.cdecimal(data["porcentaje_descuento"].ToString());
		_monto_descuento =Utils.cint(data["monto_descuento"].ToString());
		_precio_neto_unitario =Utils.cint(data["precio_neto_unitario"].ToString());
		_monto_impuesto =Utils.cint(data["monto_impuesto"].ToString());
		_impuesto_ID =Utils.cint(data["impuesto_ID"].ToString());
		_total_neto =Utils.cint(data["total_neto"].ToString());
		_iva =Utils.cdecimal(data["iva"].ToString());
		_total_bruto =Utils.cint(data["total_bruto"].ToString());
		_estado =Utils.cint(data["estado"].ToString());
		_documento_compra_ID =Utils.cint(data["documento_compra_ID"].ToString());
		_flete_unitario =Utils.cdecimal(data["flete_unitario"].ToString());
		_precio_neto_unitario_factura =Utils.cint(data["precio_neto_unitario_factura"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Detalle_documento_compra()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fproducto_ID{
		
	get{return (_producto_ID);}
	set{_producto_ID=value;}
	
	}
	
	public int fdetalle_solicitud_compra_ID{
		
	get{return (_detalle_solicitud_compra_ID);}
	set{_detalle_solicitud_compra_ID=value;}
	
	}
	
	public int fdetalle_comprobante_contable_ID{
		
	get{return (_detalle_comprobante_contable_ID);}
	set{_detalle_comprobante_contable_ID=value;}
	
	}
	
	public int fcantidad{
		
	get{return (_cantidad);}
	set{_cantidad=value;}
	
	}
	
	public int fexento{
		
	get{return (_exento);}
	set{_exento=value;}
	
	}
	
	public decimal fporcentaje_descuento{
		
	get{return (_porcentaje_descuento);}
	set{_porcentaje_descuento=value;}
	
	}
	
	public int fmonto_descuento{
		
	get{return (_monto_descuento);}
	set{_monto_descuento=value;}
	
	}
	
	public int fprecio_neto_unitario{
		
	get{return (_precio_neto_unitario);}
	set{_precio_neto_unitario=value;}
	
	}
	
	public int fmonto_impuesto{
		
	get{return (_monto_impuesto);}
	set{_monto_impuesto=value;}
	
	}
	
	public int fimpuesto_ID{
		
	get{return (_impuesto_ID);}
	set{_impuesto_ID=value;}
	
	}
	
	public int ftotal_neto{
		
	get{return (_total_neto);}
	set{_total_neto=value;}
	
	}
	
	public decimal fiva{
		
	get{return (_iva);}
	set{_iva=value;}
	
	}
	
	public int ftotal_bruto{
		
	get{return (_total_bruto);}
	set{_total_bruto=value;}
	
	}
	
	public int festado{
		
	get{return (_estado);}
	set{_estado=value;}
	
	}
	
	public int fdocumento_compra_ID{
		
	get{return (_documento_compra_ID);}
	set{_documento_compra_ID=value;}
	
	}
	
	public decimal fflete_unitario{
		
	get{return (_flete_unitario);}
	set{_flete_unitario=value;}
	
	}
	
	public int fprecio_neto_unitario_factura{
		
	get{return (_precio_neto_unitario_factura);}
	set{_precio_neto_unitario_factura=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlDetalle_documento_compra.actualizar(this);
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
		return  CtrlDetalle_documento_compra.guardar(this);
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
		CtrlDetalle_documento_compra.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}

	public Documento_compra getDocumento_compra()
	{
		return CtrlDocumento_compra.getDocumento_compra(_documento_compra_ID);
	}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Detalle_documento_compra
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String producto_ID{
		
	get{return ("producto_ID");}
	}
	public static String detalle_solicitud_compra_ID{
		
	get{return ("detalle_solicitud_compra_ID");}
	}
	public static String detalle_comprobante_contable_ID{
		
	get{return ("detalle_comprobante_contable_ID");}
	}
	public static String cantidad{
		
	get{return ("cantidad");}
	}
	public static String exento{
		
	get{return ("exento");}
	}
	public static String porcentaje_descuento{
		
	get{return ("porcentaje_descuento");}
	}
	public static String monto_descuento{
		
	get{return ("monto_descuento");}
	}
	public static String precio_neto_unitario{
		
	get{return ("precio_neto_unitario");}
	}
	public static String monto_impuesto{
		
	get{return ("monto_impuesto");}
	}
	public static String impuesto_ID{
		
	get{return ("impuesto_ID");}
	}
	public static String total_neto{
		
	get{return ("total_neto");}
	}
	public static String iva{
		
	get{return ("iva");}
	}
	public static String total_bruto{
		
	get{return ("total_bruto");}
	}
	public static String estado{
		
	get{return ("estado");}
	}
	public static String documento_compra_ID{
		
	get{return ("documento_compra_ID");}
	}
	public static String flete_unitario{
		
	get{return ("flete_unitario");}
	}
	public static String precio_neto_unitario_factura{
		
	get{return ("precio_neto_unitario_factura");}
	}
	}//Fin clase estática
	
	}//Fin name_space
