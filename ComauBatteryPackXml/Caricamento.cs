using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ComauBatteryPackXml
{
    public partial class Caricamento : Form
    {
        BackgroundWorker worker;
        public Caricamento()
        {
            InitializeComponent();
            //set up progress bar ans label
            progressBar1.Value = 0;
            progressBar1.Step = 20;
            progressBar1.Maximum = 100;
            progressBar1.Visible = false;
            label2.Visible = false;
            //background worker
            worker = new BackgroundWorker();
            worker.DoWork += backgroundWorker1_DoWork;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
        }

        private void Caricamento_Load(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Visible = true;
                label2.Visible = true;
            });
            worker.ReportProgress(20);
            //restituisce \bin\debug
            string workingDirectory = Environment.CurrentDirectory;
            //restituisce la directory principale
            string file = Directory.GetParent(workingDirectory).Parent.FullName;
            string _fileXml = file +"\\XML folder" +"\\prova.xml";
            string _filePLC = file+"\\PLCDB.config";
            List<RootFIELD_DATA> list = new List<RootFIELD_DATA>();
            this.Invoke((MethodInvoker)delegate
            {
                Thread.Sleep(1000);
            });
            list = (from a in XDocument.Load(_filePLC).Descendants("PLC")
                    select new RootFIELD_DATA
                    {
                        MSG_ID = (string)a.Attribute("MSG_ID"),
                        MSG_DT = (string)a.Attribute("MSG_DT"),
                        CISNUM = (string)a.Attribute("CISNUM"),
                        MODCOD = (string)a.Attribute("MODCOD"),
                        SEQNUM = (string)a.Attribute("SEQNUM"),
                        LB__ID = (string)a.Attribute("LB__ID"),
                        LINCOD = (string)a.Attribute("LINCOD"),
                        PRGNUM = (string)a.Attribute("PRGNUM"),
                        LINDES = (string)a.Attribute("LINDES"),
                        SUBGROUP_DESCRIPTION = (string)a.Attribute("SUBGROUP_DESCRIPTION"),
                        PROCESSING_DATA_SECTION = (from f in XDocument.Load(_fileXml).Descendants("TRACED_OPERATION")
                                                   select new RootFIELD_DATAPROCESSING_DATA_SECTIONTRACED_OPERATION
                                                   {
                                                       OPCODE = (string)f.Attribute("OPCODE"),
                                                       OPTYPE = (string)f.Attribute("OPTYPE"),
                                                       OPCYCLE = (string)f.Attribute("OPCYCLE"),
                                                       OPTOOL_ID = (string)f.Attribute("OPTOOL_ID"),
                                                       OP_RESULT = (string)f.Attribute("OP_RESULT"),
                                                       OPERATOR = (string)f.Attribute("OPERATOR"),
                                                       OPDATE = (string)f.Attribute("OPDATE"),
                                                       SINGLE_ITEM = (from o in f.Elements("SINGLE_ITEM")
                                                                      select new RootFIELD_DATAPROCESSING_DATA_SECTIONTRACED_OPERATIONSINGLE_ITEM
                                                                      {
                                                                          ITEM_ID = (string)o.Attribute("ITEM_ID"),
                                                                          ITEM_DESC = (string)o.Attribute("ITEM_DESC"),
                                                                          ITEM_RESULT = (string)o.Attribute("ITEM_RESULT"),
                                                                          OPERATOR = (string)o.Attribute("OPERATOR"),
                                                                          OPTOOL_ID = (string)o.Attribute("OPTOOL_ID"),
                                                                          SINGLE_OP_RESULT = (from i in o.Elements("SINGLE_OP_RESULT")
                                                                                              select new RootFIELD_DATAPROCESSING_DATA_SECTIONTRACED_OPERATIONSINGLE_ITEMSINGLE_OP_RESULT
                                                                                              {
                                                                                                  TRY_ID = (string)i.Attribute("TRY_ID"),
                                                                                                  TRY_RESULT = (string)i.Attribute("TRY_RESULT"),
                                                                                                  OPERATOR = (string)i.Attribute("OPERATOR"),
                                                                                                  OPTOOL_ID = (string)i.Attribute("OPTOOL_ID"),
                                                                                                  MEASUREMENT = (from h in i.Elements("MEASUREMENT")
                                                                                                                 select new RootFIELD_DATAPROCESSING_DATA_SECTIONTRACED_OPERATIONSINGLE_ITEMSINGLE_OP_RESULTMEASUREMENT
                                                                                                                 {
                                                                                                                     MEAS_DESCR = (string)h.Attribute("MEAS_DESCR"),
                                                                                                                     MEASURE = (string)h.Attribute("MEASURE"),
                                                                                                                     VALUE = (string)h.Attribute("VALUE"),
                                                                                                                     UM = (string)h.Attribute("UM"),
                                                                                                                     UPPER_TOLERANCE = (string)h.Attribute("UPPER_TOLERANCE"),
                                                                                                                     LOWER_TOLERANCE = (string)h.Attribute("LOWER_TOLERANCE")
                                                                                                                 }).ToArray()
                                                                                              }).ToArray()

                                                                      }).ToArray()
                                                   }).ToArray()

                    }).ToList();
            this.Invoke((MethodInvoker)delegate
            {
                Thread.Sleep(1000);
            });
            worker.ReportProgress(40);
            XmlSerializer serializer = new XmlSerializer(list.GetType());
            string path = Directory.GetCurrentDirectory();
            this.Invoke((MethodInvoker)delegate
            {
                Thread.Sleep(1000);
            });
            worker.ReportProgress(80);
            using (StreamWriter writer = new StreamWriter(path + "Battery_Pack.xml"))
            {
                serializer.Serialize(writer, list);
            }
            this.Invoke((MethodInvoker)delegate
            {
                Thread.Sleep(1000);
            });
            worker.ReportProgress(100);
            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Visible = false;
                label2.Visible = false;
            });
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label2.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Esportazione conclusa con successo!");
            this.Close();
        }
    }
}
