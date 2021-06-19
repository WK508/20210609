using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210619_1
{
    enum dbdbdip
    {
        주먹, 부리, 날개
    }

    public partial class DBDBDIP : Form
    {
        public DBDBDIP()
        {
            InitializeComponent();

            button1.Text = "주먹";
            button2.Text = "부리";
            button3.Text = "날개";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int pcchoice = new Random().Next(3);
            offense.Text = "부리";

            if (pcchoice == 0)
            {
                defense.Text = "주먹";
                result.Text = "수비성공 and 공격실패";
            }

            else if (pcchoice == 1)
            {
                defense.Text = "부리";
                result.Text = "수비실패 and 공격성공";
            }

            else
            {
                defense.Text = "날개";
                result.Text = "수비성공 and 공격실패";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int pcchoice = new Random().Next(3);
            offense.Text = "날개";

            if (pcchoice == 0)
            {
                defense.Text = "주먹";
                result.Text = "수비성공 and 공격실패";
            }

            else if (pcchoice == 1)
            {
                defense.Text = "부리";
                result.Text = "수비성공 and 공격실패";
            }

            else
            {
                defense.Text = "날개";
                result.Text = "수비실패 and 공격성공";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int pcchoice = new Random().Next(3);
            offense.Text = "주먹";

            if (pcchoice == 0)
            {
                defense.Text = "주먹";
                result.Text = "수비실패 and 공격성공";
            }

            else if (pcchoice == 1)
            {
                defense.Text = "부리";
                result.Text = "수비성공 and 공격실패";
            }

            else
            {
                defense.Text = "날개";
                result.Text = "수비성공 and 공격실패";
            }
        }
    }
}
