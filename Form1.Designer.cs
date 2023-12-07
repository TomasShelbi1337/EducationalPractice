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
            this.tSurname = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPatronymic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chChil = new System.Windows.Forms.CheckBox();
            this.tQch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chBag = new System.Windows.Forms.CheckBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chTb = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtBack = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtThere = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFlight = new System.Windows.Forms.ComboBox();
            this.bCalc = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aeroflot ticket office";
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(73, 19);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(139, 20);
            this.tSurname.TabIndex = 1;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(73, 45);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(139, 20);
            this.tName.TabIndex = 2;
            // 
            // tPatronymic
            // 
            this.tPatronymic.Location = new System.Drawing.Point(73, 71);
            this.tPatronymic.Name = "tPatronymic";
            this.tPatronymic.Size = new System.Drawing.Size(139, 20);
            this.tPatronymic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patronymic";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tPatronymic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buyer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chChil);
            this.groupBox2.Controls.Add(this.tQch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chBag);
            this.groupBox2.Controls.Add(this.cbClass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chTb);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbFlight);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 220);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(77, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "|";
            // 
            // chChil
            // 
            this.chChil.AutoSize = true;
            this.chChil.Location = new System.Drawing.Point(13, 190);
            this.chChil.Name = "chChil";
            this.chChil.Size = new System.Drawing.Size(64, 17);
            this.chChil.TabIndex = 8;
            this.chChil.Text = "Children";
            this.chChil.UseVisualStyleBackColor = true;
            this.chChil.CheckedChanged += new System.EventHandler(this.chChil_CheckedChanged);
            // 
            // tQch
            // 
            this.tQch.Enabled = false;
            this.tQch.Location = new System.Drawing.Point(140, 188);
            this.tQch.Name = "tQch";
            this.tQch.Size = new System.Drawing.Size(71, 20);
            this.tQch.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Quantity";
            // 
            // chBag
            // 
            this.chBag.AutoSize = true;
            this.chBag.Location = new System.Drawing.Point(131, 47);
            this.chBag.Name = "chBag";
            this.chBag.Size = new System.Drawing.Size(69, 17);
            this.chBag.TabIndex = 5;
            this.chBag.Text = "Baggage";
            this.chBag.UseVisualStyleBackColor = true;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Economy",
            "Comfort",
            "Business",
            "First Class"});
            this.cbClass.Location = new System.Drawing.Point(48, 160);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(164, 21);
            this.cbClass.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Class";
            // 
            // chTb
            // 
            this.chTb.AutoSize = true;
            this.chTb.Location = new System.Drawing.Point(13, 47);
            this.chTb.Name = "chTb";
            this.chTb.Size = new System.Drawing.Size(102, 17);
            this.chTb.TabIndex = 0;
            this.chTb.Text = "There and back";
            this.chTb.UseVisualStyleBackColor = true;
            this.chTb.CheckedChanged += new System.EventHandler(this.chTb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtBack);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtThere);
            this.groupBox3.Location = new System.Drawing.Point(13, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Back";
            // 
            // dtBack
            // 
            this.dtBack.Enabled = false;
            this.dtBack.Location = new System.Drawing.Point(46, 45);
            this.dtBack.Name = "dtBack";
            this.dtBack.Size = new System.Drawing.Size(141, 20);
            this.dtBack.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "There";
            // 
            // dtThere
            // 
            this.dtThere.Location = new System.Drawing.Point(46, 19);
            this.dtThere.Name = "dtThere";
            this.dtThere.Size = new System.Drawing.Size(141, 20);
            this.dtThere.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Flight";
            // 
            // cbFlight
            // 
            this.cbFlight.FormattingEnabled = true;
            this.cbFlight.Items.AddRange(new object[] {
            "Ekaterinburg - Moscow",
            "Ekaterinburg - Saint-Petersburg",
            "Ekaterinburg - Kaliningrad"});
            this.cbFlight.Location = new System.Drawing.Point(48, 20);
            this.cbFlight.Name = "cbFlight";
            this.cbFlight.Size = new System.Drawing.Size(164, 21);
            this.cbFlight.TabIndex = 0;
            // 
            // bCalc
            // 
            this.bCalc.AutoSize = true;
            this.bCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bCalc.Location = new System.Drawing.Point(12, 378);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(102, 23);
            this.bCalc.TabIndex = 9;
            this.bCalc.Text = "Calculate the cost";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // bExit
            // 
            this.bExit.AutoSize = true;
            this.bExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bExit.BackColor = System.Drawing.Color.LightCoral;
            this.bExit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.bExit.FlatAppearance.BorderSize = 2;
            this.bExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bExit.Location = new System.Drawing.Point(203, 378);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(34, 23);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 412);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ticket office";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSurname;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPatronymic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFlight;
        private System.Windows.Forms.CheckBox chTb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtThere;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chChil;
        private System.Windows.Forms.TextBox tQch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chBag;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Button bExit;
    }
}

