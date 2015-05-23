using System;
using System.Collections;
using System.Data;
using querytor;
namespace utilidades
{
    class Controlador_Producto
    {
        Producto_Fachada fachada = new Producto_Fachada();
        public Producto[] getListado(Query query)
        {
           // query.AddWhereExacto("estado", "1");
            DataSet dataset = fachada.getListado(query);
            Producto[] producto = new Producto[dataset.Tables[0].Rows.Count];
            int contador = 0;
            if (dataset != null)
            {
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    Producto objeto = new Producto(fila);
                    if (dataset.Tables[0].Columns["nombreCategoria"]!=null)
                    objeto.fnombreCategoria = fila["nombreCategoria"].ToString();
                    producto[contador] = objeto;
                    contador++;
                }
            }
            return producto;
        }
        public int guardar(Producto objeto)
        {
            return fachada.guardar(objeto);
        }
        public void actualizar(Producto objeto)
        {
            fachada.actualizar(objeto);
        }
        public void actualizarPrecioVenta(Producto producto)
        {
            Query query = new Query("update", "producto");
            query.AddSet("precio_venta", producto.fprecio_venta.ToString());
            query.AddWhere("ID", producto.fID.ToString());
            BDConnect.EjecutaSinRetorno(query.listo());
        
        }
        public void eliminar(Query query)
        {
            fachada.eliminar(query);
        }
        public void ejecutaSin_retorno(Query query)
        {
            fachada.ejecutaSin_retorno(query);
        }
        public Producto getProducto(string id)
        {
            Query query = new Query("select", "Producto");
            query.AddWhere("ID", id);
            query.AddSelect("*");
            Producto objeto = new Producto();
            DataSet dataset = fachada.getListado(query);
            int contador = 0;
            if (dataset != null)
            {
                foreach (DataRow fila in dataset.Tables[0].Rows)
                {
                    objeto = new Producto(fila);
                    contador++;
                }
            }
            return objeto;
        }
        //public void rebajarStock(int bodega_ID, int producto_ID, double cantidad_comprada)
        //{
        //    try
        //    {
        //        Query query = new Query("select", "configuracion");
        //        query.AddWhere(ST_Configuracion.nombre_llave, "REBAJAR_STOCK");
        //        Configuracion[] arrConfiguracion = CtrlConfiguracion.getListado(query);
        //        Configuracion configuracion = arrConfiguracion[0];

        //        Producto_Fachada producto_fachada = new Producto_Fachada();
        //        Producto producto= this.getProducto(producto_ID.ToString());
        //        producto._ultima_fecha_venta = DateTime.Now;
        //        if (configuracion.fvalor_llave.Equals("si"))
        //        {
        //            if (producto.fproducto_compuesto_ID > 0)
        //            {
        //                Producto_compuesto productoCompuesto = CtrlProducto_compuesto.getProducto_compuesto(producto.fproducto_compuesto_ID);
        //                productoCompuesto.fultima_fecha_venta = DateTime.Now;
        //                productoCompuesto.actualizar();
        //                query = new Query("select", "producto_producto_compuesto");
        //                query.AddWhere(ST_Producto_producto_compuesto.producto_compuesto_ID, producto.fproducto_compuesto_ID.ToString());
        //                Producto_producto_compuesto[] arrProductoProductoCompuesto = CtrlProducto_producto_compuesto.getListado(query);
        //                Producto materiaPrima;
        //                foreach (Producto_producto_compuesto objeto in arrProductoProductoCompuesto)
        //                {
        //                    materiaPrima = objeto.getProducto();
        //                    materiaPrima.fstock_actual -= Utils.cdouble(objeto.fcantidad.ToString()) * cantidad_comprada;
        //                    this.actualizar(materiaPrima);
        //                }
        //            }
        //            else
        //            {
        //                producto.fstock_actual = producto.fstock_actual - cantidad_comprada;
        //                producto_fachada.rebajarStock(bodega_ID, producto_ID, cantidad_comprada);
        //            }
        //        }
        //        this.actualizar(producto);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //    }
        //}
        public void aumentarStock(int bodega_ID, int producto_ID, double cantidadDevolucion)
        {
            Producto_Fachada producto_fachada = new Producto_Fachada();
            producto_fachada.AumentarStock(bodega_ID, producto_ID, cantidadDevolucion);
            Producto producto = this.getProducto(producto_ID.ToString());
            producto._stock_actual = producto._stock_actual + cantidadDevolucion;
            this.actualizar(producto);
        }

