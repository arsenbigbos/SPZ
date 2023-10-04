namespace Lab1_Task3
{
    partial class Form1
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
            this.btn_p5 = new System.Windows.Forms.Button();
            this.btn_p6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_p5
            // 
            this.btn_p5.Location = new System.Drawing.Point(131, 152);
            this.btn_p5.Name = "btn_p5";
            this.btn_p5.Size = new System.Drawing.Size(144, 72);
            this.btn_p5.TabIndex = 0;
            this.btn_p5.Text = "Вивести Р5";
            this.btn_p5.UseVisualStyleBackColor = true;
            this.btn_p5.Click += new System.EventHandler(this.btn_p5_Click);
            // 
            // btn_p6
            // 
            this.btn_p6.Location = new System.Drawing.Point(471, 152);
            this.btn_p6.Name = "btn_p6";
            this.btn_p6.Size = new System.Drawing.Size(148, 72);
            this.btn_p6.TabIndex = 1;
            this.btn_p6.Text = "Записати Р6";
            this.btn_p6.UseVisualStyleBackColor = true;
            this.btn_p6.Click += new System.EventHandler(this.btn_p6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_p6);
            this.Controls.Add(this.btn_p5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_p5;
        private System.Windows.Forms.Button btn_p6;
    }
}

