namespace Laba8oop
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount1 = new System.Windows.Forms.TextBox();
            this.count1 = new System.Windows.Forms.Label();
            this.txtCount2 = new System.Windows.Forms.TextBox();
            this.count2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(25, 25);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(442, 79);
            this.txtText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 83);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Русский текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Транслит";
            // 
            // txtCount1
            // 
            this.txtCount1.Location = new System.Drawing.Point(489, 43);
            this.txtCount1.Multiline = true;
            this.txtCount1.Name = "txtCount1";
            this.txtCount1.Size = new System.Drawing.Size(83, 24);
            this.txtCount1.TabIndex = 0;
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.Location = new System.Drawing.Point(486, 25);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(58, 13);
            this.count1.TabIndex = 3;
            this.count1.Text = "Символов";
            // 
            // txtCount2
            // 
            this.txtCount2.Location = new System.Drawing.Point(489, 154);
            this.txtCount2.Multiline = true;
            this.txtCount2.Name = "txtCount2";
            this.txtCount2.Size = new System.Drawing.Size(83, 24);
            this.txtCount2.TabIndex = 0;
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.Location = new System.Drawing.Point(486, 138);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(58, 13);
            this.count2.TabIndex = 3;
            this.count2.Text = "Символов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count2);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCount2);
            this.Controls.Add(this.txtCount1);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCount1;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.TextBox txtCount2;
        private System.Windows.Forms.Label count2;
    }
}

