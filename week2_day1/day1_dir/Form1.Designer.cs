namespace day1_dir {
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
            this.Lbdir = new System.Windows.Forms.ListBox();
            this.Lbfile = new System.Windows.Forms.ListBox();
            this.Lbdinf = new System.Windows.Forms.ListBox();
            this.Btndir = new System.Windows.Forms.Button();
            this.Btnfile = new System.Windows.Forms.Button();
            this.Btndinf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbdir
            // 
            this.Lbdir.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbdir.FormattingEnabled = true;
            this.Lbdir.ItemHeight = 18;
            this.Lbdir.Location = new System.Drawing.Point(22, 31);
            this.Lbdir.Name = "Lbdir";
            this.Lbdir.Size = new System.Drawing.Size(429, 94);
            this.Lbdir.TabIndex = 0;
            // 
            // Lbfile
            // 
            this.Lbfile.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbfile.FormattingEnabled = true;
            this.Lbfile.ItemHeight = 18;
            this.Lbfile.Location = new System.Drawing.Point(22, 157);
            this.Lbfile.Name = "Lbfile";
            this.Lbfile.Size = new System.Drawing.Size(429, 94);
            this.Lbfile.TabIndex = 1;
            // 
            // Lbdinf
            // 
            this.Lbdinf.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbdinf.FormattingEnabled = true;
            this.Lbdinf.ItemHeight = 18;
            this.Lbdinf.Location = new System.Drawing.Point(22, 282);
            this.Lbdinf.Name = "Lbdinf";
            this.Lbdinf.Size = new System.Drawing.Size(429, 94);
            this.Lbdinf.TabIndex = 2;
            // 
            // Btndir
            // 
            this.Btndir.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btndir.Location = new System.Drawing.Point(502, 53);
            this.Btndir.Name = "Btndir";
            this.Btndir.Size = new System.Drawing.Size(183, 46);
            this.Btndir.TabIndex = 3;
            this.Btndir.Text = "디렉토리 목록";
            this.Btndir.UseVisualStyleBackColor = true;
            this.Btndir.Click += new System.EventHandler(this.Btndir_Click);
            // 
            // Btnfile
            // 
            this.Btnfile.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btnfile.Location = new System.Drawing.Point(502, 180);
            this.Btnfile.Name = "Btnfile";
            this.Btnfile.Size = new System.Drawing.Size(183, 46);
            this.Btnfile.TabIndex = 4;
            this.Btnfile.Text = "파일 목록";
            this.Btnfile.UseVisualStyleBackColor = true;
            this.Btnfile.Click += new System.EventHandler(this.Btnfile_Click);
            // 
            // Btndinf
            // 
            this.Btndinf.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btndinf.Location = new System.Drawing.Point(502, 305);
            this.Btndinf.Name = "Btndinf";
            this.Btndinf.Size = new System.Drawing.Size(183, 46);
            this.Btndinf.TabIndex = 5;
            this.Btndinf.Text = "디렉토리 정보";
            this.Btndinf.UseVisualStyleBackColor = true;
            this.Btndinf.Click += new System.EventHandler(this.Btndinf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btndinf);
            this.Controls.Add(this.Btnfile);
            this.Controls.Add(this.Btndir);
            this.Controls.Add(this.Lbdinf);
            this.Controls.Add(this.Lbfile);
            this.Controls.Add(this.Lbdir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lbdir;
        private System.Windows.Forms.ListBox Lbfile;
        private System.Windows.Forms.ListBox Lbdinf;
        private System.Windows.Forms.Button Btndir;
        private System.Windows.Forms.Button Btnfile;
        private System.Windows.Forms.Button Btndinf;
    }
}

