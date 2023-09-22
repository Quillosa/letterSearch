using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //hold the error
            {
                int index;
                string search = textBox2.Text;
                string input = textBox1.Text;
                
                for(index = 0; index < search.Length; index++) // to loop the index
                {
                    if (search == "" || input == "")
                    {
                        label1.Text = "plss input in textboxes";
                        break;
                    }
                    else if (search.Contains(input[index]))//kapag si input ay contains ung ssineacrch and sa index
                    {
                        label1.Text = "found";
                        break;  
                    }
                    else
                    {
                        label1.Text = "not found";
                        break;

                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("error perd" + ex);
            }
        }
    }
}
