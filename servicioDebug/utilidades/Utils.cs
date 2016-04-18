using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Net.NetworkInformation;
using querytor;
namespace utilidades
{
    static public class Utils
    {
        public static int cint(string valor)
        {
            if (valor != null)
            {
                if (valor.IndexOf(",") > -1 || valor.IndexOf(".") > -1)
                {
                    if (valor.IndexOf(".") > -1)
                        valor = valor.Replace('.', ',');
                    Double _temp = System.Math.Floor(Double.Parse(valor));
                    valor = _temp.ToString();
                }
                if (valor.IndexOf("$") > -1)
                {
                    return LimpiaMoneda(valor);
                }
                if (valor == "")
                    return 0;
                else
                    return int.Parse(valor);
            }

            return 0;
        }
        public static int cint(decimal valor)
        {
            return int.Parse(valor.ToString());
        }
        public static int cint(double valor)
        {
            double temp = Math.Round(valor, 0, MidpointRounding.AwayFromZero);
            return int.Parse(temp.ToString());
        }
        public static DateTime cdate(string valor)
        {

            if (valor == null || valor == "" || valor == "0000-00-00")
                return DateTime.Parse("1/1/1900");
            else
                return DateTime.Parse(valor);
        }
        public static string cdateConHoraString(DateTime valor)
        {
            string mes = "";
            string dia = "";
            string hora = "";
            string minuto = "";
            string segundos = "";
            if (valor.Month < 10)
                mes = "0" + valor.Month.ToString();
            else
                mes = valor.Month.ToString();

            if (valor.Day < 10)
                dia = "0" + valor.Day.ToString();
            else
                dia = valor.Day.ToString();

            if (valor.Hour < 10)
                hora = "0" + valor.Hour.ToString();
            else
                hora = valor.Hour.ToString();

            if (valor.Minute < 10)
                minuto = "0" + valor.Minute.ToString();
            else
                minuto = valor.Minute.ToString();

            if (valor.Second < 10)
                segundos = "0" + valor.Second.ToString();
            else
                segundos = valor.Second.ToString();

            //return valor.Year + "-" + mes + "-" + dia + " " + hora + ":" + minuto + ":" + segundos;        
            return dia + "-" + mes + "-" + valor.Year.ToString() + " " + hora + ":" + minuto + ":" + segundos;
        }
        public static string cdateBD(DateTime valor)
        {
            string mes = "";
            string dia = "";
            if (valor.Month < 10)
                mes = "0" + valor.Month.ToString();
            else
                mes = valor.Month.ToString();

            if (valor.Day < 10)
                dia = "0" + valor.Day.ToString();
            else
                dia = valor.Day.ToString();
            return valor.Year + "-" + mes + "-" + dia;
        }
        public static string cdateBDString(DateTime valor)
        {
            return cdateBD(valor);
            //string mes = "";
            //if (valor.Month < 10)
            //    mes = "0" + valor.Month.ToString();
            //else
            //    mes = valor.Month.ToString();

            //if (valor.Day < 10)
            //    dia = "0" + valor.Day.ToString();
            //else
            //    dia = valor.Day.ToString();

            //return "'" + valor.Year + "-" + mes + "-" + valor.Day.ToString() + "'";
        }
        public static decimal cdecimal(string valor)
        {

            if (valor == "")
                return 0;
            else
                return decimal.Parse(valor);
        }
        public static double cdouble(string valor)
        {
            valor = valor.Replace(".", ",");
            if (valor == "")
                return 0;
            else
                return double.Parse(valor);
        }
        public static object preparaIU(object objeto)
        {
            return objeto;
            //string valor = "''";
            //if (objeto != null)
            //{
            //    string tipo = objeto.GetType().ToString();

