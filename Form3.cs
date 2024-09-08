using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox9.Text== "")
            {
                MessageBox.Show("Enter Your ID");
                return;
            }

            String fn;
            fn = "C:\\Users\\almut\\OneDrive\\Desktop\\Internship\\New folder\\";
            String sn;
            sn = fn + textBox9.Text + "firstname.txt" ;


            if(System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn ,Encoding.UTF8);
                this.textBox2.Text = r; 
            
            }

             sn = fn + textBox9.Text + "lastname.txt";


            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox3.Text = r;

            }

            sn = fn + textBox9.Text + "telephone.txt";

            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox4.Text = r;

            }

             sn = fn + textBox9.Text + "cellphone.txt";

            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox5.Text = r;

            }

            sn = fn + textBox9.Text + "email.txt";

            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox6.Text = r;

            }

            sn = fn + textBox9.Text + "contact.txt";

            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox7.Text = r;

            }

             sn = fn + textBox9.Text + "address.txt";

            if (System.IO.File.Exists(sn) == true)
            {
                String r;
                r = System.IO.File.ReadAllText(sn, Encoding.UTF8);
                this.textBox8.Text = r;

            }

            









        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.textBox10.Text = this.openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox11.Text = System.IO.File.GetCreationTime(this.textBox10.Text).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox11.Text = System.IO.File.GetLastWriteTime(this.textBox10.Text).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox11.Text = System.IO.File.GetLastAccessTime(this.textBox10.Text).ToString();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
