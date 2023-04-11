using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                double a1 = double.Parse(textBox1.Text);
                double b1 = double.Parse(textBox2.Text);
                double c1 = double.Parse(textBox3.Text);
                double a2 = double.Parse(textBox4.Text);
                double b2 = double.Parse(textBox5.Text);
                double c2 = double.Parse(textBox6.Text);
      
                double d = a1 * b2 - a2 * b1;
            
                if (d == 0)
                {
                    textBox7.Text = "Прямі не існують";
                }
                else
                {
                    textBox7.Text = "Прямі існують";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат вводу");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
            finally
            {
             
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}
