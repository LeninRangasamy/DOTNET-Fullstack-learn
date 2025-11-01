using System;
class Program{
  static void Main(){
    Vehicle v=new Vehicle("SUV");
    Vehicle v1=new Car("TATA");
  }
}
class Vehicle{
  public Vehicle(string type){
    Console.WriteLine($"Vehicle Type:{type}");
  }
}
class Car:Vehicle{
  string model;
  public Car(string type,string model):base(type){
    //fields;
    this.model=model;
    Console.WriteLine($"Model:{model}");

  }
  public Car(string model):this("Car",model){
    //defaults
  }
}
