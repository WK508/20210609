using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210618
{
    enum mafia
    {
        마피아, 경찰, 시민
    }

    public partial class Mafia : Form
    {
        public Mafia()
        {
            InitializeComponent();

            button1.Text = "마피아";
            button2.Text = "경찰";
            button3.Text = "시민";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int pcchoice = new Random().Next(3);
            label_main.Text = "마피아";

            if (pcchoice == 0)
            {
                label_object.Text = "마피아";
                label_result.Text = "사격 중지";
                MessageBox.Show("같은 마피아이기 때문에 사격하지 않는다.");
            }

            else if (pcchoice == 1)
            {
                label_object.Text = "경찰";
                label_result.Text = "사격 개시";
            }

            else
            {
                label_object.Text = "시민";
                label_result.Text = "사격 개시";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int pcchoice = new Random().Next(3);
            label_main.Text = "경찰";

            if (pcchoice == 0)
            {
                label_object.Text = "마피아";
                label_result.Text = "사격 개시";
            }

            else if (pcchoice == 1)
            {
                label_object.Text = "경찰";
                label_result.Text = "사격 중지";
                MessageBox.Show("같은 경찰이기 때문에 사격하지 않는다.");
            }

            else
            {
                label_object.Text = "시민";
                label_result.Text = "사격 중지";
                MessageBox.Show("시민에게는 사격하지 않는 것이 원칙이다.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int pcchoice = new Random().Next(3);
            label_main.Text = "시민";

            if (pcchoice == 0)
            {
                label_object.Text = "마피아";
                label_result.Text = "사격 개시";
            }

            else if (pcchoice == 1)
            {
                label_object.Text = "경찰";
                label_result.Text = "사격 중지";
                MessageBox.Show("경찰에게는 사격하지 않는 것이 원칙이다.");
            }

            else
            {
                label_object.Text = "시민";
                label_result.Text = "사격 중지";
                MessageBox.Show("같은 시민이기 때문에 사격하지 않는다.");
            }
        }
    }


}