            //    //"System.Int32"
            //    if (tipo == "System.String")
            //        valor = "\"" + objeto.ToString() + "\"";
            //    else if (tipo == "System.DateTime")
            //    {
            //        DateTime fecha = DateTime.Parse(objeto.ToString());
            //        valor = "\"" + fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString() + " " + fecha.Hour.ToString() + ":" + fecha.Minute.ToString() + ":" + fecha.Second.ToString() + "\"";
            //    }
            //    else if (tipo == "System.Double")
            //    {
            //        valor = "\"" + objeto.ToString().Replace(",",".") + "\"";
            //    }
            //    else if (tipo == "System.Decimal")
            //        valor = "\"" + objeto.ToString().Replace(",", ".") + "\"";
            //    else
            //        valor = objeto.ToString();
            //}
            // return valor;
        }
        public static string limpiaQuery(string query)
        {
            if (query.Contains("º"))
                query.Replace("º", "um");

            //query = query.ToLower();//bug 561
            return query;
        }
        public static string hoy()
        {
            return DateTime.Now.ToShortDateString();
        }
        public static int yearProceso()
        {
            return DateTime.Now.Year;
        }
        public static int mesProceso()
        {
            return DateTime.Now.Month;
        }
        public static DateTime fechaProceso()
        {
            DateTime fecha = new DateTime(yearProceso(), mesProceso(), DateTime.Now.Day);
            return fecha;
        }
        //Retorna el IVA como valor decimal
        public static double iva()
        {
            //no funciona.
            //Query query = new Query("select", "impuesto");
            //query.AddWhere(ST_Impuesto.nombre, "iva");
            //Impuesto impuesto = CtrlImpuesto.getListado(query)[0];
            //double resultado = impuesto.fporcentaje / 100;
            return 0.19;
        }
        public static int tipoNotaCredito()
        {
            return 2;
        }
        public static int tipoFacturaCompra()
        {
            return 1;
        }
        public static int tipoNotaDebito()
        {
            return 3;
        }
        public static string formatMoneyDouble(string valor)
        {
            return String.Format("{0:C}", double.Parse(valor));
        }
        public static string formatMoney(string valor)
        {
            if (valor == "")
                valor = "0";
            return String.Format("{0:C}", int.Parse(valor)).Replace(",00", "");
        }
        public static string formatMoney(int valor)
        {
            return String.Format("{0:C}", valor).Replace(",00", "");
        }
        public static bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        public static void achicarPanel(System.Windows.Forms.Panel panel1, System.Windows.Forms.Panel panel2, System.Windows.Forms.Button boton)
        {
            if (boton.Visible)
            {
                boton.Visible = false;
                panel1.Height = panel1.Height - panel2.Height - 10;
                panel2.Location = new System.Drawing.Point(panel2.Location.X, panel1.Height + 40);
                panel2.Visible = true;
            }
        }
        public static void agrandarPanel(System.Windows.Forms.Panel panel, System.Windows.Forms.Button boton, int panelHeightOriginal)
        {
            if (boton.Visible == false)
            {
                boton.Visible = true;
                panel.Height = panelHeightOriginal;
                //panel.Visible = false;
            }
        }
        static public void EscribeLog(string _texto)
        {
            string filename = "log.txt";
            StreamWriter writer = File.AppendText(filename);
            _texto = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - " + _texto;
            writer.WriteLine(_texto);
            writer.Close();
        }
        static public void EscribeLog(string _texto, string origen)
        {
            string filename = "log.txt";
            StreamWriter writer = File.AppendText(filename);
            _texto = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - origen->" + origen + " " + _texto;
            writer.WriteLine(_texto);
            writer.Close();
        }
        static public void EscribeLog(Exception ex)
        {
            string filename = "log.txt";
            StreamWriter writer = File.AppendText(filename);
            string texto = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - " + ex.Message + " -stack trace-->" + ex.StackTrace;
            writer.WriteLine(texto);
            writer.Close();
        }
        static public void EscribeLog(Exception ex, string origen)
        {
            string filename = "log.txt";
            StreamWriter writer = File.AppendText(filename);
            string texto = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - " + ex.Message + " - origen->" + origen + " - stack trace-->" + ex.StackTrace;
            writer.WriteLine(texto);
            writer.Close();
        }
        static public int LimpiaMoneda(string valor)
        {
            valor = valor.Replace(" ", "");
            return cint(valor.Replace("$", "").Replace(".", ""));
        }
        //Devuelve el nombre del mes dado él número de este.
        static public string GetNombreMes(string numero)
        {
            int numeroMes = cint(numero);
            switch (numeroMes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
            }
            return "";
        }
        //Devuelve el número de un mes dado su nombre.
        static public string devuelveMesNumero(string nombreMes)
        {
            try
            {
                string numeroMes = "";
                if (nombreMes == "Enero")
                    numeroMes = "1";
                else if (nombreMes == "Febrero")
                    numeroMes = "2";
                else if (nombreMes == "Marzo")
                    numeroMes = "3";
                else if (nombreMes == "Abril")
                    numeroMes = "4";
                else if (nombreMes == "Mayo")
                    numeroMes = "5";
                else if (nombreMes == "Junio")
                    numeroMes = "6";
                else if (nombreMes == "Julio")
                    numeroMes = "7";
                else if (nombreMes == "Agosto")
                    numeroMes = "8";
                else if (nombreMes == "Septiembre")
                    numeroMes = "9";
                else if (nombreMes == "Octubre")
                    numeroMes = "10";
                else if (nombreMes == "Noviembre")
                    numeroMes = "11";
                else if (nombreMes == "Diciembre")
                    numeroMes = "12";


                return numeroMes;
            }
            catch (Exception ex)
            {
                Utils.EscribeLog(ex);
                return null;

            }
        }
        //Carga un combobox de años.
        static public void cargarYear(ComboBox cmb_year)
        {
            try
            {
                cmb_year.Items.Add("Seleccione...");
                cmb_year.Items.Add("2005");
                cmb_year.Items.Add("2006");
                cmb_year.Items.Add("2007");
                cmb_year.Items.Add("2008");
                cmb_year.Items.Add("2009");
                cmb_year.Items.Add("2010");
                cmb_year.Items.Add("2011");
                cmb_year.Items.Add("2012");
                cmb_year.Items.Add("2013");
                cmb_year.Items.Add("2014");
                cmb_year.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                Utils.EscribeLog(ex);
            }
        }
        //Carga un combobox con los meses de un año.
        static public void cargarMes(ComboBox cmbMes)
        {
            try
            {
                cmbMes.Items.Add("Seleccione...");
                cmbMes.Items.Add("Enero");
                cmbMes.Items.Add("Febrero");
                cmbMes.Items.Add("Marzo");
                cmbMes.Items.Add("Abril");
                cmbMes.Items.Add("Mayo");
                cmbMes.Items.Add("Junio");
                cmbMes.Items.Add("Julio");
                cmbMes.Items.Add("Agosto");
                cmbMes.Items.Add("Septiembre");
                cmbMes.Items.Add("Octubre");
                cmbMes.Items.Add("Noviembre");
                cmbMes.Items.Add("Diciembre");
                cmbMes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                Utils.EscribeLog(ex);
            }
        }
        //static public void cargaUsuarios(ComboBox cmbUsuario)
        //{
        //    int intento = 0;
        //    try
        //    {
        //        intento++;
        //        // Sigcom.Controlador_Usuario ctrlUsuario = new Sigcom.Controlador_Usuario();
        //        Query query = new Query("select", "usuario");
        //        query.AddOrderBy("nombre");
        //        Usuario[] listaUsuarios = CtrlUsuario.getListado(query);

