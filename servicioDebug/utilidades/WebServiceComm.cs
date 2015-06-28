using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Collections;
using utilidadesQuerytor;
using MSXML2;
using System.Xml;
using System.Data.SqlClient;
using System.IO.Compression;
using System.Net;

namespace utilidades
{
    static public class WebServiceComm
    {
        static System.Configuration.AppSettingsReader conf = new System.Configuration.AppSettingsReader();
        static string host = conf.GetValue("SERVIDORBD_HOSTING", System.Type.GetType("System.String")).ToString();//"127.0.0.1";
        static string encoding = "utf-8";


        static public string getDatosSincronizacionVentaJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionVentaJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionVentaJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionDocumentoVentaJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionDocumentoVentaJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionDocumentoVentaJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionDetalleVentaJSON(int venta_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionDetalleVentaJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <venta_ID xsi:type=""xsd:string""><![CDATA[" + venta_ID + @"]]></venta_ID>
      </mys:getDatosSincronizacionDetalleVentaJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionDetalleDocumentoVentaJSON(int documento_venta_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionDetalleDocumentoVentaJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <venta_ID xsi:type=""xsd:string""><![CDATA[" + documento_venta_ID + @"]]></venta_ID>
      </mys:getDatosSincronizacionDetalleDocumentoVentaJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaCategoriaSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaCategoriaSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaCategoriaSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaClienteProveedorSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaClienteProveedorSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaClienteProveedorSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaPrecioClienteSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaPrecioClienteSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaPrecioClienteSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaUsuarioSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaUsuarioSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaUsuarioSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaProductoSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaProductoSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaProductoSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaProductoJoinListaPreciosSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaProductoJoinListaPreciosSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaProductoJoinListaPreciosSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaPrecioVolumenSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaPrecioVolumenSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:ingresaPrecioVolumenSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionCategoriaJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionCategoriaJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionCategoriaJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionProductoJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionProductoJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionProductoJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionClienteProveedorJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionClienteProveedorJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionClienteProveedorJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionPrecioClienteJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionPrecioClienteJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionPrecioClienteJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionUsuarioJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionUsuarioJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionUsuarioJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionProductoJoinListaPrecioJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionProductoJoinListaPrecioJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionProductoJoinListaPrecioJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string getDatosSincronizacionPrecioVolumenJSON(int servidor_ID)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:getDatosSincronizacionPrecioVolumenJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <servidor_ID xsi:type=""xsd:string""><![CDATA[" + servidor_ID + @"]]></servidor_ID>
      </mys:getDatosSincronizacionPrecioVolumenJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string EliminaRegistroSincronizacionJSON(string arreglo_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:EliminaRegistroSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arreglo_json xsi:type=""xsd:string""><![CDATA[" + arreglo_json + @"]]></arreglo_json>
      </mys:EliminaRegistroSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaVentasSincronizacionJSON(string arr_ventas_json, string arr_detalle_ventas_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaVentasSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arr_ventas_json xsi:type=""xsd:string""><![CDATA[" + arr_ventas_json + @"]]></arr_ventas_json>
        <arr_detalle_ventas_json xsi:type=""xsd:string""><![CDATA[" + arr_detalle_ventas_json + @"]]></arr_detalle_ventas_json>
      </mys:ingresaVentasSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }

        static public string ingresaDocumentoVentaSincronizacionJSON(string arr_docventas_json, string arr_docdetalle_ventas_json)
        {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();
                string soap = @"<soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mys=""MyServicePHP"">
   <soapenv:Header/>
   <soapenv:Body>
      <mys:ingresaDocumentoVentaSincronizacionJSON soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
        <arr_docventas_json xsi:type=""xsd:string""><![CDATA[" + arr_docventas_json + @"]]></arr_docventas_json>
        <arr_docdetalle_ventas_json xsi:type=""xsd:string""><![CDATA[" + arr_docdetalle_ventas_json + @"]]></arr_docdetalle_ventas_json>
      </mys:ingresaDocumentoVentaSincronizacionJSON>
   </soapenv:Body>
</soapenv:Envelope>";


                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(host);
                req.Headers.Add("Accept-Encoding", "gzip");
                req.Headers.Add("SOAPAction", "http://tempuri.org/getRecordValue");
                req.ContentType = "text/xml;charset=\"" + encoding + "";
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

                xmlDoc.LoadXml(result);
                //string temp= xmlDoc.LastChild.InnerText;

                //xmlDoc.ge
                return xmlDoc.LastChild.InnerText;// result;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return "error_conexion";
            }
        }


        static public string SanitizeXmlString(string xml)
        {
            //if (xml == null)
            //{
            //throw new ArgumentNullException("xml");
            StringBuilder buffer = new StringBuilder(xml.Length);
            foreach (char c in xml)
            {
                if (IsLegalXmlChar(c))
                {
                    buffer.Append(c);
                }
            }
            return buffer.ToString();

            //}
        }
        static public bool IsLegalXmlChar(int character)
        {
            return
            (
                 character == 0x9 /* == '\t' == 9   */          ||
                 character == 0xA /* == '\n' == 10  */          ||
                 character == 0xD /* == '\r' == 13  */          ||
                (character >= 0x20 && character <= 0xD7FF) ||
                (character >= 0xE000 && character <= 0xFFFD) ||
                (character >= 0x10000 && character <= 0x10FFFF)
            );

        }

    }
}
