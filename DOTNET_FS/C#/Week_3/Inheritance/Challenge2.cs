using System;
class Program{
  static void Main(){
    Animal a=new Animal();
    a.Sound();
    Dog d=new Dog();
    d.Sound();
    Cat c=new Cat();
    c.Sound();
    
    //See the difference between these outputs
    Animal a1=new Dog();
    Animal a2=new Cat();
    a1.Sound();
    a2.Sound();
  }
}
class Animal{
  public virtual void Sound()=>Console.WriteLine("Animals can make sound");
}
class Dog:Animal{
  public override void Sound()=>Console.WriteLine("Dog barks");
  
}
class Cat:Animal{
  public new void Sound()=>Console.WriteLine("Cat meows");
}
