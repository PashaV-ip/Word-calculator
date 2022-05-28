
namespace Word_calculator
{
    partial class WordCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCalculator));
            this.firstWord = new System.Windows.Forms.TextBox();
            this.secondWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.resultWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(207, 10);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(175, 29);
            this.firstWord.TabIndex = 0;
            this.firstWord.TextChanged += new System.EventHandler(this.firstWord_TextChanged);
            // 
            // secondWord
            // 
            this.secondWord.Location = new System.Drawing.Point(415, 10);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(175, 29);
            this.secondWord.TabIndex = 1;
            this.secondWord.TextChanged += new System.EventHandler(this.secondWord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите 2 слова:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(596, 5);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(127, 38);
            this.connect.TabIndex = 4;
            this.connect.Text = "Склеить";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // resultWord
            // 
            this.resultWord.Location = new System.Drawing.Point(207, 60);
            this.resultWord.Name = "resultWord";
            this.resultWord.ReadOnly = true;
            this.resultWord.Size = new System.Drawing.Size(383, 29);
            this.resultWord.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(596, 55);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 38);
            this.clear.TabIndex = 7;
            this.clear.Text = "Отчистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // WordCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 108);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultWord);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "WordCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор слов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordCalculator_FormClosing);
            this.Load += new System.EventHandler(this.WordCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstWord;
        private System.Windows.Forms.TextBox secondWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox resultWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
    }
}

