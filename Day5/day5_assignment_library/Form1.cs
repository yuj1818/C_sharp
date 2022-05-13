using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5_assignment_library {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void cBoxBook_SelectedIndexChanged(object sender, EventArgs e) {
            listBox1.Items.Clear();
            if (cBoxBook.SelectedItem == "IT") {
                listBox1.Items.Add("프로그래밍 도서");
                listBox1.Items.Add("AI 도서");
                listBox1.Items.Add("IoT 도서");
            }
            else if(cBoxBook.SelectedItem == "역사") {
                listBox1.Items.Add("한국사");
                listBox1.Items.Add("세계사");
            }
            else if(cBoxBook.SelectedItem == "예술") {
                listBox1.Items.Add("미술");
                listBox1.Items.Add("음악");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            listBox2.Items.Clear();
            if(cBoxBook.SelectedItem == "IT") {
                if (listBox1.SelectedItem == "프로그래밍 도서") {
                    listBox2.Items.Add("C#");
                    listBox2.Items.Add("JAVA");
                    listBox2.Items.Add("Python");
                }
                else if(listBox1.SelectedItem == "AI 도서") {
                    listBox2.Items.Add("Orange 데이터 마이닝");
                    listBox2.Items.Add("OpenCV");
                    listBox2.Items.Add("딥러닝");
                }
                else if(listBox1.SelectedItem == "IoT 도서") {
                    listBox2.Items.Add("라즈베리파이");
                    listBox2.Items.Add("젯슨나노");
                    listBox2.Items.Add("아두이노");
                }
            }
            else if(cBoxBook.SelectedItem == "역사") {
                if(listBox1.SelectedItem == "한국사") {
                    listBox2.Items.Add("삼국시대");
                    listBox2.Items.Add("조선시대");
                    listBox2.Items.Add("근현대사");
                }
                else if(listBox1.SelectedItem == "세계사") {
                    listBox2.Items.Add("고대");
                    listBox2.Items.Add("중세");
                    listBox2.Items.Add("근현대");
                }
            }
            else if(cBoxBook.SelectedItem == "예술") {
                if (listBox1.SelectedItem == "미술") {
                    listBox2.Items.Add("근세미술");
                    listBox2.Items.Add("근대미술");
                    listBox2.Items.Add("현대미술");
                }
                else if(listBox1.SelectedItem == "음악") {
                    listBox2.Items.Add("중세시대");
                    listBox2.Items.Add("르네상스시대");
                    listBox2.Items.Add("바로크시대");
                }
            }
        }

        private void BtnReg_Click(object sender, EventArgs e) {
            string gender;
            if (rBtnM.Checked) {
                gender = "남성";
            } 
            else {
                gender = "여성";
            }
            if (txtBName.Text == "" || txtBPnum.Text == "" || txtBGroup.Text == "" || txtBID.Text == "" || txtBBday.Text == "" || cBoxBook.Text == "" || (rBtnF.Checked == false && rBtnM.Checked == false) || cBoxAge.SelectedItem == "") {
                MessageBox.Show("데이터를 입력해 주세요");
            } else {
                string[] strItem = new string[] { txtBID.Text,txtBName.Text, cBoxAge.Text, gender, txtBPnum.Text, txtBGroup.Text, txtBBday.Text, txtBRday.Text, listBox2.SelectedItem.ToString() };
                ListViewItem listviews = new ListViewItem(strItem);
                listAll.Items.Add(listviews);
                txtBID.Clear();
                txtBName.Clear();
                cBoxAge.SelectedItem = null;
                rBtnF.Checked = false;
                rBtnM.Checked = false;
                txtBPnum.Clear();
                txtBGroup.Clear();
                txtBBday.Clear();
                txtBRday.Clear();
                cBoxBook.SelectedItem = null;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }

        private void txtBBday_TextChanged(object sender, EventArgs e) {
            if (txtBBday.Text.Length == 10) {
                DateTime bday = Convert.ToDateTime(txtBBday.Text);
                DateTime rday = bday.AddDays(7);
                txtBRday.Text = rday.Date.ToString("d");
            }
        }

        private void txtBBday_KeyPress(object sender, KeyPressEventArgs e) {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-')) {
                e.Handled = true;
            }
        }

        private void txtBPnum_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) {
                e.Handled = true;
            }
        }
    }
}
