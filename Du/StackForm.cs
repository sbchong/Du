using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du
{
    public partial class StackForm : Form
    {
        SqStackClass sq = new SqStackClass();
        SqQueueClass qu = new SqQueueClass();
        LinkStackClass li = new LinkStackClass();

        private void Display1()
        {
            string str;
            str = sq.DispStack();
            textBox1.Text = str;
        }

        private void Display2()
        {
            string str;
            str = qu.DispQueue();
            textBox1.Text = str;
        }

        private void Display3()
        {
            string str;
            str = li.DispLinkStack();
            textBox1.Text = str;
        }

        private bool enQueue(int k, string e)
        {
            int i = 1, n = qu.GetCount();
            string x = "";
            if (k < 1 || k > n + 1)
                return false;
            if (k <= n)
                for (i = 0; i <= n; i++)
                {
                    if (i == k)
                        qu.enQueue(e);
                    qu.deQueue(ref x);
                    qu.enQueue(x);
                }
            else qu.enQueue(e);
            return true;
        }

        private bool deQueue(int k, ref string e)
        {
            int i = 1, n = qu.GetCount();
            string x = "";
            if (k < 1 || k > n + 1)
                return false;
            if (k <= n)
                for (i = 0; i <= n; i++)
                {
                    qu.deQueue(ref x);
                    if (i != k)
                        qu.enQueue(x);
                    else e = x;
                }
            return true;
        }

        private bool Match(string str)
        {
            SqStackClass st = new SqStackClass();
            int i = 0;
            string x = "";
            while (i < str.Length)
            {
                if (str[i] == '(')
                    st.Push("(");
                else if (str[i] == ')')
                {
                    if (!st.StackEmpty())
                        st.Pop(ref x);
                    else
                        return false;
                }
                i++;
            }
            if (st.StackEmpty())
                return true;
            else
                return false;
        }

        private bool Palindrome(string str)
        {
            int i;
            string x = "";
            SqStackClass st = new SqStackClass();
            for (i = 0; i < str.Length; i++)
            {
                x = str[i].ToString();
                st.Push(x);
            }
            for (i = 0; i < str.Length; i++)
            {
                st.Pop(ref x);
                if (string.Compare(str[i].ToString(), x) != 0)
                    return false;
            }
            return true;
        }

        public StackForm()
        {
            InitializeComponent();
        }

        private void StackForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "             -_-  还什么都没有呢  -_-                 ";
            EnterBtn.Text = "";
            OutBtn.Text = "";
            OutTopBtn.Text = "";
            EnterBtn.Enabled = false;
            OutBtn.Enabled = false;
            OutTopBtn.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string x;
            int k;
            x = textBox2.Text.Trim();
            if (EnterBtn.Text == "进顺序栈")
            {
                if (x == "")
                { infolabel.Text = "发生错误了"; }
                else
                {
                    if (sq.Push(x))
                    {
                        Display1();
                        infolabel.Text = "成功进栈";
                    }
                }
            }

            if (EnterBtn.Text == "进链栈")
            {
                if (x == "")
                { infolabel.Text = "发生错误了"; }
                else
                {
                    li.Push(x);
                    infolabel.Text = "成功进栈";
                    Display3();

                }
            }

            if (EnterBtn.Text == "进队")
            {
                if (x == "")
                { infolabel.Text = "发生错误了"; }
                else
                {
                    if (textBox4.Text == "")
                    {
                        if (qu.enQueue(x))
                        {
                            Display2();
                            infolabel.Text = "成功进队";
                        }
                    }
                    else
                    {
                        k = Convert.ToInt16(textBox4.Text.Trim());
                        if (enQueue(k, x))
                            Display2();
                        infolabel.Text = "成功进队";
                    }
                }
            }

            if (EnterBtn.Text == "判断配对")
            {
                string str;
                str = textBox1.Text.Trim();
                if (str == "")
                    infolabel.Text = "发生错误了";
                else
                {
                    if (Match(str))
                        infolabel.Text = "配对正确😀";
                    else
                        infolabel.Text = "配对失败😭";
                }
            }

            if (EnterBtn.Text == "判断回文")
            {
                string str;
                str = textBox1.Text.Trim();
                if (str == "")
                    infolabel.Text = "发生错误了";
                else
                {
                    if (Palindrome(str))
                    {
                        infolabel.Text = "是回文！😀";

                    }
                    else
                        infolabel.Text = "不是回文😭";
                }
            }
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            string x = "";
            int k;
            if (OutBtn.Text == "出顺序栈")
            {
                if (sq.Pop(ref x))
                {
                    textBox3.Text = x;
                    Display1();
                    infolabel.Text = "出栈成功";
                    label3.Text = "出栈元素";
                }
            }

            if (OutBtn.Text == "出链栈")
            {
                if (li.Pop(ref x))
                {
                    textBox3.Text = x;
                    Display3();
                    infolabel.Text = "出栈成功";
                    label3.Text = "出栈元素";
                }
            }

            if (OutBtn.Text == "出队")
            {
                if (textBox3.Text == "")
                {
                    if (qu.deQueue(ref x))
                    {
                        textBox4.Text = x;
                        Display2();
                        infolabel.Text = "出队成功";
                    }
                }
                else
                {
                    k = Convert.ToInt16(textBox3.Text.Trim());
                    if (deQueue(k, ref x))
                    {
                        textBox4.Text = x;
                        Display2();
                        infolabel.Text = "出队成功";
                    }
                }
            }
        }

        private void OutTopBtn_Click(object sender, EventArgs e)
        {

            if (OutTopBtn.Text == "取栈顶")
            {
                string x = "";
                if (sq.GetTop(ref x))
                {
                    textBox3.Text = x;
                    Display1();
                    label3.Text = "栈顶元素";
                    infolabel.Text = "成功找到栈顶元素";
                }
            }

            if (OutTopBtn.Text == "取链栈顶")
            {
                string x = "";
                if (li.GetTop(ref x))
                {
                    textBox3.Text = x;
                    Display3();
                    label3.Text = "栈顶元素";
                    infolabel.Text = "成功找到栈顶元素";
                }
            }
        }

        private void 操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 回文判断ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterBtn.Text = "判断回文";
            EnterBtn.Enabled = true;
            OutBtn.Enabled = false;
            OutTopBtn.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = " ";
            textBox4.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            menuStrip1.Text = "判断回文";
        }

        private void 括号配对ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterBtn.Text = "判断配对";
            EnterBtn.Enabled = true;
            OutBtn.Enabled = false;
            OutTopBtn.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = " ";
            textBox4.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            menuStrip1.Text = "判断括号匹配";
        }

        private void 顺序栈运算ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EnterBtn.Text = "进顺序栈";
            OutBtn.Text = "出顺序栈";
            OutTopBtn.Text = "取栈顶";
            EnterBtn.Enabled = true;
            OutBtn.Enabled = true;
            OutTopBtn.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "进栈元素";
            label2.Text = "";
            label3.Text = "出栈元素";
            menuStrip1.Text = "顺序栈";
        }

        private void 链栈运算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterBtn.Text = "进链栈";
            OutBtn.Text = "出链栈";
            OutTopBtn.Text = "取链栈顶";
            EnterBtn.Enabled = true;
            OutBtn.Enabled = true;
            OutTopBtn.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "进栈元素";
            label2.Text = "";
            label3.Text = "出栈元素";
            menuStrip1.Text = "链栈";
        }

        private void 队列运算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterBtn.Text = "进队";
            OutBtn.Text = "出队";
            OutTopBtn.Text = "";
            EnterBtn.Enabled = true;
            OutBtn.Enabled = true;
            OutTopBtn.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "进队元素";
            label2.Text = "位置";
            label3.Text = "出队元素";
            menuStrip1.Text = "队列";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm  Main = new MainForm();
            Main.Show();
        }
    }
}
