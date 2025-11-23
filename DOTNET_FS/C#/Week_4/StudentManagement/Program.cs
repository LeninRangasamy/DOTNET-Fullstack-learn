using System;
using System.Linq;
using StudentManagement.Models.StudentModel;
using StudentManagement.Controllers.StudentController;namespace StudentManagement;

public static class Program
{
    public static void Main()
    {
        var stc = new StudentController();
        int option;
        int session;

        Console.WriteLine("Welcome to student management");

        Console.WriteLine($"Choose option\n1.View all \n2.Create new\n3.Read\n4.Update\n5.Delete");

        session = 1;
        while (session == 1)
        {
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    stc.Index();
                    break;

                case 2:
                    Console.WriteLine("Enter student id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter student name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter student marks");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    stc.Create(id, name, marks);
                    break;

                case 3:
                    Console.WriteLine("Enter student id");
                    int d = Convert.ToInt32(Console.ReadLine());
                    stc.Read(d);
                    break;

                case 4:
                    Console.WriteLine("Enter student's id you want to update");
                    int i = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter student name");
                    string n = Console.ReadLine();

                    Console.WriteLine("Enter student marks");
                    int m = Convert.ToInt32(Console.ReadLine());
                    stc.Update(i, n, m);
                    break;

                case 5:
                    Console.WriteLine("Enter student id");
                    int did = Convert.ToInt32(Console.ReadLine());

                    stc.Delete(did);
                    break;


            }
            Console.WriteLine("To continue 1\nEnd session 0");
            session = Convert.ToInt32(Console.ReadLine());
            if (session == 0)
            {
                Console.WriteLine("-------Session ended-------");
                break;
            }

            else continue;

        }

    }
}

