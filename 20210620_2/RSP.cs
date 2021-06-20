using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210620_2
{
    enum rsp
    {
        가위, 바위, 보
    }

    public partial class RSP : Form
    {
        public RSP()
        {
            InitializeComponent();

            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int pcchoice = new Random().Next(3);
            resulta.Text = "가위";

            if (pcchoice == 0)
            {
                resultb.Text = "가위";
                result.Text = "무승부";
            }

            else if (pcchoice == 1)
            {
                resultb.Text = "바위";
                result.Text = "B의 승리";
            }

            else
            {
                resultb.Text = "보";
                result.Text = "A의 승리";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int pcchoice = new Random().Next(3);
            resultb.Text = "바위";

            if (pcchoice == 0)
            {
                resulta.Text = "가위";
                result.Text = "B의 승리";
            }

            else if (pcchoice == 1)
            {
                resulta.Text = "바위";
                result.Text = "무승부";
            }

            else
            {
                resulta.Text = "보";
                result.Text = "A의 승리";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 3;
            int pcchoice = new Random().Next(3);
            resulta.Text = "보";

            if (pcchoice == 0)
            {
                resultb.Text = "가위";
                result.Text = "B의 승리";
            }

            else if (pcchoice == 1)
            {
                resultb.Text = "바위";
                result.Text = "A의 승리";
            }

            else
            {
                resultb.Text = "보";
                result.Text = "무승부";
            }
        }
    }
}
