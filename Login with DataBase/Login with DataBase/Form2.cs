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

namespace Login_with_DataBase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fields can not be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    StreamWriter sw = File.AppendText("mydb.csv");
                    sw.WriteLine(textBox1.Text + "," + Form1.GenerateSHA256String(textBox2.Text));
                    sw.Close();

                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//end-else

        }//end-method

        private void icon1Button_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                icon2Button.BringToFront();
            }
            else
                textBox2.UseSystemPasswordChar = true;
                icon2Button.BringToFront();
        }

        private void icon2Button_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                icon1Button.BringToFront();
            }
            else
                textBox2.UseSystemPasswordChar = true;
                icon1Button.BringToFront();
        }
    }
}