        //        Usuario inicial = new Usuario();
        //        inicial.fnombre = "Seleccione...";
        //        cmbUsuario.Items.Clear();
        //        cmbUsuario.Items.Add(inicial);
        //        foreach (Sigcom.Usuario objeto in listaUsuarios)
        //        {
        //            cmbUsuario.Items.Add(objeto);
        //        }
        //        cmbUsuario.DisplayMember = "fnombreCompleto";
        //        cmbUsuario.ValueMember = "fID";
        //        cmbUsuario.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        if (intento == 1)
        //        {
        //            cargaUsuarios(cmbUsuario);
        //        }
        //        else
        //        {
        //            Utils.Mensaje("Ha ocurrido un error con la carga, por favor cierre la ventana y abrala nuevamente");
        //        }
        //    }
        //}
        //static public void cargaUsuariosFiltro(ComboBox cmbUsuario)
        //{
        //    int intento = 0;
        //    try
        //    {
        //        intento++;

        //        // Sigcom.Controlador_Usuario ctrlUsuario = new Sigcom.Controlador_Usuario();
        //        Query query = new Query("select", "usuario");
        //        Usuario[] listaUsuarios = CtrlUsuario.getListado(query);

        //        Usuario inicial = new Usuario();
        //        inicial.fnombre = "TODOS";
        //        cmbUsuario.Items.Clear();
        //        cmbUsuario.Items.Add(inicial);
        //        foreach (Sigcom.Usuario objeto in listaUsuarios)
        //        {
        //            cmbUsuario.Items.Add(objeto);
        //        }
        //        cmbUsuario.DisplayMember = "fnombreCompleto";
        //        cmbUsuario.ValueMember = "fID";
        //        cmbUsuario.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        if (intento == 1)
        //        {
        //            cargaUsuariosFiltro(cmbUsuario);
        //        }
        //        else
        //        {
        //            Utils.Mensaje("Ha ocurrido un error con la carga, por favor cierre la ventana y abrala nuevamente");
        //        }
        //    }

