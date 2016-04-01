using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Detalle_venta
	{
		private int _ID;
		private int _producto_ID;
		private int _detalle_comprobante_contable_ID;
		private decimal _cantidad;
		private decimal _precio_unitario;
		private int _descuento;
		private int _iva;
		private int _total;
		private int _venta_ID;
		private int _estado;
		private string _es_promocion;
		private int _total_otros_impuestos;
		private int _impuesto_ID;
		private decimal _precio_unitario_neto;
		
	//CONSTRUCTOR
	public Detalle_venta(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_producto_ID =Utils.cint(data["producto_ID"].ToString());
		_detalle_comprobante_contable_ID =Utils.cint(data["detalle_comprobante_contable_ID"].ToString());
		_cantidad =Utils.cdecimal(data["cantidad"].ToString());
		_precio_unitario =Utils.cdecimal(data["precio_unitario"].ToString());
		_descuento =Utils.cint(data["descuento"].ToString());
		_iva =Utils.cint(data["iva"].ToString());
		_total =Utils.cint(data["total"].ToString());
		_venta_ID =Utils.cint(data["venta_ID"].ToString());
		_estado =Utils.cint(data["estado"].ToString());
		_es_promocion =data["es_promocion"].ToString();
		_total_otros_impuestos =Utils.cint(data["total_otros_impuestos"].ToString());
		_impuesto_ID =Utils.cint(data["impuesto_ID"].ToString());
		_precio_unitario_neto =Utils.cdecimal(data["precio_unitario_neto"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Detalle_venta()
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
	
	public int fdetalle_comprobante_contable_ID{
		
	get{return (_detalle_comprobante_contable_ID);}
	set{_detalle_comprobante_contable_ID=value;}
	
	}
	
	public decimal fcantidad{
		
	get{return (_cantidad);}
	set{_cantidad=value;}
	
	}
	
	public decimal fprecio_unitario{
		
	get{return (_precio_unitario);}
	set{_precio_unitario=value;}
	
	}
	
	public int fdescuento{
		
	get{return (_descuento);}
	set{_descuento=value;}
	
	}
	
	public int fiva{
		
	get{return (_iva);}
	set{_iva=value;}
	
	}
	
	public int ftotal{
		
	get{return (_total);}
	set{_total=value;}
	
	}
	
	public int fventa_ID{
		
	get{return (_venta_ID);}
	set{_venta_ID=value;}
	
	}
	
	public int festado{
		
	get{return (_estado);}
	set{_estado=value;}
	
	}
	
	public string fes_promocion{
		
	get{return (_es_promocion);}
	set{_es_promocion=value;}
	
	}
	
	public int ftotal_otros_impuestos{
		
	get{return (_total_otros_impuestos);}
	set{_total_otros_impuestos=value;}
	
	}
	
	public int fimpuesto_ID{
		
	get{return (_impuesto_ID);}
	set{_impuesto_ID=value;}
	
	}
	
	public decimal fprecio_unitario_neto{
		
	get{return (_precio_unitario_neto);}
	set{_precio_unitario_neto=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlDetalle_venta.actualizar(this);
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
		return  CtrlDetalle_venta.guardar(this);
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
		CtrlDetalle_venta.eliminar(this._ID);
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	//public Producto getProducto()
	//{
	//	return CtrlProducto.getProducto(_producto_ID);
	//}
	
	//public Detalle_comprobante_contable getDetalle_comprobante_contable()
	//{
	//	return CtrlDetalle_comprobante_contable.getDetalle_comprobante_contable(_detalle_comprobante_contable_ID);
	//}
	
	public Venta getVenta()
	{
		return CtrlVenta.getVenta(_venta_ID);
	}
	
	//public Impuesto getImpuesto()
	//{
	//	return CtrlImpuesto.getImpuesto(_impuesto_ID);
	//}
	
	
	}//fin clase lógica
	
	//Inicio clase estática
static public class ST_Detalle_venta
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String producto_ID{
		
	get{return ("producto_ID");}
	}
	public static String detalle_comprobante_contable_ID{
		
	get{return ("detalle_comprobante_contable_ID");}
	}
	public static String cantidad{
		
	get{return ("cantidad");}
	}
	public static String precio_unitario{
		
	get{return ("precio_unitario");}
	}
	public static String descuento{
		
	get{return ("descuento");}
	}
	public static String iva{
		
	get{return ("iva");}
	}
	public static String total{
		
	get{return ("total");}
	}
	public static String venta_ID{
		
	get{return ("venta_ID");}
	}
	public static String estado{
		
	get{return ("estado");}
	}
	public static String es_promocion{
		
	get{return ("es_promocion");}
	}
	public static String total_otros_impuestos{
		
	get{return ("total_otros_impuestos");}
	}
	public static String impuesto_ID{
		
	get{return ("impuesto_ID");}
	}
	public static String precio_unitario_neto{
		
	get{return ("precio_unitario_neto");}
	}
	}//Fin clase estática
	
	}//Fin name_space
