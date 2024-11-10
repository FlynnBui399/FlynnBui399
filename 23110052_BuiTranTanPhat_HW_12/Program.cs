/*
Student's full name: Bui Tran Tan Phat
Student ID: 23110052 - Class: 23110FIE1
Update Date: 08/11/2024
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

//Vid 148
/*
 internal class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine("Non recursive way: ");
        Console.WriteLine(FactorialNonRecursive(number));
        Console.WriteLine("recursive way");
        Console.WriteLine(Factorial(number));
    }
    //Non-Recursive way
    public static int FactorialNonRecursive(int n)
    {
        if (n == 0) return 1;
        int value = 1;
        for (int i = n; i > 0; i--)
        {
            value *= i;
            Console.WriteLine(i);
        }
        return value;
    }
    //Recursive
    public static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
*/


//RecuresiveEx(vid 149)
/*class Program
{
    static void Main(string[] args)
    {
        string path = string.Empty;
        path = @"C:\Files";
        Console.WriteLine(path);
        DisplayFolders(path, 0);


    }
    public static void DisplayFolders(string path, int indent)
    {
        foreach (var folder in Directory.GetDirectories(path))
        {
            Console.WriteLine($"{new string(' ', indent)}{Path.GetFileName(folder)}");
            DisplayFolders(folder, indent + 2);
        }
    }
}*/

//Vid 150
/*
 * class Program
{
    static void Main(string[] args)
    {
        DisplayPlayerInformation(7, "Ronaldo", 60, "Portugal", "Real Madrid");
        Console.WriteLine("----------");
        DisplayPlayerInformation(10, "Messi");
    }
    public static void DisplayPlayerInformation(int no, string name, int goals = 0, string country = "", string club = "")
    {
        Console.WriteLine("Hi from the first method");
        Console.WriteLine(no);
        Console.WriteLine(name);
        Console.WriteLine(goals);
        Console.WriteLine(country);
        Console.WriteLine(club);
    }
    public static void DisplayPlayerInformation(int no, string name, int goals)
    {
        Console.WriteLine("Hi from the overloaded method");
        Console.WriteLine(no);
        Console.WriteLine(name);
        Console.WriteLine(goals);
    }
}
 */



//Vid 151
/*
 class Program
{
    static void Main(string[] args)
    {
        DisplayPlayerInformation(country: "Portugal", playerName: "Ronaldo", playerGoals: 55, playerNo: 7);
    }
    public static void DisplayPlayerInformation(int playerNo, string playerName, int playerGoals, string country = "Unknown")
    {
        Console.WriteLine(playerNo);
        Console.WriteLine(playerName);
        Console.WriteLine(playerGoals);
        Console.WriteLine(country);
    }
}
 */

//Vid 152
/*class Program
{
    static void Main(string[] args)
    {
        DisplayInfo("John");
        DisplayInfo(2);
        DisplayInfo(2.5);
        DisplayInfo(DateTime.Now);

        var playerInfo = (7, "Ronaldo", 55);
        DisplayInfo(playerInfo);
    }
    public static void DisplayInfo<T>(T info)
    {
        Console.WriteLine(info);
    }
}
 */


//Vid 153
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student's full name: Bui Tran Tan Phat\r\nStudent ID: 23110052 - Class: 23110FIE1\r\nUpdate Date: 08/11/2024");
        LoopThroughArray(10, 50, 25, 3);
        LoopThroughArray("Ahmad", "Ned", "Emma");
        LoopThroughArray(DateTime.Now, new DateTime(2017, 10, 10));
    }
    public static void LoopThroughArray<T>(params T[] items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------");
    }
}
 */

//vid 154 same as 153
/**/

//vid 155

/*
 class Program
{
    static void Main(string[] args)
    {

        PerformMathOperations(1, 2, 3, 4);
        PerformMathOperations(5, 20);
    }

    public static void PerformMathOperations(params int[] numbers)
    {
        Console.WriteLine("Add = " + AddNumbers());
        int AddNumbers()
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result = result + number;
            }
            return result;
        }

        Console.WriteLine("Multi = " + MultiNumebrs());
        int MultiNumebrs()
        {
            int result = 1;
            foreach (var number in numbers)
            {
                result = result * number;
            }
            return result;
        }
        Console.WriteLine("----------");
    }

}

 */

//156
/*class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x.IsGreater(10));
            string text = "100";
            Console.WriteLine(text.IsNumber());
        }
        
    }
    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }
    }*/

//157
/**/
class Program
{
    static void Main(string[] args)
    {

    }
}
    


