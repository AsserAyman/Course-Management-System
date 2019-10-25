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
    public partial class Read : Form
    {
        char[] course_name= new char[10];
        char[] course_id=new char[3];
        char[] course_instructor=new char[20];
        string Student_name;
        string Student_id;
        string Student_Phone;

        public Read()
        {
            InitializeComponent();
            load();
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
           
        }
        private void load() {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
         
            while (sr.Peek() != -1)
            {
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

                string numberOfStudents;
                numberOfStudents = sr.ReadLine();

                dataGridView1.Rows.Add(courseID, courseName, courseInstructor, numberOfStudents);

                //Just To Ignore Lines Special For Students
                for (int i = 0; i < Convert.ToInt32(numberOfStudents); i++)
                    sr.ReadLine();



            }
            sr.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Read_Load(object sender, EventArgs e)
        {

        }
    }
}