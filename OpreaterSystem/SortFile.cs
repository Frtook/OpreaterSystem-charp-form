using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace OpreaterSystem
{
    public partial class SortFile : Form
    {
        public SortFile()
        {
            InitializeComponent();
        }
        static FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void btnSelectFolder(object sender, EventArgs e)
        {

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbd.SelectedPath;

            }
        }
        public static int ExtractNumber(string s)
        {
            string num = "";
            bool d = false;
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    d = true;
                    num += c;
                }
                else if (d && !char.IsDigit(c))
                {
                    break;
                }
            }
            try {return int.Parse(num); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
            
        }
        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            if (tbPath.Text.Length > 0)
            {
                btnClear.Enabled = true;
                btnSort.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
                btnSort.Enabled = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPath.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            string sourceFolder = fbd.SelectedPath;
            string targetFolder = fbd.SelectedPath;

            // Get all files in the source folder
            List<string> files = Directory.GetFiles(sourceFolder).ToList();

            // Sort the files based on the numeric part of their names
            files.Sort((a, b) => {
                int aNum = ExtractNumber(a);
                int bNum = ExtractNumber(b);
                return aNum.CompareTo(bNum);

            });

            // Rename the files and move them to the target folder
            int counter = 1;
            foreach (string file in files)
            {
                
                string fileName = Path.GetFileName(file);
                string newFileName = $"{counter}. {fileName}";
                string targetPath = Path.Combine(targetFolder, newFileName);
                File.Move(file, targetPath);
                counter++;
            }
            MessageBox.Show($"Done you sort {counter -1} video");

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }
    }
 }

