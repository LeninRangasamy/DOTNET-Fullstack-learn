using System;
class ProgramMain{
    public static void Main(){
        Car[] c={
            new Car("TATA","SUV",500000),
            new Car("HONDA","M324"),
            new Car("RollsRoyce","Phantom",7000000)
        };
        foreach(var car in c) car.ShowDetails();
    }
}
class Car{
    public string brand,model;
    public long price;
    public Car(string b,string m,int p){
        brand=b;
        model=m;
        price=p;
    }
    public Car(string b,string m)
    {
        brand=b;
        model=m;
        price=1000000;
    }
    public void ShowDetails(){
        Console.WriteLine($"Car details:");
        Console.WriteLine($"Brand:{brand}");
        Console.WriteLine($"Model:{model}");
        Console.WriteLine($"Price:{price}");
        Console.WriteLine("-------------");
    }
}
