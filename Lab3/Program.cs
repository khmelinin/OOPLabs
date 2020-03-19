// 13
using System;

namespace oop_lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            TableOfStudents students = new TableOfStudents(10);
            students[0] = new Student { Name = "Nicol", Surname = "Chuk", ByPatronomic = "Dmitriiyovich" };
            students[1] = new Student { Name = "Vasya", Surname = "Ey", ByPatronomic = "Alexandriyovich" };
            students[2] = new Student { Name = "Alex", Surname = "Nechay", ByPatronomic = "Alexandriyovich" };
            string a = students[0].Name;
            int c = students.StudentsCount;
            int cc = c;
            Console.WriteLine(c);
        }
    }

    class Student
    {
        string name;
        string surname;
        string byPatronomic;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string ByPatronomic
        {
            get => byPatronomic;
            set => byPatronomic = value;
        }


    }

    class TableOfStudents
    {
        Student[] data;
        private int studentsCount = 0;

        public int StudentsCount
        {
            get
            {
                
                for (int i = 0; i < data.Length; i++)
                {
                    
                        if (data[i]!=null && data[i].Surname=="Nechay")
                        {
                        
                            studentsCount++;
                        }
                    
                }
                return studentsCount;
            }
            

        }


        public TableOfStudents(int length)
        {
            data = new Student[length];
        }

        public Student this[int index]
        {
            get { return data[index]; }

            set
            {
                data[index] = value;
                //if (data[index].Surname.Equals("Nechay"))
                //{
                //    studentsCount += 1;
                //}
                
            }
        }
    }
}