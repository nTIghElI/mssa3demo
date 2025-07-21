namespace Class_Methods;

class Program
{
    static void Main(string[] args)
    {
        //         //create an instance of a given class
        //         //it would be like 'int newNumber1 = 0;'
        //         BankAccount account1 = new BankAccount();
        //         account1.Deposit(100);
        //         Console.WriteLine(account1.GetBalance());

        //         BankAccount account2 = new BankAccount();
        //         account2.Deposit(200);
        //         Console.WriteLine(account2.GetBalance());


        //         Console.WriteLine(account1.GetBalance());

        //         Console.WriteLine(MathHelper.Add(2, 3));

        //         // BankAccount account1 = new BankAccount();
        //         // account1.Deposit(100);
        //         // Console.WriteLine(account1.GetBalance());

        //         // BankAccount account2 = new BankAccount();
        //         // account2.Deposit(200);
        //         // Console.WriteLine(account2.GetBalance());

        //         // Console.WriteLine(account1.GetBalance());

        //         // Console.WriteLine(MathHelper.Add(2, 3));
        Panda frank = new Panda("Frank", 4);
        Panda wendy = new Panda("Wendy", 7);
        frank.CelebrateBirthday();
        Console.WriteLine("Total Pandas: " + Panda.GetTotalPanada());
        Console.WriteLine(Panda.ViewingDays(DayOfWeek.Monday));
    }
    // }

    // //defining a class called BankAccount
    // class BankAccount
    // {
    //     decimal balance = 0;
    //     //defining two 'instances' that will work within a class not necessarily methods.
    //     public void Deposit(decimal amount)
    //     {
    //         balance += amount;
    //     }
    //     public decimal GetBalance()
    //     {
    //         return balance;
    //     }
    // }

    // //creating a new class and going to define a method so an instance isn't required
    // //This is the difference between static also stateless vs stated.
    // class MathHelper
    // {
    //     //this allows the method to call outside it's own class
    //     //by adding the word static this creates a method without needing an instance if it wasn't there.
    //     public static int Add(int a, int b)
    //     {
    //         return a + b;
    //     }

}
class Panda
{
    string name;
    int age;
    static int totalPandas = 0;

    public Panda(string name, int age)
    {
        this.name = name;
        this.age = age;
        totalPandas++;
    }

    //Stateful, Non-static
    public void CelebrateBirthday()
    {
        //statefull since the state 'age' is being impacted
        age++;
        Console.WriteLine($"{name} is now {age} years old");
    }

    //Stateful, Static
    public static int GetTotalPanada()
    {
        return totalPandas;
    }

    //Stateless, Static
    //Stateless because no values are reference at top below class Panda
    public static bool ViewingDays(DayOfWeek day)
    {
        return day >= DayOfWeek.Monday && day <= DayOfWeek.Friday;
    }
}
