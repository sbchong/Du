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
    public partial class BTreeForm : Form
    {
        BTNodeClass b = new BTNodeClass();

        public BTreeForm()
        {
            InitializeComponent();
        }

        private void CreaBtn_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            if (CreaBtn.Text == "二叉树创建")
                b.CreateBTNode(str);
            else if (CreaBtn.Text == "创建二叉树")
                b.CreateBTNode2(str);
            label1.Text = "创建二叉树成功";
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "二叉树括号表示为： " + b.DispBTNode();
        }

        private void HeightBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "二叉树的高度为： " + b.BTNodeHeight();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string x;
            x = textBox2.Text.Trim();
            label1.Text = "查找到值为：" + b.FindNode(x);
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "总结点数为： " + b.Count2();
        }

        private void LeafCountBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "叶子结点数为： " + b.LeafCount();
        }

        private void PreOrderBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "先序序列为：" + b.PreOrder();
        }

        private void InOrderBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "中序序列为：" + b.InOrder();
        }

        private void PostOrderBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "后序序列为：" + b.PostOrder();
        }

        private void PathBtn_Click(object sender, EventArgs e)
        {
            string str1, str2;
            str1 = textBox3.Text.Trim();
            str2 = textBox4.Text.Trim();
            label1.Text = "路径为：" + b.Path(str1,str2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CreaBtn.Text = "二叉树创建";
                OutBtn.Text = "二叉树输出";
                textBox1.Text = "";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CreaBtn.Text = "创建二叉树";
                OutBtn.Text = "输出二叉树";
                textBox1.Text = "";
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void BTreeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
