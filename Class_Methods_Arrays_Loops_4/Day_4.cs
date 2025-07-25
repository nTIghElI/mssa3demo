// using System.Runtime.InteropServices.Marshalling;

// namespace Class_Methods_Arrays_Loops_4;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Console.WriteLine("Hello, World!");
//         // int x = 10;
//         // bool isTen = (x == 10);
//         // Console.WriteLine($"{isTen}");

//         // string input = "Yes";
//         // bool saidYes = (input.ToUpper() == "YES");
//         // Console.WriteLine($"{saidYes}");

//         // int score = 90;
//         // bool notPerfectScore = (score != 100);
//         // Console.WriteLine($"{notPerfectScore}");

//         // int temp = 90;
//         // bool isHot = (temp > 85);
//         // Console.WriteLine($"{isHot}");

//         // string name = "gregor";
//         // bool upperName = name.ToUpper() == "GREGOR";
//         // Console.WriteLine($"{upperName}");
//         // Person p1 = new Person("Lara");
//         // Person p2 = new Person("Lara");
//         // Person p3 = p1;

//         // Console.WriteLine(p1 == p2);
//         // Console.WriteLine(p1 == p3);

//         // string s1 = "hello";
//         // string s2 = "hello";
//         // string s3 = new string("hello".ToCharArray());

//         // Console.WriteLine($"{s3}");

//         // Console.WriteLine(s1 == s2);
//         // Console.WriteLine(s1 == s3);

//         // int score = 45;
//         // // string result = (score >= 90 ? "A" : score || score >= 80 ? "Passed" : "Failed" || score >= 70 ? "Passed" : "Failed");
//         // Console.WriteLine(score);
//         // // Console.WriteLine(result);
//         // Console.WriteLine(score >= 90 ? "A": score > 80 ? "B" : "C");
//         // Console.WriteLine(score >= 90 ? "A" : score >= 80 ? "B" : score >= 70 ? "C" : "Failed");

//         //Heads or Tails
//         // Random coinFlip = new Random();
//         // int coinFlipResult = coinFlip.Next(2);
//         // Console.Write(coinFlipResult == 1 ? "Heads" : "Tails");
//         // Console.Write($" {coinFlipResult}");

//         // Random coin = new Random();

//         // for (int i = 0; i < 10; i++)
//         // {
//         //     int result = coin.Next(1, 3);
//         //     Console.WriteLine(result == 1 ? "Heads" : "Tails");
//         // }

//         // string permission = "Admin|Manager";

//         // int level = 55;

//         // Console.WriteLine(permission.ToUpper() == "ADMIN" && level > 55 ? "Welcome, Super Admin user." 
//         // : permission.ToUpper() == "ADMIN" && level <= 55 ? "Welcom, Admin user." 
//         // : permission.ToUpper() == "ADMIN" && level >= 20 ? "Contact an Admin for access." 
//         // : level < 20 ? "You do not have sufficient privileges" 
//         // : "You do not have sufficient privileges");\

//         // int number = 10;
//         // void DoSomething()
//         // {
//         //     int number = 20;
//         // }

//         // int number = 5;
//         // switch (number >= 10)
//         // {
//         //     Console.WriteLine("You did it!");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("Try again.");
//         // }

//         //     int[] numbers = { 4, 8, 15, 16, 23, 42 };
//         //     int total = 0;
//         //     bool found = false;

//         //     foreach (int number in numbers)
//         //     {
//         //         total += number;

//         //         switch (number == 42)
//         //             found = true;
//         //     }
//         //     switch (found) 
//         //         Console.WriteLine("Set contains 42");

//         //     Console.WriteLine($"Total: {total}");
//         // }

//         // int studentGradeLevel = 5;
//         // string studentName = "Billy-bob";

//         // string gradeDescription = "";

//         // switch (studentGradeLevel)
//         // {
//         //     case 1:
//         //         Console.WriteLine("Freshman");
//         //         break;
//         //     case 2:
//         //         Console.WriteLine("Sophomore");
//         //         break;
//         //     case 3:
//         //         Console.WriteLine("Junior");
//         //         break;
//         //     case 4:
//         //         Console.WriteLine("Senior");
//         //         break;
//         //     default:
//         //         Console.WriteLine("Unspecswitchied Level");
//         //         break;
//         // }

//         // SKU = Stock Keeping Unit.
//         // SKU value format: <product #>-<2-letter color code>-<size code>
//         string sku = "01-MN-L";
        
//         string[] product = sku.Split('-');
        
//         string type = "";
//         string color = "";
//         string size = "";

//         switch (product[0])
//         {
//             case "01":
//                 type = "Sweat shirt";
//                 break;
//             case "02":
//                 type = "T-Shirt";
//                 break;
//             case "03":
//                 type = "Sweat pants";
//                 break;
//             default:
//                 type = "Other";
//                 break;
//         }
//         switch (product[1])
//         {
//             case "BL":
//                 color = "Black";
//                 break;
//             case "MN":
//                 color = "Maroon";
//                 break;
//             default:
//                 color = "White";
//                 break;
//         }
        
//         switch (product[2])
//         {
//             case "S":
//                 size = "Small";
//                 break;
//             case "M":
//                 size = "Medium";
//                 break;
//             case "L":
//                 size = "Large";
//                 break;
//             default:
//                 size = "One Size Fits All";
//                 break;
//         }
        
//         Console.WriteLine($"Product: {size} {color} {type}");
        

    

//     // static int Max(int a, int b)
//         // {
//         //     return (a > b) ? a : b; //returns larger value
//         // }

//         // public class Person
//         // {
//         //     public string Name { get; set; }
//         //     public Person(string name)
//         //     {
//         //         Name = name;
//         //     }
//     }
// }
