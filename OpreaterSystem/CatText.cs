using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace OpreaterSystem
{
    public partial class CatText : Form
    {
        public CatText()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        string ext=".txt";
        private void button2_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            List<string> list = Directory.GetFiles(fbd.SelectedPath).ToList();
            foreach(string s in list)
            {
                if (s.EndsWith(ext))
                {
                    StreamReader sr = new StreamReader(s);
                    text += sr.ReadToEnd();
                    text += "\n";
                    sr.Close();
                }
            }
        
            StreamWriter sw = new StreamWriter(fbd.SelectedPath+"\\All"+ext);
            sw.Write(text);
            sw.Close();

            MessageBox.Show("Done ");
        }

        private void CatText_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(tbPath.Text.Length > 0)
            {
                btnOk.Enabled = true;
                btnClear.Enabled = true;
            }
            else
            {
                btnOk.Enabled = false;
                btnClear.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPath.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }

        private void lbExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ext = lbExt.SelectedItem.ToString();
        }

        
    }
}
