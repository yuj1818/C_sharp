using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day5_Info {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnIn_Click(object sender, EventArgs e) {
            if(txtBName.Text == "" || txtBPnum.Text == "" || txtBGroup.Text == "") {
                MessageBox.Show("데이터를 입력해 주세요");
            } 
            else {
                string[] strItem = new string[] {txtBName.Text, txtBPnum.Text, txtBGroup.Text};
                ListViewItem listviews = new ListViewItem(strItem);
                listView1.Items.Add(listviews);
                txtBName.Clear();
                txtBPnum.Clear();
                txtBGroup.Clear();
            }
        }

        private void BtnDel_Click(object sender, EventArgs e) {
            listView1.Items.RemoveAt(listView1.FocusedItem.Index);
        }
    }
}
