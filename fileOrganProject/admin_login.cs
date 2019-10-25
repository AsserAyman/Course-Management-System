using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileOrganProject
{
    public partial class admin_login : Form
    {
        char[] course_name = new char[10];
        char[] course_id = new char[3];
        char[] course_instructor = new char[20];
        string Student_name;
        string Student_id;
        string Student_Phone;
        public admin_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                dataGridView1.Rows.Clear();
                bool isFound = false;
                while (sr.Peek() != -1)
                {

                    sr.Read(course_id, 0, 3);
                    sr.Read(course_name, 0, 10);
                    sr.Read(course_instructor, 0, 20);
                    string cont;
                    cont = sr.ReadLine();
                    int z = 0;

                    //Checking if Name of Course is Found
                    bool check = true;

                    foreach (var VARIABLE in course_name)
                    {
                        if (z > textBox1.Text.Length - 1)
                            break;
                        if (VARIABLE != textBox1.Text[z])
                            check = false;
                        z++;
                    }

                    if (check == true)
                    {
                        isFound = true;
                        for (int i = 0; i < Convert.ToInt32(cont); i++)
                        {
                            string[] token = sr.ReadLine().Split(',');
                            Student_id = token[0];
                            Student_name = token[1];
                            Student_Phone = token[2];
                            dataGridView1.Rows.Add(Student_id, Student_name, Student_Phone);
                        }


                    }
                    else
                    {
                        for (int i = 0; i < Convert.ToInt32(cont); i++)
                            sr.ReadLine();
                    }


                }
                if (!isFound)
                    MessageBox.Show("Course Name Not Found ", "Alert");
                sr.Close();
                fs.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show("Invalid Input ", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
