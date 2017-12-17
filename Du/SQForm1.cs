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
    public partial class BTNodeForm : Form
    {
        SqListClass D = new SqListClass();
        SqListClass L1 = new SqListClass();
        SqListClass L2 = new SqListClass();
        SqListClass L3 = new SqListClass();
        const int INF = 32767;
        public BTNodeForm()
        {
            InitializeComponent();
        }

        private void Merge2(ref SqListClass L3)//二路归并
        {
            int i = 0, j = 0, k = 0;
            while (i < L1.length && j < L2.length)
            {
                if (Convert.ToInt16(L1.data[i]) < Convert.ToInt16(L2.data[j]))
                {
                    L3.data[k] = L1.data[i];
                    i++; k++;
                }
                else
                {
                    L3.data[k] = L2.data[j];
                    j++; k++;
                }
            }
            while (i < L1.length)
            {
                L3.data[k] = L1.data[i];
                i++; k++;
            }
            while (j < L2.length)
            {
                L3.data[k] = L2.data[j];
                j++; k++;
            }
            L3.length = k;

        }

        private void Merge3(ref SqListClass L4)//三路归并
        {
            int i = 0, j = 0, k = 0, s = 0, t;
            int a, b, c, mind = 0;           
            while (i<L1.length||j<L2.length||k<L3.length )
            {
                if (i >= L1.length) a = INF;
                else a = Convert.ToInt16(L1.data[i]);
                if (j >= L2.length) b = INF;
                else b = Convert.ToInt16(L2.data[j]);
                if (k >= L3.length) c = INF;
                else c = Convert.ToInt16(L3.data[k]);
                t = mindata(a, b, c, ref mind);
                switch (t)
                {
                    case 1: L4.data[s] = mind.ToString(); s++;i++;break;
                    case 2: L4.data[s] = mind.ToString(); s++; j++; break;
                    case 3: L4.data[s] = mind.ToString(); s++; k++; break;
                }
            }
            L4.length = s;
        }
        private int mindata(int a,int b,int c,ref int mind)
        {
            int mini = 1;
            mind = a;
            if (mind > b)
            {
                mind = b;
                mini = 2;
            }
            if (mind > c)
            {
                mind = c;
                mini = 3;
            }
            return mini;
        }

        private void CreBtn_Click(object sender, EventArgs e)//创建
        {
            string str1 = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();
            string str3 = textBox3.Text.Trim();
            //if (str1 == "" || str2 == "" || str3 == "")
            //{
            //    MessageBox.Show("必须输入三组元素", "提示");
            //}
            //else
            //{
                string[] splist1 = str1.Split(' ', ',', '.', ':');
                string[] splist2 = str2.Split(' ', ',', '.', ':');
                string[] splist3 = str3.Split(' ', ',', '.', ':');
                L1.CreatList(splist1);
                L2.CreatList(splist2);
                L3.CreatList(splist3);

                OutpBtn.Enabled = true;
                MergeBtn.Enabled = true;
                
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.linkLabel1.Links.Add(0, 8, @"http://blog.csdn.net/u012572538/article/details/20492539");
            //添加一个CSDN链接
            textBox3.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            label3.Text = "";
            label1.Text = "";
            label2.Text = "";
            CreBtn.Enabled = true;
            OutpBtn.Enabled = false;
            MergeBtn.Enabled = false;
        }

        private void OutpBtn_Click(object sender, EventArgs e)//输出
        {
            textBox1.Text = L1.DispList();
            textBox2.Text = L2.DispList();
            textBox3.Text = L3.DispList();
            MessageBox.Show("输出成功");
        }

        private void MergeBtn_Click(object sender, EventArgs e)//归并
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Merge3(ref D);
                textBox4.Text = D.DispList();
            }

            else
            {
                MessageBox.Show("必须输入完整数据","大写的警告");
            }


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
            {
                Merge2(ref D);
                textBox4.Text = D.DispList();
            }

            //else
            //{
                //MessageBox.Show("必须输入完整数据","大写的警告");
           // }
        }

        private void 请选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 二路归并ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "表1";
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Enabled = true;
            label2.Text = "表2";
            textBox3.Text = "";
            textBox3.Enabled = false;
            label3.Text = "";
            textBox4.Text = "";
            请选择ToolStripMenuItem.Text = "二路归并";
        }

        private void 三路归并ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "表3";
            textBox3.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label2.Text = "表2";
            label1.Text = "表1";
            textBox4.Text = "";
            请选择ToolStripMenuItem.Text = "三路归并";
        }

        private void BackBtn_Click(object sender, EventArgs e)//返回主窗口
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.Links[this.linkLabel1.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (string.IsNullOrEmpty(targetUrl))
                MessageBox.Show("没有链接地址！");
            else
                System.Diagnostics.Process.Start("iexplore.exe", targetUrl);
            //System.Diagnostics.Process.Start("d:\\Program Files\\firefox\\firefox.exe", targetUrl);
        }
    }
}
