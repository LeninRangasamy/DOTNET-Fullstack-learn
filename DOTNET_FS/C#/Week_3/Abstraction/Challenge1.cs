using System;
abstract class Shape{
    public abstract void CalculateArea();
    public void DisplayInfo(){
        Console.WriteLine("This is a shape");
    }
}
class Circle:Shape{
    public double radius;
    public Circle(double r){
        radius=r;
    }
    public override void CalculateArea(){
        double area=3.14159*radius*radius;
        Console.WriteLine($"Area of circle: {area}");
    }
}
class Rectangle:Shape{
    public double length;
    public double width;
    public Rectangle(double l, double w){
        length=l;
        width=w;
    }
    public override void CalculateArea(){
        double area=length*width;
        Console.WriteLine($"Area of rectangle: {area}");
    }
}
class Program{
    static void Main(){
        Shape[] shapes={
            new Circle(5),
            new Rectangle(10,23)
        };
        foreach(var s in shapes) s.CalculateArea();
    }
}
