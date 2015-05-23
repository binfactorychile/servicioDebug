using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaCliente_proveedor
    {

        public static DataSet getListado(Query query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static DataSet getListado(string query)
        {
            try
            {
                return BDConnect.EjecutaConRetorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex.Message + " --- TRACE-->" + ex.StackTrace);
                return null;
            }
        }
        public static int guardar(Cliente_proveedor objeto)
        {
            try
            {
                Query query = new Query("insert", "cliente_proveedor");
                if(objeto.fID > 0)
                {
                    query.AddInsert("ID", objeto.fID);
                }
                query.AddInsert("nombre", objeto.fnombre);
                query.AddInsert("direccion", objeto.fdireccion);
                query.AddInsert("ciudad", objeto.fciudad);
                query.AddInsert("razon_social", objeto.frazon_social);
                query.AddInsert("telefono", objeto.ftelefono);
                query.AddInsert("email", objeto.femail);
                query.AddInsert("estado", objeto.festado);
                query.AddInsert("giro", objeto.fgiro);
                query.AddInsert("fax", objeto.ffax);
                query.AddInsert("tipo", objeto.ftipo);
                query.AddInsert("cuenta_credito_ID", objeto.fcuenta_credito_ID);
                query.AddInsert("monto_credito", objeto.fmonto_credito);
                query.AddInsert("rut", objeto.frut);
                query.AddInsert("coordenadas_GPS", objeto.fcoordenadas_GPS);
                query.AddInsert("tipo_cliente_ID", objeto.ftipo_cliente_ID);
                query.AddInsert("listado_cliente_ID", objeto.flistado_cliente_ID);
                query.AddInsert("sector_ID", objeto.fsector_ID);
                query.AddInsert("es_sucursal", objeto.fes_sucursal);
                query.AddInsert("observacion", objeto.fobservacion);
                query.AddInsert("sucursal_ID", objeto.fsucursal_ID);
                query.AddInsert("lista_precios_ID", objeto.flista_precios_ID);
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM cliente_proveedor WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Cliente_proveedor_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Cliente_proveedor_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Cliente_proveedor_ID = Utils.cint(fila["ID"].ToString());
                }
                return Cliente_proveedor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Cliente_proveedorJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "cliente_proveedor");
                if (objeto.getID() > 0)
                {
                    query.AddInsert("ID", objeto.getID());
                }
                query.AddInsert("nombre", objeto.getNombre());
                query.AddInsert("direccion", objeto.getDireccion());
                query.AddInsert("ciudad", objeto.getCiudad());
                query.AddInsert("razon_social", objeto.getRazon_social());
                query.AddInsert("telefono", objeto.getTelefono());
                query.AddInsert("email", objeto.getEmail());
                query.AddInsert("estado", objeto.getEstado());
                query.AddInsert("giro", objeto.getGiro());
                query.AddInsert("fax", objeto.getFax());
                query.AddInsert("tipo", objeto.getTipo());
                query.AddInsert("cuenta_credito_ID", objeto.getCuenta_credito_ID());
                query.AddInsert("monto_credito", objeto.getMonto_credito());
                query.AddInsert("rut", objeto.getRut());
                query.AddInsert("coordenadas_GPS", objeto.getCoordenadas_GPS());
                query.AddInsert("tipo_cliente_ID", objeto.getTipo_cliente_ID());
                query.AddInsert("listado_cliente_ID", objeto.getListado_cliente_ID());
                query.AddInsert("sector_ID", objeto.getSector_ID());
                query.AddInsert("es_sucursal", objeto.getEs_sucursal());
                query.AddInsert("observacion", objeto.getObservacion());
                query.AddInsert("sucursal_ID", objeto.getSucursal_ID());
                query.AddInsert("lista_precios_ID", objeto.getLista_precios_ID());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID = query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM cliente_proveedor WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Cliente_proveedor_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Cliente_proveedor_ID = Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Cliente_proveedor_ID = Utils.cint(fila["ID"].ToString());
                }
                return Cliente_proveedor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Cliente_proveedor objeto)
        {
            try
            {
                Query query = new Query("update", "cliente_proveedor");
                query.AddSet("nombre", objeto.fnombre);
                query.AddSet("direccion", objeto.fdireccion);
                query.AddSet("ciudad", objeto.fciudad);
                query.AddSet("razon_social", objeto.frazon_social);
                query.AddSet("telefono", objeto.ftelefono);
                query.AddSet("email", objeto.femail);
                query.AddSet("estado", objeto.festado);
                query.AddSet("giro", objeto.fgiro);
                query.AddSet("fax", objeto.ffax);
                query.AddSet("tipo", objeto.ftipo);
                query.AddSet("cuenta_credito_ID", objeto.fcuenta_credito_ID);
                query.AddSet("monto_credito", objeto.fmonto_credito);
                query.AddSet("rut", objeto.frut);
                query.AddSet("coordenadas_GPS", objeto.fcoordenadas_GPS);
                query.AddSet("tipo_cliente_ID", objeto.ftipo_cliente_ID);
                query.AddSet("listado_cliente_ID", objeto.flistado_cliente_ID);
                query.AddSet("sector_ID", objeto.fsector_ID);
                query.AddSet("es_sucursal", objeto.fes_sucursal);
                query.AddSet("estado_vigente", objeto.festado_vigente);
                query.AddSet("observacion", objeto.fobservacion);
                query.AddSet("sucursal_ID", objeto.fsucursal_ID);
                query.AddSet("lista_precios_ID", objeto.flista_precios_ID);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Cliente_proveedorJSON objeto)
        {
            try
            {
                Query query = new Query("update", "cliente_proveedor");
                query.AddSet("nombre", objeto.getNombre());
                query.AddSet("direccion", objeto.getDireccion());
                query.AddSet("ciudad", objeto.getCiudad());
                query.AddSet("razon_social", objeto.getRazon_social());
                query.AddSet("telefono", objeto.getTelefono());
                query.AddSet("email", objeto.getEmail());
                query.AddSet("estado", objeto.getEstado());
                query.AddSet("giro", objeto.getGiro());
                query.AddSet("fax", objeto.getFax());
                query.AddSet("tipo", objeto.getTipo());
                query.AddSet("cuenta_credito_ID", objeto.getCuenta_credito_ID());
                query.AddSet("monto_credito", objeto.getMonto_credito());
                query.AddSet("rut", objeto.getRut());
                query.AddSet("coordenadas_GPS", objeto.getCoordenadas_GPS());
                query.AddSet("tipo_cliente_ID", objeto.getTipo_cliente_ID());
                query.AddSet("listado_cliente_ID", objeto.getListado_cliente_ID());
                query.AddSet("sector_ID", objeto.getSector_ID());
                query.AddSet("es_sucursal", objeto.getEs_sucursal());
                query.AddSet("estado_vigente", objeto.getEstado_vigente());
                query.AddSet("observacion", objeto.getObservacion());
                query.AddSet("sucursal_ID", objeto.getSucursal_ID());
                query.AddSet("lista_precios_ID", objeto.getLista_precios_ID());
                query.AddWhere("ID", objeto.getID().ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

    }//Fin Clase
}//Fin name_space

