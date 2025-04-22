using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinform
{
    public partial class Form1 : Form
    {
        private static string OriginalText;
        private const string DEFAUlT_FILE_NAME = "제목없음";
        private const string DEFAULT_FILE_FILTER = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
            OriginalText = textBox1.Text;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != OriginalText){
                lblTextChanged.Text = "⁂";
            }
            
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = DEFAULT_FILE_FILTER;
            DialogResult result = openFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.Cancel:
                    return;
                    break;
                case DialogResult.OK:
                    lblFileName.Text = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        textBox1.Text = sr.ReadToEnd();
                        OriginalText = textBox1.Text;
                        sr.Close();
                    }
                    break;



            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFileName.Text = DEFAUlT_FILE_NAME;
            OriginalText = textBox1.Text;
            lblTextChanged.Text = "";
            textBox1.Text = "글자를 입력해주세요~";
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == DEFAUlT_FILE_NAME)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
                DialogResult result = saveFileDialog.ShowDialog();

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                        break;
                    case DialogResult.OK:
                        lblFileName.Text = saveFileDialog.FileName;
                        break;
                }
            }
            using (StreamWriter sr = new StreamWriter(lblFileName.Text))
            {
                sr.Write(textBox1.Text);
                OriginalText = textBox1.Text;
                lblTextChanged.Text = "";
                sr.Close();
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == DEFAUlT_FILE_NAME)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "텍스트 문서(*.txt)|*.txt|csv 파일(*.csv)|*.csv|모든 파일(*.*)|*.*";
                saveFileDialog.FileName = lblFileName.Text;
                DialogResult result = saveFileDialog.ShowDialog();

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                        break;
                    case DialogResult.OK:
                        lblFileName.Text = saveFileDialog.FileName;
                        break;
                }
            }
            using (StreamWriter sr = new StreamWriter(lblFileName.Text))
            {
                sr.Write(textBox1.Text);
                OriginalText = textBox1.Text;
                lblTextChanged.Text = "";
                sr.Close();
            }
        }
    }
}
