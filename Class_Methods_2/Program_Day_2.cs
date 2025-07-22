// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// // Math getLarge = new Math();
// // int number = getLarge.Max();
// // Console.WriteLine(number);

// // int firstValue = 601;
// // int secondValue = 601;
// // int largerValue;
// // double firstValue1 = 601.69;
// // double secondValue1 = 601.6;
// // double largerValue1;
// // largerValue = Math.Max(firstValue, secondValue);
// // Console.WriteLine(largerValue);
// // largerValue1 = Math.Max(firstValue1, secondValue1);
// // Console.WriteLine(largerValue1);


// // Random dice = new Random();
// // Console.WriteLine(dice.Next(1, 5));
// // Random m1 = new Random();
// // Console.WriteLine(m1.Next());
// // Console.WriteLine(m1.Next(1, 101));
// // int number1 = m1.Next();
// // int number2 = m1.Next(1, 101);
// // Console.WriteLine(number1);
// // Console.WriteLine(number2);
// // Console.WriteLine($"{number1},{number2}");
// // Console.WriteLine($"{number2},{number1}");

// // Printer printer = new Printer();
// // printer.Print();
// // printer.Print("Hello!");
// // printer.Print("Hello world!", "This is fun!");

// // class Printer
// // {
// //     public void Print()
// //     {
// //         Console.WriteLine("Nothing to Print");
// //     }

// //     public void Print(string message)
// //     {
// //         Console.WriteLine($"Printing: {message}");
// //     }

// //     public void Print(string message, string extraNote)
// //     {
// //         Console.WriteLine($"Printing: {message}");
// //         Console.WriteLine($"Note: {extraNote}");
// //     }
// // }

// // Random dice = new Random();
// // int roll1 = dice.Next(1, 7);
// // Console.WriteLine($"Dice 1: {roll1}");
// // // Random dice2 = new Random();
// // int roll2 = dice.Next(1, 7);
// // Console.WriteLine($"Dice 2: {roll2}");
// // // Random dice3 = new Random();
// // int roll3 = dice.Next(1, 7);
// // Console.WriteLine($"Dice 3: {roll3}");
// // int total = (roll1 + roll2 + roll3);
// // //Console.WriteLine($"Total: {total}");
// // if (total >= 15)
// // {
// //     Console.WriteLine("You've reached a new high score");
// // }
// // if (total < 6)
// // {
// //     Console.WriteLine("You've reached a new low score");
// // }
// // if((roll1 == roll2 && roll1 != roll3) || (roll1 == roll3 && roll1 != roll2) || (roll2 == roll3 && roll2 != roll1)) //revisit
// // {
// //     total += 2;
// //     Console.WriteLine("Great job! You got '2' points!");
// // }
// // if (roll1 == roll2 && roll1 == roll3 && roll2 == roll3)//revisit
// // {
// //     total += 6;
// //     Console.WriteLine("Amazing! You got '6' points!");
// // }
// // else if((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)) //revisit
// // {
// //     total += 2;
// //     Console.WriteLine("Great job! You got '2' points!");
// // }
// // Console.WriteLine($"You rolled {roll1}, {roll2}, {roll3} totaling: {total}");





// // class Program
// // {
// //     static void Main()
// //     {
// //         int x = 0;
// //         if (x != 0 && 10 / x > 1)
// //         {
// //             Console.WriteLine("Division works");
// //         }
// //         else
// //         {
// //             Console.WriteLine("Division is not allowed");
// //         }
// //         bool FirstCondition()
// //         {
// //             Console.WriteLine("First condition evaluated");
// //             return false;
// //         }
// //         bool SecondCondition()
// //         {
// //             Console.WriteLine("Second condition evaluated");
// //             return true;
// //         }

// //         if (FirstCondition() && SecondCondition())
// //         {
// //             Console.WriteLine("Both conditions are true");
// //         }
// //         else
// //         {
// //             Console.WriteLine("At least one condition is false");
// //         }


// //     }

// // }

