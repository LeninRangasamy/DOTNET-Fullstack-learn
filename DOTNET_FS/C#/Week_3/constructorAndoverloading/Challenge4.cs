using System;
class ProgramMain{
    public static void Main(){
        Student[] s={
            new Student(),
            new Student("Pelvin"),
            new Student(1020,"Lenin",75)
        };
        foreach(var st in s){
            st.Show();
            Console.WriteLine("--------------");
        }
    }
}
class Student{
    private static int counter=1000;
    public int rollno,marks;
    public string name;
    public Student(){
        rollno=0;
        name="unknown";
        marks=0;
    }
    public Student(string n){
        counter++;
        rollno=counter;
        name=n;
        marks=50;
    }
    public Student(int r,string n,int m){
        rollno=r;
        name=n;
        marks=m;
    }
    public void Show()=>Console.WriteLine($"Student details:\nRollno:{rollno}\nName:{name}\nMarks:{marks}");
}