        //}
        //static public void cargaUsuarios(ComboBox cmbUsuario, ComboBox cmbUsuario2)
        //{
        //    int intento = 0;
        //    try
        //    {
        //        // Sigcom.Controlador_Usuario ctrlUsuario = new Sigcom.Controlador_Usuario();
        //        Query query = new Query("select", "usuario");
        //        Usuario[] listaUsuarios = CtrlUsuario.getListado(query);

        //        Usuario inicial = new Usuario();
        //        inicial.fnombre = "TODOS";
        //        cmbUsuario.Items.Clear();
        //        cmbUsuario.Items.Add(inicial);

        //        cmbUsuario2.Items.Clear();
        //        cmbUsuario2.Items.Add(inicial);
        //        foreach (Sigcom.Usuario objeto in listaUsuarios)
        //        {
        //            cmbUsuario.Items.Add(objeto);
        //            cmbUsuario2.Items.Add(objeto);
        //        }
        //        cmbUsuario.DisplayMember = "fnombreCompleto";
        //        cmbUsuario.ValueMember = "fID";
        //        cmbUsuario.SelectedIndex = 0;

        //        cmbUsuario2.DisplayMember = "fnombreCompleto";
        //        cmbUsuario2.ValueMember = "fID";
        //        cmbUsuario2.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.EscribeLog(ex);
        //        if (intento == 1)
        //        {
        //            cargaUsuarios(cmbUsuario, cmbUsuario2);
        //        }
        //        else
        //        {
        //            Utils.Mensaje("Ha ocurrido un error con la carga, por favor cierre la ventana y abrala nuevamente");
        //        }
        //    }
        //}
        //static public void Mensaje(string mensaje)
        //{
        //    Sigcom.SIGCOM frm_mensaje = new Sigcom.SIGCOM();
        //    frm_mensaje.SetMensaje(mensaje);
        //    frm_mensaje.Show();
        //}
        static public int DivisionEntero(int numero, int divisor)
        {
            double resultado = numero / divisor;
            return (int)Math.Ceiling(resultado);
        }
        static public int DivisionDouble(int numero, int divisor)
        {
            double resultado = cdouble(numero.ToString()) / cdouble(divisor.ToString());
            return (int)Math.Ceiling(resultado);
        }
        static public double DivisionDoubleSinRedondear(int numero, int divisor)
        {
            double resultado = cdouble(numero.ToString()) / cdouble(divisor.ToString());
            return (resultado);
        }
        //static public int DivisionEnteroTecho(int numero, int divisor)
        //{
        //    double resultado = cdouble(numero.ToString()) / cdouble(divisor.ToString());
        //    return (int)Math.Floor(resultado);
        //}
        static public Query RetornaWhereBusqueda(Query query, string textoAbuscar, string nombreAtributo)
        {
            if (!String.IsNullOrEmpty(textoAbuscar))
            {
                char[] delimitadores = { ' ' };
                string[] arregloBuscar = textoAbuscar.Split(delimitadores);
                //se debe contruir la parte where en base a distinto filtros que el usuario pudo haber ingresado.
                //y estos filtros no necesariamente estarán en el orden que están en la base de datos por lo que eso
                //se maneja en el siguiente for:
                foreach (string cadena in arregloBuscar)
                {
                    query.AddWhere(nombreAtributo, cadena);
                }
            }
            return query;
        }
        static public string RetornaWhereBusquedaString(string textoAbuscar, string nombreAtributo)
        {
            string where = "";
            string and = "";
            if (!String.IsNullOrEmpty(textoAbuscar))
            {
                char[] delimitadores = { ' ' };
                string[] arregloBuscar = textoAbuscar.Split(delimitadores);

                //se debe contruir la parte where en base a distinto filtros que el usuario pudo haber ingresado.
                //y estos filtros no necesariamente estarán en el orden que están en la base de datos por lo que eso
                //se maneja en el siguiente for:
                foreach (string cadena in arregloBuscar)
                {
                    where += " and " + nombreAtributo + " LIKE '%" + textoAbuscar + "%'";

                    //query.AddWhere(nombreAtributo, cadena);
                }
            }
            return where;
        }
        static public Query RetornaWhereBusquedaConJoin(Query query, string textoAbuscar, string nombreAtributo, string nombreTabla)
        {
            if (!String.IsNullOrEmpty(textoAbuscar))
            {
                char[] delimitadores = { ' ' };
                string[] arregloBuscar = textoAbuscar.Split(delimitadores);
                //se debe contruir la parte where en base a distinto filtros que el usuario pudo haber ingresado.
                //y estos filtros no necesariamente estarán en el orden que están en la base de datos por lo que eso
                //se maneja en el siguiente for:
                foreach (string cadena in arregloBuscar)
                {
                    query.AddWhere(nombreAtributo, cadena, nombreTabla);
                }
            }
            return query;
        }
        //Dada una fecha, retorna la fecha inicial y final correspondiente a la semana de la fecha dada.
        static public ArrayList RetornaFechasLimiteSemana(DateTime fecha)
        {
            ArrayList ArrFechas = new ArrayList();
            int _tempInt = (int)fecha.DayOfWeek;
            if (_tempInt == 0)
                _tempInt = 7;

            DateTime _temp = fecha.AddDays(-(_tempInt - 1));
            ArrFechas.Add(_temp);
            DateTime _temp2 = fecha.AddDays(7 - _tempInt);
            ArrFechas.Add(_temp2);
            return ArrFechas;
        }
        static public string getValorConfig(string nombre_variable)
        {
            System.Configuration.AppSettingsReader conf = new System.Configuration.AppSettingsReader();
            return conf.GetValue(nombre_variable, System.Type.GetType("System.String")).ToString();
        }
        public static string cdateBDInicio(DateTime valor)
        {
            string mes = "";
            string dia = "";
            if (valor.Month < 10)
                mes = "0" + valor.Month.ToString();
            else
                mes = valor.Month.ToString();

            if (valor.Day < 10)
                dia = "0" + valor.Day.ToString();
            else
                dia = valor.Day.ToString();

            return "'" + valor.Year + "-" + mes + "-" + dia + " 00:00:000'";
        }
        public static string cdateBDTermino(DateTime valor)
        {
            string mes = "";
            string dia = "";
            if (valor.Month < 10)
                mes = "0" + valor.Month.ToString();
            else
                mes = valor.Month.ToString();

            if (valor.Day < 10)
                dia = "0" + valor.Day.ToString();
            else
                dia = valor.Day.ToString();

            return "'" + valor.Year + "-" + mes + "-" + dia + " 23:59:59'";
        }
        public static string getDirectorioActual()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
        public static string getMD5(string texto)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(texto);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
        //public static bool existeConexionMySql()
        //{
        //    try
        //    {
        //        Query query = new Query("usuario");
        //        query.AddWhereExacto(ST_Usuario.login, "bcea");
        //        if (BDConnect.Exec_cQuery(query.listo()) == null)
        //            return false;
        //        else
        //            return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
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
        //static public int getSucursalID(ComboBox cmbSucursal)
        //{
        //    if (cmbSucursal.Visible)
        //    {

