using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
	{
		
public class Documento_compra
	{
		private int _ID;
		private int _proveedor_ID;
		private int _tipo_documento_ID;
		private string _numero;
		private DateTime _fecha_digitacion;
		private DateTime _fecha_cancelacion;
		private DateTime _fecha_documento;
		private int _mes_proceso;
		private int _ano_proceso;
		private int _total_neto;
		private int _total_impuesto;
		private int _total_exento;
		private int _total_iva;
		private int _total_saldo;
		private int _total_pagos;
		private int _solicitud_compra_ID;
		private int _forma_pago_ID;
		private string _observacion;
		private DateTime _fecha_vencimiento;
		private int _comprobante_contable_ID;
		private int _estado;
		private int _total_bruto;
		private int _documento_compra_ID;
		private decimal _flete_unitario_constante;
		private int _sucursal_ID;
		
	//CONSTRUCTOR
	public Documento_compra(DataRow data)
	{
		try
	{
		_ID =Utils.cint(data["ID"].ToString());
		_proveedor_ID =Utils.cint(data["proveedor_ID"].ToString());
		_tipo_documento_ID =Utils.cint(data["tipo_documento_ID"].ToString());
		_numero =data["numero"].ToString();
		_fecha_digitacion =Utils.cdate(data["fecha_digitacion"].ToString());
		_fecha_cancelacion =Utils.cdate(data["fecha_cancelacion"].ToString());
		_fecha_documento =Utils.cdate(data["fecha_documento"].ToString());
		_mes_proceso =Utils.cint(data["mes_proceso"].ToString());
		_ano_proceso =Utils.cint(data["ano_proceso"].ToString());
		_total_neto =Utils.cint(data["total_neto"].ToString());
		_total_impuesto =Utils.cint(data["total_impuesto"].ToString());
		_total_exento =Utils.cint(data["total_exento"].ToString());
		_total_iva =Utils.cint(data["total_iva"].ToString());
		_total_saldo =Utils.cint(data["total_saldo"].ToString());
		_total_pagos =Utils.cint(data["total_pagos"].ToString());
		_solicitud_compra_ID =Utils.cint(data["solicitud_compra_ID"].ToString());
		_forma_pago_ID =Utils.cint(data["forma_pago_ID"].ToString());
		_observacion =data["observacion"].ToString();
		_fecha_vencimiento =Utils.cdate(data["fecha_vencimiento"].ToString());
		_comprobante_contable_ID =Utils.cint(data["comprobante_contable_ID"].ToString());
		_estado =Utils.cint(data["estado"].ToString());
		_total_bruto =Utils.cint(data["total_bruto"].ToString());
		_documento_compra_ID =Utils.cint(data["documento_compra_ID"].ToString());
		_flete_unitario_constante =Utils.cdecimal(data["flete_unitario_constante"].ToString());
		_sucursal_ID =Utils.cint(data["sucursal_ID"].ToString());
	}
	catch(Exception ex)
	{
		Utils.EscribeLog(ex);
	}
	}
	public Documento_compra()
	{
	}
	
	public int fID{
		
	get{return (_ID);}
	set{_ID=value;}
	
	}
	
	public int fproveedor_ID{
		
	get{return (_proveedor_ID);}
	set{_proveedor_ID=value;}
	
	}
	
	public int ftipo_documento_ID{
		
	get{return (_tipo_documento_ID);}
	set{_tipo_documento_ID=value;}
	
	}
	
	public string fnumero{
		
	get{return (_numero);}
	set{_numero=value;}
	
	}
	
	public DateTime ffecha_digitacion{
		
	get{return (_fecha_digitacion);}
	set{_fecha_digitacion=value;}
	
	}
	
	public DateTime ffecha_cancelacion{
		
	get{return (_fecha_cancelacion);}
	set{_fecha_cancelacion=value;}
	
	}
	
	public DateTime ffecha_documento{
		
	get{return (_fecha_documento);}
	set{_fecha_documento=value;}
	
	}
	
	public int fmes_proceso{
		
	get{return (_mes_proceso);}
	set{_mes_proceso=value;}
	
	}
	
	public int fano_proceso{
		
	get{return (_ano_proceso);}
	set{_ano_proceso=value;}
	
	}
	
	public int ftotal_neto{
		
	get{return (_total_neto);}
	set{_total_neto=value;}
	
	}
	
	public int ftotal_impuesto{
		
	get{return (_total_impuesto);}
	set{_total_impuesto=value;}
	
	}
	
	public int ftotal_exento{
		
	get{return (_total_exento);}
	set{_total_exento=value;}
	
	}
	
	public int ftotal_iva{
		
	get{return (_total_iva);}
	set{_total_iva=value;}
	
	}
	
	public int ftotal_saldo{
		
	get{return (_total_saldo);}
	set{_total_saldo=value;}
	
	}
	
	public int ftotal_pagos{
		
	get{return (_total_pagos);}
	set{_total_pagos=value;}
	
	}
	
	public int fsolicitud_compra_ID{
		
	get{return (_solicitud_compra_ID);}
	set{_solicitud_compra_ID=value;}
	
	}
	
	public int fforma_pago_ID{
		
	get{return (_forma_pago_ID);}
	set{_forma_pago_ID=value;}
	
	}
	
	public string fobservacion{
		
	get{return (_observacion);}
	set{_observacion=value;}
	
	}
	
	public DateTime ffecha_vencimiento{
		
	get{return (_fecha_vencimiento);}
	set{_fecha_vencimiento=value;}
	
	}
	
	public int fcomprobante_contable_ID{
		
	get{return (_comprobante_contable_ID);}
	set{_comprobante_contable_ID=value;}
	
	}
	
	public int festado{
		
	get{return (_estado);}
	set{_estado=value;}
	
	}
	
	public int ftotal_bruto{
		
	get{return (_total_bruto);}
	set{_total_bruto=value;}
	
	}
	
	public int fdocumento_compra_ID{
		
	get{return (_documento_compra_ID);}
	set{_documento_compra_ID=value;}
	
	}
	
	public decimal fflete_unitario_constante{
		
	get{return (_flete_unitario_constante);}
	set{_flete_unitario_constante=value;}
	
	}
	
	public int fsucursal_ID{
		
	get{return (_sucursal_ID);}
	set{_sucursal_ID=value;}
	
	}
	
	
	public void actualizar()
	{
		try
	{
		CtrlDocumento_compra.actualizar(this);
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
		return  CtrlDocumento_compra.guardar(this);
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
		CtrlDocumento_compra.eliminar(this._ID);
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
static public class ST_Documento_compra
	{
	public static String ID{
		
	get{return ("ID");}
	}
	public static String proveedor_ID{
		
	get{return ("proveedor_ID");}
	}
	public static String tipo_documento_ID{
		
	get{return ("tipo_documento_ID");}
	}
	public static String numero{
		
	get{return ("numero");}
	}
	public static String fecha_digitacion{
		
	get{return ("fecha_digitacion");}
	}
	public static String fecha_cancelacion{
		
	get{return ("fecha_cancelacion");}
	}
	public static String fecha_documento{
		
	get{return ("fecha_documento");}
	}
	public static String mes_proceso{
		
	get{return ("mes_proceso");}
	}
	public static String ano_proceso{
		
	get{return ("ano_proceso");}
	}
	public static String total_neto{
		
	get{return ("total_neto");}
	}
	public static String total_impuesto{
		
	get{return ("total_impuesto");}
	}
	public static String total_exento{
		
	get{return ("total_exento");}
	}
	public static String total_iva{
		
	get{return ("total_iva");}
	}
	public static String total_saldo{
		
	get{return ("total_saldo");}
	}
	public static String total_pagos{
		
	get{return ("total_pagos");}
	}
	public static String solicitud_compra_ID{
		
	get{return ("solicitud_compra_ID");}
	}
	public static String forma_pago_ID{
		
	get{return ("forma_pago_ID");}
	}
	public static String observacion{
		
	get{return ("observacion");}
	}
	public static String fecha_vencimiento{
		
	get{return ("fecha_vencimiento");}
	}
	public static String comprobante_contable_ID{
		
	get{return ("comprobante_contable_ID");}
	}
	public static String estado{
		
	get{return ("estado");}
	}
	public static String total_bruto{
		
	get{return ("total_bruto");}
	}
	public static String documento_compra_ID{
		
	get{return ("documento_compra_ID");}
	}
	public static String flete_unitario_constante{
		
	get{return ("flete_unitario_constante");}
	}
	public static String sucursal_ID{
		
	get{return ("sucursal_ID");}
	}
	}//Fin clase estática
	
	}//Fin name_space
