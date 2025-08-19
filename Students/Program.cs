short studentsCount = short.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] arguments = Console.ReadLine().Split();
    string firstName = arguments[0];
    string lastName = arguments[1];
    double grade = double.Parse(arguments[2]);

    Student student = new Student(firstName, lastName, grade);
    students.Add(student);
}

students = students.OrderByDescending(s => s.Grade).ToList();

foreach (Student student in students)
{
    Console.WriteLine(student);
}
public class Student
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

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:F2}";
    }
}