namespace TestDataStructures;

public class Tests
{
    [Test]
    public void Run()
    {
        Student x = new Student();
        x.Name = "khoa";
        x.Age = 5;

        if (x == null)
        {

        }

        SetStudentToNull(x);
        if (x == null)
        {
            
        }
        else
        {

        }

    }

    public void SetStudentToNull(Student x)
    {
        x.Name = "Link";
    }

    public class Student
    {
        public string Name;
        public int Age;
    }
}
