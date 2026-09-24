using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public static int answer = 0;
        public Form5()
        {
            InitializeComponent();
        }
        public void Disable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        public void Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        public void Enable2()
        {
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал известен как отличный проводник электричества и используется в карандашах?";
            button5.Text = "Галит";
            button6.Text = "Графит";
            button8.Text = "Флюорит";
            button7.Text = "Тальк";
            answer = 2;
            Disable();
            Enable2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал имеет твердость 9 по Моосу и включает сапфир и рубин?";
            button5.Text = "Корунд";
            button6.Text = "Кварц";
            button8.Text = "Галит";
            button7.Text = "Гипс";
            answer = 1;
            Disable();
            Enable2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал часто используется в строительстве и гипсовых изделиях??";
            button5.Text = "Галит";
            button6.Text = "Кварц";
            button7.Text = "Флюорит";
            button8.Text = "Гипс";
            answer = 4;
            Disable();
            Enable2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал часто окрашивает железистые руды красно-коричневым цветом?";
            button5.Text = "Магнетит";
            button6.Text = "Гематит";
            button8.Text = "Галит";
            button7.Text = "Тальк";
            answer = 2;
            Disable();
            Enable2();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (answer == 1)
            {
                label2.Text = "Правильно!";
                Enable();
            }
            else
            {
                label2.Text = "Неправильно";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (answer == 2)
            {
                label2.Text = "Правильно!";
                Enable();
            }
            else
            {
                label2.Text = "Неправильно";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (answer == 3)
            {
                label2.Text = "Правильно!";
                Enable();
            }
            else
            {
                label2.Text = "Неправильно";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (answer == 4)
            {
                label2.Text = "Правильно!";
                Enable();
            }
            else
            {
                label2.Text = "Неправильно";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}