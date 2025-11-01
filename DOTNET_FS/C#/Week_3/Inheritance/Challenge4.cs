using System;
class Program{
  static void Main(){
    Shape[] s={
      new Shape(),
      new Circle(),
      new Square()
    };
    foreach(var sh in s) sh.Draw();
  }
}
class Shape{
  public virtual void Draw()=>Console.WriteLine("Drawing shapes....");
}
class Circle:Shape{
  public override void Draw()=>Console.WriteLine("Drawing circle");
}
class Square:Shape{
  public override void Draw()=>Console.WriteLine("Drawing square");
}
