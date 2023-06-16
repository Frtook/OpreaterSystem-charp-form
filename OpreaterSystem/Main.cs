using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpreaterSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void butSortFile(object sender, EventArgs e)
        {
            Hide();
            SortFile sortFile = new SortFile();
            sortFile.Show();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Hide();
            CatText c = new CatText();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SearchFile sf = new SearchFile();
            sf.Show();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Hide();
            CountText count = new CountText();
            count.Show();
        }
    }
}
