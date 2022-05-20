namespace Order_Assignment {
    partial class MakeOrder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.gbMakeorder = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInputOrder = new System.Windows.Forms.Button();
            this.btnFindOrder = new System.Windows.Forms.Button();
            this.gbMakeorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(9, 95);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(90, 23);
            this.btnPlaceOrder.TabIndex = 10;
            this.btnPlaceOrder.Text = "주문";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // gbMakeorder
            // 
            this.gbMakeorder.Controls.Add(this.btnExit);
            this.gbMakeorder.Controls.Add(this.dtpOrderDate);
            this.gbMakeorder.Controls.Add(this.numOrderAmount);
            this.gbMakeorder.Controls.Add(this.btnPlaceOrder);
            this.gbMakeorder.Controls.Add(this.label1);
            this.gbMakeorder.Controls.Add(this.label4);
            this.gbMakeorder.Enabled = false;
            this.gbMakeorder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbMakeorder.Location = new System.Drawing.Point(51, 65);
            this.gbMakeorder.Name = "gbMakeorder";
            this.gbMakeorder.Size = new System.Drawing.Size(224, 134);
            this.gbMakeorder.TabIndex = 9;
            this.gbMakeorder.TabStop = false;
            this.gbMakeorder.Text = "주문 만들기";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(123, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "마침";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(89, 58);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(124, 22);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numOrderAmount.Location = new System.Drawing.Point(89, 25);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(124, 22);
            this.numOrderAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문 총액:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "주문 날짜:";
            // 
            // btnInputOrder
            // 
            this.btnInputOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInputOrder.Location = new System.Drawing.Point(60, 27);
            this.btnInputOrder.Name = "btnInputOrder";
            this.btnInputOrder.Size = new System.Drawing.Size(90, 23);
            this.btnInputOrder.TabIndex = 12;
            this.btnInputOrder.Text = "주문 입력";
            this.btnInputOrder.UseVisualStyleBackColor = true;
            this.btnInputOrder.Click += new System.EventHandler(this.btnInputOrder_Click);
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindOrder.Location = new System.Drawing.Point(174, 27);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(90, 23);
            this.btnFindOrder.TabIndex = 13;
            this.btnFindOrder.Text = "주문 찾기";
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnInputFindOrder_Click);
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 233);
            this.Controls.Add(this.btnFindOrder);
            this.Controls.Add(this.btnInputOrder);
            this.Controls.Add(this.gbMakeorder);
            this.Name = "MakeOrder";
            this.Text = "Form3";
            this.gbMakeorder.ResumeLayout(false);
            this.gbMakeorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox gbMakeorder;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInputOrder;
        private System.Windows.Forms.Button btnFindOrder;
    }
}