        //        Sucursal sucursal = (Sucursal)cmbSucursal.SelectedItem;
        //        return sucursal.fID;
        //    }
        //    else
        //    {
        //        return Program.usuarioActual.fsucursal_ID;
        //    }

        //}
        //static public int getBodegaID(ComboBox cmbSucursal)
        //{

        //    if (cmbSucursal.Visible)
        //    {

        //        Sucursal sucursal = (Sucursal)cmbSucursal.SelectedItem;
        //        Query query = new Query("bodega");
        //        query.AddWhere("sucursal_ID", sucursal.fID.ToString());
        //        Controlador_Bodega CtrlBodega = new Controlador_Bodega();
        //        Bodega[] arrBodega = CtrlBodega.getListado(query);
        //        return arrBodega[0].fID;
        //    }
        //    else
        //    {
        //        return Program.bodega_ID;
        //    }
        //}
        //static public int getBodegaID(int sucursal_ID)
        //{

        //    Query query = new Query("bodega");
        //    query.AddWhere("sucursal_ID", sucursal_ID.ToString());
        //    Controlador_Bodega CtrlBodega = new Controlador_Bodega();
        //    Bodega[] arrBodega = CtrlBodega.getListado(query);
        //    return arrBodega[0].fID;
        //}
        //static public void setVisibleCmbSucursal(ComboBox cmbSucursalFiltro, ComboBox cmbSucursalIngreso, Label lblSucursalFiltro, Label lblSucursalIngreso)
        //{
        //    if (Program.tipo_sistema.Equals("VENTAS_TERRENO"))
        //    {
        //        if (Program.usuarioActual.frol_usuario_ID == 1)
        //        {
        //            int index = 0;// cmbSucursalFiltro.FindStringExact(Program.sucursal_por_defecto.fnombre);
        //            if (cmbSucursalIngreso != null)
        //            {
        //                index = cmbSucursalIngreso.FindStringExact(Program.sucursal_por_defecto.fnombre);
        //                cmbSucursalIngreso.Visible = true;
        //                cmbSucursalIngreso.SelectedIndex = index;
        //            }
        //            if (cmbSucursalFiltro != null)
        //            {
        //                index = cmbSucursalFiltro.FindStringExact(Program.sucursal_por_defecto.fnombre);
        //                cmbSucursalFiltro.Visible = true;
        //                cmbSucursalFiltro.SelectedIndex = index;
        //            }
        //            if (lblSucursalFiltro != null)
        //                lblSucursalFiltro.Visible = true;
        //            if (lblSucursalIngreso != null)
        //                lblSucursalIngreso.Visible = true;
        //        }
        //        else
        //        {
        //            if (cmbSucursalIngreso != null)
        //                cmbSucursalIngreso.Visible = false;
        //            if (cmbSucursalFiltro != null)
        //                cmbSucursalFiltro.Visible = false;
        //            if (lblSucursalFiltro != null)
        //                lblSucursalFiltro.Visible = false;
        //            if (lblSucursalIngreso != null)
        //                lblSucursalIngreso.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        if (cmbSucursalIngreso != null)
        //            cmbSucursalIngreso.Visible = false;
        //        if (cmbSucursalFiltro != null)
        //            cmbSucursalFiltro.Visible = false;
        //        if (lblSucursalFiltro != null)
        //            lblSucursalFiltro.Visible = false;
        //        if (lblSucursalIngreso != null)
        //            lblSucursalIngreso.Visible = false;            
        //    }

