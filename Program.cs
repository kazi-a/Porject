using System;

namespace Project
{
    class Student
    {
        // Private fields
        private int _studentId;
        private string _studentName;
        private char _grade;

        // Default constructor
        public Student()
        {
            // Default values
            _studentId = 0;
            _studentName = "Unknown";
            _grade = 'N';
        }

        // Parameterized constructor
        public Student(int studentId, string studentName, char grade)
        {
            _studentId = studentId;
            _studentName = studentName;
            _grade = grade;
        }

        // Get and Set methods for _studentId field
        public int GetStudentId()
        {
            return _studentId;
        }

        public void SetStudentId(int studentId)
        {
            _studentId = studentId;
        }

        // Get and Set methods for _studentName field
        public string GetStudentName()
        {
            return _studentName;
        }

        public void SetStudentName(string studentName)
        {
            _studentName = studentName;
        }

        // Get and Set methods for _grade field
        public char GetGrade()
        {
            return _grade;
        }

        public void SetGrade(char grade)
        {
            _grade = grade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects using default constructor
            Student student1 = new Student();
            Student student2 = new Student();

            // Set data for student1 using set methods
            student1.SetStudentId(1);
            student1.SetStudentName("John Doe");
            student1.SetGrade('A');

            // Set data for student2 using set methods
            student2.SetStudentId(2);
            student2.SetStudentName("Jane Smith");
            student2.SetGrade('B');

            // Creating two objects using parameterized constructor with user input
            Console.WriteLine("Enter details for Student 3:");
            Student student3 = CreateStudentWithInput();
            Console.WriteLine("Enter details for Student 4:");
            Student student4 = CreateStudentWithInput();

            // Printing object information
            Console.WriteLine("Object Information:");
            Console.WriteLine("--------------------");
            PrintStudentInfo(student1);
            PrintStudentInfo(student2);
            PrintStudentInfo(student3);
            PrintStudentInfo(student4);
        }

        // Method to create a student object with user input
        static Student CreateStudentWithInput()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Grade: ");
            char grade = char.Parse(Console.ReadLine());
            return new Student(id, name, grade);
        }

        // Method to print student information
        static void PrintStudentInfo(Student student)
        {
            Console.WriteLine($"Student ID: {student.GetStudentId()}");
            Console.WriteLine($"Student Name: {student.GetStudentName()}");
            Console.WriteLine($"Grade: {student.GetGrade()}");
            Console.WriteLine();
        }
    }
}
