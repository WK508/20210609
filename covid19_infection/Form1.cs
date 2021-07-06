using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace covid19_infection
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
            str.Append("http://openapi.data.go.kr/openapi/service/rest/Covid19/getCovid19InfStateJson");
            str.Append("?bLORjXNAfn0T3bvdmfewxXjUZllXmuQzSvIrA9bEOATdGD%2FNsMpHeRNAlno9VUBv4pvL4psVP3fPLXmmJ4BXxg==");
            str.Append("&startCreateDt=");
            str.Append("20200310");
            str.Append("&endCreateDt=");
            str.Append("20200315");

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);
            XmlElement root = doc.DocumentElement;
            XmlNodeList xnList = doc.GetElementsByTagName("item");

            dataGridView1.Rows.Clear();

            foreach (XmlNode xn in xnList)
            {
                dataGridView1.Rows.Add(
                    xn["careCnt"].InnerText,
                    xn["clearCnt"].InnerText,
                    xn["createDt"].InnerText,
                    xn["deathCnt"].InnerText,
                    xn["decideCnt"].InnerText,
                    xn["examCnt"].InnerText,
                    xn["resutlNegCnt"].InnerText,
                    xn["seq"].InnerText,
                    xn["stateDt"].InnerText,
                    xn["stateTime"].InnerText);
            }
        }
    }
}
