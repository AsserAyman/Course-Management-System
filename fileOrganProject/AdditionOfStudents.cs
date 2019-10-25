using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fileOrganProject;

namespace amrhany
{
    public partial class For2 : Form
    {
        public For2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            For1 f1 = new For1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\fileOrganProject\fileOrganProject\bin\Debug\data.txt";
                FileStream fs = new FileStream(path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(textBox5.Text + "," + textBox4.Text + "," + textBox6.Text);

                For1.x--;
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                sw.Close();

                if (For1.x == 0)
                {
                    MessageBox.Show("Students Enrolled Successufely to this course");
                    MainPage f1 = new MainPage();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
     
            }catch(Exception e1)
            {
                MessageBox.Show("Sorry There is missing input", "Error");
            }

        }

        private void For2_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
