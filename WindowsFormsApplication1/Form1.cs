using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string fig; // 가,감,승,제수
        string pre; // 피 가감승제 수
        string result;  //결과
        int chose=0;  //연산자파트
        int chk; //입력 체크
        double f;
        double p;
        double temp;
        
        
        
        
        public Form1()
        {
            
            InitializeComponent();
            this.Text = "멀티 계산기 Made by Khw";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (pasttextBox1.Text == "+")
                pasttextBox1.Clear();
            if (pasttextBox1.Text == "-")
                pasttextBox1.Clear();
            if (pasttextBox1.Text == "/")
                pasttextBox1.Clear();
            if (pasttextBox1.Text == "*")
                pasttextBox1.Clear();

        }
       /*  숫자버튼  */ 
        private void button1_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "1";
            if (chk == 0)
                pre += "1";
            else
                fig += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "2";
            if (chk == 0)
                pre += "2";
            else
                fig += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            pasttextBox1.Text += "3";
            if (chk == 0)
                pre += "3";
            else
                fig += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "4";
            if (chk == 0)
                pre += "4";
            else 
                fig += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "5";
            if (chk == 0)
                pre += "5";
            else
                fig += "5";
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "6";
            
            if (chk == 0)
                pre += "6";
            else
                fig += "6";
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "7";
            if (chk == 0)
                pre += "7";
            else
                fig += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "8";
            if (chk == 0)
                pre += "8";
            else
                fig += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "9";
            if (chk == 0)
                pre += "9";
            else
                fig += "9";
        }
        
        private void button0_Click(object sender, EventArgs e)
        {
            pasttextBox1.Text += "0";
            if (pasttextBox1.Text == "") 
            pasttextBox1.Clear();
            else
                if (chk == 0)
                    pre += "0";
                else
                    fig += "0";




        }
     /* 기능키 */
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            if (pasttextBox1.Text == "")
                pasttextBox1.Clear();
            else
            {
                fig = "";
                pre = "";
                result = "";
                chose = 0;
                f = 0;
                p = 0;
                temp = 0;
                chk = 0;
                pasttextBox1.Clear();
            }


        }
        
        
        /*  연산자 키 */
        private void div_Click(object sender, EventArgs e)
        {
            chk = 1;

            if (chose == 0)
            {chose = 4;
            pasttextBox1.Text += "/";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            chk = 1;
            if (chose == 0)
            {
                chose = 1;
                pasttextBox1.Text += "+";
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            chk = 1;
            if (chose == 0)
            {
                chose = 2;
                pasttextBox1.Text += "-";
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            chk = 1;
            if (chose == 0)
            {
                chose = 3;
                pasttextBox1.Text += "*";
            }
        }

        private void equl_Click(object sender, EventArgs e)
        {
            if (pasttextBox1.Text == "")
                pasttextBox1.Clear();
            else
            {
                p = int.Parse(pre);
                f = int.Parse(fig);
                switch (chose)
                {
                    case 1: //가
                        temp = p + f;
                        result = temp.ToString();
                        pasttextBox1.Text = result;
                        break;
                    case 2: //감
                        temp = p - f;
                        result = temp.ToString();
                        pasttextBox1.Text = result;
                        break;
                    case 3: //승
                        temp = p * f;
                        result = temp.ToString();
                        pasttextBox1.Text = result;
                        break;
                    case 4: //제
                        temp = p / f;
                        result = temp.ToString();
                        pasttextBox1.Text = result;
                        break;
                }
                chk = 0;
                fig = "";
                pre = pasttextBox1.Text;
                chose = 0;
                temp = 0;
            }

        }

        

        
    }
}
