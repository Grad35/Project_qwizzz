namespace WinFormsApp1
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 30);
            button1.Name = "button1";
            button1.Size = new Size(110, 28);
            button1.TabIndex = 0;
            button1.Text = "Вопрос 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(230, 30);
            button2.Name = "button2";
            button2.Size = new Size(110, 28);
            button2.TabIndex = 1;
            button2.Text = "Вопрос 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(410, 30);
            button3.Name = "button3";
            button3.Size = new Size(110, 28);
            button3.TabIndex = 2;
            button3.Text = "Вопрос 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(590, 30);
            button4.Name = "button4";
            button4.Size = new Size(110, 28);
            button4.TabIndex = 3;
            button4.Text = "Вопрос 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(700, 80);
            label1.TabIndex = 4;
            label1.Text = "Выберите вопрос";
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(20, 350);
            button5.Name = "button5";
            button5.Size = new Size(175, 28);
            button5.TabIndex = 5;
            button5.Text = "Ответ 1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(215, 350);
            button6.Name = "button6";
            button6.Size = new Size(175, 28);
            button6.TabIndex = 6;
            button6.Text = "Ответ 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(410, 350);
            button7.Name = "button7";
            button7.Size = new Size(175, 28);
            button7.TabIndex = 7;
            button7.Text = "Ответ 3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(605, 350);
            button8.Name = "button8";
            button8.Size = new Size(175, 28);
            button8.TabIndex = 8;
            button8.Text = "Ответ 4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // btnBack — кнопка возврата (маленькая, справа внизу)
            // 
            btnBack.Location = new Point(735, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 25);
            btnBack.TabIndex = 9;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 430);
            Controls.Add(btnBack);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnBack;
    }
}