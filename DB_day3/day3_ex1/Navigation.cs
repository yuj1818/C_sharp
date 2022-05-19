using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day3_ex1 {
    public partial class Navigation : Form {
        public Navigation() {
            InitializeComponent();
        }

        private void btnGotoAdd_Click(object sender, EventArgs e) {
            Form frm = new NewCustomer();
            frm.Show();
        }

        private void btnGotoFillOrCancel_Click(object sender, EventArgs e) {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
