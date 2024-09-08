using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneBook
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false; //
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel2.Enabled = true;
            this.groupBox1.Enabled = true; 

            this.textbox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.toolStripLabel2.Enabled= false;
            this.toolStripLabel1.Enabled = true;
            this.groupBox1.Enabled = false;
            String fn;
            fn = "C:\\Users\\almut\\OneDrive\\Desktop\\Internship\\New folder\\";
            String sn;

            sn = fn + textbox1.Text + "ID.txt"; //renaming the txt file
            System.IO.File.WriteAllText(sn, textbox1.Text, Encoding.UTF8); /// writing value in the txt file

            sn = fn + textbox1.Text + "firstname.txt";
            System.IO.File.WriteAllText(sn, textBox2.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "lastname.txt";
            System.IO.File.WriteAllText(sn, textBox3.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "telephone.txt";
            System.IO.File.WriteAllText(sn, textBox4.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "cellphone.txt";
            System.IO.File.WriteAllText(sn, textBox5.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "email.txt";
            System.IO.File.WriteAllText(sn, textBox6.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "contact.txt";
            System.IO.File.WriteAllText(sn, textBox7.Text, Encoding.UTF8);

            sn = fn + textbox1.Text + "address.txt";
            System.IO.File.WriteAllText(sn, textBox8.Text, Encoding.UTF8);








           }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (this.textBox4.Text.Length >= 14)
            {
                this.label11.Text = this.textBox4.Text.Length.ToString();
                this.label12.Text = this.textBox5.Text.Length.ToString();             
                this.label14.Text = this.textBox4.Text.Substring(0, 3);           
                this.label15.Text = this.textBox4.Text.Substring(3, 11);
                Int32 countrycode;
                if (Int32.TryParse(this.label14.Text, out countrycode))
                {
                    switch (countrycode)
                    {
                        case 88:
                            this.label16.Text = "Bangladesh";
                            break;
                        case 1:
                            this.label16.Text = "United States";
                            break;
                        case 44:
                            this.label16.Text = "United Kingdom";
                            break;
                        case 91:
                            this.label16.Text = "India";
                            break;
                        case 81:
                            this.label16.Text = "Japan";
                            break;
                        case 61:
                            this.label16.Text = "Australia";
                            break;
                        case 49:
                            this.label16.Text = "Germany";
                            break;
                        default:
                            this.label16.Text = "Unknown Country";
                            break;
                    }
                }
                else
                {
                    this.label16.Text = "Invalid Country Code";
                }
            }
            else
            {
                
                this.label16.Text = "Input too short";
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
    }

