namespace Du
{
    partial class MainForm
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
            this.SQListBtn = new System.Windows.Forms.Button();
            this.StackBtn = new System.Windows.Forms.Button();
            this.BTreeeBtn = new System.Windows.Forms.Button();
            this.GraphBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQListBtn
            // 
            this.SQListBtn.Location = new System.Drawing.Point(99, 41);
            this.SQListBtn.Name = "SQListBtn";
            this.SQListBtn.Size = new System.Drawing.Size(75, 23);
            this.SQListBtn.TabIndex = 0;
            this.SQListBtn.Text = "线性表";
            this.SQListBtn.UseVisualStyleBackColor = true;
            this.SQListBtn.Click += new System.EventHandler(this.SQListBtn_Click);
            // 
            // StackBtn
            // 
            this.StackBtn.Location = new System.Drawing.Point(99, 98);
            this.StackBtn.Name = "StackBtn";
            this.StackBtn.Size = new System.Drawing.Size(75, 23);
            this.StackBtn.TabIndex = 1;
            this.StackBtn.Text = "栈和队列";
            this.StackBtn.UseVisualStyleBackColor = true;
            this.StackBtn.Click += new System.EventHandler(this.StackBtn_Click);
            // 
            // BTreeeBtn
            // 
            this.BTreeeBtn.Location = new System.Drawing.Point(99, 151);
            this.BTreeeBtn.Name = "BTreeeBtn";
            this.BTreeeBtn.Size = new System.Drawing.Size(75, 23);
            this.BTreeeBtn.TabIndex = 2;
            this.BTreeeBtn.Text = "二叉树";
            this.BTreeeBtn.UseVisualStyleBackColor = true;
            this.BTreeeBtn.Click += new System.EventHandler(this.BTreeeBtn_Click);
            // 
            // GraphBtn
            // 
            this.GraphBtn.Location = new System.Drawing.Point(99, 210);
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(75, 23);
            this.GraphBtn.TabIndex = 3;
            this.GraphBtn.Text = "图";
            this.GraphBtn.UseVisualStyleBackColor = true;
            this.GraphBtn.Click += new System.EventHandler(this.GraphBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GraphBtn);
            this.Controls.Add(this.BTreeeBtn);
            this.Controls.Add(this.StackBtn);
            this.Controls.Add(this.SQListBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQListBtn;
        private System.Windows.Forms.Button StackBtn;
        private System.Windows.Forms.Button BTreeeBtn;
        private System.Windows.Forms.Button GraphBtn;
    }
}