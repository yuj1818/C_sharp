namespace day5_Info {
    partial class Form2 {
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("동물");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.BtnReduce = new System.Windows.Forms.Button();
            this.BtnDelSel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(506, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 40);
            this.textBox1.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAdd.Location = new System.Drawing.Point(506, 97);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(265, 40);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(60, 31);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "root";
            treeNode5.Text = "동물";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(388, 352);
            this.treeView1.TabIndex = 3;
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDel.Location = new System.Drawing.Point(506, 159);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(265, 40);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "삭제";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnExpand.Location = new System.Drawing.Point(506, 220);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(265, 40);
            this.BtnExpand.TabIndex = 9;
            this.BtnExpand.Text = "확장";
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // BtnReduce
            // 
            this.BtnReduce.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnReduce.Location = new System.Drawing.Point(506, 283);
            this.BtnReduce.Name = "BtnReduce";
            this.BtnReduce.Size = new System.Drawing.Size(265, 40);
            this.BtnReduce.TabIndex = 10;
            this.BtnReduce.Text = "축소";
            this.BtnReduce.UseVisualStyleBackColor = true;
            this.BtnReduce.Click += new System.EventHandler(this.BtnReduce_Click);
            // 
            // BtnDelSel
            // 
            this.BtnDelSel.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelSel.Location = new System.Drawing.Point(506, 343);
            this.BtnDelSel.Name = "BtnDelSel";
            this.BtnDelSel.Size = new System.Drawing.Size(265, 40);
            this.BtnDelSel.TabIndex = 11;
            this.BtnDelSel.Text = "선택된 항목 삭제";
            this.BtnDelSel.UseVisualStyleBackColor = true;
            this.BtnDelSel.Click += new System.EventHandler(this.BtnDelSel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelSel);
            this.Controls.Add(this.BtnReduce);
            this.Controls.Add(this.BtnExpand);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnExpand;
        private System.Windows.Forms.Button BtnReduce;
        private System.Windows.Forms.Button BtnDelSel;
    }
}