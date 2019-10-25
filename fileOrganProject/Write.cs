using fileOrganProject;
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

namespace amrhany
{
    public partial class For1 : Form
    {
        public static int x = 0;
        public For1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            For2 f1 = new For2();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\fileOrganProject\fileOrganProject\bin\Debug\data.txt";
                FileStream fs = new FileStream(path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                StringBuilder courseID = new StringBuilder(3);
                StringBuilder courseName = new StringBuilder(10);
                StringBuilder instructorName = new StringBuilder(20);
                StringBuilder numberOfStudents = new StringBuilder(2);

                courseID.Insert(0, textBox2.Text);
                instructorName.Insert(0, textBox3.Text);
                courseName.Insert(0, textBox1.Text);
                numberOfStudents.Insert(0, textBox4.Text);


                for (int i = textBox2.Text.Length; i < 3; i++)
                    courseID.Append('\0');
                sw.Write(courseID.ToString(), 0, 3);



                for (int i = textBox1.Text.Length; i < 10; i++)
                    courseName.Append('\0');
                sw.Write(courseName.ToString(), 0, 10);


                for (int i = textBox3.Text.Length; i < 20; i++)
                {
                    if (i == 19)
                        instructorName.Append('\n');
                    else if (i == 18)
                        instructorName.Append('\r');
                    else
                        instructorName.Append('\0');
                }
                sw.Write(instructorName.ToString(), 0, 20);


                for (int i = textBox4.Text.Length; i < 2; i++)
                    numberOfStudents.Append('\0');
                sw.Write(numberOfStudents.ToString(), 0, 2);
                sw.WriteLine();
                x = Convert.ToInt32(textBox4.Text);

                sw.Close();
                For2 f1 = new For2();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }catch(Exception e1)
            {
                MessageBox.Show("Sorry There is missing input","Error");
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void For1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
