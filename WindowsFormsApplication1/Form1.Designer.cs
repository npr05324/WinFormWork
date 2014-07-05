namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pasttextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pasttextBox1
            // 
            this.pasttextBox1.Location = new System.Drawing.Point(28, 34);
            this.pasttextBox1.Name = "pasttextBox1";
            this.pasttextBox1.Size = new System.Drawing.Size(238, 21);
            this.pasttextBox1.TabIndex = 1;
            this.pasttextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(143, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(61, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 36);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(102, 196);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 36);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(143, 196);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 36);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(61, 70);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(35, 36);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(12, 238);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(117, 36);
            this.exitbutton.TabIndex = 12;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(194, 196);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 36);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(194, 154);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(45, 36);
            this.multi.TabIndex = 15;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(194, 112);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(45, 36);
            this.remove.TabIndex = 16;
            this.remove.Text = "-";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(194, 70);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 36);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(102, 70);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(35, 36);
            this.clear.TabIndex = 18;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // equl
            // 
            this.equl.Location = new System.Drawing.Point(194, 238);
            this.equl.Name = "equl";
            this.equl.Size = new System.Drawing.Size(45, 36);
            this.equl.TabIndex = 19;
            this.equl.Text = "=";
            this.equl.UseVisualStyleBackColor = true;
            this.equl.Click += new System.EventHandler(this.equl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 304);
            this.Controls.Add(this.equl);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.div);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pasttextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pasttextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equl;
    }
}

