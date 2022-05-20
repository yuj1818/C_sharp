using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Order_Assignment {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private bool IsCustomerNameValid() {
            if (txtlogName.Text == "") {
                MessageBox.Show("Please enter a Name");
                return false;
            }
            else {
                return true;
            }
        }

        private bool IsCustomerIDValid() {
            if (txtlogID.Text == "") {
                MessageBox.Show("Please enter a ID");
                return false;
            }
            else {
                return true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            Form frm = new MakeAccount();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (IsCustomerIDValid()) {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString)) {
                    // Create the SqlCommand object and identify it as a stored procedure.
                    connection.Open();
                    bool login = false;
                    int login_id = Int32.Parse(txtlogID.Text);
                    string login_name = txtlogName.Text;

                    string sql = "SELECT * FROM [Sales].[Customer] WHERE [CustomerID] = \'" + login_id + "\' ";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader mdr = cmd.ExecuteReader();
                    while(mdr.Read()) {
                        if(login_id == (int)mdr["CustomerID"] && login_name == (string)mdr["CustomerName"]) {
                            login = true;
                        }
                    }
                    mdr.Close();

                    if (login) {
                        Form frm = new MakeOrder(Int32.Parse(txtlogID.Text));
                        frm.Show();
                    }
                    else {
                        MessageBox.Show("아이디/이름을 확인해 주세요.");
                    }
                }
            }
        }

        private void txtlogID_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }
    }
}
