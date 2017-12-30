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
            return m;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int n, en;
            n = Choose2(a.Length);
            en = n + 1;
            gl.CreateMGraph(n,en,a);
            infolabel.Text = "建立完毕";

        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = gl.DispMGraph();
            infolabel.Text = "输出成功";
        }

        private void CreateABtn_Click(object sender, EventArgs e)
        {
            gl.MatToList();
            infolabel.Text = "建立完毕";
        }

        private void OutABtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = gl.DispALGraph();
            infolabel.Text = "输出成功";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            Main.Show();
            this.Close();
        }
    }
}
