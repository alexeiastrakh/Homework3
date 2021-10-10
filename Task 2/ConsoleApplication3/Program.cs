using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TASK2
{
    abstract class Student
    {
        public string name;
        public string state;
        public Student(string _name)
        {
            name = _name;
            state = "";
        }
        public void Relax()
        {
            state += "Relax";
        }
        public void Read()
        {
            state += "Read";
        }
        public void Write()
        {
            state += "Write";
        }
        abstract public void Study();
    }
    class GoodStudent : Student
    {
        public GoodStudent(string _name)
            : base(_name)
        {
            state += "good";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
        class BadStudent : Student
        {
            public BadStudent(string _name)
                : base(_name)
            {
                state += "bad";
            }

            public override void Study()
            {
                Relax();
                Relax();
                Relax();
                Relax();
                Read();
            }
        }
        class Group
        {

            public string group_name;

            public List<Student> students_group;

            public Group(string group_Name)
            {
                group_name = group_Name;

                students_group = new List<Student>();
            }
            public Group(string group_Name, List<Student> students)
            {
                group_name = group_Name;

                students = students_group;

            }
            public void AddStudent(Student st)
            {
                students_group.Add(st);
            }
            public void GetInfo()
            {
                Console.WriteLine(group_name);
                foreach (Student st in students_group)
                {
                    Console.WriteLine(st.name + " ");
                }
            }
            public void GetFullInfo()
            {
                Console.WriteLine(group_name);
                foreach (Student st in students_group)
                {
                    Console.WriteLine(st.name + " " + st.state);
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    Group A = new Group("K-25");
                    GoodStudent B = new GoodStudent("Merry");
                    BadStudent C = new BadStudent("John");


                    A.AddStudent(B);
                    A.AddStudent(C);
                    Console.WriteLine("GetInfo:");
                    A.GetInfo();
                    Console.WriteLine("GetFullInfo:");
                    A.GetFullInfo();
                    Console.Read();
                }
            }
        }
    }
}
