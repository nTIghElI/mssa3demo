// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Math getLarge = new Math();
// int number = getLarge.Max();
// Console.WriteLine(number);

// int firstValue = 601;
// int secondValue = 601;
// int largerValue;
// double firstValue1 = 601.69;
// double secondValue1 = 601.6;
// double largerValue1;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);
// largerValue1 = Math.Max(firstValue1, secondValue1);
// Console.WriteLine(largerValue1);


// Random dice = new Random();
// Console.WriteLine(dice.Next(1, 5));
// Random m1 = new Random();
// Console.WriteLine(m1.Next());
// Console.WriteLine(m1.Next(1, 101));
// int number1 = m1.Next();
// int number2 = m1.Next(1, 101);
// Console.WriteLine(number1);
// Console.WriteLine(number2);
// Console.WriteLine($"{number1},{number2}");
// Console.WriteLine($"{number2},{number1}");

// Printer printer = new Printer();
// printer.Print();
// printer.Print("Hello!");
// printer.Print("Hello world!", "This is fun!");

// class Printer
// {
//     public void Print()
//     {
//         Console.WriteLine("Nothing to Print");
//     }

//     public void Print(string message)
//     {
//         Console.WriteLine($"Printing: {message}");
//     }

//     public void Print(string message, string extraNote)
//     {
//         Console.WriteLine($"Printing: {message}");
//         Console.WriteLine($"Note: {extraNote}");
//     }
// }

class Program
{
    static void Main()
    {
        bool FirstCondition()
        {
            Console.WriteLine("First condition evaluated");
            return false;
        }
        bool SecondCondition()
        {
            Console.WriteLine("Second condition evaluated");
            return true;
        }

        if (FirstCondition() && SecondCondition())
        {
            Console.WriteLine("Both conditions are true");
        }
        else
        {
            Console.WriteLine("At least one condition is false");
        }

    }
    
}
