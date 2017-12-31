using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Du
{
    public partial class GraphForm : Form
    {
        GraphClass gl = new GraphClass();
        int[,] a =new int[5,5];
        
        public GraphForm()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选文件";
           // ofd.InitialDirectory = @"E:\";
            ofd.Multiselect = true;           
            ofd.Filter = @"|*.dat|所有文件|*.*";
            ofd.ShowDialog();
            string []str = ofd.FileNames;
            string Fname = "";
            for (int i = 0; i < str.Length; i++)
            {
                Fname += str[i];
            }

            a = LoadFile(Fname);
            
        }

        private int[,] LoadFile(string Fname)
        {
            if (File.Exists(Fname))
            {
                int n = 0;
                int m = 0;
                FileStream fs = File.OpenRead(Fname);
                BinaryReader br = new BinaryReader(fs, Encoding.Default);
                fs.Seek(0, SeekOrigin.Begin);
                int[] c = new int[n];
                string str = br.ReadString();
                string[] btstr = str.Split(',');
                n = Choose1(btstr.Length);
                m = Choose2(btstr.Length);
                int[,] a = new int[m, m];
                c = Array.ConvertAll<string, int>(btstr, s => int.Parse(s));
                for (int i = 0; i < n; i++)
                {
                    a[i / m, i % m] = c[i];
                }
                return a;
            }
            else
            {
                int[,] a = new int[0, 0];
                return a;
            }
            
        }

        private int Choose1(int length)
        {
            int n = 0;
            if (length == 0)
            {
                n = 0;
            }
            else if (length >= 1 && length < 4)
            {
                n = 1;
            }
            else if (length >= 4 && length < 9)
            {
                n = 4;
            }
            else if (length >= 9 && length < 16)
            {
                n = 9;
            }
            else if (length >= 16 && length < 25)
            {
                n = 16;
            }
            else if (length >= 25 && length < 36)
            {
                n = 25;
            }
            else if (length >= 36 && length < 49)
            {
                n = 36;
            }
            else if (length >= 49 && length < 64)
            {
                n = 49;
            }
            else if (length >= 64 && length < 81)
            {
                n = 64;
            }
            else if (length >= 81 && length < 100)
            {
                n = 81;
            }
            else if (length >= 100 && length < 121)
            {
                n = 100;
            }
            return n;
        }

        private int Choose2(int length)
        {
            int m = 0;
            if (length == 0)
            {
                m = 0;
            }
            else if (length >= 1 && length < 4)
            {
                m = 1;
            }
            else if (length >= 4 && length < 9)
            {
                m = 2;
            }
            else if (length >= 9 && length < 16)
            {
                m = 3;
            }
            else if (length >= 16 && length < 25)
            {
                m = 4;
            }
            else if (length >= 25 && length < 36)
            {
                m = 5;
            }
            else if (length >= 36 && length < 49)
            {
                m = 6;
            }
            else if (length >= 49 && length < 64)
            {
                m = 7;
            }
            else if (length >= 64 && length < 81)
            {
                m = 8;
            }
            else if (length >= 81 && length < 100)
            {
                m = 9;
            }
            else if (length >= 100 && length < 121)
            {
                m = 10;
            }
            return m;
        }

        private void CreateMBtn_Click(object sender, EventArgs e)
        {
            if (CreateMBtn.Text == "建立邻接矩阵")
            {
                int n, en;
                n = Choose2(a.Length);
                en = n + 1;
                gl.CreateMGraph(n, en, a);
                infolabel.Text = "建立完毕";
            }
            else if (CreateMBtn.Text == "建立邻接表")
            {
                gl.MatToList();
                infolabel.Text = "建立完毕";
            }
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            if (OutMBtn.Text == "输出邻接矩阵")
            {
                textBox1.Text = gl.DispMGraph();
                infolabel.Text = "输出成功";
            }
            if (OutMBtn.Text == "输出邻接表")
            {
                textBox1.Text = gl.DispALGraph();
                infolabel.Text = "输出成功";
            }
        }

        private void CreateABtn_Click(object sender, EventArgs e)
        {
            if (CreateABtn.Text == "建立邻接表")
            {
                gl.MatToList();
                infolabel.Text = "建立完毕";
            }
            if (CreateABtn.Text == "建立邻接矩阵")
            {
                int n, en;
                n = Choose2(a.Length);
                en = n + 4;
                gl.CreateMGraph(n, en, a);
                infolabel.Text = "建立完毕";
            }
        }

        private void OutABtn_Click(object sender, EventArgs e)
        {
            if (OutABtn.Text == "输出邻接表")
            {
                textBox1.Text = gl.DispALGraph();
                infolabel.Text = "输出成功";
            }
            if (OutABtn.Text == "输出邻接矩阵")
            {
                textBox1.Text = gl.DispMGraph();
                infolabel.Text = "输出成功";
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CreateMBtn.Text = "建立邻接矩阵";
                CreateABtn.Text = "建立邻接表";
                OutMBtn.Text = "输出邻接矩阵";
                OutABtn.Text = "输出邻接表";
                DegreeBtn.Text="顶点和边";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CreateMBtn.Text = "建立邻接表";
                CreateABtn.Text = "建立邻接矩阵";
                OutMBtn.Text = "输出邻接表";
                OutABtn.Text = "输出邻接矩阵";
                DegreeBtn.Text = "边和顶点";
            }
        }

        private void DegreeBtn_Click(object sender, EventArgs e)
        {
            int i;
            string astr = "";
            string bstr = "";
            string cstr = "";
            if (DegreeBtn.Text == "顶点和边")
            {
                cstr ="顶点"+ "  \t" + "  \t" +"度"+"\r\n";
                bstr ="\r\n"+ "顶点数：" + gl.Getn().ToString()+"  "+ "边数：" + gl.Gete().ToString();
                for (i = 0; i < gl.Getn(); i++)
                    astr += " " + i.ToString() + "： \t" + "  \t" + gl.Degree1(i).ToString() + "\r\n";
                textBox1.Text = cstr + astr + "\n" + bstr;
            }
            else if (DegreeBtn.Text == "边和顶点")
            {
                int k, outs = 0, ins = 0, d;
                for (k = 0; k < gl.Getn(); k++)
                {
                    gl.Degree4(k, ref outs, ref ins);
                    d = outs + ins;
                    astr += "  " + k.ToString() + ":  \t" + outs.ToString() + " \t" + ins.ToString() + " \t" + d.ToString() + "\r\n";
                }                cstr = "顶点" + "  \t" + "出度" + "  \t" + "入度" + "  \t"  + "度" + "\r\n";
                bstr = "\r\n" + "顶点数：" + gl.Getn().ToString() + "  " + "边数：" + gl.Gete().ToString();
                textBox1.Text = cstr + astr + "\n" + bstr;
            }
        }

        
    }
}
