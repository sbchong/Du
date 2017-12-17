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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SQListBtn_Click(object sender, EventArgs e)
        {
            SQForm2 Sq = new SQForm2();
            this.Hide();
            Sq.ShowDialog();
        }

        private void StackBtn_Click(object sender, EventArgs e)
        {
            StackForm St = new StackForm();
            this.Hide();
            St.ShowDialog();
        }

        private void BTreeeBtn_Click(object sender, EventArgs e)
        {
            BTreeForm Sb = new BTreeForm();
            this.Hide();
            Sb.ShowDialog();
        }

        private void GraphBtn_Click(object sender, EventArgs e)
        {
            GraphForm Sg = new GraphForm();
            this.Hide();
            Sg.ShowDialog();
        }
    }
}
