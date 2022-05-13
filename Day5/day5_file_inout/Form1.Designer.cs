namespace day5_file_inout {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFW_byte = new System.Windows.Forms.Button();
            this.BtnFR_byte = new System.Windows.Forms.Button();
            this.txtB_byte = new System.Windows.Forms.TextBox();
            this.txtB_txt = new System.Windows.Forms.TextBox();
            this.BtnFR_txt = new System.Windows.Forms.Button();
            this.BtnFW_txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filestream byte 단위 처리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(392, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "텍스트 입출력";
            // 
            // BtnFW_byte
            // 
            this.BtnFW_byte.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFW_byte.Location = new System.Drawing.Point(48, 80);
            this.BtnFW_byte.Name = "BtnFW_byte";
            this.BtnFW_byte.Size = new System.Drawing.Size(140, 38);
            this.BtnFW_byte.TabIndex = 2;
            this.BtnFW_byte.Text = "파일 쓰기";
            this.BtnFW_byte.UseVisualStyleBackColor = true;
            // 
            // BtnFR_byte
            // 
            this.BtnFR_byte.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFR_byte.Location = new System.Drawing.Point(210, 80);
            this.BtnFR_byte.Name = "BtnFR_byte";
            this.BtnFR_byte.Size = new System.Drawing.Size(140, 38);
            this.BtnFR_byte.TabIndex = 3;
            this.BtnFR_byte.Text = "파일 읽기";
            this.BtnFR_byte.UseVisualStyleBackColor = true;
            // 
            // txtB_byte
            // 
            this.txtB_byte.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtB_byte.Location = new System.Drawing.Point(48, 135);
            this.txtB_byte.Multiline = true;
            this.txtB_byte.Name = "txtB_byte";
            this.txtB_byte.Size = new System.Drawing.Size(302, 255);
            this.txtB_byte.TabIndex = 4;
            // 
            // txtB_txt
            // 
            this.txtB_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtB_txt.Location = new System.Drawing.Point(396, 135);
            this.txtB_txt.Multiline = true;
            this.txtB_txt.Name = "txtB_txt";
            this.txtB_txt.Size = new System.Drawing.Size(302, 255);
            this.txtB_txt.TabIndex = 7;
            // 
            // BtnFR_txt
            // 
            this.BtnFR_txt.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFR_txt.Location = new System.Drawing.Point(558, 80);
            this.BtnFR_txt.Name = "BtnFR_txt";
            this.BtnFR_txt.Size = new System.Drawing.Size(140, 38);
            this.BtnFR_txt.TabIndex = 6;
            this.BtnFR_txt.Text = "파일 읽기";
            this.BtnFR_txt.UseVisualStyleBackColor = true;
            // 
            // BtnFW_txt
            // 
            this.BtnFW_txt.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFW_txt.Location = new System.Drawing.Point(396, 80);
            this.BtnFW_txt.Name = "BtnFW_txt";
            this.BtnFW_txt.Size = new System.Drawing.Size(140, 38);
            this.BtnFW_txt.TabIndex = 5;
            this.BtnFW_txt.Text = "파일 쓰기";
            this.BtnFW_txt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 438);
            this.Controls.Add(this.txtB_txt);
            this.Controls.Add(this.BtnFR_txt);
            this.Controls.Add(this.BtnFW_txt);
            this.Controls.Add(this.txtB_byte);
            this.Controls.Add(this.BtnFR_byte);
            this.Controls.Add(this.BtnFW_byte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFW_byte;
        private System.Windows.Forms.Button BtnFR_byte;
        private System.Windows.Forms.TextBox txtB_byte;
        private System.Windows.Forms.TextBox txtB_txt;
        private System.Windows.Forms.Button BtnFR_txt;
        private System.Windows.Forms.Button BtnFW_txt;
    }
}