// // Challenge: Improve renewal rate of subscriptions
// // You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. 
// //Your task is to display a renewal message when a user logs into the software system and is notified their subscription will end soon. 
// //You'll need to add a couple of decision statements to properly nest branching logic for the application and satisfy the requirements.

// // You need to perform the following tasks in this code challenge:
// // Review the business rules for this challenge.
// // Implement your solution code using if statements.

// // Starter code

// // Random random = new Random();
// // int daysUntilExpiration = random.Next(12);
// // // daysUntilExpiration = 11; //testing
// // int discountPercentage = 0;
// // //Rule 6
// // if (daysUntilExpiration > 10)//this is redundant
// // {
// //     // Console.WriteLine();//actually I'll need to write nothing here
// // }
// // //Rule 5
// // else if (daysUntilExpiration <= 0)
// // {
// //     Console.WriteLine("Your subscription has expired.");
// // }
// // //Rule 4
// // else if (daysUntilExpiration == 1)
// // {
// //     discountPercentage = 20;
// //     Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}!");
// // }
// // //Rule 3
// // else if (daysUntilExpiration <= 5)
// // {
// //     discountPercentage = 10;
// //     Console.WriteLine($"Renew now and save {discountPercentage}!");
// // }
// // //Rule 2
// // else if (daysUntilExpiration <= 10)
// // {
// //     Console.WriteLine("Your subscription will expire soon. Renew now!");
// // }
// // Console.WriteLine(daysUntilExpiration);

// // // Your code goes here

// // Review the business rules (Rule 1)
// // Your code should only display one message.
// // The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

// // Review the business rules (Rule 2)
// // If the user's subscription will expire in 10 days or less, display the message:

// // Your subscription will expire soon. Renew now!

// // Review the business rules (Rule 3)
// // If the user's subscription will expire in five days or less, display the messages:

// // Your subscription expires in _ days.
// // Renew now and save 10%!

// // Review the business rules (Rule 4)
// // If the user's subscription will expire in one day, display the messages:

// // Your subscription expires within a day!
// // Renew now and save 20%!

// // Review the business rules (Rule 5)
// // If the user's subscription has expired, display the message:

// // Your subscription has expired.

// // Review the business rules (Rule 6)
// // If the user's subscription doesn't expire in 10 days or less, display nothing.

// // int[] numbers = new int[4];
// // numbers[0] = 10;
// // numbers[1] = 20;
// // numbers[2] = 30;
// // numbers[3] = 40;

// // string[] fruits = ("apple", "banana", "cherry");

// // // bool[] test = new;

// // Declare a new array
// string[] animals = new string[3];
// animals[0] = "Cat";
// animals[1] = "Dog";
// animals[2] = "Bat";

// // Attempt to use an index that is outside the bounds dimensioned for the array
// // animals[3] = "Hat";

// // Assign values to elements of an array
// animals[1] = "Hat";
// Console.WriteLine($"Updated second animal: {animals[1]}");
// // Use the Length property of an array
// int[] numbers = { 10, 20, 30, 40 };
// Console.WriteLine($"Length of animal array: {animals.Length}");
// Console.WriteLine($"Updated number array: {numbers.Length}");


// // Retrieve values from elements of an array
// // Reassign the value of an array element
// Console.WriteLine(numbers[^1]);
// Console.WriteLine(numbers[^2]);
// // Initialize array values at the time of array declaration 

// int[] bins = { 2, 5, 10 };
// // bins[0] = 2;
// // bins[1] = 5;
// // bins[2] = 10;
// int totalSum = 0;
// int binNumber = 1;
// foreach (int bin in bins)
// {
//     totalSum += bin;
//     Console.WriteLine($"Bin {binNumber}: running total={totalSum}");
//     binNumber++;
// }
// Console.WriteLine($"Final total sum: {totalSum}");


// Create a new console application.  
// Create a string array that contains the data specified for the challenge.
// "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"
// Create a foreach statement to iterate through each element of your array.
// Identify and report the Order IDs that start with the letter "B". 
string [] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        char targetChar = 'B';
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith(targetChar))
    {
        Console.WriteLine($"order ID # {orderID} has been flagged.");
    }
}
 
 