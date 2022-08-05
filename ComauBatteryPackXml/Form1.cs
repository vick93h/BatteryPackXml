using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;
using ComauBatteryPackXml.XML_Classes;
using RoundedBtnStyle;
namespace ComauBatteryPackXml
{
    public partial class Form1 : Form
    {
        Caricamento _estrai = new Caricamento();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Estrai_IN_XML_Click(object sender, EventArgs e)
        {
            if (Singleton.CurrentState.DatiScambio.Esportato == true)
            {

                DialogResult dialogResult = MessageBox.Show("Dati già presenti.Sovrascrivere?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _estrai.ShowDialog();
                }


            }
            else
                _estrai.ShowDialog();

            }

        private void Visualizza_IN_XML_Click(object sender, EventArgs e)
        {
            if (Singleton.CurrentState.DatiScambio.Esportato == true)
            {
                string path = Directory.GetCurrentDirectory();

                string xmlString = System.IO.File.ReadAllText((path + "Battery_Pack.xml"));

                // Load the xslt used by IE to render the xml
                XslCompiledTransform xTrans = new XslCompiledTransform();
                xTrans.Load(Path.Combine(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName, @"resource\default.xsl"));

                // Read the xml string.
                StringReader sr = new StringReader(xmlString);
                XmlReader xReader = XmlReader.Create(sr);

                // Transform the XML data
                MemoryStream ms = new MemoryStream();
                xTrans.Transform(xReader, null, ms);

                ms.Position = 0;

                // Set to the document stream
                webBrowser.DocumentStream = ms;
            }
            else
                MessageBox.Show("Devi prima esportare!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
