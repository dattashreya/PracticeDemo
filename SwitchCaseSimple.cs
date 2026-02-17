using System;
class SwitchCaseSimple {
    static void Main() {
        Console.WriteLine("User Input?");
        int day = Convert.ToInt16(Console.ReadLine()) ;
        switch(day) {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("tue");
                break;
            case 3:
                Console.WriteLine("wed");
                break;
            case 4:
                Console.WriteLine("thu");
                break;
            case 5:
                Console.WriteLine("fri");
                break;
            case 6:
                Console.WriteLine("sat");
                break;
            case 7:
                Console.WriteLine("sun");
                break;
            default:
                Console.WriteLine("None!");
                break;
        }
    }
}
