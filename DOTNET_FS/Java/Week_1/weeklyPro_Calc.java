import java.util.Scanner;
class Program{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int i=0;
        while (i!=1){
            Pro2 cl=new Pro2();
            cl.Calc();
            System.out.println("Do you want use again (0-Yes/1-No)");
            int op=sc.nextInt();
            if (op==1){
                i++;
                }
            
            }
   }
}
class Pro2{
    int Calc(){
        Scanner sc2=new Scanner (System.in);
        //input for operation
        
        System.out.println("Select a option:\n1.Add\n 2.Subract\n3.Multiplication\n4.Division");
        int op=sc2.nextInt();
        
        //input two numbers
        System.out.println("Enter number 1");
        int n1=sc2.nextInt();
        System.out.println("Enter number 2");
        int n2=sc2.nextInt();
        switch (op){
            case 1:
                int t=n1+n2;
                System.out.println(t);
                break;
            case 2:
                int h=n1-n2;
                System.out.println(h);
                break;
            case 3:
                int j=n1*n2;
                System.out.println(j);
                break;
            case 4:
                int k=n1/n2;
                System.out.println(k);
                break;
            case 5:
                int l=n1%n2;
                System.out.println(l);
                break;
            default:
                System.out.println("No input cases are matched!!");
            }
       return 0;
    }
}