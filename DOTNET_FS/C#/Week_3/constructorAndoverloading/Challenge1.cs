using System;
class ProgramMain{
    public static void Main(string[] args){
        Employee[] e={
            new Employee(1001,"Pelvin",15000),
            new Employee(1002,"Boopa",13000)
        };
        foreach(var em in e){
            em.Show();
            Console.WriteLine("---------------");
        }
        
    }
}
class Employee{
    public int id;
    public string name;
    public int salary;
    public Employee(int id,string name,int salary){
        this.id=id;
        this.name=name;
        this.salary=salary;
    }
    public void Show()=>Console.WriteLine($"ID: {id}\nName:{name}\nSalary:{salary}");
}
