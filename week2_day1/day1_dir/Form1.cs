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

namespace day1_dir {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Btndir_Click(object sender, EventArgs e) {
            Lbdir.Items.Clear();
            //string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);    //directory 안 찾아지면 using System.IO 추가하면 됨
            string[] apaths = Directory.GetDirectories(@"C:\Windows\System32");
            foreach (string apath in apaths) {
                Lbdir.Items.Add(apath);
            }
        }

        private void Btnfile_Click(object sender, EventArgs e) {
            Lbfile.Items.Clear();
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory);
            foreach (string afile in afiles) {
                Lbfile.Items.Add(afile);
            }
        }

        private void Btndinf_Click(object sender, EventArgs e) {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Windows\");
            Lbdinf.Items.Clear();
            if (dirInfo.Exists) {
                Lbdinf.Items.Add("전체경로: " + dirInfo.FullName);
                Lbdinf.Items.Add("디렉토리 이름: " + dirInfo.Name);
                Lbdinf.Items.Add("생성일: " + dirInfo.CreationTime);
                Lbdinf.Items.Add("속성: " + dirInfo.Attributes);
                Lbdinf.Items.Add("루트: " + dirInfo.Root);
            }
        }
    }
}
