﻿using System;
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
            int lineNumber = 1;

            while ( sr.ReadLine() != null)
            {
                if (sr.ReadLine().Contains(search))
                {
                    MessageBox.Show($"Line {lineNumber} : {sr.ReadLine()}");
                }
                lineNumber++;
            }
           

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
