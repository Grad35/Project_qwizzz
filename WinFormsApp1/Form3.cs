using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        // 1 — правильный первый вариант, 2 — второй, 3 — третий, 4 — четвёртый
        private int answer = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Disable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void Enable2()
        {
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        // Вопрос 1 — Гематит
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал часто окрашивает железистые руды красно-коричневым цветом?";
            button5.Text = "Магнетит";
            button6.Text = "Гематит";
            button7.Text = "Галит";
            button8.Text = "Тальк";
            answer = 2;
            Disable();
            Enable2();
        }

        // Вопрос 2 — Азурит
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал известен своим ярким синим цветом и медным карбонатом?";
            button5.Text = "Галит";
            button6.Text = "Малахит";
            button7.Text = "Флюорит";
            button8.Text = "Азурит";
            answer = 4;
            Disable();
            Enable2();
        }

        // Вопрос 3 — Тальк
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал самый мягкий и применяется в косметике?";
            button5.Text = "Гипс";
            button6.Text = "Галит";
            button7.Text = "Тальк";
            button8.Text = "Флюорит";
            answer = 3;
            Disable();
            Enable2();
        }

        // Вопрос 4 — Слюда
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Какой минерал легко расщепляется на тонкие прозрачные пластинки?";
            button5.Text = "Кварц";
            button6.Text = "Слюда";
            button7.Text = "Галит";
            button8.Text = "Пирит";
            answer = 2;
            Disable();
            Enable2();
        }

        private void button5_Click(object sender, EventArgs e) => CheckAnswer(1);
        private void button6_Click(object sender, EventArgs e) => CheckAnswer(2);
        private void button7_Click(object sender, EventArgs e) => CheckAnswer(3);
        private void button8_Click(object sender, EventArgs e) => CheckAnswer(4);

        private void CheckAnswer(int selected)
        {
            if (answer == selected)
            {
                label1.Text = "Правильно!";
                Enable();
            }
            else
            {
                label1.Text = "Неправильно";
            }
        }

        // Кнопка возврата — закрывает Form3
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}