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
            this.tCombM = new System.Windows.Forms.TextBox();
            this.tCombN = new System.Windows.Forms.TextBox();
            this.tPlacM = new System.Windows.Forms.TextBox();
            this.tPlacN = new System.Windows.Forms.TextBox();
            this.tPermN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rBtnComb = new System.Windows.Forms.RadioButton();
            this.rBtnPlac = new System.Windows.Forms.RadioButton();
            this.rBtnPerm = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalc.Location = new System.Drawing.Point(80, 113);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(61, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // tCombM
            // 
            this.tCombM.Location = new System.Drawing.Point(80, 61);
            this.tCombM.Name = "tCombM";
            this.tCombM.Size = new System.Drawing.Size(100, 20);
            this.tCombM.TabIndex = 1;
            // 
            // tCombN
            // 
            this.tCombN.Location = new System.Drawing.Point(80, 87);
            this.tCombN.Name = "tCombN";
            this.tCombN.Size = new System.Drawing.Size(100, 20);
            this.tCombN.TabIndex = 2;
            // 
            // tPlacM
            // 
            this.tPlacM.Location = new System.Drawing.Point(237, 61);
            this.tPlacM.Name = "tPlacM";
            this.tPlacM.Size = new System.Drawing.Size(100, 20);
            this.tPlacM.TabIndex = 3;
            // 
            // tPlacN
            // 
            this.tPlacN.Location = new System.Drawing.Point(237, 87);
            this.tPlacN.Name = "tPlacN";
            this.tPlacN.Size = new System.Drawing.Size(100, 20);
            this.tPlacN.TabIndex = 4;
            // 
            // tPermN
            // 
            this.tPermN.Location = new System.Drawing.Point(393, 61);
            this.tPermN.Name = "tPermN";
            this.tPermN.Size = new System.Drawing.Size(100, 20);
            this.tPermN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "m:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "m:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "n:";
            // 
            // rBtnComb
            // 
            this.rBtnComb.AutoSize = true;
            this.rBtnComb.Location = new System.Drawing.Point(80, 38);
            this.rBtnComb.Name = "rBtnComb";
            this.rBtnComb.Size = new System.Drawing.Size(83, 17);
            this.rBtnComb.TabIndex = 11;
            this.rBtnComb.TabStop = true;
            this.rBtnComb.Text = "Combination";
            this.rBtnComb.UseVisualStyleBackColor = true;
            // 
            // rBtnPlac
            // 
            this.rBtnPlac.AutoSize = true;
            this.rBtnPlac.Location = new System.Drawing.Point(237, 38);
            this.rBtnPlac.Name = "rBtnPlac";
            this.rBtnPlac.Size = new System.Drawing.Size(75, 17);
            this.rBtnPlac.TabIndex = 12;
            this.rBtnPlac.TabStop = true;
            this.rBtnPlac.Text = "Placement";
            this.rBtnPlac.UseVisualStyleBackColor = true;
            // 
            // rBtnPerm
            // 
            this.rBtnPerm.AutoSize = true;
            this.rBtnPerm.Location = new System.Drawing.Point(393, 38);
            this.rBtnPerm.Name = "rBtnPerm";
            this.rBtnPerm.Size = new System.Drawing.Size(86, 17);
            this.rBtnPerm.TabIndex = 13;
            this.rBtnPerm.TabStop = true;
            this.rBtnPerm.Text = "Permutations";
            this.rBtnPerm.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(218, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 186);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rBtnPerm);
            this.Controls.Add(this.rBtnPlac);
            this.Controls.Add(this.rBtnComb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tPermN);
            this.Controls.Add(this.tPlacN);
            this.Controls.Add(this.tPlacM);
            this.Controls.Add(this.tCombN);
            this.Controls.Add(this.tCombM);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tCombM;
        private System.Windows.Forms.TextBox tCombN;
        private System.Windows.Forms.TextBox tPlacM;
        private System.Windows.Forms.TextBox tPlacN;
        private System.Windows.Forms.TextBox tPermN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBtnComb;
        private System.Windows.Forms.RadioButton rBtnPlac;
        private System.Windows.Forms.RadioButton rBtnPerm;
        private System.Windows.Forms.Label lblResult;
    }
}

