
using System.Security.Cryptography.X509Certificates;

ContractStudent contractStudent = new ContractStudent("Денис", 12345, 3, 10000);
BudgetStudent budgetStudent = new BudgetStudent("Иван", 54321, 2, true);
CorrespondenceStudent corStudent = new CorrespondenceStudent("Катя", 67890, 1, 38);
contractStudent.ShowGeneralData();
budgetStudent.ShowGeneralData();
corStudent.ShowGeneralData();

List<Student> fakult = new List<Student>()
{
    contractStudent, budgetStudent, corStudent;
};

abstract class Person
{
    public string name;
    public Person(string name)
    {
        this.name = name;
    }
}
abstract class Student:Person
{
    public int studentId, course;
    public Student(string name, int studentId, int course):base(name)
    {
        this.studentId = studentId;
        this.course = course;
    }
    public abstract void ShowGeneralData();
    
}
class ContractStudent:Student
{
    public int contractPrice;

    public ContractStudent(string name, int studentId,int course, int contractPrice):base(name,studentId, course)
    {
        this.contractPrice = contractPrice;
    } 
    public override void ShowGeneralData()
    {
        Console.WriteLine($"Студент {name} учится на {course} курсе, его номер студенческого {studentId}, учится на контракте за {contractPrice}грн за семестр");
    }
}
class BudgetStudent : Student
{
    public bool gettingScholarship;
    public BudgetStudent(string name, int studentId, int course, bool gettingScholarship) : base(name, studentId, course)
    { 
        this.gettingScholarship = gettingScholarship;
    }
    
    public override void ShowGeneralData()
    {
        Console.WriteLine($"Студент {name} учится на {course} курсе, его номер студенческого {studentId}, учится на бюджете,получает ли стипендию - {gettingScholarship}");
    }
}
class CorrespondenceStudent : Student
{
    public int numberOfLessons;
    public CorrespondenceStudent(string name, int studentId, int course, int numberOfLessons) : base(name, studentId, course)
    { 
        this.numberOfLessons = numberOfLessons;
    }
    public override void ShowGeneralData()
    {
        Console.WriteLine($"Студент {name} учится на {course} курсе, его номер студенческого {studentId}, учится на заочном по {numberOfLessons} пар(ы) в семестр");
    }
}

