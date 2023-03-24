using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_reflex_simulation
{
    public partial class FrmChapterTwo : Form
    {
        public FrmChapterTwo()
        {
            InitializeComponent();
        }

        private void chapter1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void chapter1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChapterOne newForm = new FrmChapterOne();
            this.Hide();
            newForm.Show();
        }
    }
}