        //}
        static public string quitarAcentos(string texto)
        {
            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜÑçÇ";
            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUNcC";
            for (int v = 0; v < sinsignos.Length; v++)
            {
                string i = consignos.Substring(v, 1);
                string j = sinsignos.Substring(v, 1);
                texto = texto.Replace(i, j);
            }

            return texto;

            //string textoOriginal = texto;//transformación UNICODE
            //string textoNormalizado = textoOriginal.Normalize(NormalizationForm.FormD);
            ////coincide todo lo que no sean letras y números ascii o espacio
            ////y lo reemplazamos por una cadena vacía.
            //Regex reg = new Regex("[^a-zA-Z0-9 ]");
            //string textoSinAcentos = reg.Replace(textoNormalizado, "");        
            //return textoSinAcentos;
        }
        public static string agregarcero(int valor)
        {
            if (valor < 10)
                return "0" + valor.ToString();
            else
                return valor.ToString();

        }

        public static int calculaPrecioVenta(int precio_original, double porcentaje_aumento)
        {
            if (porcentaje_aumento > 0)
            {
                double resultado_porcentaje = ((double)porcentaje_aumento / (double)100);
                double precio_double = precio_original + (precio_original * resultado_porcentaje);//resultad (porcentaje_aumento/100);
                int precio_int = (int)Math.Round(precio_double, 0);

                int last = precio_int % 10;
                if ((10 - last) > 0 && last != 0)
                {
                    int res = 10 - last;
                    precio_int += res;
                }
                return precio_int;
            }
            else if (porcentaje_aumento < 0)
            {
                double precio_double = precio_original - precio_original * (porcentaje_aumento / 100);
                int precio_int = (int)Math.Ceiling(precio_double);

                int last = precio_int % 10;
                if ((10 - last) > 0)
                {
                    int res = 10 - last;
                    precio_int += res;
                }
                return precio_int;
            }
            else
            {
                return precio_original;
            }
        }
        //Convierte un valor que está en formato moneda a int
        //static public int MoneyToInt(string valorMoneda)
        //{
        //    try
        //    {
        //        string MoneyAux = valorMoneda.Replace("$","");
        //        MoneyAux = MoneyAux.Replace(".","");
        //        MoneyAux = MoneyAux.Replace(" ", "");
        //        return int.Parse(MoneyAux);
        //    }
        //    catch (Exception ex)
        //    {
        //       Utils.EscribeLog(ex);
        //       return -1;
        //    }
        //}
        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    //IPInterfaceProperties properties = adapter.GetIPProperties(); Line is not required
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

    }
}
