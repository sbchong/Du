namespace Du
{
    partial class BTNodeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CreBtn = new System.Windows.Forms.Button();
            this.OutpBtn = new System.Windows.Forms.Button();
            this.MergeBtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.请选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二路归并ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三路归并ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 21);
            this.textBox3.TabIndex = 2;
            // 
            // CreBtn
            // 
            this.CreBtn.Location = new System.Drawing.Point(94, 142);
            this.CreBtn.Name = "CreBtn";
            this.CreBtn.Size = new System.Drawing.Size(53, 22);
            this.CreBtn.TabIndex = 3;
            this.CreBtn.Text = "创建";
            this.CreBtn.UseVisualStyleBackColor = true;
            this.CreBtn.Click += new System.EventHandler(this.CreBtn_Click);
            // 
            // OutpBtn
            // 
            this.OutpBtn.Location = new System.Drawing.Point(198, 142);
            this.OutpBtn.Name = "OutpBtn";
            this.OutpBtn.Size = new System.Drawing.Size(53, 22);
            this.OutpBtn.TabIndex = 4;
            this.OutpBtn.Text = "输出";
            this.OutpBtn.UseVisualStyleBackColor = true;
            this.OutpBtn.Click += new System.EventHandler(this.OutpBtn_Click);
            // 
            // MergeBtn
            // 
            this.MergeBtn.Location = new System.Drawing.Point(94, 191);
            this.MergeBtn.Name = "MergeBtn";
            this.MergeBtn.Size = new System.Drawing.Size(53, 22);
            this.MergeBtn.TabIndex = 5;
            this.MergeBtn.Text = "归并";
            this.MergeBtn.UseVisualStyleBackColor = true;
            this.MergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(385, 21);
            this.textBox4.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请选择ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 请选择ToolStripMenuItem
            // 
            this.请选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二路归并ToolStripMenuItem,
            this.三路归并ToolStripMenuItem});
            this.请选择ToolStripMenuItem.Name = "请选择ToolStripMenuItem";
            this.请选择ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.请选择ToolStripMenuItem.Text = "请选择";
            this.请选择ToolStripMenuItem.Click += new System.EventHandler(this.请选择ToolStripMenuItem_Click);
            // 
            // 二路归并ToolStripMenuItem
            // 
            this.二路归并ToolStripMenuItem.Name = "二路归并ToolStripMenuItem";
            this.二路归并ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.二路归并ToolStripMenuItem.Text = "二路归并";
            this.二路归并ToolStripMenuItem.Click += new System.EventHandler(this.二路归并ToolStripMenuItem_Click);
            // 
            // 三路归并ToolStripMenuItem
            // 
            this.三路归并ToolStripMenuItem.Name = "三路归并ToolStripMenuItem";
            this.三路归并ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.三路归并ToolStripMenuItem.Text = "三路归并";
            this.三路归并ToolStripMenuItem.Click += new System.EventHandler(this.三路归并ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // BackBtn
            // 
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.Location = new System.Drawing.Point(197, 190);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(54, 23);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "返回";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "更多";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Du.Properties.Resources.UU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(420, 276);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.MergeBtn);
            this.Controls.Add(this.OutpBtn);
            this.Controls.Add(this.CreBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "归并操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CreBtn;
        private System.Windows.Forms.Button OutpBtn;
        private System.Windows.Forms.Button MergeBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 请选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二路归并ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三路归并ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

