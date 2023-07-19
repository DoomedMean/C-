using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This is Comment in c#
                Console.WriteLine("Hello World"); // equivalent to "print" on python
                string Name = "Sparrow"; // variable in c# with string data type
                int Age = 35; // variable in c# with interger data type
                Console.WriteLine("Nice to meat you, " + Name);
                Console.WriteLine("Your are " + Age + " years old");
                Console.WriteLine("Total string on Name Variable are " + Name.Length); // length of variable Name
                Console.WriteLine("Convert to uppercase : " + Name.ToUpper()); // convert to UpperCase
                Console.WriteLine("'rro' on Name variable : " + Name.Contains("rro")); // find string on Name variable
                Console.WriteLine("Finding index 'ow' on Name variable : " + Name.IndexOf("ow")); // find index on Name variable
                Console.WriteLine("This 3 power of 2 equal to " + Math.Pow(3, 2)); // using Math method
                Console.Write("Enter Your Favorite Movie: ");
                string Movie = Console.ReadLine();
                Console.WriteLine(Movie + " is a great movie");
                int[] LuckyNumbers = { 4, 7, 9, 12, 56 }; // [] indicate array in c#
                Console.Write("Enter a number : ");
                decimal num = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Cube of " + num + " are equal to " + Cube(num));
                Console.Write("Enter a day number between 0-6 : ");
                int Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You choose " + GetDay(Day));
                GoodBye(Name); // call GoodBye method
                Book book1 = new Book("Harry Potter","JK Rowling", 400, 4);
                Console.WriteLine(book1.Rating);
                Console.WriteLine(book1.title);
                Console.WriteLine(book1.HasHonor());
                Book book2 = new Book("Harry Potter", "JK Rowling", 100, 4);
                Book book3 = new Book("Harry Potter", "JK Rowling", 200, 2);
                Book book4 = new Book("Harry Potter", "JK Rowling", 600, 3);
                Book book5 = new Book("Harry Potter", "JK Rowling", 70, 1);
                Console.WriteLine(Book.bookcount);
                Static_Class.SayHi("Jack");
                int[,] NumberGrid = //2D array
                    { 
                    {1,2},
                    {4,6},
                    {9,8}
                    };
                Console.WriteLine("This is 2D array " + NumberGrid);
                bool isMale = true; // boolean data type
                bool isTall = true;
                if (!isMale && !isTall) // AND statement and negation
                {
                    Console.WriteLine("You are Male and Tall");
                }
                else if (!isMale || !isTall) // OR statement and negation
                {
                    Console.WriteLine("Maybe you are Male or Tall");
                }
                else
                {
                    Console.WriteLine("You are not Male and not Tall");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine(); // keep console until press "Enter"
        }
        static void GoodBye(string name)
        {
            Console.WriteLine("GoodBye " + name);
        }
        static decimal Cube (decimal num)
        {
            decimal result = num * num * num;
            return result;
        }
        static string GetDay(int daynum)
        {
            string dayName;
            switch (daynum){
                case 0: dayName = "Sunday"; break;
                case 1: dayName = "Monday";break;
                case 2: dayName = "Tuesday";break;
                case 3: dayName = "Wednesday";break;
                case 4: dayName = "Thurday";break;
                case 5: dayName = "Friday";break;
                case 6: dayName = "Saturday";break;
                default: dayName = "Invalid Number";break;
            }
            return dayName;
        }
    }
}
