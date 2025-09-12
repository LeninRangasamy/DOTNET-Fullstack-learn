using System;
class Application{
    public static void Main(string[] args){
      C
      //method 1
      Console.WriteLine("Method Type 1:");
      Method1 m1=new Method1();
      m1.BasicFunction();
       
      //method 2
      Console.WriteLine("\nMethod Type 2:");
      WithParameters wp= new WithParameters();
      wp.LeapYear(2024);
       
      //method 3
      Console.WriteLine("\nMethod Type 3:");
      WithReturnValues wrv=new WithReturnValues();
      int result= wrv.Age(2004,2025);
      Console.WriteLine($"Your age is {result}");
      
      //method 4
      Console.WriteLine("\nMethod Type 4:");
      DefaultParameters dp=new DefaultParameters();
      dp.Values("Custom message");
    }
}

//method 1
class Method1{
    public void BasicFunction(){
      Console.WriteLine("Hello from Basic Function");
    }
}

//method 2
class WithParameters{
    public void LeapYear(int a){
        if (a%4==0){
            Console.WriteLine($"{a} is a leap year");
        }
        else{
            Console.WriteLine($"{a} is not a leap year");
        }
    }       
}

//method 3
class WithReturnValues{
    public int Age(int doy,int cy){
        int age=cy-doy;
        return age;
    } 
}

//method 4
class DefaultParameters{
    public void Values(string msg="This is a default value"){
        Console.WriteLine(msg);
    }
}
