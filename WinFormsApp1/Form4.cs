using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        // Структура для хранения данных вопроса
        private struct Question
        {
            public string Text { get; set; }
            public string[] Answers { get; set; }
            public string CorrectAnswer { get; set; }

            public Question(string text, string[] answers, string correctAnswer)
            {
                Text = text;
                Answers = answers;
                CorrectAnswer = correctAnswer;
            }
        }

        // Массив с вопросами (добавлено еще 2 вопроса)
        private Question[] questions = new Question[]
        {
            new Question(
                " Какой минерал известен как отличный проводник электричества и используется в карандашах?",
                new string[] { "Графит", "Галит", "Флюорит", "Тальк" },
                "Графит"
            ),
            new Question(
                "Какой минерал часто встречается как декоративный зелёный камень?",
                new string[] { "Галит", "Азурит", "Малахит", "Гипс" },
                "Малахит"
            ),
            new Question(
                "Какой минерал часто встречается в виде прозрачных кристаллов и используется в стекле?",
                new string[] { "Алмаз", "Кварц", "Флюорит", "Тальк" },
                "Кварц"
            ),
            new Question(
                "Какой минерал самый твёрдый по Моосу?",
                new string[] { "Алмаз", "Кварц", "Флюорит", "Тальк" },
                "Алмаз"
            )
            
        };

        private int currentQuestionIndex = 0; // Индекс текущего вопроса
        private int score = 0;                  // Счетчик правильных ответов

        public Form4()
        {
            InitializeComponent();
            DisplayQuestion(); // Отображаем первый вопрос при запуске
        }

        // Метод для обновления текста вопроса и вариантов ответов на форме
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Length)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                
                // Меняем текст в элементах управления
                lblQuestion.Text = currentQuestion.Text;
                btnAnswer1.Text = currentQuestion.Answers[0];
                btnAnswer2.Text = currentQuestion.Answers[1];
                btnAnswer3.Text = currentQuestion.Answers[2];
                btnAnswer4.Text = currentQuestion.Answers[3];

                // Обновляем заголовок окна, показывая прогресс
                this.Text = $"Вопрос {currentQuestionIndex + 1} из {questions.Length}";
            }
        }

        // Единый обработчик клика для всех 4 кнопок
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                string selectedAnswer = clickedButton.Text;
                string correctAnswer = questions[currentQuestionIndex].CorrectAnswer;

                // Проверяем ответ и увеличиваем счетчик
                if (selectedAnswer == correctAnswer)
                {
                    score++;
                    MessageBox.Show("Правильно!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Неверно. Правильный ответ: {correctAnswer}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Переходим к следующему вопросу
                currentQuestionIndex++;

                // Проверяем, закончились ли вопросы
                if (currentQuestionIndex < questions.Length)
                {
                    DisplayQuestion();
                }
                else
                {
                    MessageBox.Show($"Тест завершен!\nВы ответили правильно на {score} из {questions.Length} вопросов.", "Финиш", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    // Сбрасываем тест для повторного прохождения (по желанию)
                    currentQuestionIndex = 0;
                    score = 0;
                    DisplayQuestion();
                }
            }
        }
    }
}