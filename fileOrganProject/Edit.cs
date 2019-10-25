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

namespace fileOrganProject
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\fileOrganProject\fileOrganProject\bin\Debug\data.txt";
                FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                bool isFound = false;

                while (sr.Peek() != -1)
                {
                    char[] course_name = new char[10];
                    char[] course_id = new char[3];
                    char[] course_instructor = new char[20];
                    string text = File.ReadAllText(path);

                    String str1 = "";
                    String str = "";


                    //StringBuilder str1 = new StringBuilder(10);
                    ///str1.Insert(0, textBox1.Text);
                    str1 += textBox1.Text;
                    str += textBox2.Text;

                    for (int i = textBox1.Text.Length; i < 10; i++)
                    {

                        str1 += ('\0');
                    }

                    // StringBuilder str = new StringBuilder(20);
                    // str.Insert(0, textBox2.Text);
                    for (int i = textBox2.Text.Length; i < 20; i++)
                    {
                        if (i == 19)
                            str += ('\n');
                        else if (i == 18)
                            str += ('\r');
                        else
                            str += ('\0');
                    }

                    String courseID = "";
                    String courseName = "";
                    String courseInstructor = "";

                    sr.Read(course_id, 0, 3);
                    sr.Read(course_name, 0, 10);
                    sr.Read(course_instructor, 0, 20);

                    foreach (var VARIABLE in course_id)
                        courseID += VARIABLE;

                    foreach (var VARIABLE in course_name)
                        courseName += VARIABLE;


                    foreach (var VARIABLE in course_instructor)
                        courseInstructor += VARIABLE;

                    if (str1.Equals(courseName))
                    {

                        sr.Close();
                        isFound = true;

                        text = text.Replace(courseInstructor.ToString(), str.ToString());
                        File.WriteAllText("data.txt", text);
                        MessageBox.Show("Edited Successufely", ":)");
                        break;

                    }



                    string numberOfStudents;
                    numberOfStudents = sr.ReadLine();


                    //Just To Ignore Lines Special For Students
                    for (int i = 0; i < Convert.ToInt32(numberOfStudents); i++)
                        sr.ReadLine();



                }
                if (!isFound)
                {
                    MessageBox.Show("Can't Find this Course", "Alert");
                }
                sr.Close();
                fs.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show("Missing Input ", "Error");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
