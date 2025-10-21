using System;
class ProgramMain{
    public static void Main(){
        Book[] b={
            new Book(),
            new Book("Automic fusion","Jhon"),
            new Book("The goat life","Najeeb",1999)
        };
        foreach(var bo in b){
            bo.Show();
            Console.WriteLine("------------");
        }
    }
}
class Book{
    public string title,author;
    public int price;
    public Book(){
        title="unknown";
        author="unknown";
        price=0;
    }
    public Book(string title,string author){
        this.title=title;
        this.author=author;
        price=500;
    }
    public Book(string title,string author,int price){
        this.title=title;
        this.author=author;
        this.price=price;
    }
    public void Show()=>Console.WriteLine($"Book details:\nTitle:{title}\nAuthor:{author}\nPrice:{price}");
}
