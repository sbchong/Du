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
    public partial class SQForm2 : Form
    {
        SqListClass L = new SqListClass();
        SqListClass K = new SqListClass();
        SqListClass J = new SqListClass();
        public SQForm2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ElemDelete(string x)//按元素值删除所有该元素
        {
            int k = 0, i;
            string y = "";

            for (i = 1; i <= L.ListLength(); i++)
            {
                L.GetElem(i, ref y);
                if (string.Compare(y, x) != 0)
                {
                    L.data[k] = y;
                    k++;

                }
            }
            L.length = k;
        }

        private void Split(ref SqListClass L1, ref SqListClass L2)//输出奇偶顺序表
        {
            int i = 1, j = 1, k = 1;
            string x = "";
            while (k <= L.ListLength())
            {
                L.GetElem(k, ref x);
                L1.ListInsert(i, x);
                i++;
                k++;
                if (k <= L.ListLength())
                {
                    L.GetElem(k, ref x);
                    L2.ListInsert(j, x);
                    j++;
                    k++;


                }
            }
            MessageBox.Show("操作提示：成功产生两个顺序表");
        }

        private void CreBtn_Click(object sender, EventArgs e)//创建
        {
            string str = textBox1.Text.Trim();
            if (str == "")
            {
               
                return;
            }
            else
            {
                string[] split = str.Split(new char[] { ' ', ' ', '.', ':', });   //建立顺序表
                L.CreatList(split);
              
            }
        }

        private void OutputBtn_Click(object sender, EventArgs e)//输出
        {

            textBox6.Text = L.DispList();
            label6.Text = "输出结果";
            textBox8.Text = L.ListLength().ToString();
            label5.Text = "长度";
        }

        private void ElemBtn_CheckedChanged(object sender, EventArgs e)//按序号查找
        {
            int i;
            string x = " ";
            if (textBox2.Text.Trim() == "")
                MessageBox.Show("操作提示：必须输入序号");
            else
            {
                try
                {
                    i = Convert.ToInt16(textBox2.Text.Trim());
                }
                catch (Exception err)
                {
                  
                    return;
                }
                if (L.GetElem(i, ref x))
                {
                    textBox3.Text = x;
                   
                }
                else
                {
                  
                    textBox3.Text = "";
                }

            }
        }


        private void OrderBtn_CheckedChanged(object sender, EventArgs e)//按元素查找
        {
            int i;
            string x = textBox2.Text.Trim();
            if (x == "")
                MessageBox.Show( "操作提示：必须输入元素值");
            else
            {
                i = L.LocateElem(x);
                if (i == 0)
                {
                  
                    textBox3.Text = "";
                }
                else
                {
                    textBox3.Text = i.ToString();
                  
                }
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)//插入
        {
            int i;
            string x, str;
            if (textBox4.Text.Trim() == "")
               MessageBox.Show( "操作提示：必须输入序号");
            else
            {
                try
                {
                    i = Convert.ToInt16(textBox4.Text.Trim());
                }
                catch (Exception err)
                {
                    MessageBox.Show("操作提示：输入的序号是错误的");
                    return;
                }
                x = textBox5.Text.Trim();
                if (x == "")
                {
                    
                }
                else
                {
                    

                    if (L.ListInsert(i, x))
                    {
                        str = L.DispList();
                        textBox8.Text = str;
                        label5.Text = "插入结果";
                        textBox6.Text = L.ListLength().ToString();
                        label6.Text = "长度";
                        textBox4.Text = "";
                        textBox5.Text = "";
                       
                    }
                    else
                    {
                       
                        textBox8.Text = "";
                    }
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)//删除
        {
            int i;
            string x = "";
            string str;
            if (textBox4.Text.Trim() == "" && textBox5.Text.Trim() == "")
                MessageBox.Show("操作提示：必须输入序号或元素");
            else
            {
                if (textBox4.Text.Trim() != "")
                {
                    try
                    {
                        i = Convert.ToInt16(textBox4.Text.Trim());
                    }
                    catch (Exception err)
                    {
  
                        return;
                    }
                    L.ListDelete(i);
                    textBox6.Text = L.DispList();
                    label6.Text = "删除结果";
                  
                    label5.Text = "长度";
                    textBox8.Text = L.ListLength().ToString();
                    textBox5.Text = "";
                    textBox4.Text = "";
                   
                }
                if (textBox5.Text.Trim() != "")
                {
                    x = textBox5.Text.Trim();
                    ElemDelete(x);
                    textBox8.Text = L.DispList();
                    label5.Text = "删除结果";
                    label6.Text = "长度";
                    textBox6.Text = L.ListLength().ToString();
                    textBox5.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void OddEvenBtn_Click(object sender, EventArgs e)//输出奇偶顺序表
        {
            Split(ref K,ref J);
            textBox8.Text = K.DispList();
            label5.Text = "奇数表";
            textBox6.Text = J.DispList();
            label6.Text = "偶数表";
        }

        private void MergeBtn_Click(object sender, EventArgs e)//归并操作
        {
            Form s2 = new BTNodeForm();//调用新窗口进行归并操作
            s2.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm Main = new MainForm();
            Main.Show();
        }
    }
    
}
