using System;
class Program{
  static void Main(){
    Manager e=new Manager();
    e.Show();
    e.ShowCompany();
  }
}
class Employee{
  protected string company="XYZ com";
  public void ShowCompany()=>Console.WriteLine($"Company name:{company}");
}
class Manager:Employee{
  public void Show()=>Console.WriteLine($"Manager works at {company}");
}
