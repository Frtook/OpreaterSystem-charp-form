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
    public partial class CountText : Form
    {
        public CountText()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnFile_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = ofd.FileName;
            }
        }

        private void CountText_Load(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(tbFile.Text);
            string File=sr.ReadToEnd().Trim();

            int line = 1;
            int wodr = 1;
            int chr = 1;
            if(File.Length == 0)
            {
                MessageBox.Show("Empty");
            }
            else
            {
                for (int i = 0; i < File.Length; i++)
                {
                    if (File[i] == '\n')
                    {
                        line++;
                    }
                    else
                    {
                        chr++;
                    }
                    if ((File[i] == ' ' || File[i] == '\n') && File[i + 1] != ' ')
                    {
                        wodr++;
                    }

                }
            lbLine.Text = line.ToString();
            lbChar.Text = chr.ToString();
            lbWord.Text = wodr.ToString();

            }

            
            sr.Close();
        }

        private void tbFile_TextChanged(object sender, EventArgs e)
        {
            if(tbFile.Text.Length > 0)
            {
                btnCount.Enabled = true;
            }
            else
            {
                btnCount.Enabled = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
