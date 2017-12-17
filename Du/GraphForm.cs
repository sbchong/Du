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
        int[,] a = new int[,] { };
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
            if (!LoadFile(Fname)) { }
        }

        private bool LoadFile(string Fname)
        {
            if (!File.Exists(Fname))
                return false;
            FileStream fs = File.OpenRead(Fname);
            BinaryReader br = new BinaryReader(fs, Encoding.Default);
            fs.Seek(0, SeekOrigin.Begin);
            string str = br.ReadString();
            string[] btstr = str.Split(',');
            // char[] ch = str.ToCharArray();
            //a = Array.ConvertAll(btstr,int.Parse);
            return true;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int n = 5,en = 6;
           // gl.CreateMGraph(n,en,);
            infolabel.Text = "建立完毕";

        }
    }
}
