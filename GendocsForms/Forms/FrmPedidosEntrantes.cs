using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GendocsForms
{
    public partial class FrmPedidosEntrantes : Form
    {
        public static string strTrello_API_Key = "d96312f0a6409f687a998a10cc602b24";
        public static string strTrello_Token = "9d897910fbfb76a19e38f474dc16321d73d3ccfbd2f833d6bb995cfdaaed9411";
        public static string strBoardID = "5d413324dec3d28ee2b83875";
        public static string strListID = "5ec6754a3faf851dcab6d83c";
        public static string strCardId = "5ec613ba12a1235cffe96cdb";
        public static string strCardIdLeidos = "5dc16484f2c4214e5e36c5f6";
        public static string sURL;
        public static string RutaPdf = string.Empty;
        public static string RutaCarpeta = @"Y:\GenDocs\Pedidos_entrantes\";

        public FrmPedidosEntrantes()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void FrmPedidosEntrantes_Load(object sender, EventArgs e)
        {
            CargarListaPedidos(RutaCarpeta);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PbTrello_Click(object sender, EventArgs e)
        {
            try
            {
                TramitarPedidos();
            }
            catch (Exception ex)
            {
                _  = ex.Message;
            }
        }

        #endregion

        #region "Métodos Privados"
        private void TramitarPedidos()
        {
            try
            {
                CargarPedidosPedientes("Cards");

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnProcesarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                String texto = string.Empty;
                List<String> ListaInicial = CargarConfiguarcionIncial();
                List<String> ListaFinal = new List<string>();
                if (lstvDisponibles.Items.Count > 0)
                {
                    foreach (ListViewItem itemRow in lstvDisponibles.SelectedItems)
                    {
                        texto = GetTextFromPDF(RutaCarpeta + itemRow.SubItems[1].Text);

                        ClsPedidos pedido = new ClsPedidos();
                        pedido.ProcesaTxt(texto);
                        //if (BuscaTXT(texto, 1, "IBERDROLA DISTRIBUCION ELECTRICA, S.A.U.", 0, ""))
                        //{
                        //    //IdCliente = 1;
                        //}
                    }
                }
                else
                    MessageBox.Show("No hay pedidos para procesar", "Procesar Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        public bool BuscaTXT(String texto,int lIni,String strBusca, int intMrg, string strFinCampo = " ",int lFin=0,string strResultado="",
                             String strMSG = "",bool intPasaLineasBeforeFind= false,bool intReverse = false)
        {
            bool Encontrado = false;
            int K;
            int bAsc;
            string strR = string.Empty;
            string strTxt;
            int iPaso;
            try
            {
                iPaso = intReverse ? -1 : 1; // El reverse marca el paso 
                strTxt = texto; // De momento en mi caso solo se contempla una opción de cargar el texto

                if (strBusca.Equals("IBERDROLA DISTRIBUCION ELECTRICA, S.A.U."))
                {
                    if (lIni == 0)
                    {
                        K = 1;
                    }
                    else
                    {
                        K = lIni;
                    }
                    Bucle1();
                }

                long i;
                if (lIni == 0)
                {
                    i = 1;
                }
                else
                    i = lIni;
                K = Strings.InStr(lIni == 0 ? 1:lIni,strTxt,strBusca);
                    
                if (K == 0)
                {
                    strMSG = "No se encontró '" + strBusca + "'";
                    HandleExit();
                }

                if (intMrg > 0 && (K - lIni) > intMrg)
                {
                    strMSG = "No se encontró '" + strBusca + "' en el espacio esperado";
                    HandleExit();
                }

                if (!intReverse)
                {
                    K += strBusca.Length;
                }
                else
                    K -= 1;

                if (strFinCampo == string.Empty)
                {
                    Ok();
                }

                void Bucle1()
                {
                    
                    try
                    {
                        bAsc = Strings.Asc(Strings.Mid(strTxt, K, 1));// Recorre de uno en uno los caracteres de una cadena empezando por la posicion k
                        switch (bAsc)
                        {
                            case 0:
                            case 10:
                            case 13: //' Salto de línea
                                if (!intPasaLineasBeforeFind)
                                {
                                    Ok();
                                }
                                else
                                {
                                    K += iPaso;
                                    Bucle1();
                                }
                                break;
                            case (33)://Case Is< 33 ' espacio 32, tabulador 9, ...
                                K += iPaso;
                                Bucle1();
                                break;
                            default:
                                strR = Strings.Mid(strTxt, K, 1);
                                Bucle2();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                    }
                }

                void Bucle2()
                {
                    try
                    {
                        K += iPaso;
                        if (Strings.InStr(K, strTxt, strFinCampo) == K)
                        {
                            Ok();
                        }

                        bAsc = Strings.Asc(Strings.Mid(strTxt, K, 1));
                        switch (bAsc)
                        {
                            case 0:
                            case 10:
                            case 13: //  Case 0, 10, 13
                                Ok();
                                break;
                            default:
                                if (!intReverse)
                                {
                                    strR += Strings.Mid(strTxt, K, 1);
                                }
                                else
                                {
                                    strR = Strings.Mid(strTxt, K, 1) + strR;
                                }
                                Bucle2();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                    }
                }


                bool Ok()
                {
                    try
                    {
                        strResultado = strR;
                        lFin = K;
                        return true;                     
                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                        return false;
                    }
                }

                void HandleExit()
                {
                    try
                    {
                        lFin = K;
                        return;
                    }
                    catch (Exception ex)
                    {
                        _ = ex.Message;
                    }
                }

                Encontrado = true;
            }

            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return Encontrado;
        }

        private List<String> CargarConfiguarcionIncial()
        {
            List<String> ListaInicial = new List<String>();
            try
            {
                ListaInicial.Add("Empresa Contratante");
                ListaInicial.Add("Gestor Responsable");
                ListaInicial.Add("N/Ref");
                ListaInicial.Add("Fecha");
                ListaInicial.Add("Acuerdo Macro");
                ListaInicial.Add("Direccion Pedido");
                ListaInicial.Add("Código Proveedor");
                ListaInicial.Add("Responsable del suministro");
                ListaInicial.Add("Ref. Oferta");
                ListaInicial.Add("Fecha Oferta");
                ListaInicial.Add("Fecha Entrega");
            }
            catch (Exception ex)
            {
               _ = ex.Message;
            }
            return ListaInicial;
        }

        public void CargarPedidosPedientes(String strSolicitud = "Cards")
        {
            try
            {
                switch (strSolicitud)
                {
                    case "Boards":
                        //strUrl = "https://api.trello.com/1/members/me/boards?key=" & strTrello_API_Key & "&token=" & strTrello_Token & "&fields=name,shortLink"
                        sURL = "Pendiente de hacer";
                        break;
                    case "Lists":
                        sURL = "https://api.trello.com/1/lists/" + strListID + "/ cards?key=d96312f0a6409f687a998a10cc602b24&token=" + strTrello_Token;
                        break;
                    case "Cards":
                        sURL = "https://api.trello.com/1/lists/" + strListID + "/cards?key=d96312f0a6409f687a998a10cc602b24&token=" + strTrello_Token;
                        if (sURL != string.Empty)
                        {
                            CargarPedidosPedientes("Attachments");
                        }
                        break;
                    case "Attachments":
                        sURL = "https://api.trello.com/1/cards/" + strCardId + "/attachments?key=d96312f0a6409f687a998a10cc602b24&token=" + strTrello_Token + "&fields=name,url";

                        WebRequest wrGETURL;
                        wrGETURL = WebRequest.Create(sURL);
                        WebResponse response = wrGETURL.GetResponse();

                        Stream dataStream = response.GetResponseStream();
                        // Open the stream using a StreamReader for easy access.
                        StreamReader reader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = reader.ReadToEnd();
                        dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseFromServer);
                        RutaPdf = result[1].url;
                        GuardarArchivoACarpeta(RutaPdf, RutaCarpeta);
                        if (RutaPdf != string.Empty)
                        {
                            result = MessageBox.Show("Se encontraron nuevos Pedidos Entrantes, ¿Desea importarlos ahora?", "Importar Nuevos Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                CargarListaPedidos(RutaCarpeta);

                            }
                        }

                        // Clean up the streams.
                        reader.Close();
                        dataStream.Close();
                        response.Close();
                        CargarPedidosPedientes("MoveToList");
                        break;
                    case "MoveToList":
                        sURL = "https://api.trello.com/1/cards/" + strCardId + "/?key=" + strTrello_API_Key + "&token=" + strTrello_Token + "&idList=" + strCardIdLeidos + "&pos=top";


                        var request = (HttpWebRequest)WebRequest.Create(sURL);
                        request.Method = "PUT";
                        request.ContentType = "application/xml";


                        HttpWebResponse response2 = (HttpWebResponse)request.GetResponse();
                        string returnString = response2.StatusCode.ToString();

                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private static void MoverDeRecibidosALeidos(string IdTarjetaLeidos)
        {
            try
            {
                sURL = "https://api.trello.com/1/lists/" + IdTarjetaLeidos + "/ cards?key=d96312f0a6409f687a998a10cc602b24&token=" + strTrello_Token;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
        private static void GuardarArchivoACarpeta(string Uri, string NombreCarpeta)
        {
            try
            {
                WebClient myWebClient = new WebClient();
                NombreCarpeta += DameNombrePdf(Uri);
                myWebClient.DownloadFile(Uri, NombreCarpeta);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        private static string DameNombrePdf(String Url)
        {
            string NombrePdf = string.Empty;
            try
            {
                int UltimaPosicion = Url.LastIndexOf("/");
                NombrePdf = Url.Substring(UltimaPosicion + 1);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return NombrePdf;
        }

        private void CargarListaPedidos(string NombreCarpeta)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(NombreCarpeta);
                string pattern = "*.pdf";
                FileInfo[] files = dir.GetFiles(pattern);

                foreach (var item in files)
                {
                    ListViewItem lista = new ListViewItem();
                    lista.SubItems.Add(item.Name);
                    lstvDisponibles.Items.Add(lista);
                }
            }
            catch (Exception ex)
            {
               _ = ex.Message;
            }
        }

        public static String GetTextFromPDF(string filePath)
        {
            string texto= string.Empty;
            try
            {
                SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                f.XmlOptions.ConvertNonTabularDataToSpreadsheet = true;
                f.OpenPdf(filePath);

                texto = f.ToText();

                //f.ToHtml(@"c:\Table.xml");

                //SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                //f.OpenPdf(filePath);

                //if (f.PageCount > 0)
                //{  
                //    texto = f.ToText();
                //    texto = f.ToXml();
                //}

                //using (PdfReader reader = new PdfReader(filePath))
                //{
                //    string prevPage = "";
                //    for (int page = 1; page <= reader.NumberOfPages; page++)
                //    {
                //        ITextExtractionStrategy its = new SimpleTextExtractionStrategy();
                //        var s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                //        if (prevPage != s) sb.Append(s);
                //        prevPage = s;
                //    }
                //    reader.Close();
                //}
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return texto;
        }

        #endregion

        #region "Control de Eventos"

        #endregion
    }
}
