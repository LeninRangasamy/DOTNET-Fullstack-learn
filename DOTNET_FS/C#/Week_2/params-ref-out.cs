using System;
class Program{
    static void Main(string[] args){
        Params(10,20,30);
       //Params(1,2,3,4,5);
       int x=4;
       Ref(ref x);
       Console.WriteLine($"Output of Ref {x}");
       int y,z;
       Out(out y,out z);
       int t=y+z;
       Console.WriteLine($"Out function output {t}");
        
    }
    static void Params(params int[] arr){
        for (int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine(arr.Length);
    }
    static void Ref(ref int num){
        num+=2;
        Console.WriteLine($"Total {num}");
    }
    static void Out(out int a,out int b){
        a=10;
        b=20;
        
    }
}￼Enter
