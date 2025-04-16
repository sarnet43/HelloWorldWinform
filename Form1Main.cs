using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "쾅";
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm1 = new aboutForm(); 
            Form aboutForm2 = new aboutForm();

            //모달(modal)창
            aboutForm1.Text = "모달창";
            aboutForm1.ShowDialog();

            //모달리스(modaless)창
            //aboutForm2.Text = "모달리스창";
            //aboutForm2.Show();
        }

        private void btnpush_Click(object sender, EventArgs e)
        {
            label1.Text = "콰쾅";
        }
    }
}
