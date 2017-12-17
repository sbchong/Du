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
        int[,] a = new int[5, 5];
        
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

            LoadFile(Fname);
            
        }

        private void LoadFile(string Fname)
        {
            if (File.Exists(Fname))
            {
                FileStream fs = File.OpenRead(Fname);
                BinaryReader br = new BinaryReader(fs, Encoding.Default);
                fs.Seek(0, SeekOrigin.Begin);
                //int[,] b=new int[5, 5] ;
                int[] c = new int[25];
                string str = br.ReadString();
                string[] btstr = str.Split(',');
                c = Array.ConvertAll<string, int>(btstr, s => int.Parse(s));
                for (int i = 0; i < 25; i++)
                {
                    a[i / 5, i % 5] = c[i];
                }
            }
            
        }

       

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int n = 5,en = 6;
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
