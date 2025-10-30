using System;
class Program{
  static void Main(){
    Student s=new Student("Lenin",19,'A');
    s.Show();
    Student s1=new Student("Pelvin");
    s1.Show();
    
  }
}
class Person{
  public string name;
  public int age;
  public Person(string name,int age){
    this.name=name;
    this.age=age;
  }
}
class Student:Person{
  public char grade;
  public Student(string name,int age,char grade):base(name,age){
    this.grade=grade;
  }
  public Student(string name):this(name,18,'C'){
    //Gives default value as age=18, grade=C
  }
  public void Show()=>Console.WriteLine($"{name},{age},{grade}");
}
