namespace EducationalPractice1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rCustomer = new System.Windows.Forms.RadioButton();
            this.rEmployee = new System.Windows.Forms.RadioButton();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPatronymic = new System.Windows.Forms.TextBox();
            this.lblPd = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tLog = new System.Windows.Forms.TextBox();
            this.tPas = new System.Windows.Forms.TextBox();
            this.tPd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patronymic *";
            // 
            // rCustomer
            // 
            this.rCustomer.AutoSize = true;
            this.rCustomer.Checked = true;
            this.rCustomer.Location = new System.Drawing.Point(129, 61);
            this.rCustomer.Name = "rCustomer";
            this.rCustomer.Size = new System.Drawing.Size(69, 17);
            this.rCustomer.TabIndex = 5;
            this.rCustomer.TabStop = true;
            this.rCustomer.Text = "Customer";
            this.rCustomer.UseVisualStyleBackColor = true;
            this.rCustomer.CheckedChanged += new System.EventHandler(this.rCustomer_CheckedChanged);
            // 
            // rEmployee
            // 
            this.rEmployee.AutoSize = true;
            this.rEmployee.Location = new System.Drawing.Point(219, 61);
            this.rEmployee.Name = "rEmployee";
            this.rEmployee.Size = new System.Drawing.Size(71, 17);
            this.rEmployee.TabIndex = 6;
            this.rEmployee.Text = "Employee";
            this.rEmployee.UseVisualStyleBackColor = true;
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(129, 92);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(161, 20);
            this.tSurname.TabIndex = 7;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(129, 128);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(161, 20);
            this.tName.TabIndex = 8;
            // 
            // tPatronymic
            // 
            this.tPatronymic.Location = new System.Drawing.Point(129, 164);
            this.tPatronymic.Name = "tPatronymic";
            this.tPatronymic.Size = new System.Drawing.Size(161, 20);
            this.tPatronymic.TabIndex = 9;
            // 
            // lblPd
            // 
            this.lblPd.AutoSize = true;
            this.lblPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPd.Location = new System.Drawing.Point(318, 58);
            this.lblPd.Name = "lblPd";
            this.lblPd.Size = new System.Drawing.Size(123, 20);
            this.lblPd.TabIndex = 10;
            this.lblPd.Text = "Phone number *";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(322, 144);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(169, 30);
            this.btnGen.TabIndex = 12;
            this.btnGen.Text = "Generate login/password";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Your login: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(235, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Your password: ";
            // 
            // tLog
            // 
            this.tLog.Location = new System.Drawing.Point(129, 200);
            this.tLog.Name = "tLog";
            this.tLog.Size = new System.Drawing.Size(100, 20);
            this.tLog.TabIndex = 15;
            // 
            // tPas
            // 
            this.tPas.Location = new System.Drawing.Point(364, 200);
            this.tPas.Name = "tPas";
            this.tPas.Size = new System.Drawing.Size(100, 20);
            this.tPas.TabIndex = 16;
            // 
            // tPd
            // 
            this.tPd.Location = new System.Drawing.Point(322, 92);
            this.tPd.Mask = "+7(000)000-00-00";
            this.tPd.Name = "tPd";
            this.tPd.Size = new System.Drawing.Size(169, 20);
            this.tPd.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 237);
            this.Controls.Add(this.tPd);
            this.Controls.Add(this.tPas);
            this.Controls.Add(this.tLog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lblPd);
            this.Controls.Add(this.tPatronymic);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.rEmployee);
            this.Controls.Add(this.rCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rCustomer;
        private System.Windows.Forms.RadioButton rEmployee;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPatronymic;
        private System.Windows.Forms.Label lblPd;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tLog;
        private System.Windows.Forms.TextBox tPas;
        private System.Windows.Forms.MaskedTextBox tPd;
    }
}

