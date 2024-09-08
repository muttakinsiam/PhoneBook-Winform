using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.MdiParent = this;
            reg.Show();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.MdiParent = this;
            s.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {

        }

        private void floralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::PhoneBook.Properties.Resources.natures_beauty_captured_colorful_flower_close_up_generative_ai;

        }

        private void batmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = global::PhoneBook.Properties.Resources.simple;

        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks Visit Our Website");
        }
    }
}
