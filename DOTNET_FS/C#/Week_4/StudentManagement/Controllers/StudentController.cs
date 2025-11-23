using System;
using System.Linq;
using System.Collections.Generic;
using StudentManagement.Models.StudentModel;
namespace StudentManagement.Controllers.StudentController;

public class StudentController
{
    private List<Student> st = new List<Student>{
        new Student{id=1,name="Abinaya",marks=370},
        new Student {id=2,name="Agalya",marks=390}
    };

    //Show all students
    public void Index()
    {
        foreach (var s in st)
        {
            Console.WriteLine($"Student info:\nID: {s.id}\nName: {s.name}\nMarks: {s.marks}\n----------");
        }
    }

    //Create
    public void Create(int i, string n, int m)
    {
        var NewStudent = new Student
        {
            id = i,
            name = n,
            marks = m
        };
        st.Add(NewStudent);
        Index();
    }

    //Read specific student
    public void Read(int id)
    {
        var result = st.FirstOrDefault(e => e.id == id);
        if (result != null)
        {
            Console.WriteLine($"Student ID: {result.id}\nStudent Name: {result.name}\nStudent Mark: {result.marks}");
        }
        else Console.WriteLine("Given result is empty");
    }

    //Update 
    public void Update(int i, string n, int m)
    {
        var result = st.FirstOrDefault(e => e.id == i);
        if (result != null)
        {
            result.name = n;
            result.marks = m;
            Console.WriteLine("Updated successfully");
            Index();
        }
        else Console.WriteLine("Given result is empty");

    }

    //Delete specific student
    public void Delete(int id)
    {
        var result = st.FirstOrDefault(e => e.id == id);
        try
        {
            st.RemoveAt(id);
            Console.WriteLine($"Student {id} was removed successfull");
            Index();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Given index value is out of range\nUse Student ID -1 for exact student results");
        }
    }

}