        /// <summary>
        /// Verifica si el precio de venta está de acorde al porcentaje de ganancia que posee.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="precioNetoUnitario"></param>
        /// <param name="fleteUnitario"></param>
        /// <returns></returns>
        //public bool VerificaVigenciaPrecioVenta(Producto producto, int precioNetoUnitario, int fleteUnitario)
        //{
        //    try
        //    {
        //        //FORMULAR PRECIO VENTA:
        //        //pnu:precio neto unitario
        //        //pnu+(pnu*%ganancia)+((pnu+(pnu*%ganancia))*IVA)

        //        System.Configuration.AppSettingsReader conf = new System.Configuration.AppSettingsReader();
        //        int ID_PRODUCTO_FLETE =  Utils.cint(CtrlConfiguracion.GetValor("ID_PRODUCTO_FLETE"));//   "sigcom_produccion";
        //        if (producto.fID != ID_PRODUCTO_FLETE)
        //        {
        //            int precioCompra = this.GetPrecioCompraProducto(producto, precioNetoUnitario, (int)fleteUnitario);
                    

        //            producto.fultimo_precio_compra = precioCompra;
        //            Query query = new Query("update", "producto");
        //            query.AddSet("ultimo_precio_compra", precioCompra.ToString());
        //            query.AddWhere("ID", producto.fID.ToString());
        //            BDConnect.EjecutaSinRetorno(query.listo());
        //            //producto.Actualizar();
        //            double ValorMargen = ((double)producto.fmargen_ganancia / 100);
        //            int precio_costo_neto = precioNetoUnitario + (int)fleteUnitario;
                    
        //            //double Ganancia = precioCompra * ValorMargen;
        //            double Ganancia = precio_costo_neto * ValorMargen;
                    
