using System.Windows.Forms;

namespace MyGitHubProject
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления объявляются здесь
        private Button myButton; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // Настройки кнопки
            // 
            this.myButton.Location = new System.Drawing.Point(50, 50); // Координаты (X, Y)
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(100, 30); // Размер кнопки
            this.myButton.Text = "Нажми меня";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.MyButton_Click); // Событие клика

            // 
            // Настройки самой формы
            // 
            this.ClientSize = new System.Drawing.Size(300, 200); // Размер окна
            this.Controls.Add(this.myButton); // Добавляем кнопку на форму
            this.Name = "Form4";
            this.Text = "Мое Окно";
            this.ResumeLayout(false);
        }

        // Логика для клика по кнопке
        private void MyButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Привет из VS Code!");
        }
    }
}
