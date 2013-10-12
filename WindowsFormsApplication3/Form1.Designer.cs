namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.apt1 = new System.Windows.Forms.RadioButton();
            this.apt2 = new System.Windows.Forms.RadioButton();
            this.apt3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bpt1 = new System.Windows.Forms.RadioButton();
            this.bpt2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cpt3 = new System.Windows.Forms.RadioButton();
            this.cpt2 = new System.Windows.Forms.RadioButton();
            this.cpt1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dpt3 = new System.Windows.Forms.RadioButton();
            this.dpt2 = new System.Windows.Forms.RadioButton();
            this.dpt1 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fpt3 = new System.Windows.Forms.RadioButton();
            this.fpt1 = new System.Windows.Forms.RadioButton();
            this.fpt2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optFemale);
            this.groupBox1.Controls.Add(this.optMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพศ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(78, 19);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(46, 17);
            this.optFemale.TabIndex = 2;
            this.optFemale.Text = "หญิง";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Checked = true;
            this.optMale.Location = new System.Drawing.Point(15, 19);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(44, 17);
            this.optMale.TabIndex = 1;
            this.optMale.TabStop = true;
            this.optMale.Text = "ชาย";
            this.optMale.UseVisualStyleBackColor = true;
            this.optMale.CheckedChanged += new System.EventHandler(this.optMale_CheckedChanged);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Location = new System.Drawing.Point(6, 37);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(83, 17);
            this.opt1.TabIndex = 2;
            this.opt1.TabStop = true;
            this.opt1.Text = "น้อยกว่า20ปี";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Location = new System.Drawing.Point(86, 37);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(59, 17);
            this.opt2.TabIndex = 3;
            this.opt2.TabStop = true;
            this.opt2.Text = "20-40ปี";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Location = new System.Drawing.Point(165, 37);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(87, 17);
            this.opt3.TabIndex = 4;
            this.opt3.TabStop = true;
            this.opt3.Text = "มากกว่า 40 ปี";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(304, 387);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(194, 60);
            this.cmdCheck.TabIndex = 5;
            this.cmdCheck.Text = "เรียบร้อย";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // apt1
            // 
            this.apt1.AutoSize = true;
            this.apt1.Location = new System.Drawing.Point(6, 21);
            this.apt1.Name = "apt1";
            this.apt1.Size = new System.Drawing.Size(74, 17);
            this.apt1.TabIndex = 7;
            this.apt1.Text = "ต่ำกว่า 5 ปี";
            this.apt1.UseVisualStyleBackColor = true;
            // 
            // apt2
            // 
            this.apt2.AutoSize = true;
            this.apt2.Location = new System.Drawing.Point(78, 21);
            this.apt2.Name = "apt2";
            this.apt2.Size = new System.Drawing.Size(56, 17);
            this.apt2.TabIndex = 8;
            this.apt2.TabStop = true;
            this.apt2.Text = "5-10 ปี";
            this.apt2.UseVisualStyleBackColor = true;
            // 
            // apt3
            // 
            this.apt3.AutoSize = true;
            this.apt3.Location = new System.Drawing.Point(154, 21);
            this.apt3.Name = "apt3";
            this.apt3.Size = new System.Drawing.Size(87, 17);
            this.apt3.TabIndex = 9;
            this.apt3.TabStop = true;
            this.apt3.Text = "มากกว่า 10 ปี";
            this.apt3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opt1);
            this.groupBox2.Controls.Add(this.opt2);
            this.groupBox2.Controls.Add(this.opt3);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "อายุ";
            // 
            // bpt1
            // 
            this.bpt1.AutoSize = true;
            this.bpt1.Location = new System.Drawing.Point(6, 29);
            this.bpt1.Name = "bpt1";
            this.bpt1.Size = new System.Drawing.Size(71, 17);
            this.bpt1.TabIndex = 12;
            this.bpt1.Text = "พอสมควร";
            this.bpt1.UseVisualStyleBackColor = true;
            // 
            // bpt2
            // 
            this.bpt2.AutoSize = true;
            this.bpt2.Location = new System.Drawing.Point(78, 29);
            this.bpt2.Name = "bpt2";
            this.bpt2.Size = new System.Drawing.Size(115, 17);
            this.bpt2.TabIndex = 13;
            this.bpt2.TabStop = true;
            this.bpt2.Text = "ไม่เคยเลยหรือน้อย";
            this.bpt2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.apt3);
            this.groupBox3.Controls.Add(this.apt2);
            this.groupBox3.Controls.Add(this.apt1);
            this.groupBox3.Location = new System.Drawing.Point(12, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 45);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1.อายุรถของคุณ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bpt1);
            this.groupBox4.Controls.Add(this.bpt2);
            this.groupBox4.Location = new System.Drawing.Point(12, 133);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 56);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2.คุณตรวจสภาพรถบ่อยแค่ไหน?";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cpt3);
            this.groupBox5.Controls.Add(this.cpt2);
            this.groupBox5.Controls.Add(this.cpt1);
            this.groupBox5.Location = new System.Drawing.Point(12, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 56);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3. คุณตรวจสภาพรถก่อนออกเดินทางหรือไม่";
            // 
            // cpt3
            // 
            this.cpt3.AutoSize = true;
            this.cpt3.Location = new System.Drawing.Point(152, 28);
            this.cpt3.Name = "cpt3";
            this.cpt3.Size = new System.Drawing.Size(75, 17);
            this.cpt3.TabIndex = 19;
            this.cpt3.TabStop = true;
            this.cpt3.Text = "ไม่เคยเลย";
            this.cpt3.UseVisualStyleBackColor = true;
            // 
            // cpt2
            // 
            this.cpt2.AutoSize = true;
            this.cpt2.Location = new System.Drawing.Point(78, 28);
            this.cpt2.Name = "cpt2";
            this.cpt2.Size = new System.Drawing.Size(60, 17);
            this.cpt2.TabIndex = 18;
            this.cpt2.TabStop = true;
            this.cpt2.Text = "บางครั้ง";
            this.cpt2.UseVisualStyleBackColor = true;
            // 
            // cpt1
            // 
            this.cpt1.AutoSize = true;
            this.cpt1.Location = new System.Drawing.Point(6, 28);
            this.cpt1.Name = "cpt1";
            this.cpt1.Size = new System.Drawing.Size(57, 17);
            this.cpt1.TabIndex = 17;
            this.cpt1.TabStop = true;
            this.cpt1.Text = "ทุกครั้ง";
            this.cpt1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dpt3);
            this.groupBox6.Controls.Add(this.dpt2);
            this.groupBox6.Controls.Add(this.dpt1);
            this.groupBox6.Location = new System.Drawing.Point(12, 249);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(256, 49);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "4. วิธีตรวจสภาพรถของคุณ";
            // 
            // dpt3
            // 
            this.dpt3.AutoSize = true;
            this.dpt3.Location = new System.Drawing.Point(155, 21);
            this.dpt3.Name = "dpt3";
            this.dpt3.Size = new System.Drawing.Size(47, 17);
            this.dpt3.TabIndex = 22;
            this.dpt3.TabStop = true;
            this.dpt3.Text = "เข้าอู่";
            this.dpt3.UseVisualStyleBackColor = true;
            // 
            // dpt2
            // 
            this.dpt2.AutoSize = true;
            this.dpt2.Location = new System.Drawing.Point(76, 21);
            this.dpt2.Name = "dpt2";
            this.dpt2.Size = new System.Drawing.Size(74, 17);
            this.dpt2.TabIndex = 21;
            this.dpt2.TabStop = true;
            this.dpt2.Text = "ด้วยตัวเอง";
            this.dpt2.UseVisualStyleBackColor = true;
            // 
            // dpt1
            // 
            this.dpt1.AutoSize = true;
            this.dpt1.Location = new System.Drawing.Point(6, 21);
            this.dpt1.Name = "dpt1";
            this.dpt1.Size = new System.Drawing.Size(64, 17);
            this.dpt1.TabIndex = 20;
            this.dpt1.TabStop = true;
            this.dpt1.Text = "เข้าศูนย์";
            this.dpt1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fpt3);
            this.groupBox7.Controls.Add(this.fpt1);
            this.groupBox7.Controls.Add(this.fpt2);
            this.groupBox7.Location = new System.Drawing.Point(12, 298);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 56);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "5.คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน";
            // 
            // fpt3
            // 
            this.fpt3.AutoSize = true;
            this.fpt3.Location = new System.Drawing.Point(154, 29);
            this.fpt3.Name = "fpt3";
            this.fpt3.Size = new System.Drawing.Size(57, 17);
            this.fpt3.TabIndex = 14;
            this.fpt3.TabStop = true;
            this.fpt3.Text = "ไม่เคย";
            this.fpt3.UseVisualStyleBackColor = true;
            // 
            // fpt1
            // 
            this.fpt1.AutoSize = true;
            this.fpt1.Location = new System.Drawing.Point(6, 29);
            this.fpt1.Name = "fpt1";
            this.fpt1.Size = new System.Drawing.Size(64, 17);
            this.fpt1.TabIndex = 12;
            this.fpt1.Text = "มากทีสุด";
            this.fpt1.UseVisualStyleBackColor = true;
            // 
            // fpt2
            // 
            this.fpt2.AutoSize = true;
            this.fpt2.Location = new System.Drawing.Point(76, 29);
            this.fpt2.Name = "fpt2";
            this.fpt2.Size = new System.Drawing.Size(71, 17);
            this.fpt2.TabIndex = 13;
            this.fpt2.TabStop = true;
            this.fpt2.Text = "พอสมควร";
            this.fpt2.UseVisualStyleBackColor = true;
            this.fpt2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 459);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "แบบสอบถามคุณใส่ใจการตรวจสภาพรถของคุณแล้วหรือยัง?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.RadioButton apt1;
        private System.Windows.Forms.RadioButton apt2;
        private System.Windows.Forms.RadioButton apt3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton bpt1;
        private System.Windows.Forms.RadioButton bpt2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton cpt3;
        private System.Windows.Forms.RadioButton cpt2;
        private System.Windows.Forms.RadioButton cpt1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton dpt3;
        private System.Windows.Forms.RadioButton dpt2;
        private System.Windows.Forms.RadioButton dpt1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton fpt3;
        private System.Windows.Forms.RadioButton fpt1;
        private System.Windows.Forms.RadioButton fpt2;
    }
}

