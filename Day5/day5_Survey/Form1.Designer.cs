namespace day5_Survey {
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
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxField = new System.Windows.Forms.ComboBox();
            this.listBField = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보";
            // 
            // rBtnF
            // 
            this.rBtnF.AutoSize = true;
            this.rBtnF.Location = new System.Drawing.Point(205, 141);
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
            this.rBtnM.Location = new System.Drawing.Point(111, 141);
            this.rBtnM.Name = "rBtnM";
            this.rBtnM.Size = new System.Drawing.Size(72, 24);
            this.rBtnM.TabIndex = 10;
            this.rBtnM.TabStop = true;
            this.rBtnM.Text = "남성";
            this.rBtnM.UseVisualStyleBackColor = true;
            // 
            // txtBGroup
            // 
            this.txtBGroup.Location = new System.Drawing.Point(503, 86);
            this.txtBGroup.Name = "txtBGroup";
            this.txtBGroup.Size = new System.Drawing.Size(166, 30);
            this.txtBGroup.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "소   속:";
            // 
            // txtBPnum
            // 
            this.txtBPnum.Location = new System.Drawing.Point(503, 38);
            this.txtBPnum.Name = "txtBPnum";
            this.txtBPnum.Size = new System.Drawing.Size(166, 30);
            this.txtBPnum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 44);
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
            this.cBoxAge.Location = new System.Drawing.Point(111, 92);
            this.cBoxAge.Name = "cBoxAge";
            this.cBoxAge.Size = new System.Drawing.Size(166, 28);
            this.cBoxAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "성   별:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "나   이:";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(111, 38);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(166, 30);
            this.txtBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "이   름:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(33, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "1. 관심이 있는 분야는 무엇인가요?";
            // 
            // cBoxField
            // 
            this.cBoxField.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cBoxField.FormattingEnabled = true;
            this.cBoxField.Items.AddRange(new object[] {
            "프론트엔드",
            "백엔드"});
            this.cBoxField.Location = new System.Drawing.Point(37, 270);
            this.cBoxField.Name = "cBoxField";
            this.cBoxField.Size = new System.Drawing.Size(147, 28);
            this.cBoxField.TabIndex = 2;
            // 
            // listBField
            // 
            this.listBField.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBField.FormattingEnabled = true;
            this.listBField.ItemHeight = 20;
            this.listBField.Location = new System.Drawing.Point(211, 270);
            this.listBField.Name = "listBField";
            this.listBField.Size = new System.Drawing.Size(168, 84);
            this.listBField.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 572);
            this.Controls.Add(this.listBField);
            this.Controls.Add(this.cBoxField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxField;
        private System.Windows.Forms.ListBox listBField;
    }
}

