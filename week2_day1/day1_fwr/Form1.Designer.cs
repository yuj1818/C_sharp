namespace day1_fwr {
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
            this.txtB_txt = new System.Windows.Forms.TextBox();
            this.btnFR_txt = new System.Windows.Forms.Button();
            this.btnFS_txt = new System.Windows.Forms.Button();
            this.txtB_byte = new System.Windows.Forms.TextBox();
            this.btnFR_byte = new System.Windows.Forms.Button();
            this.btnFW_byte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFinfo = new System.Windows.Forms.ListBox();
            this.btnFinfo = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstripF = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrcmbNew = new System.Windows.Forms.ToolStripComboBox();
            this.tstrtbOpen = new System.Windows.Forms.ToolStripTextBox();
            this.tstrtbSave = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB_txt
            // 
            this.txtB_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtB_txt.Location = new System.Drawing.Point(391, 283);
            this.txtB_txt.Multiline = true;
            this.txtB_txt.Name = "txtB_txt";
            this.txtB_txt.Size = new System.Drawing.Size(302, 255);
            this.txtB_txt.TabIndex = 15;
            // 
            // btnFR_txt
            // 
            this.btnFR_txt.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFR_txt.Location = new System.Drawing.Point(553, 228);
            this.btnFR_txt.Name = "btnFR_txt";
            this.btnFR_txt.Size = new System.Drawing.Size(140, 38);
            this.btnFR_txt.TabIndex = 14;
            this.btnFR_txt.Text = "파일 읽기";
            this.btnFR_txt.UseVisualStyleBackColor = true;
            this.btnFR_txt.Click += new System.EventHandler(this.btnFR_txt_Click);
            // 
            // btnFS_txt
            // 
            this.btnFS_txt.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFS_txt.Location = new System.Drawing.Point(391, 228);
            this.btnFS_txt.Name = "btnFS_txt";
            this.btnFS_txt.Size = new System.Drawing.Size(140, 38);
            this.btnFS_txt.TabIndex = 13;
            this.btnFS_txt.Text = "파일 저장";
            this.btnFS_txt.UseVisualStyleBackColor = true;
            this.btnFS_txt.Click += new System.EventHandler(this.btnFS_txt_Click);
            // 
            // txtB_byte
            // 
            this.txtB_byte.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtB_byte.Location = new System.Drawing.Point(43, 283);
            this.txtB_byte.Multiline = true;
            this.txtB_byte.Name = "txtB_byte";
            this.txtB_byte.Size = new System.Drawing.Size(302, 255);
            this.txtB_byte.TabIndex = 12;
            // 
            // btnFR_byte
            // 
            this.btnFR_byte.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFR_byte.Location = new System.Drawing.Point(205, 228);
            this.btnFR_byte.Name = "btnFR_byte";
            this.btnFR_byte.Size = new System.Drawing.Size(140, 38);
            this.btnFR_byte.TabIndex = 11;
            this.btnFR_byte.Text = "파일 읽기";
            this.btnFR_byte.UseVisualStyleBackColor = true;
            this.btnFR_byte.Click += new System.EventHandler(this.btnFR_byte_Click);
            // 
            // btnFW_byte
            // 
            this.btnFW_byte.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFW_byte.Location = new System.Drawing.Point(43, 228);
            this.btnFW_byte.Name = "btnFW_byte";
            this.btnFW_byte.Size = new System.Drawing.Size(140, 38);
            this.btnFW_byte.TabIndex = 10;
            this.btnFW_byte.Text = "파일 쓰기";
            this.btnFW_byte.UseVisualStyleBackColor = true;
            this.btnFW_byte.Click += new System.EventHandler(this.btnFW_byte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(387, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "텍스트 입출력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filestream byte 단위 처리";
            // 
            // lbFinfo
            // 
            this.lbFinfo.FormattingEnabled = true;
            this.lbFinfo.ItemHeight = 15;
            this.lbFinfo.Location = new System.Drawing.Point(43, 64);
            this.lbFinfo.Name = "lbFinfo";
            this.lbFinfo.Size = new System.Drawing.Size(302, 109);
            this.lbFinfo.TabIndex = 16;
            // 
            // btnFinfo
            // 
            this.btnFinfo.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFinfo.Location = new System.Drawing.Point(553, 100);
            this.btnFinfo.Name = "btnFinfo";
            this.btnFinfo.Size = new System.Drawing.Size(140, 38);
            this.btnFinfo.TabIndex = 18;
            this.btnFinfo.Text = "파일 정보";
            this.btnFinfo.UseVisualStyleBackColor = true;
            this.btnFinfo.Click += new System.EventHandler(this.btnFinfo_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCopy.Location = new System.Drawing.Point(391, 100);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(140, 38);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "파일 복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(39, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "파일 정보";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripF});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstripF
            // 
            this.tstripF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrcmbNew,
            this.tstrtbOpen,
            this.tstrtbSave,
            this.toolStripSeparator1,
            this.tstripExit});
            this.tstripF.Name = "tstripF";
            this.tstripF.Size = new System.Drawing.Size(43, 20);
            this.tstripF.Text = "파일";
            // 
            // tstrcmbNew
            // 
            this.tstrcmbNew.Name = "tstrcmbNew";
            this.tstrcmbNew.Size = new System.Drawing.Size(121, 23);
            this.tstrcmbNew.Text = " 새로 만들기";
            this.tstrcmbNew.Click += new System.EventHandler(this.tstrcmbNew_Click);
            // 
            // tstrtbOpen
            // 
            this.tstrtbOpen.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tstrtbOpen.Name = "tstrtbOpen";
            this.tstrtbOpen.Size = new System.Drawing.Size(100, 23);
            this.tstrtbOpen.Text = "열기";
            this.tstrtbOpen.Click += new System.EventHandler(this.tstrtbOpen_Click);
            // 
            // tstrtbSave
            // 
            this.tstrtbSave.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.tstrtbSave.Name = "tstrtbSave";
            this.tstrtbSave.Size = new System.Drawing.Size(100, 23);
            this.tstrtbSave.Text = "저장";
            this.tstrtbSave.Click += new System.EventHandler(this.tstrtbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // tstripExit
            // 
            this.tstripExit.Name = "tstripExit";
            this.tstripExit.Size = new System.Drawing.Size(181, 22);
            this.tstripExit.Text = "종료";
            this.tstripExit.Click += new System.EventHandler(this.tstripExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinfo);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lbFinfo);
            this.Controls.Add(this.txtB_txt);
            this.Controls.Add(this.btnFR_txt);
            this.Controls.Add(this.btnFS_txt);
            this.Controls.Add(this.txtB_byte);
            this.Controls.Add(this.btnFR_byte);
            this.Controls.Add(this.btnFW_byte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_txt;
        private System.Windows.Forms.Button btnFR_txt;
        private System.Windows.Forms.Button btnFS_txt;
        private System.Windows.Forms.TextBox txtB_byte;
        private System.Windows.Forms.Button btnFR_byte;
        private System.Windows.Forms.Button btnFW_byte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFinfo;
        private System.Windows.Forms.Button btnFinfo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstripF;
        private System.Windows.Forms.ToolStripComboBox tstrcmbNew;
        private System.Windows.Forms.ToolStripTextBox tstrtbOpen;
        private System.Windows.Forms.ToolStripTextBox tstrtbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tstripExit;
        private System.Windows.Forms.Label label4;
    }
}

