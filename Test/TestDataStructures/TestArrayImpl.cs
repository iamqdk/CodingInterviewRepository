using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DataStructures.DataStructuresImpl;

namespace TestDataStructures;

public class Tests
{
    [Test]
    public void DoublyLinkedList()
    {
        var doublyLinkedList = new DoublyLinkedListImpl();
        doublyLinkedList.AddLast(1);
        doublyLinkedList.AddLast(2);
        doublyLinkedList.AddLast(3);
        doublyLinkedList.AddLast(4);
        doublyLinkedList.AddLast(5);

        doublyLinkedList.AddLast(6);
    }

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
