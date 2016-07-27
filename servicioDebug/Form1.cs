﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using querytor;
using utilidades;
using Newtonsoft.Json;
namespace servicioDebug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaSincronizacion();
        }

        private void ConsultaSincronizacion()
        {
            try
            {
                Query query = new Query("sincronizacion");
                extDataSet dset = BDConnect.EjecutaConRetorno(query.listo());
                if (dset != null && dset.tieneDatos())
                {

                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        int sincronizacion_ID = int.Parse(fila["ID"].ToString());
                        Utils.EscribeLog("ConsultaSincronizacion->" + sincronizacion_ID.ToString());
                        ConsultaRegistrosSincronizacion(sincronizacion_ID);
                    }


                }
            }
            catch (Exception ex)
            {
                //Utils.EscribeLog(ex);
            }
        }
        private void ConsultaRegistrosSincronizacion(int sincronizacion_ID)
        {
            try
            {
                Utils.EscribeLog("ConsultaRegistrosSincronizacion->1->ID->" + sincronizacion_ID.ToString());

                Query query = new Query("sincronizacion_registro");
                query.AddWhere("sincronizacion_ID", sincronizacion_ID.ToString());
                query.AddOrderBy("tabla");
                string query_listo = query.listo();
                Utils.EscribeLog("ConsultaRegistrosSincronizacion->2->query->" + query_listo);
                extDataSet dset = BDConnect.EjecutaConRetorno(query_listo);
                if (dset.tieneDatos())
                {
                    int registro_ID = 0;

                    ArrayList arrCategoriaJson = new ArrayList();
                    ArrayList arrCategoriaSincronizacionIDs = new ArrayList();

                    ArrayList arrClienteProveedorJson = new ArrayList();
                    ArrayList arrClienteProveedorIDs = new ArrayList();

                    ArrayList arrPrecioClienteJson = new ArrayList();
                    ArrayList arrPrecioClienteIDs = new ArrayList();

                    ArrayList arrProductosJSON = new ArrayList();
                    ArrayList arrRegSincronizacionIDs = new ArrayList();

                    ArrayList arrJoinListaPreciosJSON = new ArrayList();
                    ArrayList arrJoinListaPreciosSincronizacionIDs = new ArrayList();

                    ArrayList arrPrecioVolumenJSON = new ArrayList();
                    ArrayList arrPrecioVolumenSincronizacionIDs = new ArrayList();

                    ArrayList arrUsuarioJSON = new ArrayList();
                    ArrayList arrUsuarioSincronizacionIDs = new ArrayList();

                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        if (fila["tabla"].ToString() == "categoria")
                        {
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            arrCategoriaSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("categoria");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetCategoria = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetCategoria.tieneDatos())
                            {
                                DataRow filaCategoria = dsetCategoria.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                CategoriaJSON objCategoriaJSON = new CategoriaJSON(filaCategoria, fila["accion"].ToString(), servidor_ID);
                                arrCategoriaJson.Add(objCategoriaJSON);

                            }
                        }

                        if (fila["tabla"].ToString() == "cliente_proveedor")
                        {
                           
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            Utils.EscribeLog("ConsultaRegistrosSincronizacion->3->cliente->" + registro_ID);
                            arrClienteProveedorIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("cliente_proveedor");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetClienteProveedor = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetClienteProveedor.tieneDatos())
                            {
                                DataRow filaClienteProveedor = dsetClienteProveedor.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                Utils.EscribeLog("ConsultaRegistrosSincronizacion->3->servidor_ID->" + servidor_ID.ToString());
                                
                                Cliente_proveedorJSON objCategoriaJSON = new Cliente_proveedorJSON(filaClienteProveedor, fila["accion"].ToString(), servidor_ID);
                               
                                Utils.EscribeLog("ConsultaRegistrosSincronizacion->4->cliente->" +  JsonConvert.SerializeObject(objCategoriaJSON));
                                arrClienteProveedorJson.Add(objCategoriaJSON);
                                
                            }
                        }

                        if (fila["tabla"].ToString() == "precio_por_cliente")
                        {
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            arrPrecioClienteIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("precio_por_cliente");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetPrecioCliente = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetPrecioCliente.tieneDatos())
                            {
                                DataRow filaPrecioCliente = dsetPrecioCliente.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                Precio_por_clienteJSON objPrecioCliente = new Precio_por_clienteJSON(filaPrecioCliente, fila["accion"].ToString(), servidor_ID);
                                arrPrecioClienteJson.Add(objPrecioCliente);

                            }
                        }


                        if (fila["tabla"].ToString() == "producto")
                        {
                           
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            Utils.EscribeLog("ConsultaRegistrosSincronizacion->producto->ID->" + registro_ID.ToString());
                            arrRegSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("producto");
                            query.AddJoinAlReves("bodega_producto", "cantidad stock_actual");
                            query.AddWhere("bodega_ID", "2", "bodega_producto");
                            query.AddSelect("ID");
                            query.AddSelect("categoria_ID");
                            query.AddSelect("codigo_barra");
                            query.AddSelect("codigo_barra_grupo");
                            query.AddSelect("nombre");
                            query.AddSelect("descripcion");
                            //query.AddSelect("stock_actual");
                            query.AddSelect("stock_minimo");
                            query.AddSelect("precio_venta");
                            query.AddSelect("unidad");
                            query.AddSelect("unidad_grupo");
                            query.AddSelect("cantidad_grupo");
                            query.AddSelect("estado");
                            query.AddSelect("ultimo_precio_compra");
                            query.AddSelect("ultimo_precio_venta");
                            query.AddSelect("ultima_fecha_compra");
                            query.AddSelect("ultima_fecha_venta");
                            query.AddSelect("margen_ganancia");
                            query.AddSelect("exento");
                            query.AddSelect("precio_venta_grupo");
                            query.AddSelect("cantidad_grupo_adicional");
                            query.AddSelect("producto_compuesto_ID");
                            query.AddSelect("cliente_proveedor_ID");
                            query.AddSelect("codigo_producto");
                            query.AddSelect("precio_base");
                            query.AddSelect("porcentaje_descuento");
                            query.AddSelect("impuesto_ID");
                            query.AddSelect("subcategoria_ID");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();
                            Utils.EscribeLog(query_listo);
                            extDataSet dsetProducto = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetProducto.tieneDatos())
                            {
                                Utils.EscribeLog("ConsultaRegistrosSincronizacion->producto->ID->hay");
                                DataRow filaProducto = dsetProducto.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                ProductoJSON objProductoJson = new ProductoJSON(filaProducto, fila["accion"].ToString(), servidor_ID);
                                Utils.EscribeLog("ConsultaRegistrosSincronizacion->4->producto->" + JsonConvert.SerializeObject(objProductoJson));
                                arrProductosJSON.Add(objProductoJson);

                            }
                        }

                        if (fila["tabla"].ToString() == "producto_join_lista_precios")
                        {
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            arrJoinListaPreciosSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("producto_join_lista_precios");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetJoinListaPrecios = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetJoinListaPrecios.tieneDatos())
                            {
                                DataRow JoinListaPrecios = dsetJoinListaPrecios.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                Producto_join_lista_preciosJSON objJoinListaPreciosJson = new Producto_join_lista_preciosJSON(JoinListaPrecios, fila["accion"].ToString(), servidor_ID);
                                arrJoinListaPreciosJSON.Add(objJoinListaPreciosJson);

                            }
                        }

                        if (fila["tabla"].ToString() == "precio_por_volumen")
                        {
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            arrPrecioVolumenSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("precio_por_volumen");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetPrecioVolumen = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetPrecioVolumen.tieneDatos())
                            {
                                DataRow filaPrecioVolumen = dsetPrecioVolumen.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                Precio_por_volumenJSON objPrecioVolumenJson = new Precio_por_volumenJSON(filaPrecioVolumen, fila["accion"].ToString(), servidor_ID);
                                arrPrecioVolumenJSON.Add(objPrecioVolumenJson);

                            }
                        }

                        if (fila["tabla"].ToString() == "usuario")
                        {
                            registro_ID = int.Parse(fila["registro_ID"].ToString());
                            arrUsuarioSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("usuario");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetUsuario = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetUsuario.tieneDatos())
                            {
                                DataRow filaUsuario = dsetUsuario.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                UsuarioJSON objUsuarioJSON = new UsuarioJSON(filaUsuario, fila["accion"].ToString(), servidor_ID);
                                arrUsuarioJSON.Add(objUsuarioJSON);

                            }
                        }

                    }
                    String arrJson = "";
                    //categorias
                    if (arrCategoriaJson.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrCategoriaJson);
                        string resultado = WebServiceComm.ingresaCategoriaSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrCategoriaSincronizacionIDs, sincronizacion_ID);
                        }
                    }

                    //cliente_proveedor
                    if (arrClienteProveedorJson.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrClienteProveedorJson);
                        Utils.EscribeLog("ingresaClienteProveedorSincronizacionJSON->" + arrJson);
                        string resultado = WebServiceComm.ingresaClienteProveedorSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrClienteProveedorIDs, sincronizacion_ID);
                        }
                    }

                    //Precio por cliente
                    if (arrPrecioClienteJson.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrPrecioClienteJson);
                        string resultado = WebServiceComm.ingresaPrecioClienteSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrPrecioClienteIDs, sincronizacion_ID);
                        }
                    }

                    //Usuario
                    if (arrUsuarioJSON.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrUsuarioJSON);
                        Utils.EscribeLog("arrUsuarioJSON->" + arrJson);
                        string resultado = WebServiceComm.ingresaUsuarioSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrUsuarioSincronizacionIDs, sincronizacion_ID);
                        }
                    }

                    //productos
                    if (arrProductosJSON.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrProductosJSON);
                        Utils.EscribeLog("arrProductosJSON->" + arrJson);
                        string resultado = WebServiceComm.ingresaProductoSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrRegSincronizacionIDs, sincronizacion_ID);
                        }
                    }
                    //producto_join_lista_precios
                    if (arrJoinListaPreciosJSON.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrJoinListaPreciosJSON);
                        string resultado = WebServiceComm.ingresaProductoJoinListaPreciosSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrJoinListaPreciosSincronizacionIDs, sincronizacion_ID);
                        }
                    }
                    //precio_por_volumen
                    if (arrPrecioVolumenJSON.Count > 0)
                    {
                        arrJson = JsonConvert.SerializeObject(arrPrecioVolumenJSON);
                        string resultado = WebServiceComm.ingresaPrecioVolumenSincronizacionJSON(arrJson);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrPrecioVolumenSincronizacionIDs, sincronizacion_ID);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        private int GetServidorID()
        {
            try
            {
                int servidor_ID = 0;
                string query = "select valor_llave from configuracion where nombre_llave like 'SERVIDOR_ID'";
                extDataSet dset = BDConnect.EjecutaConRetorno(query);
                if (dset.tieneDatos())
                {
                    DataRow fila = dset.Tables[0].Rows[0];
                    servidor_ID = Utils.cint(fila["valor_llave"].ToString());
                }
                return servidor_ID;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return -1;
            }
        }

        private void EliminaRegistrosSincronizados(ArrayList arrRegSincronizacionIDs, int sincronizacion_ID)
        {
            try
            {
                foreach (int i in arrRegSincronizacionIDs)
                {
                    string query = "delete from sincronizacion_registro where ID = " + i;
                    BDConnect.EjecutaSinRetorno(query);
                    //BDConnect.Exec_sQuery(query);
                }

                extDataSet dset = BDConnect.EjecutaConRetorno("select * from sincronizacion_registro");
                if (!dset.tieneDatos())
                {
                    BDConnect.Exec_sQuery("delete from sincronizacion where ID = " + sincronizacion_ID);
                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        //la vega consulta al hosting por nuevos registros
        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaPorSincronizacionCategoria();
            this.ConsultaPorSincronizacionProducto();
            ConsultaPorSincronizacionProductoListaPrecios();
            ConsultaPorSincronizacionPrecioVolumen();
            ConsultaPorSincronizacionClienteProveedor();
            ConsultaPorSincronizacionPrecioCliente();
            ConsultaPorSincronizacionUsuario();
        }

        private void ConsultaPorSincronizacionPrecioCliente()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionPrecioClienteJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<Precio_por_clienteJSON> arrPrecioCliente = new List<Precio_por_clienteJSON>();
                arrPrecioCliente = JsonConvert.DeserializeObject<List<Precio_por_clienteJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrPrecioCliente != null)
                {
                    foreach (Precio_por_clienteJSON precioClienteJSON in arrPrecioCliente)
                    {
                        if (precioClienteJSON.f98 == "eliminar")
                        {
                            CtrlPrecio_por_cliente.eliminar(Utils.cint(precioClienteJSON.getID()));
                        }
                        else if (precioClienteJSON.f98 == "ingresar")
                        {
                            if (ExistePrecioCliente(Utils.cint(precioClienteJSON.f0)))
                            {
                                CtrlPrecio_por_cliente.actualizarJSON(precioClienteJSON);
                            }
                            else
                            {
                                CtrlPrecio_por_cliente.guardarJSON(precioClienteJSON);
                            }
                            CtrlSincronizar_tablet.guardar("ingresar", "precio_por_cliente", Utils.cint(precioClienteJSON.getID()));
                        }
                        arrIDS.Add(precioClienteJSON.f99);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExistePrecioCliente(int precio_por_cliente_ID)
        {
            Precio_por_cliente objPrecioCliente = CtrlPrecio_por_cliente.getPrecio_por_cliente(precio_por_cliente_ID);
            if (objPrecioCliente.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionUsuario()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionUsuarioJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<UsuarioJSON> arrUsuario = new List<UsuarioJSON>();
                arrUsuario = JsonConvert.DeserializeObject<List<UsuarioJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrUsuario != null)
                {
                    foreach (UsuarioJSON UsuarioJSON in arrUsuario)
                    {
                        if (UsuarioJSON.f98 == "eliminar")
                        {
                            CtrlUsuario.eliminar(UsuarioJSON.getID());
                        }
                        else if (UsuarioJSON.f98 == "ingresar")
                        {
                            if (ExisteUsuario(UsuarioJSON.f0))
                            {
                                CtrlUsuario.actualizarJSON(UsuarioJSON);
                            }
                            else
                            {
                                CtrlUsuario.guardarJSON(UsuarioJSON);
                            }
                            CtrlSincronizar_tablet_usuario.registraCambioTablets(UsuarioJSON.getID());
                        }
                        arrIDS.Add(UsuarioJSON.f99);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteUsuario(int usuario_ID)
        {
            Usuario objUsuario = CtrlUsuario.getUsuario(usuario_ID);
            if (objUsuario.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionClienteProveedor()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionClienteProveedorJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<Cliente_proveedorJSON> arrClienteProveedor = new List<Cliente_proveedorJSON>();
                arrClienteProveedor = JsonConvert.DeserializeObject<List<Cliente_proveedorJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrClienteProveedor != null)
                {
                    foreach (Cliente_proveedorJSON clienteProveedorJSON in arrClienteProveedor)
                    {
                        if (clienteProveedorJSON.f98 == "eliminar")
                        {
                            CtrlCliente_proveedor.eliminar(clienteProveedorJSON.getID());
                        }
                        else if (clienteProveedorJSON.f98 == "ingresar")
                        {
                            if (ExisteClienteProveedor(clienteProveedorJSON.f0))
                            {
                                CtrlCliente_proveedor.actualizarJSON(clienteProveedorJSON);
                            }
                            else
                            {
                                CtrlCliente_proveedor.guardarJSON(clienteProveedorJSON);
                            }
                        }
                        arrIDS.Add(clienteProveedorJSON.f99);
                        CtrlSincroniza_tablet_cliente.guardar(clienteProveedorJSON.getID(), "ingresar");
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteClienteProveedor(int cliente_proveedor_ID)
        {
            Cliente_proveedor objclienteProveedor = CtrlCliente_proveedor.getCliente_proveedor(cliente_proveedor_ID);
            if (objclienteProveedor.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionProducto()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionProductoJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {
                bool error_sincronizacion = false;
                List<ProductoJSON> arrProductos = new List<ProductoJSON>();
                arrProductos = JsonConvert.DeserializeObject<List<ProductoJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                int auxProducto_ID = 0;
                String arrJSON = "";
                if (arrProductos != null)
                {
                    foreach (ProductoJSON prodJSON in arrProductos)
                    {
                        Producto objProducto = new Producto(prodJSON);
                        if (prodJSON.f98 == "eliminar")
                        {
                            objProducto.festado = 2;
                            CtrlProducto.actualizar(objProducto);

                        }
                        else if (prodJSON.f98 == "ingresar")
                        {
                            if (ExisteProducto(prodJSON.f0))
                            {
                                CtrlProducto.actualizar(objProducto);
                                String query_directa = "UPDATE bodega_producto SET cantidad=" + objProducto.fstock_actual.ToString() + " WHERE bodega_ID=2 and producto_ID=" + objProducto.fID.ToString();
                                BDConnect.EjecutaSinRetorno(query_directa);
                            }
                            else
                            {
                                auxProducto_ID = CtrlProducto.guardar(objProducto);
                                if (auxProducto_ID == 0)
                                {
                                    error_sincronizacion = true;
                                    break;
                                }
                            }
                            CtrlSincronizar_tablet_producto.registraCambioTablets(objProducto.fID, "ingresar");
                        }
                        arrIDS.Add(prodJSON.f99);

                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    if (!error_sincronizacion)
                    {
                        arrJSON = JsonConvert.SerializeObject(arrIDS);
                        resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                    }

                }
            }

        }
        private bool ExisteProducto(int producto_ID)
        {
            Producto objproducto = CtrlProducto.getProducto(producto_ID);
            if (objproducto.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionCategoria()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionCategoriaJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<CategoriaJSON> arrCategoria = new List<CategoriaJSON>();
                arrCategoria = JsonConvert.DeserializeObject<List<CategoriaJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrCategoria != null)
                {
                    foreach (CategoriaJSON catJSON in arrCategoria)
                    {

                        if (catJSON.f98 == "eliminar")
                        {
                            CtrlCategoria.eliminar(catJSON.getID());
                        }
                        else if (catJSON.f98 == "ingresar")
                        {
                            if (ExisteCategoria(catJSON.f0))
                            {
                                CtrlCategoria.actualizarJSON(catJSON);
                            }
                            else
                            {
                                CtrlCategoria.guardarJSON(catJSON);
                            }
                            CtrlSincronizar_tablet_categoria.registraCambioTablets(catJSON.getID());
                        }
                        arrIDS.Add(catJSON.f99);

                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }
        private bool ExisteCategoria(int categoria_ID)
        {
            Categoria objCategoria = CtrlCategoria.getCategoria(categoria_ID);
            if (objCategoria.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionProductoListaPrecios()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionProductoJoinListaPrecioJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<Producto_join_lista_preciosJSON> arrProductosListaPrecio = new List<Producto_join_lista_preciosJSON>();
                arrProductosListaPrecio = JsonConvert.DeserializeObject<List<Producto_join_lista_preciosJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrProductosListaPrecio != null)
                {
                    foreach (Producto_join_lista_preciosJSON lista_precioJSON in arrProductosListaPrecio)
                    {

                        if (lista_precioJSON.f98 == "eliminar")
                        {
                            CtrlProducto_join_lista_precios.eliminar(lista_precioJSON.f0);
                        }
                        else if (lista_precioJSON.f98 == "ingresar")
                        {
                            if (ExisteProductoListaPrecio(lista_precioJSON.f0))
                            {
                                CtrlProducto_join_lista_precios.actualizarJSON(lista_precioJSON);
                            }
                            else
                            {
                                CtrlProducto_join_lista_precios.guardarJSON(lista_precioJSON);
                            }
                            CtrlSincronizar_tablet_producto_join_lista_precios.guardar("ingresar", lista_precioJSON.getID());
                        }
                        arrIDS.Add(lista_precioJSON.f99);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteProductoListaPrecio(int producto_join_lista_precios_ID)
        {
            Producto_join_lista_precios objproductoListaPrecio = CtrlProducto_join_lista_precios.getProducto_join_lista_precios(producto_join_lista_precios_ID);
            if (objproductoListaPrecio.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionPrecioVolumen()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionPrecioVolumenJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {

                List<Precio_por_volumenJSON> arrProductosListaPrecio = new List<Precio_por_volumenJSON>();
                arrProductosListaPrecio = JsonConvert.DeserializeObject<List<Precio_por_volumenJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrProductosListaPrecio != null)
                {
                    foreach (Precio_por_volumenJSON precJSON in arrProductosListaPrecio)
                    {

                        if (precJSON.f98 == "eliminar")
                        {
                            CtrlPrecio_por_volumen.eliminar(precJSON.f0);
                        }
                        else if (precJSON.f98 == "ingresar")
                        {
                            if (ExistePrecioVolumen(precJSON.f0))
                            {
                                CtrlPrecio_por_volumen.actualizarJSON(precJSON);
                            }
                            else
                            {
                                CtrlPrecio_por_volumen.guardarJSON(precJSON);
                            }
                            CtrlSincronizar_tablet.guardar("ingresar", "precio_por_volumen", precJSON.getID());

                        }
                        arrIDS.Add(precJSON.f99);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExistePrecioVolumen(int precio_volumen_ID)
        {
            Precio_por_volumen objPrecioVolumen = CtrlPrecio_por_volumen.getPrecio_por_volumen(precio_volumen_ID);
            if (objPrecioVolumen.fID > 0)
            {
                return true;
            }
            return false;

        }

        //sincronizacion documento de venta enviado desde la vega alacasa matriz
        private void ConsultaSincronizacionDocumentoVenta()
        {
            try
            {
                Query query = new Query("sincronizacion");
                extDataSet dset = BDConnect.EjecutaConRetorno(query.listo());
                if (dset.tieneDatos())
                {

                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        int sincronizacion_ID = int.Parse(fila["ID"].ToString());
                        ConsultaRegistrosSincronizacionDocumentoVenta(sincronizacion_ID);
                    }


                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        private void ConsultaRegistrosSincronizacionDocumentoVenta(int sincronizacion_ID)
        {
            try
            {
                Query query = new Query("sincronizacion_registro");
                query.AddWhere("sincronizacion_ID", sincronizacion_ID.ToString());
                query.AddWhere("tabla", "documento_venta");

                string query_listo = query.listo();
                extDataSet dset = BDConnect.EjecutaConRetorno(query_listo);
                if (dset.tieneDatos())
                {
                    int registro_ID = 0;
                    ArrayList arrDocumentoVentasJSON = new ArrayList();
                    ArrayList arrDocumentoVentasSincronizacionIDs = new ArrayList();
                    ArrayList arrDetalleDocumentoVentaJSON = new ArrayList();
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        registro_ID = int.Parse(fila["registro_ID"].ToString());
                        arrDocumentoVentasSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                        query = new Query("documento_venta");
                        query.AddWhere("ID", registro_ID.ToString());
                        query_listo = query.listo();

                        extDataSet dsetDocumentoVenta = BDConnect.EjecutaConRetorno(query_listo);
                        if (dsetDocumentoVenta.tieneDatos())
                        {
                            DataRow filaDocumentoVenta = dsetDocumentoVenta.Tables[0].Rows[0];
                            int servidor_ID = this.GetServidorID();
                            Documento_ventaJSON objDocumentoVentaJson = new Documento_ventaJSON(filaDocumentoVenta, servidor_ID, fila["accion"].ToString());
                            arrDocumentoVentasJSON.Add(objDocumentoVentaJson);

                            query = new Query("detalle_documento_venta");
                            query.AddWhere("documento_venta_ID", filaDocumentoVenta["ID"].ToString());
                            query_listo = query.listo();
                            extDataSet dsetDetalleDocVenta = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetDetalleDocVenta.tieneDatos())
                            {
                                foreach (DataRow fila_detalledocventa in dsetDetalleDocVenta.Tables[0].Rows)
                                {
                                    Detalle_documento_ventaJSON objDetalleDocVentaJSON = new Detalle_documento_ventaJSON(fila_detalledocventa);
                                    arrDetalleDocumentoVentaJSON.Add(objDetalleDocVentaJSON);
                                }
                            }
                        }
                    }
                    String DocVentasJson = "";
                    String DetalleDocVentasJSON = "";
                    if (arrDocumentoVentasJSON.Count > 0)
                    {
                        DocVentasJson = JsonConvert.SerializeObject(arrDocumentoVentasJSON);
                        DetalleDocVentasJSON = JsonConvert.SerializeObject(arrDetalleDocumentoVentaJSON);
                        string resultado = WebServiceComm.ingresaDocumentoVentaSincronizacionJSON(DocVentasJson, DetalleDocVentasJSON);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrDocumentoVentasSincronizacionIDs, sincronizacion_ID);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }

        //sincronizacion de ventas :D

        private void button3_Click(object sender, EventArgs e)
        {
            this.ConsultaSincronizacionVentas();
        }

        private void ConsultaSincronizacionVentas()
        {
            try
            {
                Query query = new Query("sincronizacion");
                extDataSet dset = BDConnect.EjecutaConRetorno(query.listo());
                if (dset.tieneDatos())
                {

                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        int sincronizacion_ID = int.Parse(fila["ID"].ToString());
                        ConsultaRegistrosSincronizacionVentas(sincronizacion_ID);
                    }


                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        private void ConsultaRegistrosSincronizacionVentas(int sincronizacion_ID)
        {
            try
            {
                Query query = new Query("sincronizacion_registro");
                query.AddWhereExacto("sincronizacion_ID", sincronizacion_ID.ToString());
                query.AddWhere("tabla", "venta");

                string query_listo = query.listo();
                extDataSet dset = BDConnect.EjecutaConRetorno(query_listo);
                if (dset.tieneDatos())
                {
                    int registro_ID = 0;
                    ArrayList arrVentasJSON = new ArrayList();
                    ArrayList arrVentasSincronizacionIDs = new ArrayList();
                    ArrayList arrDetalleVentasJSON = new ArrayList();
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        registro_ID = int.Parse(fila["registro_ID"].ToString());
                        arrVentasSincronizacionIDs.Add(Utils.cint(fila["ID"].ToString()));
                        query = new Query("venta");
                        query.AddWhere("ID", registro_ID.ToString());
                        query_listo = query.listo();

                        extDataSet dsetVenta = BDConnect.EjecutaConRetorno(query_listo);
                        if (dsetVenta.tieneDatos())
                        {
                            DataRow filaVenta = dsetVenta.Tables[0].Rows[0];
                            int servidor_ID = this.GetServidorID();
                            VentaJSON objVentaJson = new VentaJSON(filaVenta, servidor_ID, fila["accion"].ToString());
                            arrVentasJSON.Add(objVentaJson);

                            query = new Query("detalle_venta");
                            query.AddWhere("venta_ID", filaVenta["ID"].ToString());
                            query_listo = query.listo();
                            extDataSet dsetDetalleVenta = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetDetalleVenta.tieneDatos())
                            {
                                foreach (DataRow fila_detalle_venta in dsetDetalleVenta.Tables[0].Rows)
                                {
                                    Detalle_ventaJSON objDetalleVentaJSON = new Detalle_ventaJSON(fila_detalle_venta);
                                    arrDetalleVentasJSON.Add(objDetalleVentaJSON);
                                }
                            }
                        }
                    }
                    String VentasJson = "";
                    String DetalleVentasJSON = "";
                    if (arrVentasJSON.Count > 0)
                    {
                        VentasJson = JsonConvert.SerializeObject(arrVentasJSON);
                        DetalleVentasJSON = JsonConvert.SerializeObject(arrDetalleVentasJSON);
                        string resultado = WebServiceComm.ingresaVentasSincronizacionJSON(VentasJson, DetalleVentasJSON);
                        if (!(resultado == "error_conexion"))
                        {
                            this.EliminaRegistrosSincronizados(arrVentasSincronizacionIDs, sincronizacion_ID);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }


        //peticion de ventas al hosting
        private void button4_Click(object sender, EventArgs e)
        {
            this.ConsultaPorSincronizacionVenta();
        }



        private void ConsultaPorSincronizacionVenta()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionVentaJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {
                List<VentaJSON> arrVentas = new List<VentaJSON>();
                arrVentas = JsonConvert.DeserializeObject<List<VentaJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrVentas != null)
                {
                    foreach (VentaJSON ventaJSON in arrVentas)
                    {
                        //Venta objProducto = new Venta(prodJSON);
                        if (ventaJSON.f32 == "eliminar")
                        {

                        }
                        else if (ventaJSON.f32 == "ingresar")
                        {
                            //if (ExisteVenta(ventaJSON.f0))
                            //{
                            //    CtrlVenta.actualizarJSON(ventaJSON);
                            //}
                            //else
                            //{
                            CtrlVenta.guardarJSON(ventaJSON);
                            //}
                        }
                        arrIDS.Add(ventaJSON.f31);

                        resultado = WebServiceComm.getDatosSincronizacionDetalleVentaJSON(int.Parse(ventaJSON.f0));

                        List<Detalle_ventaJSON> arrDetalleVentas = new List<Detalle_ventaJSON>();
                        arrDetalleVentas = JsonConvert.DeserializeObject<List<Detalle_ventaJSON>>(resultado);
                        if (arrDetalleVentas != null)
                        {
                            foreach (Detalle_ventaJSON detalle_ventaJSON in arrDetalleVentas)
                            {
                                if (ventaJSON.f32 == "eliminar")
                                {

                                }
                                else if (ventaJSON.f32 == "ingresar")
                                {
                                    //if (ExisteDetalleVenta(detalle_ventaJSON.f0))
                                    //{
                                    //    CtrlDetalle_venta.actualizarJSON(detalle_ventaJSON);
                                    //}
                                    //else
                                    //{
                                    CtrlDetalle_venta.guardarJSON(detalle_ventaJSON);
                                    //}
                                    ActualizaStockProducto(detalle_ventaJSON.getProducto_ID(), Utils.cint(detalle_ventaJSON.getCantidad()));
                                }

                            }
                        }


                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteVenta(string venta_ID)
        {
            Venta objVenta = CtrlVenta.getVenta(int.Parse(venta_ID));
            if (objVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionDocumentoVenta()
        {
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionDocumentoVentaJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {
                List<Documento_ventaJSON> arrDocumentoVenta = new List<Documento_ventaJSON>();
                arrDocumentoVenta = JsonConvert.DeserializeObject<List<Documento_ventaJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrDocumentoVenta != null)
                {
                    foreach (Documento_ventaJSON DocumentoventaJSON in arrDocumentoVenta)
                    {
                        //Venta objProducto = new Venta(prodJSON);
                        if (DocumentoventaJSON.f31 == "eliminar")
                        {

                        }
                        else if (DocumentoventaJSON.f31 == "ingresar")
                        {
                            if (ExisteDocumentoVenta(DocumentoventaJSON.f0))
                            {
                                CtrlDocumento_venta.actualizarJSON(DocumentoventaJSON);
                            }
                            else
                            {
                                CtrlDocumento_venta.guardarJSON(DocumentoventaJSON);
                            }
                        }
                        arrIDS.Add(DocumentoventaJSON.f30);

                        resultado = WebServiceComm.getDatosSincronizacionDetalleDocumentoVentaJSON(DocumentoventaJSON.f0);

                        List<Detalle_documento_ventaJSON> arrDetalleDocumentoVentas = new List<Detalle_documento_ventaJSON>();
                        arrDetalleDocumentoVentas = JsonConvert.DeserializeObject<List<Detalle_documento_ventaJSON>>(resultado);
                        if (arrDetalleDocumentoVentas != null)
                        {
                            foreach (Detalle_documento_ventaJSON detalle_documento_ventaJSON in arrDetalleDocumentoVentas)
                            {
                                if (DocumentoventaJSON.f31 == "eliminar")
                                {

                                }
                                else if (DocumentoventaJSON.f31 == "ingresar")
                                {
                                    if (ExisteDetalleDocumentoVenta(detalle_documento_ventaJSON.f0))
                                    {
                                        CtrlDetalle_documento_venta.actualizarJSON(detalle_documento_ventaJSON);
                                    }
                                    else
                                    {
                                        CtrlDetalle_documento_venta.guardarJSON(detalle_documento_ventaJSON);
                                    }

                                }

                            }
                        }


                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteDocumentoVenta(int documento_venta_ID)
        {
            Documento_venta objDocumentoVenta = CtrlDocumento_venta.getDocumento_venta(documento_venta_ID);
            if (objDocumentoVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ConsultaPorSincronizacionDocumentoCompra()
        {
            //TODO: aqui se debe cambiar documento_venta por documento_compra
            int servidor_ID = GetServidorID();
            string resultado = WebServiceComm.getDatosSincronizacionDocumentoVentaJSON(servidor_ID);

            if (!(resultado == "error_conexion"))
            {
                List<Documento_ventaJSON> arrDocumentoVenta = new List<Documento_ventaJSON>();
                arrDocumentoVenta = JsonConvert.DeserializeObject<List<Documento_ventaJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrDocumentoVenta != null)
                {
                    int nuevo_ID = 0;
                    Documento_compra facturaCompra;
                    foreach (Documento_ventaJSON DocumentoventaJSON in arrDocumentoVenta)
                    {
                        facturaCompra = new Documento_compra();
                        //Venta objProducto = new Venta(prodJSON);
                        if (DocumentoventaJSON.f31 == "eliminar")
                        {

                        }
                        else if (DocumentoventaJSON.f31 == "ingresar")
                        {

                            if (ExisteDocumentoVenta(DocumentoventaJSON.f0))
                            {
                                CtrlDocumento_venta.actualizarJSON(DocumentoventaJSON);
                            }
                            else
                            {

                                facturaCompra.festado = 1;
                                facturaCompra.ffecha_digitacion = DateTime.Parse(DocumentoventaJSON.getFecha_digitacion());
                                facturaCompra.ffecha_documento = DateTime.Parse(DocumentoventaJSON.getFecha_documento());
                                facturaCompra.ffecha_vencimiento = DateTime.Parse(DocumentoventaJSON.getFecha_vencimiento());
                                facturaCompra.fforma_pago_ID = DocumentoventaJSON.getForma_pago_ID();
                                facturaCompra.fproveedor_ID = 2;
                                facturaCompra.fsucursal_ID = 2;
                                facturaCompra.fnumero = DocumentoventaJSON.getNumero().ToString();
                                facturaCompra.ftipo_documento_ID = 1;
                                facturaCompra.ftotal_bruto = DocumentoventaJSON.getTotal_bruto();
                                facturaCompra.ftotal_iva = DocumentoventaJSON.getTotal_iva();
                                facturaCompra.ftotal_neto = DocumentoventaJSON.getTotal_neto();
                                facturaCompra.ftotal_pagos = DocumentoventaJSON.getTotal_pagos();
                                facturaCompra.ftotal_saldo = DocumentoventaJSON.getTotal_saldo();
                                facturaCompra.fID = facturaCompra.guardar();


                                //nuevo_ID=CtrlDocumento_venta.guardarJSON(DocumentoventaJSON);
                            }
                        }
                        arrIDS.Add(DocumentoventaJSON.f30);

                        resultado = WebServiceComm.getDatosSincronizacionDetalleDocumentoVentaJSON(DocumentoventaJSON.f0);

                        List<Detalle_documento_ventaJSON> arrDetalleDocumentoVentas = new List<Detalle_documento_ventaJSON>();
                        arrDetalleDocumentoVentas = JsonConvert.DeserializeObject<List<Detalle_documento_ventaJSON>>(resultado);
                        if (arrDetalleDocumentoVentas != null)
                        {
                            foreach (Detalle_documento_ventaJSON detalle_documento_ventaJSON in arrDetalleDocumentoVentas)
                            {
                                if (DocumentoventaJSON.f31 == "eliminar")
                                {

                                }
                                else if (DocumentoventaJSON.f31 == "ingresar")
                                {
                                    if (ExisteDetalleDocumentoVenta(detalle_documento_ventaJSON.f0))
                                    {
                                        CtrlDetalle_documento_venta.actualizarJSON(detalle_documento_ventaJSON);
                                    }
                                    else
                                    {
                                        Detalle_documento_compra detCompra = new Detalle_documento_compra();
                                        detCompra.fcantidad = detalle_documento_ventaJSON.getCantidad();
                                        detCompra.fdocumento_compra_ID = facturaCompra.fID;
                                        detCompra.festado = detalle_documento_ventaJSON.getEstado();
                                        detCompra.fiva = detalle_documento_ventaJSON.getIva();
                                        detCompra.fprecio_neto_unitario = detalle_documento_ventaJSON.getPrecio_neto_unitario();
                                        detCompra.fprecio_neto_unitario_factura = detalle_documento_ventaJSON.getPrecio_neto_unitario();
                                        detCompra.fproducto_ID = detalle_documento_ventaJSON.getProducto_ID();
                                        detCompra.ftotal_bruto = detalle_documento_ventaJSON.getTotal_bruto();
                                        detCompra.ftotal_neto = detalle_documento_ventaJSON.getTotal_neto();
                                        detCompra.guardar();


                                        //detalle_documento_ventaJSON.setDocumento_venta_ID(nuevo_ID);
                                        //CtrlDetalle_documento_venta.guardarJSON(detalle_documento_ventaJSON);
                                    }

                                }

                            }
                        }


                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private void ActualizaStockProducto(string producto_ID, int cantidad)
        {
            string query = "update bodega_producto set cantidad = (cantidad - " + cantidad + ") where bodega_ID = 2 and producto_ID = " + producto_ID;
            BDConnect.EjecutaSinRetorno(query);
        }

        private bool ExisteDetalleVenta(string detalle_venta_ID)
        {
            Detalle_venta objDetalleVenta = CtrlDetalle_venta.getDetalle_venta(int.Parse(detalle_venta_ID));
            if (objDetalleVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private bool ExisteDetalleDocumentoVenta(int detalle_documento_venta_ID)
        {
            Detalle_documento_venta objDetalleDocumentoVenta = CtrlDetalle_documento_venta.getDetalle_documento_venta(detalle_documento_venta_ID);
            if (objDetalleDocumentoVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkActivarCasaMatriz.Checked)
            {
                ConsultaSincronizacion();
                this.ConsultaPorSincronizacionVenta();
                this.ConsultaPorSincronizacionDocumentoVenta();
                //Utils.EscribeLog("consultado CM");

                //envia los documentos de venta hacia el hosting
                this.ConsultaSincronizacionDocumentoVenta();
            }
            else if (checkVega.Checked)
            {
                this.ConsultaSincronizacionVentas();
                this.ConsultaSincronizacionDocumentoVenta();

                //trae los documentos de venta desde el hosting
                this.ConsultaPorSincronizacionDocumentoCompra();

                ConsultaPorSincronizacionCategoria();
                this.ConsultaPorSincronizacionProducto();
                ConsultaPorSincronizacionProductoListaPrecios();
                ConsultaPorSincronizacionPrecioVolumen();
                ConsultaPorSincronizacionClienteProveedor();
                ConsultaPorSincronizacionPrecioCliente();
                ConsultaPorSincronizacionUsuario();
                //Utils.EscribeLog("consultado La Vega");
            }
        }

        private void checkVega_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkActivarCasaMatriz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}