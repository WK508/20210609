using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210620
{
    public partial class Lotto : Form
    {
        private Random r = new Random();
        private int[] lot = new int[6];

        public Lotto()
        {
            InitializeComponent();
        }

        private void Lotto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            MessageBox.Show(r.Next(1, 46).ToString());

            num1.Text = r.Next(1, 46).ToString();
            num2.Text = r.Next(1, 46).ToString();
            num3.Text = r.Next(1, 46).ToString();
            num4.Text = r.Next(1, 46).ToString();
            num5.Text = r.Next(1, 46).ToString();
            num6.Text = r.Next(1, 46).ToString();
            num7.Text = r.Next(1, 46).ToString();

            int[] randomNumbers = new int[7];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (randomNumbers[i] == randomNumbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            string temp = "";
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                temp = temp + (i + "번째 : " + randomNumbers[i] + Environment.NewLine);
            }
            MessageBox.Show(temp);
        }
    }
}
