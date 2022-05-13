namespace day4_menu {
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
            this.Lbmenu = new System.Windows.Forms.Label();
            this.ChBox_Kimchi = new System.Windows.Forms.CheckBox();
            this.ChBox_Pork = new System.Windows.Forms.CheckBox();
            this.ChBox_Tang = new System.Windows.Forms.CheckBox();
            this.ChBox_Pasta = new System.Windows.Forms.CheckBox();
            this.LbOrder = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.Lbresult = new System.Windows.Forms.Label();
            this.Lbagree = new System.Windows.Forms.Label();
            this.GrBoxAgree = new System.Windows.Forms.GroupBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.RBtnX = new System.Windows.Forms.RadioButton();
            this.RBtnO = new System.Windows.Forms.RadioButton();
            this.txtBrequest = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.BtnReceive = new System.Windows.Forms.Button();
            this.LbRequest = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBpay = new System.Windows.Forms.ListBox();
            this.BtnPay = new System.Windows.Forms.Button();
            this.GrBoxAgree.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbmenu
            // 
            this.Lbmenu.AutoSize = true;
            this.Lbmenu.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbmenu.Location = new System.Drawing.Point(12, 9);
            this.Lbmenu.Name = "Lbmenu";
            this.Lbmenu.Size = new System.Drawing.Size(58, 23);
            this.Lbmenu.TabIndex = 0;
            this.Lbmenu.Text = "메뉴";
            // 
            // ChBox_Kimchi
            // 
            this.ChBox_Kimchi.AutoSize = true;
            this.ChBox_Kimchi.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChBox_Kimchi.Location = new System.Drawing.Point(88, 71);
            this.ChBox_Kimchi.Name = "ChBox_Kimchi";
            this.ChBox_Kimchi.Size = new System.Drawing.Size(115, 24);
            this.ChBox_Kimchi.TabIndex = 1;
            this.ChBox_Kimchi.Text = "김치찌개";
            this.ChBox_Kimchi.UseVisualStyleBackColor = true;
            // 
            // ChBox_Pork
            // 
            this.ChBox_Pork.AutoSize = true;
            this.ChBox_Pork.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChBox_Pork.Location = new System.Drawing.Point(229, 71);
            this.ChBox_Pork.Name = "ChBox_Pork";
            this.ChBox_Pork.Size = new System.Drawing.Size(94, 24);
            this.ChBox_Pork.TabIndex = 2;
            this.ChBox_Pork.Text = "돈까스";
            this.ChBox_Pork.UseVisualStyleBackColor = true;
            // 
            // ChBox_Tang
            // 
            this.ChBox_Tang.AutoSize = true;
            this.ChBox_Tang.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChBox_Tang.Location = new System.Drawing.Point(343, 71);
            this.ChBox_Tang.Name = "ChBox_Tang";
            this.ChBox_Tang.Size = new System.Drawing.Size(94, 24);
            this.ChBox_Tang.TabIndex = 3;
            this.ChBox_Tang.Text = "탕수육";
            this.ChBox_Tang.UseVisualStyleBackColor = true;
            // 
            // ChBox_Pasta
            // 
            this.ChBox_Pasta.AutoSize = true;
            this.ChBox_Pasta.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChBox_Pasta.Location = new System.Drawing.Point(457, 71);
            this.ChBox_Pasta.Name = "ChBox_Pasta";
            this.ChBox_Pasta.Size = new System.Drawing.Size(94, 24);
            this.ChBox_Pasta.TabIndex = 4;
            this.ChBox_Pasta.Text = "파스타";
            this.ChBox_Pasta.UseVisualStyleBackColor = true;
            // 
            // LbOrder
            // 
            this.LbOrder.AutoSize = true;
            this.LbOrder.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbOrder.Location = new System.Drawing.Point(566, 9);
            this.LbOrder.Name = "LbOrder";
            this.LbOrder.Size = new System.Drawing.Size(106, 23);
            this.LbOrder.TabIndex = 5;
            this.LbOrder.Text = "주문결과";
            // 
            // BtnOrder
            // 
            this.BtnOrder.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnOrder.Location = new System.Drawing.Point(262, 128);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(137, 46);
            this.BtnOrder.TabIndex = 6;
            this.BtnOrder.Text = "주문";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // Lbresult
            // 
            this.Lbresult.AutoSize = true;
            this.Lbresult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbresult.Location = new System.Drawing.Point(576, 48);
            this.Lbresult.Name = "Lbresult";
            this.Lbresult.Size = new System.Drawing.Size(0, 20);
            this.Lbresult.TabIndex = 7;
            // 
            // Lbagree
            // 
            this.Lbagree.AutoSize = true;
            this.Lbagree.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lbagree.Location = new System.Drawing.Point(17, 200);
            this.Lbagree.Name = "Lbagree";
            this.Lbagree.Size = new System.Drawing.Size(0, 20);
            this.Lbagree.TabIndex = 8;
            // 
            // GrBoxAgree
            // 
            this.GrBoxAgree.Controls.Add(this.BtnApply);
            this.GrBoxAgree.Controls.Add(this.RBtnX);
            this.GrBoxAgree.Controls.Add(this.RBtnO);
            this.GrBoxAgree.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GrBoxAgree.Location = new System.Drawing.Point(16, 262);
            this.GrBoxAgree.Name = "GrBoxAgree";
            this.GrBoxAgree.Size = new System.Drawing.Size(656, 96);
            this.GrBoxAgree.TabIndex = 9;
            this.GrBoxAgree.TabStop = false;
            this.GrBoxAgree.Text = "개인정보동의";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(498, 38);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(92, 34);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Text = "응모";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // RBtnX
            // 
            this.RBtnX.AutoSize = true;
            this.RBtnX.Location = new System.Drawing.Point(246, 43);
            this.RBtnX.Name = "RBtnX";
            this.RBtnX.Size = new System.Drawing.Size(93, 24);
            this.RBtnX.TabIndex = 1;
            this.RBtnX.TabStop = true;
            this.RBtnX.Text = "비동의";
            this.RBtnX.UseVisualStyleBackColor = true;
            // 
            // RBtnO
            // 
            this.RBtnO.AutoSize = true;
            this.RBtnO.Location = new System.Drawing.Point(32, 43);
            this.RBtnO.Name = "RBtnO";
            this.RBtnO.Size = new System.Drawing.Size(72, 24);
            this.RBtnO.TabIndex = 0;
            this.RBtnO.TabStop = true;
            this.RBtnO.Text = "동의";
            this.RBtnO.UseVisualStyleBackColor = true;
            // 
            // txtBrequest
            // 
            this.txtBrequest.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBrequest.Location = new System.Drawing.Point(16, 388);
            this.txtBrequest.Multiline = true;
            this.txtBrequest.Name = "txtBrequest";
            this.txtBrequest.Size = new System.Drawing.Size(477, 51);
            this.txtBrequest.TabIndex = 10;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelR.Location = new System.Drawing.Point(16, 367);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(172, 20);
            this.labelR.TabIndex = 11;
            this.labelR.Text = "주문 시 요구사항";
            // 
            // BtnReceive
            // 
            this.BtnReceive.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnReceive.Location = new System.Drawing.Point(535, 388);
            this.BtnReceive.Name = "BtnReceive";
            this.BtnReceive.Size = new System.Drawing.Size(137, 51);
            this.BtnReceive.TabIndex = 12;
            this.BtnReceive.Text = "접수";
            this.BtnReceive.UseVisualStyleBackColor = true;
            this.BtnReceive.Click += new System.EventHandler(this.BtnReceive_Click);
            // 
            // LbRequest
            // 
            this.LbRequest.AutoSize = true;
            this.LbRequest.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbRequest.Location = new System.Drawing.Point(16, 447);
            this.LbRequest.Name = "LbRequest";
            this.LbRequest.Size = new System.Drawing.Size(110, 20);
            this.LbRequest.TabIndex = 13;
            this.LbRequest.Text = "labelrequest";
            // 
            // cmbPay
            // 
            this.cmbPay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장 입금",
            "포인트 사용"});
            this.cmbPay.Location = new System.Drawing.Point(16, 522);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(172, 28);
            this.cmbPay.TabIndex = 14;
            this.cmbPay.SelectedIndexChanged += new System.EventHandler(this.cmbPay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "결제 방법";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(242, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "결제 정보";
            // 
            // LBpay
            // 
            this.LBpay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBpay.FormattingEnabled = true;
            this.LBpay.ItemHeight = 20;
            this.LBpay.Location = new System.Drawing.Point(246, 522);
            this.LBpay.Name = "LBpay";
            this.LBpay.Size = new System.Drawing.Size(247, 84);
            this.LBpay.TabIndex = 17;
            // 
            // BtnPay
            // 
            this.BtnPay.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPay.Location = new System.Drawing.Point(535, 522);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(137, 51);
            this.BtnPay.TabIndex = 18;
            this.BtnPay.Text = "결제";
            this.BtnPay.UseVisualStyleBackColor = true;
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 622);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.LBpay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPay);
            this.Controls.Add(this.LbRequest);
            this.Controls.Add(this.BtnReceive);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.txtBrequest);
            this.Controls.Add(this.GrBoxAgree);
            this.Controls.Add(this.Lbagree);
            this.Controls.Add(this.Lbresult);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.LbOrder);
            this.Controls.Add(this.ChBox_Pasta);
            this.Controls.Add(this.ChBox_Tang);
            this.Controls.Add(this.ChBox_Pork);
            this.Controls.Add(this.ChBox_Kimchi);
            this.Controls.Add(this.Lbmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrBoxAgree.ResumeLayout(false);
            this.GrBoxAgree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbmenu;
        private System.Windows.Forms.CheckBox ChBox_Kimchi;
        private System.Windows.Forms.CheckBox ChBox_Pork;
        private System.Windows.Forms.CheckBox ChBox_Tang;
        private System.Windows.Forms.CheckBox ChBox_Pasta;
        private System.Windows.Forms.Label LbOrder;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Label Lbresult;
        private System.Windows.Forms.Label Lbagree;
        private System.Windows.Forms.GroupBox GrBoxAgree;
        private System.Windows.Forms.RadioButton RBtnX;
        private System.Windows.Forms.RadioButton RBtnO;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.TextBox txtBrequest;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Button BtnReceive;
        private System.Windows.Forms.Label LbRequest;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBpay;
        private System.Windows.Forms.Button BtnPay;
    }
}

