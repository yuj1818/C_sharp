namespace day5_assignment_library {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnReg = new System.Windows.Forms.Button();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxBook = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBRday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBBday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rBtnF = new System.Windows.Forms.RadioButton();
            this.rBtnM = new System.Windows.Forms.RadioButton();
            this.txtBGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBPnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxAge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listAll = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Booklist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.BtnReg);
            this.groupBox1.Controls.Add(this.txtBID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cBoxBook);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBRday);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBBday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rBtnF);
            this.groupBox1.Controls.Add(this.rBtnM);
            this.groupBox1.Controls.Add(this.txtBGroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBPnum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 534);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(669, 259);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 184);
            this.listBox2.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(393, 259);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 184);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(60, 452);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(166, 50);
            this.BtnReg.TabIndex = 21;
            this.BtnReg.Text = "등록";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // txtBID
            // 
            this.txtBID.Location = new System.Drawing.Point(115, 44);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(248, 30);
            this.txtBID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "아이디:";
            // 
            // cBoxBook
            // 
            this.cBoxBook.FormattingEnabled = true;
            this.cBoxBook.Items.AddRange(new object[] {
            "IT",
            "역사",
            "예술"});
            this.cBoxBook.Location = new System.Drawing.Point(125, 259);
            this.cBoxBook.Name = "cBoxBook";
            this.cBoxBook.Size = new System.Drawing.Size(238, 28);
            this.cBoxBook.TabIndex = 17;
            this.cBoxBook.SelectedIndexChanged += new System.EventHandler(this.cBoxBook_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "대여도서";
            // 
            // txtBRday
            // 
            this.txtBRday.Location = new System.Drawing.Point(669, 190);
            this.txtBRday.Name = "txtBRday";
            this.txtBRday.Size = new System.Drawing.Size(248, 30);
            this.txtBRday.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "반납일자:";
            // 
            // txtBBday
            // 
            this.txtBBday.Location = new System.Drawing.Point(669, 135);
            this.txtBBday.Name = "txtBBday";
            this.txtBBday.Size = new System.Drawing.Size(248, 30);
            this.txtBBday.TabIndex = 13;
            this.txtBBday.TextChanged += new System.EventHandler(this.txtBBday_TextChanged);
            this.txtBBday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBBday_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "대여일자:";
            // 
            // rBtnF
            // 
            this.rBtnF.AutoSize = true;
            this.rBtnF.Location = new System.Drawing.Point(258, 201);
            this.rBtnF.Name = "rBtnF";
            this.rBtnF.Size = new System.Drawing.Size(72, 24);
            this.rBtnF.TabIndex = 11;
            this.rBtnF.TabStop = true;
            this.rBtnF.Text = "여성";
            this.rBtnF.UseVisualStyleBackColor = true;
            // 
            // rBtnM
            // 
            this.rBtnM.AutoSize = true;
            this.rBtnM.Location = new System.Drawing.Point(154, 201);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(72, 24);
            this.rBtnM.TabIndex = 10;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "남성";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // txtBGroup
            // 
            this.txtBGroup.Location = new System.Drawing.Point(669, 86);
            this.txtBGroup.Name = "txtBGroup";
            this.txtBGroup.Size = new System.Drawing.Size(248, 30);
            this.txtBGroup.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "소   속:";
            // 
            // txtBPnum
            // 
            this.txtBPnum.Location = new System.Drawing.Point(669, 40);
            this.txtBPnum.Name = "txtBPnum";
            this.txtBPnum.Size = new System.Drawing.Size(248, 30);
            this.txtBPnum.TabIndex = 7;
            this.txtBPnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPnum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "연락처:";
            // 
            // cBoxAge
            // 
            this.cBoxAge.FormattingEnabled = true;
            this.cBoxAge.Items.AddRange(new object[] {
            "10대",
            "20대",
            "30대",
            "40대",
            "50대"});
            this.cBoxAge.Location = new System.Drawing.Point(115, 146);
            this.cBoxAge.Name = "cBoxAge";
            this.cBoxAge.Size = new System.Drawing.Size(248, 28);
            this.cBoxAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "성   별:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "나   이:";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(115, 92);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(248, 30);
            this.txtBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "이   름:";
            // 
            // listAll
            // 
            this.listAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.age,
            this.gender,
            this.PhoneNumber,
            this.group,
            this.Bday,
            this.Rday,
            this.Booklist});
            this.listAll.HideSelection = false;
            this.listAll.Location = new System.Drawing.Point(26, 584);
            this.listAll.Name = "listAll";
            this.listAll.Size = new System.Drawing.Size(954, 165);
            this.listAll.TabIndex = 5;
            this.listAll.UseCompatibleStateImageBehavior = false;
            this.listAll.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "아이디";
            this.id.Width = 100;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 100;
            // 
            // age
            // 
            this.age.Text = "나이";
            this.age.Width = 50;
            // 
            // gender
            // 
            this.gender.Text = "성별";
            this.gender.Width = 50;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "연락처";
            this.PhoneNumber.Width = 150;
            // 
            // group
            // 
            this.group.Text = "소속";
            this.group.Width = 100;
            // 
            // Bday
            // 
            this.Bday.Text = "대여일자";
            this.Bday.Width = 100;
            // 
            // Rday
            // 
            this.Rday.Text = "반납일자";
            this.Rday.Width = 100;
            // 
            // Booklist
            // 
            this.Booklist.Text = "대여도서목록";
            this.Booklist.Width = 200;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(645, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "* yyyy-mm-dd 형식으로 입력해주세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 761);
            this.Controls.Add(this.listAll);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnF;
        private System.Windows.Forms.RadioButton rBtnM;
        private System.Windows.Forms.TextBox txtBGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBPnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBRday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBBday;
        private System.Windows.Forms.ListView listAll;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader group;
        private System.Windows.Forms.ColumnHeader Bday;
        private System.Windows.Forms.ColumnHeader Rday;
        private System.Windows.Forms.ColumnHeader Booklist;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
    }
}

