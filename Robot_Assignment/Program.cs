// // namespace Robot_Assignment;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         string modelName = "C3PO";
// //         int batteryLevel = 40;
// //         if (Robot.IsModelAllowed(modelName))
// //         {
// //             Robot otherbot = new Robot(modelName, batteryLevel);
// //         }
// //         else
// //         {
// //             Console.WriteLine($"{modelName} is invalid");
// //         }
// //         Console.WriteLine($"Robots activated: {Robot.GetTotalActivated()}");
// //         if (otherbot.NeedsRecharge())
        

// //         Console.WriteLine("Hello, World!");
// //         Robot Hillbot = new Robot("R2D2", 19);
// //         Robot Fillbot = new Robot("RX89A", 40);
// //         Robot Jillbot = new Robot("C3PO", 90);
// //     }
// // }
// //Class Robot with 4) methods
// // class Robot
// // {
// //     string model;
// //     int batteryLevel;
// //     static int totalRobotsActivated = 0; //setting it to 'zero' makes it static

// //     //Constructor
// //     //getter:take model and batteryLevel
// //     //setter:set the fields using these parameters
// //     //increases totalRobotsActivated by 1
// //     public Robot (string model, int batteryLevel)
// //     {
// //         //getter & setter
// //         this.model = model;
// //         this.batteryLevel = batteryLevel;
// //         totalRobotsActivated++; //static, why?

// //     }


// //     // Four Methods: 3.9/4
// //     // - Recharge - Complete
// //     // 	Takes an integer amount
// //     // 	Adds it to the robot’s batteryLevel
// //     // 	Battery should not go over 100
// //     // 	Prints the new battery level
// //     public void Recharge(int amount) //needs more clarification for 'void'
// //     {

// //         batteryLevel += amount;
// //         if (batteryLevel > 100)// || batteryLevel <= 0)
// //         {
// //             batteryLevel = 100;
// //         }
// //         Console.WriteLine($"Currently battery level for {model} is {batteryLevel}");      
// //     }

// //     // - GetTotalActivated - Complete
// //     // 	Returns the total number of robots activated
// //     public static int GetTotalActivated()
// //     {
// //         return totalRobotsActivated;
// //     }
// //     public int TotalRobotsActivated//I completely missed this step?
// //     {
// //         get { return totalRobotsActivated; }
// //     }
// //     // - NeedsRecharge - 99%
// //     // 	Returns true if the robot’s battery level is less than 20
// //     public bool NeedsRecharge()
// //     {
// //         if (batteryLevel < 20) //need to verify if I need a 'decimal'
// //         {
// //             Console.WriteLine($"Please charge soon, battery level at {batteryLevel}");
// //             return true;
// //         }
// //         else
// //         {
// //             return false;
// //         }
// //     }
// //     // - IsModelAllowed - Complete
// //     // 	Returns true if the model name starts with "RX" and has at least 5 characters
// //     public bool IsModelAllowed()
// //     {
// //         if (model.StartsWith("RX") && model.Length >= 5)//need to factor in for 'rx' lower-case
// //         {
// //             Console.WriteLine("Model is allowed");
// //             return true;
// //         }
// //         else
// //         {
// //             Console.WriteLine("I'm afraid I can't let you do that.");
// //             return false;
// //         }


// //     }
// // }
// class Robot
// {
//     string model;
//     int batteryLevel;
//     static int totalRobotsActivated = 0;

//     public Robot(string model, int batteryLevel)
//     {
//         this.model = model;
//         this.batteryLevel = batteryLevel;
//         totalRobotsActivated++;
//     }

//     public void Recharge(int charged)
//     {
//         batteryLevel = Math.Min(batteryLevel + charged, 100);
//         Console.WriteLine($"{model} recharged to {batteryLevel}");
//     }
//     public static int GetTotalActivated()
//     {
//         return totalRobotsActivated;
//     }

//     public int TotalRobotsActivated
//     {
//         get { return totalRobotsActivated; }
//     }

//     public bool NeedsRecharge()
//     {
//         return batteryLevel < 20;
//     }
//     public static bool IsModelAllowed(string modelName)
//     {
//         string toUpperName = modelName.ToUpper();
//         return toUpperName.StartsWith("RX") && modelName.Length >= 5;
//     }
// }
namespace Robot_Assignment;
 
class Program
{
    static void Main()
    {
        string modelName = "C3PO";
        int batteryLevel = 90;
        if (Robot.IsModelAllowed(modelName))
        {
            Robot jillBot = new Robot(modelName, batteryLevel);
        }
        else
        {
            Console.WriteLine($"{modelName} is invalid");
        }

        modelName = "RX89A";
        batteryLevel = 10;
        if (Robot.IsModelAllowed(modelName))
        {
            Robot otherBot = new Robot(modelName, batteryLevel);
            if (otherBot.NeedsRecharge())
        {
            Console.WriteLine ("Battery needs charged.");
            otherBot.Recharge(50);
        }
        
        }
        else
        {
            Console.WriteLine($"{modelName} is invalid");
        }

        Console.WriteLine($"Robots activated: {Robot.GetTotalActivated()}");
    }
}
 
class Robot
{
    string model;
    int batteryLevel;
    static int totalRobotsActivated = 0;
 
    public Robot(string model, int batteryLevel)
    {
        this.model = model;
        this.batteryLevel = batteryLevel;
        totalRobotsActivated++;
    }
 
    public void Recharge(int charged)
    {
        batteryLevel = Math.Min(batteryLevel + charged, 100);
        Console.WriteLine($"{model} recharged to {batteryLevel}");
    }
    public static int GetTotalActivated()
    {
        return totalRobotsActivated;
    }
 
    public int TotalRobotsActivated
    {
        get { return totalRobotsActivated; }
    }
 
    public bool NeedsRecharge()
    {
        return batteryLevel < 20;
    }
    public static bool IsModelAllowed(string modelName)
    {
        string toUpperName = modelName.ToUpper();
        return toUpperName.StartsWith("RX") && modelName.Length >= 5;
    }
}
 