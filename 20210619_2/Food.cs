using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210619_2
{
    enum food
    {
        김밥, 라면, 떡볶이, 돈가스
    }
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();

            button1.Text = "김밥";
            button2.Text = "라면";
            button3.Text = "떡볶이";
            button4.Text = "돈가스";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int pcchoice = new Random().Next(3);
            WhatTime.Text = "현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
            result1.Text = "김밥";

            if (pcchoice == 0)
            {
                result2.Text = "김밥";
                result3.Text = "김밥";
                resultF.Text = "일치";
            }

            else if (pcchoice == 1)
            {
                result2.Text = "라면";
                result3.Text = "돈가스";
                resultF.Text = "불일치";
            }

            else if (pcchoice == 2)
            {
                result2.Text = "돈가스";
                result3.Text = "떡볶이";
                resultF.Text = "불일치";
            }

            else
            {
                result2.Text = "떡볶이";
                result3.Text = "라면";
                resultF.Text = "불일치";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int pcchoice = new Random().Next(3);
            WhatTime.Text = "현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
            result2.Text = "라면";

            if (pcchoice == 0)
            {
                result1.Text = "라면";
                result3.Text = "라면";
                resultF.Text = "일치";
            }

            else if (pcchoice == 1)
            {
                result1.Text = "김밥";
                result3.Text = "떡볶이";
                resultF.Text = "불일치";
            }

            else if (pcchoice == 2)
            {
                result1.Text = "돈가스";
                result3.Text = "김밥";
                resultF.Text = "불일치";
            }

            else
            {
                result1.Text = "떡볶이";
                result3.Text = "돈가스";
                resultF.Text = "불일치";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int pcchoice = new Random().Next(3);
            WhatTime.Text = "현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
            result3.Text = "떡볶이";

            if (pcchoice == 0)
            {
                result1.Text = "떡볶이";
                result2.Text = "떡볶이";
                resultF.Text = "일치";
            }

            else if (pcchoice == 1)
            {
                result1.Text = "라면";
                result2.Text = "김밥";
                resultF.Text = "불일치";
            }

            else if (pcchoice == 2)
            {
                result1.Text = "돈가스";
                result2.Text = "라면";
                resultF.Text = "불일치";
            }

            else
            {
                result1.Text = "김밥";
                result2.Text = "떡볶이";
                resultF.Text = "불일치";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mychoice = 3;
            int pcchoice = new Random().Next(3);
            WhatTime.Text = "현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
            result1.Text = "돈가스";

            if (pcchoice == 0)
            {
                result2.Text = "돈가스";
                result3.Text = "돈가스";
                resultF.Text = "일치";
            }

            else if (pcchoice == 1)
            {
                result2.Text = "라면";
                result3.Text = "떡볶이";
                resultF.Text = "불일치";
            }

            else if (pcchoice == 2)
            {
                result2.Text = "김밥";
                result3.Text = "라면";
                resultF.Text = "불일치";
            }

            else
            {
                result2.Text = "떡볶이";
                result3.Text = "김밥";
                resultF.Text = "불일치";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "현재 시간은 " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " 입니다.";
        }

        private void writeLog(string contents, string date)
        {
            string logcontents = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]" + $"{contents}";
        }
    }
}
