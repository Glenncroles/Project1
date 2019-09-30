using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.IO;

namespace TimingExperiment
{
    public partial class Form1 : Form
    {
        //global list
        List<PingResult> pingResults = new List<PingResult>();

        /// <summary>
        /// initializes form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fills the passed object with information then object is added to global list
        /// </summary>
        /// <param name="textbox">text from the passed textbox</param>
        /// <param name="obj">the passed object to be filled</param>
        /// <param name="region">current region</param>
        /// <param name="zone">current zone of region</param>
        /// <param name="type">either VM or App</param>
        /// <param name="language">which language is used</param>
        private void fill(string textbox, PingResult obj, string region, string zone, string type, string language)
        {
            Uri url = new Uri(textbox);
            string pingurl = string.Format("{0}", url.Host);
            string host = pingurl;
            var webGet = new HtmlWeb();
            var document = webGet.Load(textbox);
            var ping = new System.Net.NetworkInformation.Ping();
            var result = ping.Send(host, 3000);
            obj.region = region;
            obj.zone = zone;
            obj.type = type;
            obj.language = language;
            obj.address = textbox;
            obj.time = result.RoundtripTime.ToString();
            obj.number = document.Text;
            pingResults.Add(obj);
        }

        /// <summary>
        /// on click, creates objects, fills them with the fill function, then uses the global list to write a json file
        /// </summary>
        /// <param name="sender">btn object</param>
        /// <param name="e">the event</param>
        private void btnPing_Click(object sender, EventArgs e)
        {
            //variables
            string region = "asia-northeast2";
            string zone = "b";
            string python = "python";
            string java = "java";
            string vm = "VM";
            string app = "app";

            //first textbox information
            PingResult pythonVM = new PingResult();
            this.fill(pyVmBox.Text, pythonVM, region, zone, vm, python);

            //second textbox information
            PingResult pythonApp = new PingResult();
            this.fill(pyAppBox.Text, pythonApp, region, zone, app, python);

            //third textbox information
            PingResult javaVM = new PingResult();
            this.fill(jarVmBox.Text, javaVM, region, zone, vm, java);

            //fourth textbox information
            PingResult javaApp = new PingResult();
            this.fill(jarAppBox.Text, javaApp, region, zone, app, java);

            //converts and writes to json file
            string json = JsonConvert.SerializeObject(pingResults);
            string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(dataPath, @"PingList.json");
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine(json);
            tw.Close();

            //messagebox
            MessageBox.Show("PingList.json is now on your desktop", "Success");
        }
    }
}
