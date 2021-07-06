using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExamBusLocation_2
{
    public partial class Form1 : Form
    {
        const string targetURL = "http://openapi.gbis.go.kr/ws/rest/buslocationservice";
        const string serviceKey = "bLORjXNAfn0T3bvdmfewxXjUZllXmuQzSvIrA9bEOATdGD%2FNsMpHeRNAlno9VUBv4pvL4psVP3fPLXmmJ4BXxg=="; //마이 페이지에서 자신의 인증키 입력.
        const string routeid = "233000031"; //버스 노선 ID

		public static string getResults()
		{
			string result = string.Empty;

			try
			{
				WebClient client = new WebClient();
				string url = string.Format(@"{0}?serviceKey={1}&routeId={2}", targetURL, serviceKey, routeid);
				using (Stream data = client.OpenRead(url))
				{
					using (StreamReader reader = new StreamReader(data))
					{
						string s = reader.ReadToEnd();
						result = s;

						reader.Close();
						data.Close();
					}
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}

			return result;
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
        {
			string result = getResults();

			XmlDocument xml = new XmlDocument();
			xml.LoadXml(result);
			XmlNodeList list = xml.GetElementsByTagName("busLocationList");

			listViewResults.Items.Clear();
			int idx = 0;
			foreach (XmlNode bus in list)
			{
				ListViewItem item = new ListViewItem((idx++).ToString());
				item.SubItems.Add(bus["plateNo"].InnerText);
				string endBus = "N";
				if (bus["endBus"].InnerText == "1")
					endBus = "Y";
				item.SubItems.Add(endBus);

				item.SubItems.Add(bus["remainSeatCnt"].InnerText);

				listViewResults.Items.Add(item);
			}
		}  
    }
    }



    

