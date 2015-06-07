using System;
using System.Collections;
using System.Data;
using querytor;
namespace utilidades
{

    class Producto_Fachada
    {

        public DataSet getListado(Query query)
        {
            return BDConnect.Exec_cQuery(query.listo());
        }
        public int guardar(Producto objeto)
        {
            Query query = new Query("insert", "producto");
            query.AddInsert("ID", Utils.preparaIU(objeto.fID));
            query.AddInsert("categoria_ID", Utils.preparaIU(objeto.fcategoria_ID));
            query.AddInsert("codigo_barra", Utils.preparaIU(objeto.fcodigo_barra));
            query.AddInsert("codigo_barra_grupo", Utils.preparaIU(objeto.fcodigo_barra_grupo));
            query.AddInsert("nombre", Utils.preparaIU(objeto.fnombre));
            query.AddInsert("descripcion", Utils.preparaIU(objeto.fdescripcion));
            query.AddInsert("stock_actual", Utils.preparaIU(objeto.fstock_actual));
            query.AddInsert("stock_minimo", Utils.preparaIU(objeto.fstock_minimo));
            query.AddInsert("precio_venta", Utils.preparaIU(objeto.fprecio_venta));
            query.AddInsert("unidad", Utils.preparaIU(objeto.funidad));
            query.AddInsert("unidad_grupo", Utils.preparaIU(objeto.funidad_grupo));
            query.AddInsert("cantidad_grupo", Utils.preparaIU(objeto.fcantidad_grupo));
            query.AddInsert("cantidad_grupo_adicional", Utils.preparaIU(objeto.fcantidad_grupo_adicional));
            query.AddInsert("estado", Utils.preparaIU(objeto.festado));
            query.AddInsert("ultimo_precio_compra", Utils.preparaIU(objeto.fultimo_precio_compra));
            query.AddInsert("ultimo_precio_venta", Utils.preparaIU(objeto.fultimo_precio_venta));
            query.AddInsert("ultima_fecha_compra", Utils.preparaIU(objeto.fultima_fecha_compra));
            query.AddInsert("ultima_fecha_venta", Utils.preparaIU(objeto.fultima_fecha_venta));
            query.AddInsert("margen_ganancia", Utils.preparaIU(objeto.fmargen_ganancia));
            query.AddInsert("exento", Utils.preparaIU(objeto.fexento));
            query.AddInsert("precio_venta_grupo", Utils.preparaIU(objeto._precio_venta_grupo));
            query.AddInsert("producto_compuesto_ID", Utils.preparaIU(objeto.fproducto_compuesto_ID));
            query.AddInsert("cliente_proveedor_ID", Utils.preparaIU(objeto.fcliente_proveedorID));
            query.AddInsert("codigo_producto", Utils.preparaIU(objeto.fcodigo_producto));
            //BDConnect.Exec_sQuery(query.listo());
            string queryID = query.lastInsertID();
            //DataSet dataset = BDConnect.Exec_cQuery(queryID);
            //return Utils.cint(dataset.Tables[0].Rows[0]["LAST_INSERT_ID()"].ToString());


            DataSet dataset = BDConnect.EjecutaConRetorno(query.listo() + ";" + queryID);

            //string producto_ID = dataset.Tables[0].Rows[0]["LAST_INSERT_ID()"].ToString();
            //return dataset.Tables[0].Rows[0]["LAST_INSERT_ID()"].ToString());

            query = new Query("insert", "bodega_producto");
            query.AddInsert("producto_ID", objeto.fID);
            query.AddInsert("bodega_ID", 2);
            query.AddInsert("cantidad", objeto.fstock_actual);
            BDConnect.EjecutaConRetorno(query.listo());
            return objeto.fID;// Utils.cint(producto_ID);
            //return (int)BDConnect.Exec_Query(query.listo());

            //return (int)BDConnect.Exec_Query(query.listo());
        }
        public void actualizar(Producto objeto)
        {
            Query query = new Query("update", "producto");
            query.AddSet("ID", Utils.preparaIU(objeto.fID));
            query.AddSet("categoria_ID", Utils.preparaIU(objeto.fcategoria_ID));
            query.AddSet("codigo_barra", Utils.preparaIU(objeto.fcodigo_barra));
            query.AddSet("codigo_barra_grupo", Utils.preparaIU(objeto.fcodigo_barra_grupo));
            query.AddSet("nombre", Utils.preparaIU(objeto.fnombre));
            query.AddSet("descripcion", Utils.preparaIU(objeto.fdescripcion));
            query.AddSet("stock_actual", Utils.preparaIU(objeto.fstock_actual));
            query.AddSet("stock_minimo", Utils.preparaIU(objeto.fstock_minimo));
            query.AddSet("precio_venta", Utils.preparaIU(objeto.fprecio_venta));
            query.AddSet("unidad", Utils.preparaIU(objeto.funidad));
            query.AddSet("unidad_grupo", Utils.preparaIU(objeto.funidad_grupo));
            query.AddSet("cantidad_grupo", Utils.preparaIU(objeto.fcantidad_grupo));
            query.AddSet("cantidad_grupo_adicional", Utils.preparaIU(objeto.fcantidad_grupo_adicional));
            query.AddSet("estado", Utils.preparaIU(objeto.festado));
            query.AddSet("ultimo_precio_compra", Utils.preparaIU(objeto.fultimo_precio_compra));
            query.AddSet("ultimo_precio_venta", Utils.preparaIU(objeto.fultimo_precio_venta));
            query.AddSet("ultima_fecha_compra", Utils.preparaIU(objeto.fultima_fecha_compra));
            query.AddSet("ultima_fecha_venta", Utils.preparaIU(objeto.fultima_fecha_venta));
            query.AddSet("margen_ganancia", Utils.preparaIU(objeto.fmargen_ganancia));
            query.AddSet("exento", Utils.preparaIU(objeto.fexento));
            query.AddSet("precio_venta_grupo", Utils.preparaIU(objeto.fprecio_venta_grupo));
            query.AddSet("producto_compuesto_ID", Utils.preparaIU(objeto.fproducto_compuesto_ID));
            query.AddSet("cliente_proveedor_ID", Utils.preparaIU(objeto.fcliente_proveedorID));
            query.AddWhere("ID", objeto.fID.ToString());
            



            BDConnect.Exec_sQuery(query.listo());
        }
        public void ejecutaSin_retorno(Query query)
        {
            BDConnect.Exec_sQuery(query.listo());
        }
        public void eliminar(Query query)
        {
            BDConnect.Exec_sQuery(query.listo());
        }
        public DataSet get_stock_bodega(int bodega_ID, int producto_ID)
        {
            Query query = new Query("select", "bodega_producto");
            query.AddWhere("bodega_ID", bodega_ID.ToString());
            query.AddWhere("producto_ID", producto_ID.ToString());
            query.AddSelect("*");
            return BDConnect.Exec_cQuery(query.listo());
        }
        public void rebajarStock(int bodega_ID, int producto_ID, double cantidad)
        {
            string _query = "UPDATE bodega_producto SET cantidad=cantidad-" + cantidad.ToString().Replace(",", ".") + " WHERE producto_ID=" + producto_ID.ToString() + " AND bodega_ID=" + bodega_ID.ToString();
            //Query query = new Query("update", "bodega_producto");
            //query.AddSet("cantidad", "cantidad-" + cantidad.ToString().Replace(",","."));
            //query.AddWhere("producto_ID", producto_ID.ToString());
            //query.AddWhere("bodega_ID", bodega_ID.ToString());
            BDConnect.Exec_sQuery(_query);
        }
        public void AumentarStock(int bodega_ID, int producto_ID, double cantidad)
        {
            //Query query = new Query("update", "bodega_producto");
            //query.AddSet("cantidad", "cantidad+" + cantidad.ToString());
            //query.AddWhere("producto_ID", producto_ID.ToString());
            //query.AddWhere("bodega_ID", bodega_ID.ToString());
            string _query = "UPDATE bodega_producto SET cantidad=cantidad+" + cantidad.ToString().Replace(",", ".") + " WHERE producto_ID=" + producto_ID.ToString() + " AND bodega_ID=" + bodega_ID.ToString();
            BDConnect.Exec_sQuery(_query);
        }

    }//Fin Clase
}//Fin name_space

