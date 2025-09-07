import java.util.Scanner;
class MainFunction{
    public static void main(String[] args){
        Menu M=new Menu();
        int C=M.menu();
        switch (C){
            case 1:
                DaysOfWeek day=new DaysOfWeek();
                day.Days();
                break;
            case 2:
                MonthName MN=new MonthName();
                MN.namesOfMonth();
                break;
            case 3:
                TrafficLights TF=new TrafficLights();
                TF.lightsName();
                break;
            default:
                System.out.println("Invalid input");
                break;
            }
            
   }   
}
class Menu{
    int menu(){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter your choice");
        System.out.println("1.Days of week");
        System.out.println("2.Name of month");
        System.out.println("3.Traffic light");
        int choice=sc.nextInt();
        return choice;
    }
}
        
//problem 1
class DaysOfWeek{
    void Days(){
        Scanner sc=new Scanner(System.in);
        System.out.println("Enetr day number");
        int day=sc.nextInt();
        //int day=7;
        switch (day){
            case 1:
                System.out.println("Monday");
                break;
            case 2:
                System.out.println("Tuesday");
                break;
            case 3:
                System.out.println("Wednesday");
                break;
            case 4:
                System.out.println("Thursday");
                break;
            case 5:
                System.out.println("Friday");
                break;
            case 6:
                System.out.println("Saturday");
                break;
            case 7:
                System.out.println("Sunday");
                break;
            default:
                System.out.println("Invalid input");
                break;
        }
    }
}
//problem 2
class MonthName{
             void namesOfMonth(){
                 Scanner sc=new Scanner(System.in);
                 System.out.println("Enter month number");
                 int month=sc.nextInt();
                 switch (month){
                     case 1:
                         System.out.println("January");
                         break;
                     case 2:
                         System.out.println("February");
                         break;
                     case 3:
                         System.out.println("March");
                         break;
                     case 4:
                         System.out.println("April");
                         break;
                     case 5:
                         System.out.println("May");
                         break;
                     case 6:
                         System.out.println("June");
                         break;
                     case 7:
                         System.out.println("July");
                         break;
                     case 8:
                         System.out.println("August");
                         break;
                     case 9:
                         System.out.println("September");
                         break;
                     case 10:
                         System.out.println("October");
                         break;
                     case 11:
                         System.out.println("November");
                         break;
                     case 12:
                         System.out.println("December");
                         break;
                     default:
                         System.out.println("Invalid input");
                         break;
                 }
             }
}
//problem 3
class TrafficLights{
    void lightsName(){
        String light="red";
        switch (light){
            case "red":
                System.out.println("Stop");
                break;
            case "yellow":
                System.out.println("Get ready");
                break;
            case "green":
                System.out.println("Go");
                break;
            default:
                System.out.println("Input does not reached");
                break;
        }
    }
}       