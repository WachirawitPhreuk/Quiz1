public class Program
{
public static void Main(string[] args) {
    
    Console.WriteLine("Welcome to KFC");
    Console.WriteLine("i. Info");
    Console.WriteLine("ii. Founder");
    Console.WriteLine("iii. Workers");
    Console.WriteLine("iv. Income/Outcome");

    string x = Console.ReadLine();
    switch(x) {
        case "1" :
        Info();
        break;

        case "2" :
        Founder();
        break;

        case "3 " :
        Workers();
        break;

        case "4" :
        InOutcome();
        break;

        default : break;
    }
}

public static void Info() {
    Console.WriteLine("i. Francise's financial : 1000000");
    Console.WriteLine("ii. Francise's name : บางขุนเทียน ชายทะเล");
    Console.WriteLine("iii. Address : ถนนชายทะเลบางขุนเทียน ซอย 27");
}

public static void Founder() {
    Console.WriteLine("i. Name : Tawee");
    Console.WriteLine("ii. Last Name : Jaideedee");
    Console.WriteLine("iii. Citizen ID : 153-698-4561237");

    Console.WriteLine("i. Name : Yuttadee");
    Console.WriteLine("ii. Last Name : Tangjairean");
    Console.WriteLine("iii. Citizen ID : 742-112-5687412");

    Console.WriteLine("i. Name : James");
    Console.WriteLine("ii. Last Name : Rukrongrean");
    Console.WriteLine("iii. Citizen ID : 541-772-3215689");    
}

public static void Workers() {
    Console.WriteLine("Clerk : Mr.Chaidee Rukdee, 20, Salary : 15,000");
    Console.WriteLine("Clerk : Mr.Nondee Jaidee, 18, Salary : 15,000");
    Console.WriteLine("Clerk : Mr.Apaidee Reandee, 22, Salary : 15,000");
    Console.WriteLine("Delivery : Mr.Tumdee Jandee, 25, Salary : 12,500");
    Console.WriteLine("Delivery : Mr.Nondee Reabdee, 23, Salary : 12,500");
}

public static void InOutcome() {
    Console.WriteLine("This Month's Income : {0}", 17526+218628);
    Console.WriteLine(" ");
    Console.WriteLine("Rukdee's Monthly Salary : 15,000");
    Console.WriteLine("Jaidee's Monthly Salary : 15,000");
    Console.WriteLine("Reandee's Monthly Salary : 15,000");
    Console.WriteLine("Jandee's Monthly Salary : 12,500");
    Console.WriteLine("Reabdee's Monthly Salary : 12,500");
    Console.WriteLine(" ");
    Console.WriteLine("Balance : {0}", 17526+218628-70000);
}

}