using System;
using System.Collections;
using System.Data;
using utilidades;
using querytor;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using System.IO.Compression;
using System.Net;
namespace utilidades
{
    static public class CtrlSincroniza_tablet_cliente
    {
        public static Sincroniza_tablet_cliente[] getListado(Query query)
        {
            try
            {
                //query.AddWhereExacto(ST_Sincroniza_tablet_cliente.estado_vigente, "vigente");
                DataSet dataset = FachadaSincroniza_tablet_cliente.getListado(query);
                Sincroniza_tablet_cliente[] arrsincroniza_tablet_cliente = new Sincroniza_tablet_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincroniza_tablet_cliente objeto = new Sincroniza_tablet_cliente(fila);
                        arrsincroniza_tablet_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincroniza_tablet_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincroniza_tablet_cliente[] getListado(string query)
        {
            try
            {
                DataSet dataset = FachadaSincroniza_tablet_cliente.getListado(query);
                Sincroniza_tablet_cliente[] arrsincroniza_tablet_cliente = new Sincroniza_tablet_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincroniza_tablet_cliente objeto = new Sincroniza_tablet_cliente(fila);
                        arrsincroniza_tablet_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincroniza_tablet_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static Sincroniza_tablet_cliente[] getListadoPorWhere(string where)
        {
            try
            {
                string[] arrString = where.Split('=');
                Query query = new Query("select", "sincroniza_tablet_cliente");
                query.AddWhere(arrString[0], arrString[1]);
                query.AddSelect("*");
                DataSet dataset = FachadaSincroniza_tablet_cliente.getListado(query);
                Sincroniza_tablet_cliente[] arrsincroniza_tablet_cliente = new Sincroniza_tablet_cliente[dataset.Tables[0].Rows.Count];
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        Sincroniza_tablet_cliente objeto = new Sincroniza_tablet_cliente(fila);
                        arrsincroniza_tablet_cliente[contador] = objeto;
                        contador++;
                    }
                }
                return arrsincroniza_tablet_cliente;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }

        }
        public static int guardar(Sincroniza_tablet_cliente objeto)
        {
            try
            {
                return FachadaSincroniza_tablet_cliente.guardar(objeto);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return 0;
            }
        }
        public static void guardar(int cliente_ID, string accion)
        {
            Query query = new Query("tablet");
            Tablet[] arrTablet = CtrlTablet.getListado(query);
            Sincroniza_tablet_cliente sincroniza;
            string querys = "";
            foreach (Tablet tablet in arrTablet)
            {
                sincroniza = new Sincroniza_tablet_cliente();
                sincroniza.fcliente_proveedor_ID = cliente_ID;
                sincroniza.ftablet_ID = tablet.fID;
                sincroniza.faccion = accion;

                sincroniza.guardar();

            }
            BDConnect.EjecutaSinRetorno(querys);

        }
        public static void actualizar(Sincroniza_tablet_cliente objeto)
        {
            try
            {
                FachadaSincroniza_tablet_cliente.actualizar(objeto);
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
                FachadaSincroniza_tablet_cliente.eliminar(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static void eliminar(int ID)
        {
            try
            {
                Query query = new Query("delete", "Sincroniza_tablet_cliente");
                query.AddWhere("ID", ID.ToString());
                FachadaSincroniza_tablet_cliente.eliminar(query);
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
                FachadaSincroniza_tablet_cliente.ejecutaSin_retorno(query);
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
            }
        }
        public static Sincroniza_tablet_cliente getSincroniza_tablet_cliente(int id)
        {
            try
            {
                Query query = new Query("select", "Sincroniza_tablet_cliente");
                query.AddWhere("ID", id.ToString());
                query.AddSelect("*");
                Sincroniza_tablet_cliente objeto = new Sincroniza_tablet_cliente();
                DataSet dataset = FachadaSincroniza_tablet_cliente.getListado(query);
                int contador = 0;
                if (dataset != null)
                {
                    foreach (DataRow fila in dataset.Tables[0].Rows)
                    {
                        objeto = new Sincroniza_tablet_cliente(fila);
                        contador++;
                    }
                }
                return objeto;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;
            }
        }
        public static void registraCambioTablets(int cliente_proveedor_ID, string accion)
        {
            //Query query = new Query("tablet");

            //Tablet[] arrTablet = CtrlTablet.getListado(query);
            //Sincroniza_tablet_cliente sincroCliente;
            //foreach (Tablet tablet in arrTablet)
            //{
            //    sincroCliente = new Sincroniza_tablet_cliente();
            //    sincroCliente.fcliente_proveedor_ID = cliente_proveedor_ID;
            //    sincroCliente.ftablet_ID = tablet.fID;
            //    sincroCliente.faccion=accion;
            //    sincroCliente.guardar();

            //}
            try
            {
                string host = Utils.getValorConfig("SERVIDORBD");
                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:registraCambioTablets soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
         <cliente_proveedor_ID xsi:type=""xsd:string"">" + cliente_proveedor_ID + @"</cliente_proveedor_ID>
      </mys:registraCambioTablets>
   </soapenv:Body>
</soapenv:Envelope>";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"utf-8\"";
                req.Accept = "text/xml";
                req.Method = "POST";

                using (Stream stm = req.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(stm))
                    {
                        stmw.Write(soap);
                    }
                }
                WebResponse response = req.GetResponse();
                Stream respStram = response.GetResponseStream();
                string result = "";
                if (response.Headers["Content-Encoding"] != null)
                {
                    if (response.Headers["Content-Encoding"].ToLower() == "gzip")
                    {
                        using (Stream streamGZip = new GZipStream(respStram, CompressionMode.Decompress))
                        {
                            StreamReader reader = new StreamReader(streamGZip);
                            result = reader.ReadToEnd();
                        }

                    }
                    else
                    {
                        StreamReader srd = new StreamReader(response.GetResponseStream());
                        result = srd.ReadToEnd();
                    }
                }
                else
                {
                    StreamReader srd = new StreamReader(response.GetResponseStream());
                    result = srd.ReadToEnd();
                }
                //return result;

            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                //return "error";
            } 

        }

        public static void eliminarClienteTablet(string cliente_ID)
        {
             try
            {
                string host = Utils.getValorConfig("SERVIDORBD");
                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:eliminarClienteTablet soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
         <cliente_ID xsi:type=""xsd:string"">" + cliente_ID + @"</cliente_ID>
      </mys:eliminarClienteTablet>
   </soapenv:Body>
</soapenv:Envelope>";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"utf-8\"";
                req.Accept = "text/xml";
                req.Method = "POST";

                using (Stream stm = req.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(stm))
                    {
                        stmw.Write(soap);
                    }
                }
                WebResponse response = req.GetResponse();
                Stream respStram = response.GetResponseStream();
                string result = "";
                if (response.Headers["Content-Encoding"] != null)
                {
                    if (response.Headers["Content-Encoding"].ToLower() == "gzip")
                    {
                        using (Stream streamGZip = new GZipStream(respStram, CompressionMode.Decompress))
                        {
                            StreamReader reader = new StreamReader(streamGZip);
                            result = reader.ReadToEnd();
                        }

                    }
                    else
                    {
                        StreamReader srd = new StreamReader(response.GetResponseStream());
                        result = srd.ReadToEnd();
                    }
                }
                else
                {
                    StreamReader srd = new StreamReader(response.GetResponseStream());
                    result = srd.ReadToEnd();
                }
                
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
         
            }           
        
        }

        public static string cambiarClienteVendedor(string cliente_ID, string listado_cliente_destino_ID)
        {
            try
            {
                string host = Utils.getValorConfig("SERVIDORBD");
                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:cambiarClienteVendedor soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
         <cliente_ID xsi:type=""xsd:string"">" + cliente_ID + @"</cliente_ID>
         <listado_cliente_destino_ID xsi:type=""xsd:string"">" + listado_cliente_destino_ID + @"</listado_cliente_destino_ID>
      </mys:cambiarClienteVendedor>
   </soapenv:Body>
</soapenv:Envelope>";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"utf-8\"";
                req.Accept = "text/xml";
                req.Method = "POST";

                using (Stream stm = req.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(stm))
                    {
                        stmw.Write(soap);
                    }
                }
                WebResponse response = req.GetResponse();
                Stream respStram = response.GetResponseStream();
                string result = "";
                if (response.Headers["Content-Encoding"] != null)
                {
                    if (response.Headers["Content-Encoding"].ToLower() == "gzip")
                    {
                        using (Stream streamGZip = new GZipStream(respStram, CompressionMode.Decompress))
                        {
                            StreamReader reader = new StreamReader(streamGZip);
                            result = reader.ReadToEnd();
                        }

                    }
                    else
                    {
                        StreamReader srd = new StreamReader(response.GetResponseStream());
                        result = srd.ReadToEnd();
                    }
                }
                else
                {
                    StreamReader srd = new StreamReader(response.GetResponseStream());
                    result = srd.ReadToEnd();
                }
                return result;
                
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error";
            }        
        }
        public static string cambiarListadoClientesDeVendedor(int listado_cliente_ID, int vendedor_destino_ID) {
            try
            {
                string host = Utils.getValorConfig("SERVIDORBD");
                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:cambiarListadoClientesDeVendedor soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
         <listado_cliente_ID xsi:type=""xsd:string"">" + listado_cliente_ID + @"</listado_cliente_ID>
         <vendedor_destino_ID xsi:type=""xsd:string"">" + vendedor_destino_ID + @"</vendedor_destino_ID>
      </mys:cambiarListadoClientesDeVendedor>
   </soapenv:Body>
</soapenv:Envelope>";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"utf-8\"";
                req.Accept = "text/xml";
                req.Method = "POST";

                using (Stream stm = req.GetRequestStream())
                {
                    using (StreamWriter stmw = new StreamWriter(stm))
                    {
                        stmw.Write(soap);
                    }
                }
                WebResponse response = req.GetResponse();
                Stream respStram = response.GetResponseStream();
                string result = "";
                if (response.Headers["Content-Encoding"] != null)
                {
                    if (response.Headers["Content-Encoding"].ToLower() == "gzip")
                    {
                        using (Stream streamGZip = new GZipStream(respStram, CompressionMode.Decompress))
                        {
                            StreamReader reader = new StreamReader(streamGZip);
                            result = reader.ReadToEnd();
                        }

                    }
                    else
                    {
                        StreamReader srd = new StreamReader(response.GetResponseStream());
                        result = srd.ReadToEnd();
                    }
                }
                else
                {
                    StreamReader srd = new StreamReader(response.GetResponseStream());
                    result = srd.ReadToEnd();
                }
                return result;

            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error";
            }
        }

    }
}//Fin name_space
//------------------------------------------------------------------------------
//	FIN CONTROLADOR
//------------------------------------------------------------------------------
