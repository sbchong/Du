namespace Du
{
    partial class StackForm
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
            this.EnterBtn = new System.Windows.Forms.Button();
            this.OutBtn = new System.Windows.Forms.Button();
            this.OutTopBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺序栈运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.链栈运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.队列运算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.判断ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回文判断ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.括号配对ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(184, 100);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "建立";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // OutBtn
            // 
            this.OutBtn.Location = new System.Drawing.Point(184, 131);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(75, 23);
            this.OutBtn.TabIndex = 1;
            this.OutBtn.Text = "输出";
            this.OutBtn.UseVisualStyleBackColor = true;
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // OutTopBtn
            // 
            this.OutTopBtn.Location = new System.Drawing.Point(184, 158);
            this.OutTopBtn.Name = "OutTopBtn";
            this.OutTopBtn.Size = new System.Drawing.Size(75, 23);
            this.OutTopBtn.TabIndex = 2;
            this.OutTopBtn.Text = "取栈顶";
            this.OutTopBtn.UseVisualStyleBackColor = true;
            this.OutTopBtn.Click += new System.EventHandler(this.OutTopBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(10, 230);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(41, 12);
            this.infolabel.TabIndex = 11;
            this.infolabel.Text = "label4";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顺序栈运算ToolStripMenuItem,
            this.链栈运算ToolStripMenuItem,
            this.队列运算ToolStripMenuItem,
            this.判断ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            this.操作ToolStripMenuItem.Click += new System.EventHandler(this.操作ToolStripMenuItem_Click);
            // 
            // 顺序栈运算ToolStripMenuItem
            // 
            this.顺序栈运算ToolStripMenuItem.Name = "顺序栈运算ToolStripMenuItem";
            this.顺序栈运算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.顺序栈运算ToolStripMenuItem.Text = "顺序栈运算";
            this.顺序栈运算ToolStripMenuItem.Click += new System.EventHandler(this.顺序栈运算ToolStripMenuItem_Click);
            // 
            // 链栈运算ToolStripMenuItem
            // 
            this.链栈运算ToolStripMenuItem.Name = "链栈运算ToolStripMenuItem";
            this.链栈运算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.链栈运算ToolStripMenuItem.Text = "链栈运算";
            this.链栈运算ToolStripMenuItem.Click += new System.EventHandler(this.链栈运算ToolStripMenuItem_Click);
            // 
            // 队列运算ToolStripMenuItem
            // 
            this.队列运算ToolStripMenuItem.Name = "队列运算ToolStripMenuItem";
            this.队列运算ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.队列运算ToolStripMenuItem.Text = "队列运算";
            this.队列运算ToolStripMenuItem.Click += new System.EventHandler(this.队列运算ToolStripMenuItem_Click);
            // 
            // 判断ToolStripMenuItem
            // 
            this.判断ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.回文判断ToolStripMenuItem,
            this.括号配对ToolStripMenuItem});
            this.判断ToolStripMenuItem.Name = "判断ToolStripMenuItem";
            this.判断ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.判断ToolStripMenuItem.Text = "判断";
            // 
            // 回文判断ToolStripMenuItem
            // 
            this.回文判断ToolStripMenuItem.Name = "回文判断ToolStripMenuItem";
            this.回文判断ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.回文判断ToolStripMenuItem.Text = "回文判断";
            this.回文判断ToolStripMenuItem.Click += new System.EventHandler(this.回文判断ToolStripMenuItem_Click);
            // 
            // 括号配对ToolStripMenuItem
            // 
            this.括号配对ToolStripMenuItem.Name = "括号配对ToolStripMenuItem";
            this.括号配对ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.括号配对ToolStripMenuItem.Text = "括号配对";
            this.括号配对ToolStripMenuItem.Click += new System.EventHandler(this.括号配对ToolStripMenuItem_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(78, 187);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(181, 23);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "返回主界面";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutTopBtn);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StackForm";
            this.Text = "StackForm";
            this.Load += new System.EventHandler(this.StackForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button OutBtn;
        private System.Windows.Forms.Button OutTopBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺序栈运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 链栈运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 队列运算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 判断ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.ToolStripMenuItem 回文判断ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 括号配对ToolStripMenuItem;
        private System.Windows.Forms.Button BackBtn;
    }
}