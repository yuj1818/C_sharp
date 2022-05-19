namespace day3_ex1 {
    partial class Navigation {
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
            this.btnGotoAdd = new System.Windows.Forms.Button();
            this.btnGotoFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "원하는 작업을 선택하세요";
            // 
            // btnGotoAdd
            // 
            this.btnGotoAdd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGotoAdd.Location = new System.Drawing.Point(136, 78);
            this.btnGotoAdd.Name = "btnGotoAdd";
            this.btnGotoAdd.Size = new System.Drawing.Size(87, 30);
            this.btnGotoAdd.TabIndex = 1;
            this.btnGotoAdd.Text = "계정 추가";
            this.btnGotoAdd.UseVisualStyleBackColor = true;
            this.btnGotoAdd.Click += new System.EventHandler(this.btnGotoAdd_Click);
            // 
            // btnGotoFillOrCancel
            // 
            this.btnGotoFillOrCancel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGotoFillOrCancel.Location = new System.Drawing.Point(105, 126);
            this.btnGotoFillOrCancel.Name = "btnGotoFillOrCancel";
            this.btnGotoFillOrCancel.Size = new System.Drawing.Size(152, 30);
            this.btnGotoFillOrCancel.TabIndex = 2;
            this.btnGotoFillOrCancel.Text = "주문 입력 or 취소";
            this.btnGotoFillOrCancel.UseVisualStyleBackColor = true;
            this.btnGotoFillOrCancel.Click += new System.EventHandler(this.btnGotoFillOrCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(307, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGotoFillOrCancel);
            this.Controls.Add(this.btnGotoAdd);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGotoAdd;
        private System.Windows.Forms.Button btnGotoFillOrCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

