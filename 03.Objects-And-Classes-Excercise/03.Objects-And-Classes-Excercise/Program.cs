
using System.Diagnostics;

int n = int.Parse(Console.ReadLine());

List<Student> listOfStudents = new List<Student>();

for (int i = 0; i < n; i++)
{
    string[] studentInfo = Console.ReadLine().Split(" ").ToArray();

    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    double grade = double.Parse(studentInfo[2]);

    Student currentStudent = new Student(firstName, lastName, grade);

    listOfStudents.Add(currentStudent);
    
}
foreach (var student in listOfStudents.OrderByDescending(s => s.Grade))
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}


class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public double Grade { get; set; }
}