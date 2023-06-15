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

namespace OpreaterSystem
{
    public partial class SearchFile : Form
    {
        public SearchFile()
        {
            InitializeComponent();
        }

       OpenFileDialog ofd = new OpenFileDialog();

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = ofd.FileName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            StreamReader sr = new StreamReader(tbPath.Text);
            int lineCount = 0;
            int SearchCount = 0;

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lineCount++;
                if (line.Contains(search))
                {
                    SearchCount++;
                    MessageBox.Show($"Line {lineCount} : {line}");
                }
            }
            if(SearchCount == 0)
            {
                MessageBox.Show("Not found !");
            }
            
            sr.Close();
           

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            if(tbPath.Text.Length > 0)
            {
                tbSearch.Enabled = true;
            }
            else
            {
                tbSearch.Enabled = false;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbSearch.Text.Length > 0)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
        }
    }
}
