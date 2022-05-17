using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace day1_fwr {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            string path = @"C:\fs.txt";

            try {
                lbFinfo.Items.Clear();
                if(File.Exists(path)) {
                    File.Copy(path, @"C:\fs_복사.txt");
                    lbFinfo.Items.Add("복사가 완료");
                } 
                else {
                    lbFinfo.Items.Clear();
                    lbFinfo.Items.Add("파일이 없음");
                }
            } 
            catch (Exception) {
                lbFinfo.Items.Clear();
                lbFinfo.Items.Add("이미 파일이 존재");
            }
        }

        private void btnFinfo_Click(object sender, EventArgs e) {
            lbFinfo.Items.Clear();
            FileInfo fileInfo = new FileInfo(@"C:\fs.txt");

            if (fileInfo.Exists) {
                lbFinfo.Items.Add("파일 디렉토리: " + fileInfo.Directory);
                lbFinfo.Items.Add("파일 이름: " + fileInfo.Name);
                lbFinfo.Items.Add("파일 확장자: " + fileInfo.Extension);
                lbFinfo.Items.Add("생성 일자: " + fileInfo.CreationTime);
                lbFinfo.Items.Add("파일 크기: " + fileInfo.Length);
            }
        }

        private void btnFW_byte_Click(object sender, EventArgs e) {
            FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Create, FileAccess.Write);
            byte[] data = new byte[26];
            for (int i = 0; i< data.Length; i++) {
                data[i] = (byte)(65 + i);
            }

            fs.Write(data, 0, data.Length);
            fs.Close();
            MessageBox.Show("파일 기록");
        }

        private void btnFR_byte_Click(object sender, EventArgs e) {
            try {
                FileStream fs = new FileStream(@"d:\fs.txt", FileMode.Open, FileAccess.Read);
                
                byte[] readData = new byte[26];
                
                fs.Read(readData, 0, readData.Length);
                fs.Close();

                for(int i=0; i< readData.Length; i++) {
                    txtB_byte.Text += Convert.ToChar(readData[i]) + ",";
                }
            } 
            catch (Exception) {
                MessageBox.Show("파일을 찾을 수 없습니다.");
            }
        }

        private void btnFS_txt_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter(@"d:\sw.txt");
            sw.Write(txtB_txt.Text);
            sw.Close();
            txtB_txt.Clear();
            MessageBox.Show("텍스트 저장");
        }

        private void btnFR_txt_Click(object sender, EventArgs e) {
            try {
                //char[] buffer = new char[10];     //강사님 버전
                //int charCount = 0;

                StreamReader sr = new StreamReader(@"d:\sw.txt");
                //string line = "";
                //int ch;
                //while((line = sr.ReadLine()) != null) {
                //    txtB_txt.Text += line + "\r\n";     //txtbox에서 줄바꿈하려면 \r\n으로 써야함
                //}
                //while (!sr.EndOfStream) {                 //강사님 버전
                //    charCount = sr.Read(buffer, 0, 1);   

                //    for(int i=0; i<charCount;i++) {
                //        txtB_txt.Text += buffer[i];
                //    }
                //}
                //while((ch = sr.Read())>-1) {
                //    txtB_txt.Text += Convert.ToChar(ch);
                //}
                //sr.Close();
                txtB_txt.Text = sr.ReadToEnd();
            } 
            catch (Exception) {
                MessageBox.Show("파일을 찾을 수 없습니다.");
            }
        }

        private void tstrcmbNew_Click(object sender, EventArgs e) {
            label4.Text = "새 파일";
        }

        private void tstrtbOpen_Click(object sender, EventArgs e) {
            label4.Text = "열기";
        }

        private void tstrtbSave_Click(object sender, EventArgs e) {
            label4.Text = "저장";
        }

        private void tstripExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
