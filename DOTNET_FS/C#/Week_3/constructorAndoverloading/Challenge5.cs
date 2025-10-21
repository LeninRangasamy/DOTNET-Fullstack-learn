using System;
class ProgramMain{
    public static void Main(){
        Order[] o={
            new Order(),
            new Order("Dosa",4),
            new Order("Kuruma",2),
            new Order("Idly",5,120)
        };
        foreach(var or in o){
            or.Display();
            //Console.WriteLine("-------------");
        }
    }
}
class Order{
    private static int counter=1340;
    public string productName;
    public int orderId, quantity,price;
    public Order(){
        orderId=0;
        productName="unknown";
        quantity=0;
        price=0;
    }
    public Order(string pn,int q){
        counter++;
        orderId=counter;
        productName=pn;
        quantity=q;
        price=100;
    }
    public Order(string pn,int q,int p){
        counter++;
        orderId=counter;
        productName=pn;
        quantity=q;
        price=p;
    }
    int GetTotalAmount()=>quantity*price;
    public void Display(){
        Console.WriteLine("-----Order details:-----");
        Console.WriteLine($"Oreder id:{orderId}");
        Console.WriteLine($"Product name:{productName}");
        Console.WriteLine($"Quantity:{quantity}\nPrice:{price}");
        Console.WriteLine($"Total bill:{GetTotalAmount()}");
    }
}