        //            Ganancia = Math.Round(Ganancia, 0, MidpointRounding.AwayFromZero);
        //            precio_costo_neto += (int)Ganancia;
        //            double IVA = Utils.cdouble(precio_costo_neto.ToString()) * Utils.iva();
        //            IVA = Math.Round(IVA, 0, MidpointRounding.AwayFromZero);
        //            int PrecioCalculado = precio_costo_neto + (int)IVA;
        //            Form_ConfirmacionModificacionPrecioVenta frmConfirmacion = new Form_ConfirmacionModificacionPrecioVenta();
        //            if (producto.fprecio_venta < PrecioCalculado)
        //            {
        //                //System.Windows.Forms.DialogResult dlgRes = System.Windows.Forms.MessageBox.Show("Estimado(a) " + Program.usuarioActual.fnombre + ": El precio de venta (" + utilidades.Utils.formatMoney(producto.fprecio_venta.ToString()) + ") es menor al precio de compra más el margen de ganancia, ¿Deseas actualizar el precio de venta a " + Utils.formatMoney(PrecioCalculado) + "?", "Confirmar actualización de precio de venta", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
        //                frmConfirmacion.setMensaje("El precio de venta es menor al precio de compra más el margen de ganancia, ¿Deseas actualizar el precio de venta de");
        //                frmConfirmacion.SetProducto(producto);
        //                frmConfirmacion.SetPrecioVentaCalculado(PrecioCalculado);
        //                System.Windows.Forms.DialogResult resultado = frmConfirmacion.ShowDialog();
        //                if (resultado == System.Windows.Forms.DialogResult.OK)//(dlgRes == System.Windows.Forms.DialogResult.Yes)
        //                {
        //                    producto.fprecio_venta = frmConfirmacion.precioVenta();
        //                    this.actualizarPrecioVenta(producto);
        //                    return true;
        //                }
        //                else if (resultado == System.Windows.Forms.DialogResult.Cancel)
        //                {
        //                    return false;
        //                }
        //                else if (resultado == System.Windows.Forms.DialogResult.No)
        //                {
        //                    return true;
        //                }
        //            }
        //            else
        //            {
        //                ValorMargen = (((float)producto.fprecio_venta * 10) / 100);
        //                if (producto.fprecio_venta > PrecioCalculado + (int)ValorMargen)
        //                {
        //                    frmConfirmacion.setMensaje("El precio de venta es muy mayor al precio de compra más el margen de ganancia, ¿Deseas actualizar el precio de venta de");
        //                    frmConfirmacion.SetProducto(producto);
        //                    frmConfirmacion.SetPrecioVentaCalculado(PrecioCalculado);
        //                    //System.Windows.Forms.DialogResult dlgRes = System.Windows.Forms.MessageBox.Show("Estimado(a) " + Program.usuarioActual.fnombre + ": El precio de venta (" + utilidades.Utils.formatMoney(producto.fprecio_venta.ToString()) + ") es muy mayor al precio de compra más el margen de ganancia, ¿Deseas actualizar el precio de venta a " + Utils.formatMoney(PrecioCalculado) + "?", "Confirmar actualización de precio de venta", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
        //                    System.Windows.Forms.DialogResult resultado = frmConfirmacion.ShowDialog();
        //                    if (resultado == System.Windows.Forms.DialogResult.OK)//dlgRes == System.Windows.Forms.DialogResult.Yes)
        //                    {
        //                        producto.fprecio_venta = frmConfirmacion.precioVenta();
        //                        //producto.fprecio_venta = PrecioCalculado;
        //                        this.actualizarPrecioVenta(producto);
        //                        //this.actualizar(producto);
        //                        System.Windows.Forms.MessageBox.Show("El precio de venta del producto:" + producto.fnombre + " se actualizó a " + producto.fprecio_venta);
        //                        return true;
        //                    }
        //                    else if (resultado == System.Windows.Forms.DialogResult.Cancel)
        //                    {
        //                        return false;
        //                    }
        //                    else if (resultado == System.Windows.Forms.DialogResult.No)
        //                    {
        //                        return true;
        //                    }
        //                }
        //                else
        //                    return true;
        //            }
        //            return true;
        //        }
        //        else
        //            return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        return false;
        //    }
        //}
        /// <summary>
        /// Obtiene el precio unitario de costo bruto.(neto + IVA + flete)
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="precioNetoUnitario"></param>
        /// <param name="precioFleteUnitario"></param>
        /// <returns></returns>
        private int GetPrecioCompraProducto(Producto producto, int precioNetoUnitario,int precioFleteUnitario)
        {
            int porcentajeAcumuladosImpuestos = 0;
            //Query query = new Query("select", ST_Tablas.categoria_impuesto);
            //query.AddWhere(ST_Categoria_impuesto.categoria_ID, producto.getCategoria().fID.ToString());
            //Categoria_impuesto[] ArrCategoriaImpuesto = CtrlCategoria_impuesto.getListado(query);
      
            //foreach (Categoria_impuesto item in ArrCategoriaImpuesto)
            //{
            //    porcentajeAcumuladosImpuestos += item.getImpuesto().fporcentaje;
            //}
            double montoImpuestos = 0;
            if (porcentajeAcumuladosImpuestos > 0)
                montoImpuestos = (precioNetoUnitario * porcentajeAcumuladosImpuestos) / 100;

            double precioNetoDouble = Utils.cdouble(precioNetoUnitario.ToString());
            if (producto.fexento == null)
            {
                precioNetoDouble = precioNetoDouble * 1.19;
            }
            else if (producto.fexento == "no")
                precioNetoDouble = precioNetoDouble * 1.19;

            precioNetoDouble += montoImpuestos;
            precioNetoDouble = Math.Round(precioNetoDouble, 0, MidpointRounding.AwayFromZero);
            return Utils.cint(precioNetoDouble.ToString()) + precioFleteUnitario;
        }
        public int getID(string nombre)
        {
            try
            {
                if (nombre.Length > 0)
                {
                    nombre = nombre.Trim();
                    Query query = new Query("Producto");
                    query.AddWhereExacto("nombre", nombre);
                    Producto[] arrProducto = this.getListado(query);
                    if (arrProducto.Length > 0)
                    {
                        return arrProducto[0].fID;
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
