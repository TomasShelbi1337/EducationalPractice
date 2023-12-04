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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnComb = new System.Windows.Forms.RadioButton();
            this.rBtnPlac = new System.Windows.Forms.RadioButton();
            this.rBtnPerm = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalc.Location = new System.Drawing.Point(80, 170);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(61, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(80, 97);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(80, 123);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "m:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n:";
            // 
            // rBtnComb
            // 
            this.rBtnComb.AutoSize = true;
            this.rBtnComb.Checked = true;
            this.rBtnComb.Location = new System.Drawing.Point(221, 87);
            this.rBtnComb.Name = "rBtnComb";
            this.rBtnComb.Size = new System.Drawing.Size(83, 17);
            this.rBtnComb.TabIndex = 11;
            this.rBtnComb.TabStop = true;
            this.rBtnComb.Text = "Combination";
            this.rBtnComb.UseVisualStyleBackColor = true;
            this.rBtnComb.CheckedChanged += new System.EventHandler(this.rBtnComb_CheckedChanged);
            // 
            // rBtnPlac
            // 
            this.rBtnPlac.AutoSize = true;
            this.rBtnPlac.Location = new System.Drawing.Point(221, 110);
            this.rBtnPlac.Name = "rBtnPlac";
            this.rBtnPlac.Size = new System.Drawing.Size(75, 17);
            this.rBtnPlac.TabIndex = 12;
            this.rBtnPlac.Text = "Placement";
            this.rBtnPlac.UseVisualStyleBackColor = true;
            this.rBtnPlac.CheckedChanged += new System.EventHandler(this.rBtnPlac_CheckedChanged);
            // 
            // rBtnPerm
            // 
            this.rBtnPerm.AutoSize = true;
            this.rBtnPerm.Location = new System.Drawing.Point(221, 133);
            this.rBtnPerm.Name = "rBtnPerm";
            this.rBtnPerm.Size = new System.Drawing.Size(86, 17);
            this.rBtnPerm.TabIndex = 13;
            this.rBtnPerm.Text = "Permutations";
            this.rBtnPerm.UseVisualStyleBackColor = true;
            this.rBtnPerm.CheckedChanged += new System.EventHandler(this.rBtnPerm_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(218, 175);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(120, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(187, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rBtnPerm);
            this.Controls.Add(this.rBtnPlac);
            this.Controls.Add(this.rBtnComb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnComb;
        private System.Windows.Forms.RadioButton rBtnPlac;
        private System.Windows.Forms.RadioButton rBtnPerm;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

