namespace StopWatch
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
            this.components = new System.ComponentModel.Container();
            this.tb_H = new System.Windows.Forms.TextBox();
            this.tb_M = new System.Windows.Forms.TextBox();
            this.tb_S = new System.Windows.Forms.TextBox();
            this.tb_MS = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mytimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tb_H
            // 
            this.tb_H.Location = new System.Drawing.Point(104, 14);
            this.tb_H.Name = "tb_H";
            this.tb_H.Size = new System.Drawing.Size(37, 20);
            this.tb_H.TabIndex = 0;
            this.tb_H.Text = "0";
            // 
            // tb_M
            // 
            this.tb_M.Location = new System.Drawing.Point(159, 15);
            this.tb_M.Name = "tb_M";
            this.tb_M.Size = new System.Drawing.Size(37, 20);
            this.tb_M.TabIndex = 0;
            this.tb_M.Text = "00";
            // 
            // tb_S
            // 
            this.tb_S.Location = new System.Drawing.Point(217, 15);
            this.tb_S.Name = "tb_S";
            this.tb_S.Size = new System.Drawing.Size(37, 20);
            this.tb_S.TabIndex = 0;
            this.tb_S.Text = "00";
            // 
            // tb_MS
            // 
            this.tb_MS.Location = new System.Drawing.Point(273, 15);
            this.tb_MS.Name = "tb_MS";
            this.tb_MS.Size = new System.Drawing.Size(37, 20);
            this.tb_MS.TabIndex = 0;
            this.tb_MS.Text = "000";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Старт";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(328, 11);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Сброс";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ".";
            // 
            // mytimer
            // 
            this.mytimer.Interval = 1;
            this.mytimer.Tick += new System.EventHandler(this.mytimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 53);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tb_MS);
            this.Controls.Add(this.tb_S);
            this.Controls.Add(this.tb_M);
            this.Controls.Add(this.tb_H);
            this.Name = "Form1";
            this.Text = "Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_H;
        private System.Windows.Forms.TextBox tb_M;
        private System.Windows.Forms.TextBox tb_S;
        private System.Windows.Forms.TextBox tb_MS;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer mytimer;
    }
}

