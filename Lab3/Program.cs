using System;

//variant 13
namespace oop_lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            TableOfStudents students = new TableOfStudents(10);
            students[0] = new Student { Name = "Nicol", Surname = "Necha", ByPatronomic = "Dmitriiyovich" };
            students[1] = new Student { Name = "Vasya", Surname = "Nechay", ByPatronomic = "Alexandriyovich" };
            students[2] = new Student { Name = "Alex", Surname = "Nechay", ByPatronomic = "Alexandriyovich" };
            string a = students[0].Name;
            int c = students.StudentsCount;
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
            get => studentsCount;
            set => studentsCount = value;
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
                if (data[index].Surname.Equals("Nechay"))
                {
                    studentsCount += 1;
                }
                //Console.WriteLine(data[index].Surname);
            }
        }
    }
}