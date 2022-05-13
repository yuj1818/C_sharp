namespace day5_Info {
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
            this.LbName = new System.Windows.Forms.Label();
            this.LbPnum = new System.Windows.Forms.Label();
            this.LbGroup = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBPnum = new System.Windows.Forms.TextBox();
            this.txtBGroup = new System.Windows.Forms.TextBox();
            this.BtnIn = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbName.Location = new System.Drawing.Point(126, 51);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(89, 23);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "이   름:";
            // 
            // LbPnum
            // 
            this.LbPnum.AutoSize = true;
            this.LbPnum.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbPnum.Location = new System.Drawing.Point(126, 95);
            this.LbPnum.Name = "LbPnum";
            this.LbPnum.Size = new System.Drawing.Size(89, 23);
            this.LbPnum.TabIndex = 1;
            this.LbPnum.Text = "휴대폰:";
            // 
            // LbGroup
            // 
            this.LbGroup.AutoSize = true;
            this.LbGroup.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LbGroup.Location = new System.Drawing.Point(126, 134);
            this.LbGroup.Name = "LbGroup";
            this.LbGroup.Size = new System.Drawing.Size(89, 23);
            this.LbGroup.TabIndex = 2;
            this.LbGroup.Text = "소   속:";
            // 
            // txtBName
            // 
            this.txtBName.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBName.Location = new System.Drawing.Point(221, 49);
            this.txtBName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBName.Multiline = true;
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(229, 25);
            this.txtBName.TabIndex = 3;
            // 
            // txtBPnum
            // 
            this.txtBPnum.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBPnum.Location = new System.Drawing.Point(221, 95);
            this.txtBPnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBPnum.Multiline = true;
            this.txtBPnum.Name = "txtBPnum";
            this.txtBPnum.Size = new System.Drawing.Size(229, 25);
            this.txtBPnum.TabIndex = 4;
            // 
            // txtBGroup
            // 
            this.txtBGroup.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBGroup.Location = new System.Drawing.Point(221, 134);
            this.txtBGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBGroup.Multiline = true;
            this.txtBGroup.Name = "txtBGroup";
            this.txtBGroup.Size = new System.Drawing.Size(229, 25);
            this.txtBGroup.TabIndex = 5;
            // 
            // BtnIn
            // 
            this.BtnIn.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnIn.Location = new System.Drawing.Point(554, 43);
            this.BtnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(181, 45);
            this.BtnIn.TabIndex = 6;
            this.BtnIn.Text = "입력";
            this.BtnIn.UseVisualStyleBackColor = true;
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDel.Location = new System.Drawing.Point(554, 114);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(181, 45);
            this.BtnDel.TabIndex = 7;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListName,
            this.ListPnum,
            this.ListGroup});
            this.listView1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(130, 188);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 256);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ListName
            // 
            this.ListName.Text = "이름";
            this.ListName.Width = 200;
            // 
            // ListPnum
            // 
            this.ListPnum.Text = "휴대폰";
            this.ListPnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListPnum.Width = 200;
            // 
            // ListGroup
            // 
            this.ListGroup.Text = "소속";
            this.ListGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListGroup.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 548);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnIn);
            this.Controls.Add(this.txtBGroup);
            this.Controls.Add(this.txtBPnum);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.LbGroup);
            this.Controls.Add(this.LbPnum);
            this.Controls.Add(this.LbName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbPnum;
        private System.Windows.Forms.Label LbGroup;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBPnum;
        private System.Windows.Forms.TextBox txtBGroup;
        private System.Windows.Forms.Button BtnIn;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ListName;
        private System.Windows.Forms.ColumnHeader ListPnum;
        private System.Windows.Forms.ColumnHeader ListGroup;
    }
}

