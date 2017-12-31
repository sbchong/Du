namespace Du
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateMBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.infolabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OutMBtn = new System.Windows.Forms.Button();
            this.CreateABtn = new System.Windows.Forms.Button();
            this.OutABtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DegreeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateMBtn
            // 
            this.CreateMBtn.Location = new System.Drawing.Point(125, 52);
            this.CreateMBtn.Name = "CreateMBtn";
            this.CreateMBtn.Size = new System.Drawing.Size(94, 23);
            this.CreateMBtn.TabIndex = 0;
            this.CreateMBtn.Text = "建立邻接矩阵";
            this.CreateMBtn.UseVisualStyleBackColor = true;
            this.CreateMBtn.Click += new System.EventHandler(this.CreateMBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 52);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "打开";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(30, 399);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(41, 12);
            this.infolabel.TabIndex = 2;
            this.infolabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 240);
            this.textBox1.TabIndex = 3;
            // 
            // OutMBtn
            // 
            this.OutMBtn.Location = new System.Drawing.Point(125, 96);
            this.OutMBtn.Name = "OutMBtn";
            this.OutMBtn.Size = new System.Drawing.Size(94, 23);
            this.OutMBtn.TabIndex = 4;
            this.OutMBtn.Text = "输出邻接矩阵";
            this.OutMBtn.UseVisualStyleBackColor = true;
            this.OutMBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // CreateABtn
            // 
            this.CreateABtn.Location = new System.Drawing.Point(242, 52);
            this.CreateABtn.Name = "CreateABtn";
            this.CreateABtn.Size = new System.Drawing.Size(96, 23);
            this.CreateABtn.TabIndex = 5;
            this.CreateABtn.Text = "建立邻接表";
            this.CreateABtn.UseVisualStyleBackColor = true;
            this.CreateABtn.Click += new System.EventHandler(this.CreateABtn_Click);
            // 
            // OutABtn
            // 
            this.OutABtn.Location = new System.Drawing.Point(242, 96);
            this.OutABtn.Name = "OutABtn";
            this.OutABtn.Size = new System.Drawing.Size(96, 23);
            this.OutABtn.TabIndex = 6;
            this.OutABtn.Text = "输出邻接表";
            this.OutABtn.UseVisualStyleBackColor = true;
            this.OutABtn.Click += new System.EventHandler(this.OutABtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 96);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "返回主界面";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "无向图",
            "有向图"});
            this.comboBox1.Location = new System.Drawing.Point(242, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 20);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DegreeBtn
            // 
            this.DegreeBtn.Location = new System.Drawing.Point(365, 52);
            this.DegreeBtn.Name = "DegreeBtn";
            this.DegreeBtn.Size = new System.Drawing.Size(95, 23);
            this.DegreeBtn.TabIndex = 9;
            this.DegreeBtn.Text = "顶点和边";
            this.DegreeBtn.UseVisualStyleBackColor = true;
            this.DegreeBtn.Click += new System.EventHandler(this.DegreeBtn_Click);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 440);
            this.Controls.Add(this.DegreeBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OutABtn);
            this.Controls.Add(this.CreateABtn);
            this.Controls.Add(this.OutMBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.CreateMBtn);
            this.Name = "GraphForm";
            this.Text = "图";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OutMBtn;
        private System.Windows.Forms.Button CreateABtn;
        private System.Windows.Forms.Button OutABtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button DegreeBtn;
    }
}