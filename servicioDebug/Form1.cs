using System;
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
                if (dset.tieneDatos())
                {

                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        int sincronizacion_ID = int.Parse(fila["ID"].ToString());
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
                Query query = new Query("sincronizacion_registro");
                query.AddWhere("sincronizacion_ID", sincronizacion_ID.ToString());
                query.AddOrderBy("tabla");
                string query_listo = query.listo();
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
                            arrClienteProveedorIDs.Add(Utils.cint(fila["ID"].ToString()));
                            query = new Query("cliente_proveedor");
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetClienteProveedor = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetClienteProveedor.tieneDatos())
                            {
                                DataRow filaClienteProveedor = dsetClienteProveedor.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                Cliente_proveedorJSON objCategoriaJSON = new Cliente_proveedorJSON(filaClienteProveedor, fila["accion"].ToString(), servidor_ID);
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
                            query.AddWhere("ID", registro_ID.ToString());
                            query_listo = query.listo();

                            extDataSet dsetProducto = BDConnect.EjecutaConRetorno(query_listo);
                            if (dsetProducto.tieneDatos())
                            {
                                DataRow filaProducto = dsetProducto.Tables[0].Rows[0];
                                int servidor_ID = this.GetServidorID();
                                ProductoJSON objProductoJson = new ProductoJSON(filaProducto, fila["accion"].ToString(), servidor_ID);
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
                    if(arrPrecioVolumenJSON.Count > 0)
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
                        if (precioClienteJSON.f6 == "eliminar")
                        {
                            CtrlPrecio_por_cliente.eliminar(precioClienteJSON.getID());
                        }
                        else if (precioClienteJSON.f6 == "ingresar")
                        {
                            if (ExistePrecioCliente(precioClienteJSON.f0))
                            {
                                CtrlPrecio_por_cliente.actualizarJSON(precioClienteJSON);
                            }
                            else
                            {
                                CtrlPrecio_por_cliente.guardarJSON(precioClienteJSON);
                            }
                            CtrlSincronizar_tablet.guardar("ingresar", "precio_por_cliente", precioClienteJSON.getID());
                        }
                        arrIDS.Add(precioClienteJSON.f7);
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
                        if (UsuarioJSON.f10 == "eliminar")
                        {
                            CtrlUsuario.eliminar(UsuarioJSON.getID());
                        }
                        else if (UsuarioJSON.f10 == "ingresar")
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
                        arrIDS.Add(UsuarioJSON.f11);
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
                        if (clienteProveedorJSON.f23 == "eliminar")
                        {
                            CtrlCliente_proveedor.eliminar(clienteProveedorJSON.getID());
                        }
                        else if (clienteProveedorJSON.f23 == "ingresar")
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
                        arrIDS.Add(clienteProveedorJSON.f24);
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

                List<ProductoJSON> arrProductos = new List<ProductoJSON>();
                arrProductos = JsonConvert.DeserializeObject<List<ProductoJSON>>(resultado);
                ArrayList arrIDS = new ArrayList();
                String arrJSON = "";
                if (arrProductos != null)
                {
                    foreach (ProductoJSON prodJSON in arrProductos)
                    {
                        Producto objProducto = new Producto(prodJSON);
                        if (prodJSON.f24 == "eliminar")
                        {
                            objProducto.festado = 2;
                            objProducto.Actualizar();
                        }
                        else if (prodJSON.f24 == "ingresar")
                        {
                            if (ExisteProducto(prodJSON.f0))
                            {
                                objProducto.Actualizar();
                            }
                            else
                            {
                                (new Controlador_Producto()).guardar(objProducto);
                            }
                            CtrlSincronizar_tablet_producto.registraCambioTablets(objProducto.fID, "ingresar");
                        }
                        arrIDS.Add(prodJSON.f25);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }
        private bool ExisteProducto(int producto_ID)
        {
            Producto objproducto = (new Controlador_Producto()).getProducto(producto_ID.ToString());
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
                        
                        if (catJSON.f7 == "eliminar")
                        {
                            CtrlCategoria.eliminar(catJSON.getID());
                        }
                        else if (catJSON.f7 == "ingresar")
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
                        arrIDS.Add(catJSON.f8);
                        
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
                     
                        if (lista_precioJSON.f4 == "eliminar")
                        {
                            CtrlProducto_join_lista_precios.eliminar(lista_precioJSON.f0);
                        }
                        else if (lista_precioJSON.f4 == "ingresar")
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
                        arrIDS.Add(lista_precioJSON.f5);
                    }
                    //eliminar los registros asociados de sincronizacion_registro
                    arrJSON = JsonConvert.SerializeObject(arrIDS);
                    resultado = WebServiceComm.EliminaRegistroSincronizacionJSON(arrJSON);
                }
            }

        }

        private bool ExisteProductoListaPrecio(int producto_join_lista_precios_ID)
        {
            Producto_join_lista_precios objproductoListaPrecio = CtrlProducto_join_lista_precios.getProducto_join_lista_precios(producto_join_lista_precios_ID) ;
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

                        if (precJSON.f6 == "eliminar")
                        {
                            CtrlPrecio_por_volumen.eliminar(precJSON.f0);
                        }
                        else if (precJSON.f6 == "ingresar")
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
                        arrIDS.Add(precJSON.f7);
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
                query.AddWhere("sincronizacion_ID", sincronizacion_ID.ToString());
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
                        if (ventaJSON.f29 == "eliminar")
                        {

                        }
                        else if (ventaJSON.f29 == "ingresar")
                        {
                            if (ExisteVenta(ventaJSON.f0))
                            {
                                CtrlVenta.actualizarJSON(ventaJSON);
                            }
                            else
                            {
                                CtrlVenta.guardarJSON(ventaJSON);
                            }
                        }
                        arrIDS.Add(ventaJSON.f28);

                        resultado = WebServiceComm.getDatosSincronizacionDetalleVentaJSON(ventaJSON.f0);

                        List<Detalle_ventaJSON> arrDetalleVentas = new List<Detalle_ventaJSON>();
                        arrDetalleVentas = JsonConvert.DeserializeObject<List<Detalle_ventaJSON>>(resultado);
                        if (arrDetalleVentas != null)
                        {
                            foreach (Detalle_ventaJSON detalle_ventaJSON in arrDetalleVentas)
                            {
                                if (ventaJSON.f29 == "eliminar")
                                {

                                }
                                else if (ventaJSON.f29 == "ingresar")
                                {
                                    if (ExisteDetalleVenta(detalle_ventaJSON.f0))
                                    {
                                        CtrlDetalle_venta.actualizarJSON(detalle_ventaJSON);
                                    }
                                    else
                                    {
                                        CtrlDetalle_venta.guardarJSON(detalle_ventaJSON);
                                    }
                                    ActualizaStockProducto(detalle_ventaJSON.getProducto_ID(), Utils.cint( detalle_ventaJSON.getCantidad())) ;
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

        private bool ExisteVenta(int venta_ID)
        {
            Venta objVenta = CtrlVenta.getVenta(venta_ID);
            if (objVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void ActualizaStockProducto(int producto_ID, int cantidad) 
        {
            string query = "update bodega_producto set cantidad = (cantidad - " + cantidad + ") where bodega_ID = 2 and producto_ID = " + producto_ID;
            BDConnect.EjecutaSinRetorno(query);
        }

        private bool ExisteDetalleVenta(int detalle_venta_ID)
        {
            Detalle_venta objDetalleVenta = CtrlDetalle_venta.getDetalle_venta(detalle_venta_ID);
            if (objDetalleVenta.fID > 0)
            {
                return true;
            }
            return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkActivarCasaMatriz.Checked)
            {
                ConsultaSincronizacion();
                this.ConsultaPorSincronizacionVenta();
                //Utils.EscribeLog("consultado CM");
            }
            else if(checkVega.Checked)
            {
                this.ConsultaSincronizacionVentas();

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

    }
}
