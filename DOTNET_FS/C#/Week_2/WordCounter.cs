using System;
class Program{
    public static void Main(string[] args){
        //getting input
        string word;
        Console.WriteLine("Enter a word:");
        word=Console.ReadLine();
        try{
            WordCounter(word);
        }
        catch(Exception x){
            Console.WriteLine(x.Message);
        }
        finally{
            Console.WriteLine("Program finnished ");
        }
    }
    static void WordCounter(string w){
        int len;
        len=w.Length;
        //Console.WriteLine($"The total word count is {len}");
        if (len==0){
            throw new Exception ("The words count is null");
        }
        else{
          Console.WriteLine($"The total word count is {len}");
        }
    }
}
