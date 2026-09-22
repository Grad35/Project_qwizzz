namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            btnAlexander = new Button();
            SuspendLayout();
            // 
            // button1 (Егор)
            // 
            button1.Location = new Point(688, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 0;
            button1.Text = "Егор";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(279, 170);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 1;
            label1.Text = "Квиз по минералам";
            // 
            // btnAlexander
            // 
            btnAlexander.Location = new Point(12, 12);
            btnAlexander.Name = "btnAlexander";
            btnAlexander.Size = new Size(100, 40);
            btnAlexander.TabIndex = 2;
            btnAlexander.Text = "Александр";
            btnAlexander.UseVisualStyleBackColor = true;
            btnAlexander.Click += btnAlexander_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlexander);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnAlexander;
    }
}