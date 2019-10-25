using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileOrganProject
{
    class Course
    {
        public int id_length;
        public int course_name_length;
        public int instructor_name_length;

        public char[] ID;
        public char[] Course_name;
        public char[] Instructor_name;

        public Course()
        {
            id_length = 3;
            course_name_length = 10;
            instructor_name_length = 10;
            ID = new char[id_length];
            Course_name = new char[course_name_length];
            Instructor_name = new char[instructor_name_length];
        }
        public bool ReadData_FromUser()
        {
            string str;
            Console.Write("Enter ID:");
            str = Console.ReadLine();
            if (str.Length > id_length)
            {
                Console.WriteLine("ID is too long!!!!");
                return false;
            }
            str.CopyTo(0, ID, 0, str.Length);
            for (int i = str.Length; i < id_length; i++)
                ID[i] = '\0';

            Console.Write("Enter Course Name:");
            str = Console.ReadLine();
            if (str.Length > course_name_length)
            {
                Console.WriteLine("Course name is too long!!!!");
                return false;
            }
            str.CopyTo(0, Course_name, 0, str.Length);
            for (int i = str.Length; i < course_name_length; i++)
                Course_name[i] = '\0';

            Console.Write("Enter Instructor Name:");
            str = Console.ReadLine();
            if (str.Length > instructor_name_length)
            {
                Console.WriteLine("Instructor Name is too long!!!!");
                return false;
            }
            str.CopyTo(0, Instructor_name, 0, str.Length);
            for (int i = str.Length; i < instructor_name_length; i++)
                Course_name[i] = '\0';
            return true;
        }
        public void Display_Data()
        {
            Console.WriteLine("ID\tName\n--\t----");
            Console.Write(ID);
            Console.Write("\t");
            Console.WriteLine(Course_name);
            Console.Write("\t");
            Console.WriteLine(Instructor_name);
        }

        public static class load
        {
            public static Course course = new Course();
        }
    }
}

