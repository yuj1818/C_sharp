using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4_survey {
    public partial class Form1 : Form {
        string ex1 = "";
        string ex2 = "";
        string op = "";
        double result;
        bool sig1;
        public Form1() {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn1.Text;
                txtBresult.Text = ex1;
            } 
            else {
                ex2 += Btn1.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn2_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn2.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn2.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn3_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn3.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn3.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn4_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn4.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn4.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn5_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn5.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn5.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn6_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn6.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn6.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn7_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn7.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn7.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn8_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn8.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn8.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn9_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn9.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn9.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void Btn0_Click(object sender, EventArgs e) {
            if (sig1 == false) {
                ex1 += Btn0.Text;
                txtBresult.Text = ex1;
            } else {
                ex2 += Btn0.Text;
                txtBresult.Text = ex1 + " " + op + " " + ex2;
            }
        }

        private void BtnC_Click(object sender, EventArgs e) {
            txtBresult.Clear();
            ex1 = "";
            ex2 = "";
            op = "";
            sig1 = false;
        }

        private void BtnCE_Click(object sender, EventArgs e) {
            if (op != "") {
                txtBresult.Text = txtBresult.Text.Substring(0, txtBresult.Text.Length - 1);
                op = "";
            }
            else if (sig1 == false) {
                txtBresult.Text = txtBresult.Text.Substring(0, txtBresult.Text.Length - 1);
                ex1 = ex1.Substring(0, ex1.Length - 1);
            } 
            else {
                txtBresult.Text = txtBresult.Text.Substring(0, txtBresult.Text.Length - 1);
                ex2 = ex2.Substring(0, ex1.Length - 1);
            }
        }

        private void BtnAbs_Click(object sender, EventArgs e) {
            double absnum = Convert.ToDouble(ex1);
            if (absnum < 0) {
                absnum *= -1;
                txtBresult.Text = Convert.ToString(absnum);
            } 
            else {
                txtBresult.Text = ex1;
            }
            ex1 = "";
        }

        private void BtnPlus_Click(object sender, EventArgs e) {
            op = "+";
            sig1 = true;
            txtBresult.Text += " " + op + " ";
        }
        private void BtnMinus_Click(object sender, EventArgs e) {
            if (ex1 == "") {
                ex1 += "-";
            } 
            else if (sig1 == true) {
                ex2 += "-";
            } 
            else if(ex2 == "") {
                op = "-";
                sig1 = true;
                txtBresult.Text += " " + op;
                ex2 = " ";
            } 
        }

        private void BtnResult_Click(object sender, EventArgs e) {
            double num1 = Convert.ToDouble(ex1);
            double num2 = Convert.ToDouble(ex2);
            if (op == "+") {
                result = num1 + num2;
                txtBresult.Text = Convert.ToString(result);
            }
            else if (op == "-") {
                result = num1 - num2;
                txtBresult.Text = Convert.ToString(result);
            }
            else if (op == "*") {
                result = num1 * num2;
                txtBresult.Text = Convert.ToString(result);
            }
            else if (op == "/") {
                if (num2 == 0) {
                    txtBresult.Text = "0으로 나눌 수 없습니다";
                } 
                else {
                    result = num1 / num2;
                    txtBresult.Text = Convert.ToString(result);
                }
            }
            else if (op == "%") {
                result = num1 % num2;
                txtBresult.Text = Convert.ToString(result);
            }
            else if(op == "^") {
                result = Math.Pow(num1, num2);
                txtBresult.Text = Convert.ToString(result);
            }
            ex1 = "";
            ex2 = "";
            op = "";
            sig1 = false;
        }

        private void BtnFloat_Click(object sender, EventArgs e) {
            if (ex1 != "" && sig1 == false) {
                ex1 += ".";
                txtBresult.Text += ".";
            } 
            else if (ex2 != "") {
                ex2 += ".";
                txtBresult.Text += ".";
            }
        }

        private void BtnMult_Click(object sender, EventArgs e) {
            op = "*";
            sig1 = true;
            txtBresult.Text += " " + op + " ";
        }

        private void BtnDiv_Click(object sender, EventArgs e) {
            op = "/";
            sig1 = true;
            txtBresult.Text += " " + op + " ";
        }

        private void BtnMod_Click(object sender, EventArgs e) {
            op = "%";
            sig1 = true;
            txtBresult.Text += " " + op + " ";
        }

        private void BtnPow_Click(object sender, EventArgs e) {
            op = "^";
            sig1 = true;
            txtBresult.Text += " " + op + " ";
        }
    }
}
