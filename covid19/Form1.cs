using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace covid19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WebClient wc = null;
            XmlDocument doc = null;

            wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19SidoInfStateJson");
            str.Append("?serviceKey=qRVc%2Fb5X4Xsm8CHUMdKfWqR4U1iY%2BqON6yOTdIFgcWa2l56m6XnRIZkqZS3APPu%2BTFg50U3dDQiDlkYIUjuxJg==");
            str.Append("&startCreateDt=");
            str.Append("20200410");
            str.Append("&endCreateDt=");
            str.Append("20200410");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);
            XmlElement root = doc.DocumentElement;
            XmlNodeList xnList = doc.GetElementsByTagName("item");

            dataGridView1.Rows.Clear();

            foreach(XmlNode xn in xnList)
            {
                dataGridView1.Rows.Add(
                    xn["incDec"].InnerText,
                    xn["gubun"].InnerText,
                    xn["isolClearCnt"].InnerText,
                    xn["deathCnt"].InnerText,
                    xn["stdDay"].InnerText);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
