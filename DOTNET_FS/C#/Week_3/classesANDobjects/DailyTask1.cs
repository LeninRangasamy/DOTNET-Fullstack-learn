using System;
class ProgramMain{
    public static void Main(string[] args){
        Person p=new Person();
        p.Walk();
        p.Speak();
        p.Run();
    }
}
class Person{
    public void Walk()=>Console.WriteLine("Person is walking");
    public void Speak()=>Console.WriteLine("Person is speaking");
    public void Run()=>Console.WriteLine("Person is running");
}
