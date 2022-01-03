using System;

namespace StudentInformationOOP
{
    class Student
    {
        public string id;
        public string name;
        public uint age;
        public string gender;
        public string major;
        public double midtermGrade;
        public double finalGrade;
        public double assignmentGrade;
        public double averageGrade;
        public string status;

        public void GetStudent()
        {
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Major: {0}", major);
            Console.WriteLine("Assignment: {0}", assignmentGrade);
            Console.WriteLine("Midterm: {0}", midtermGrade);
            Console.WriteLine("Final: {0}", finalGrade);
            Console.WriteLine("Average: {0}", averageGrade);
            Console.WriteLine("Status: {0}", status); 
        }

        public void CalculateAverageGrade()
        {
            averageGrade = (assignmentGrade + midtermGrade * 2 + finalGrade + 3) / 6;
        }

        public void SetStatus()
        {
            if (averageGrade >= 5)
            {
                status = "Passed";
            } else if (averageGrade < 5)
            {
                status = "Failed";
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.Write("Enter ID: ");
            student1.id = Console.ReadLine();
            Console.Write("Enter name: ");
            student1.name = Console.ReadLine();
            Console.Write("Enter age: ");
            student1.age = uint.Parse(Console.ReadLine());
            Console.Write("Enter gender: ");
            student1.gender = Console.ReadLine();
            Console.Write("Enter major: ");
            student1.major = Console.ReadLine();
            Console.Write("Enter midterm grade: ");
            student1.midtermGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter final grade: ");
            student1.finalGrade = double.Parse(Console.ReadLine());
            Console.Write("Enter assignment grade: ");
            student1.assignmentGrade = double.Parse(Console.ReadLine());

            student1.CalculateAverageGrade();
            student1.SetStatus();
            student1.GetStudent();
        }
    }
}
