namespace Du
{
    partial class BTreeForm
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
            this.CreaBtn = new System.Windows.Forms.Button();
            this.OutBtn = new System.Windows.Forms.Button();
            this.HeightBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.LeafCountBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PreOrderBtn = new System.Windows.Forms.Button();
            this.InOrderBtn = new System.Windows.Forms.Button();
            this.PostOrderBtn = new System.Windows.Forms.Button();
            this.PathBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreaBtn
            // 
            this.CreaBtn.Location = new System.Drawing.Point(24, 129);
            this.CreaBtn.Name = "CreaBtn";
            this.CreaBtn.Size = new System.Drawing.Size(75, 23);
            this.CreaBtn.TabIndex = 0;
            this.CreaBtn.Text = "建立";
            this.CreaBtn.UseVisualStyleBackColor = true;
            this.CreaBtn.Click += new System.EventHandler(this.CreaBtn_Click);
            // 
            // OutBtn
            // 
            this.OutBtn.Location = new System.Drawing.Point(203, 129);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(75, 23);
            this.OutBtn.TabIndex = 1;
            this.OutBtn.Text = "输出";
            this.OutBtn.UseVisualStyleBackColor = true;
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // HeightBtn
            // 
            this.HeightBtn.Location = new System.Drawing.Point(384, 131);
            this.HeightBtn.Name = "HeightBtn";
            this.HeightBtn.Size = new System.Drawing.Size(75, 23);
            this.HeightBtn.TabIndex = 2;
            this.HeightBtn.Text = "求高度";
            this.HeightBtn.UseVisualStyleBackColor = true;
            this.HeightBtn.Click += new System.EventHandler(this.HeightBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(24, 243);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 3;
            this.FindBtn.Text = "查找";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(203, 243);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(75, 23);
            this.CountBtn.TabIndex = 4;
            this.CountBtn.Text = "求节点";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // LeafCountBtn
            // 
            this.LeafCountBtn.Location = new System.Drawing.Point(384, 243);
            this.LeafCountBtn.Name = "LeafCountBtn";
            this.LeafCountBtn.Size = new System.Drawing.Size(75, 23);
            this.LeafCountBtn.TabIndex = 5;
            this.LeafCountBtn.Text = "求叶子节点";
            this.LeafCountBtn.UseVisualStyleBackColor = true;
            this.LeafCountBtn.Click += new System.EventHandler(this.LeafCountBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "提示信息";
            // 
            // PreOrderBtn
            // 
            this.PreOrderBtn.Location = new System.Drawing.Point(24, 366);
            this.PreOrderBtn.Name = "PreOrderBtn";
            this.PreOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.PreOrderBtn.TabIndex = 7;
            this.PreOrderBtn.Text = "先序遍历";
            this.PreOrderBtn.UseVisualStyleBackColor = true;
            this.PreOrderBtn.Click += new System.EventHandler(this.PreOrderBtn_Click);
            // 
            // InOrderBtn
            // 
            this.InOrderBtn.Location = new System.Drawing.Point(185, 366);
            this.InOrderBtn.Name = "InOrderBtn";
            this.InOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.InOrderBtn.TabIndex = 8;
            this.InOrderBtn.Text = "中序遍历";
            this.InOrderBtn.UseVisualStyleBackColor = true;
            this.InOrderBtn.Click += new System.EventHandler(this.InOrderBtn_Click);
            // 
            // PostOrderBtn
            // 
            this.PostOrderBtn.Location = new System.Drawing.Point(384, 366);
            this.PostOrderBtn.Name = "PostOrderBtn";
            this.PostOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.PostOrderBtn.TabIndex = 9;
            this.PostOrderBtn.Text = "后序遍历";
            this.PostOrderBtn.UseVisualStyleBackColor = true;
            this.PostOrderBtn.Click += new System.EventHandler(this.PostOrderBtn_Click);
            // 
            // PathBtn
            // 
            this.PathBtn.Location = new System.Drawing.Point(498, 232);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(75, 23);
            this.PathBtn.TabIndex = 10;
            this.PathBtn.Text = "求路径";
            this.PathBtn.UseVisualStyleBackColor = true;
            this.PathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 21);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(498, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "特定序列",
            "简单创建"});
            this.comboBox1.Location = new System.Drawing.Point(410, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "在这里选择建立二叉树的方式";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(498, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 16;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(498, 329);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "返回主界面";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 471);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PathBtn);
            this.Controls.Add(this.PostOrderBtn);
            this.Controls.Add(this.InOrderBtn);
            this.Controls.Add(this.PreOrderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeafCountBtn);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.HeightBtn);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.CreaBtn);
            this.Name = "BTreeForm";
            this.Text = "二叉树";
            this.Load += new System.EventHandler(this.BTreeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreaBtn;
        private System.Windows.Forms.Button OutBtn;
        private System.Windows.Forms.Button HeightBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Button LeafCountBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PreOrderBtn;
        private System.Windows.Forms.Button InOrderBtn;
        private System.Windows.Forms.Button PostOrderBtn;
        private System.Windows.Forms.Button PathBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BackBtn;
    }
}