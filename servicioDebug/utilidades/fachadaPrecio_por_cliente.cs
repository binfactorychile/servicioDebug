using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
namespace utilidades
{

    static public class FachadaPrecio_por_cliente
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
        public static int guardar(Precio_por_cliente objeto)
        {
            try
            {
                Query query = new Query("insert", "precio_por_cliente");
                query.AddInsert("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
                query.AddInsert("producto_ID", objeto.fproducto_ID);
                query.AddInsert("precio_venta_unitario", objeto.fprecio_venta_unitario);
                query.AddInsert("cantidad_minima", objeto.fcantidad_minima);
                query.AddInsert("porcentaje_aumento_precio_base", objeto.fporcentaje_aumento_precio_base);
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM precio_por_cliente WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Precio_por_cliente_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Precio_por_cliente_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Precio_por_cliente_ID = Utils.cint(fila["ID"].ToString());
                }
                return Precio_por_cliente_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static int guardarJSON(Precio_por_clienteJSON objeto)
        {
            try
            {
                Query query = new Query("insert", "precio_por_cliente");
                query.AddInsert("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
                query.AddInsert("producto_ID", objeto.getProducto_ID());
                query.AddInsert("precio_venta_unitario", objeto.getPrecio_venta_unitario());
                query.AddInsert("cantidad_minima", objeto.getCantidad_minima());
                query.AddInsert("porcentaje_aumento_precio_base", objeto.getPorcentaje_aumento_precio_base());
                query.AddInsert("estado_vigente", "vigente");

                //BDConnect.EjecutaSinRetorno(query.listo());
                string queryID=query.lastInsertID();
                //DataSet dataset=BDConnect.EjecutaConRetorno(queryID);

                //string queryID = "SELECT ID FROM precio_por_cliente WHERE ID = @@IDENTITY";
                DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

                int Precio_por_cliente_ID = 0;
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Precio_por_cliente_ID=Utils.cint(fila["LAST_INSERT_ID()"].ToString());
                    //Precio_por_cliente_ID = Utils.cint(fila["ID"].ToString());
                }
                return Precio_por_cliente_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }

        public static void actualizar(Precio_por_cliente objeto)
        {
            try
            {
                Query query = new Query("update", "precio_por_cliente");
                query.AddSet("cliente_proveedor_ID", objeto.fcliente_proveedor_ID);
                query.AddSet("producto_ID", objeto.fproducto_ID);
                query.AddSet("precio_venta_unitario", objeto.fprecio_venta_unitario);
                query.AddSet("cantidad_minima", objeto.fcantidad_minima);
                query.AddSet("estado_vigente", objeto.festado_vigente);
                query.AddSet("porcentaje_aumento_precio_base", objeto.fporcentaje_aumento_precio_base);
                query.AddWhere("ID", objeto.fID.ToString());
                BDConnect.EjecutaSinRetorno(query.listo());
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void actualizarJSON(Precio_por_clienteJSON objeto)
        {
            try
            {
                Query query = new Query("update", "precio_por_cliente");
                query.AddSet("cliente_proveedor_ID", objeto.getCliente_proveedor_ID());
                query.AddSet("producto_ID", objeto.getProducto_ID());
                query.AddSet("precio_venta_unitario", objeto.getPrecio_venta_unitario());
                query.AddSet("cantidad_minima", objeto.getCantidad_minima());
                query.AddSet("estado_vigente", objeto.getEstado_vigente());
                query.AddSet("porcentaje_aumento_precio_base", objeto.getPorcentaje_aumento_precio_base());
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

