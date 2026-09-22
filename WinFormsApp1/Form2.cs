using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static int  answer = 0;
        public Form2()
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
            label1.Text = "Какой минерал изображён на картинке?";
            button5.Text = "Кальцит";
            button6.Text = "Флюорит";
            button8.Text = "Кварц";
            button7.Text = "Сера";
            answer = 2;
            pictureBox1.Image = Resource1.Mineral1;
            Disable();
            Enable2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Что такое Галит?";
            button5.Text = "Поваренная соль";
            button6.Text = "Известняк";
            button8.Text = "Пищевая сода";
            button7.Text = "Мел";
            answer = 1;
            Disable();
            Enable2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал за внешнее сходство называют золотом дураков?";
            button5.Text = "Халькопирит";
            button6.Text = "Золотистый топаз";
            button7.Text = "Слюда";
            button8.Text = "Пирит";
            answer = 4;
            Disable();
            Enable2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал самый распространённый в земной коре?";
            button5.Text = "Полевой шпат";
            button6.Text = "Кварц";
            button8.Text = "Гипс";
            button7.Text = "Кальцит";
            answer = 2;
            Disable();
            Enable2();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (answer == 1)
            {
                label1.Text = "Правильно!";
                Enable();
            }
            else
            {
                label1.Text = "Неправильно";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (answer == 2)
            {
                label1.Text = "Правильно!";
                Enable();
                pictureBox1.Image = null;
            }
            else
            {
                label1.Text = "Неправильно";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (answer == 3)
            {
                label1.Text = "Правильно!";
                Enable();
            }
            else
            {
                label1.Text = "Неправильно";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (answer == 4)
            {
                label1.Text = "Правильно!";
                Enable();
            }
            else
            {
                label1.Text = "Неправильно";
            }
        }
    }
}
