using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day4_menu {
    public partial class Form1 : Form {
        string strOrder1 = "";
        public Form1() {
            InitializeComponent();
            Lbresult.Text = "";
            Lbagree.Text = "후기를 남겨주시면 이벤트에 응모됩니다.\n이벤트에 응모하려면 개인정보 동의해 주세요";
            LbRequest.Text = "";
        }

        private void BtnOrder_Click(object sender, EventArgs e) {
            string strOrder = "";
            if (ChBox_Kimchi.Checked == true) {
                strOrder += ChBox_Kimchi.Text + "\n";
                strOrder1 += ChBox_Kimchi.Text + " ";
            } 
            if (ChBox_Pork.Checked == true) {
                strOrder += ChBox_Pork.Text + "\n";
                strOrder1 += ChBox_Pork.Text + " ";
            }
            if(ChBox_Tang.Checked == true) {
                strOrder += ChBox_Tang.Text + "\n";
                strOrder1 += ChBox_Tang.Text + " ";
            }
            if(ChBox_Pasta.Checked == true) {
                strOrder += ChBox_Pasta.Text + "\n";
                strOrder1 += ChBox_Pasta.Text + " ";
            }
            Lbresult.Text = strOrder;
        }

        private void BtnApply_Click(object sender, EventArgs e) {
            if (RBtnO.Checked == true) {
                MessageBox.Show("개인정보 동의하셨습니다.");
            } 
            else {
                MessageBox.Show("개인정보 비동의하셨습니다.");
            }
        }

        private void BtnReceive_Click(object sender, EventArgs e) {
            LbRequest.Text =  "주문한 메뉴는 " + strOrder1 + "입니다.\n요구사항은 " + txtBrequest.Text + " 입니다.";
        }

        private void cmbPay_SelectedIndexChanged(object sender, EventArgs e) {
            LBpay.Items.Clear();
            if (cmbPay.SelectedItem == "신용카드") {
                LBpay.Items.Add("국민카드");
                LBpay.Items.Add("삼성카드");
                LBpay.Items.Add("신한카드");
            } else if (cmbPay.SelectedItem == "무통장 입금") {
                LBpay.Items.Add("국민은행");
                LBpay.Items.Add("신한은행");
                LBpay.Items.Add("농협은행");
            } else if (cmbPay.SelectedItem == "포인트 사용") {
                LBpay.Items.Add("해피포인트");
                LBpay.Items.Add("주유포인트");
            }
        }

        private void BtnPay_Click(object sender, EventArgs e) {
            MessageBox.Show(cmbPay.Text + " 결제 방법으로 " + LBpay.Text + "(으)로 결제되었습니다.");
        }
    }
}
