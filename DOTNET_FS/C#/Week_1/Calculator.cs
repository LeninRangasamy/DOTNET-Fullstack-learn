using System;
class Program {
  public static void Main(string[] args){
    int i=0;
    while(i!=1){
      Calculator cl=new Calculator();
      cl.calc();
      Console.WriteLine("Do you want continue (0-Yes/1-No)");
      int k=Convert.ToInt32(Console.ReadLine());
      if (k==1){
        i++;
      }
    }
  }
}
class Calculator {
  public int calc(){
    //Menu
    Console.WriteLine("Choose operation\n1.Add\n2.Sub\n3.Mul\n4.Div\n5.Modulus");
    int op=Convert.ToInt32(Console.ReadLine());
    //input two numbers
    Console.WriteLine("Enter number 1");
    int num1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number 2");
    int num2=Convert.ToInt32(Console.ReadLine());
    //operations
    switch (op){
      case 1:
        int a=num1+num2;
        Console.WriteLine(a);
        break;
      case 2:
        int b=num1-num2;
        Console.WriteLine(b);
        break;
      case 3:
        int c=num1*num2;
        Console.WriteLine(c);
        break;
      case 4:
        int d=num1/num2;
        Console.WriteLine(d);
        break;
      case 5:
        Console.WriteLine(num1%num2);
        break;
      default:
        Console.WriteLine("Input does not reached");
    }
    return 0;
  }
}
