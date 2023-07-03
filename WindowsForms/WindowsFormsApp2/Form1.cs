using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "")
            {
                if(txt_Family.Text!="")
                {
                    if(txt_Age.Text!="")
                    {
                        if(txt_Address.Text!="")
                        {
                            string txt = txt_Name.Text + " " + txt_Family.Text + " " + txt_Age.Text + " " + txt_Address.Text;

                            MessageBox.Show(txt);
                        }
                        else
                        {
                            MessageBox.Show("address not fill");
                        }
                    }
                    else
                    {
                        MessageBox.Show("age not fill");
                    }
                }
                else
                {
                    MessageBox.Show("family not fill");
                }
            }
            else
            {
                MessageBox.Show("name not fill");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
