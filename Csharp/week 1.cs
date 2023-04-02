using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void SortList(string val)
    {
        List<int> mixList = new List<int>() {1, 9, 2, 8, 3, 7, 4, 6, 5, 8, 3, 99, 74, 12, 54, 8, 79, 35};

        val = val.ToLower();

        if (val == "asc")
        {
            mixList.Sort();
            Console.Write("Your list in ascending order is: ");
            Console.WriteLine(string.Join(" ", mixList));
        }
        else if (val == "desc")
        {
            mixList.Sort();
            mixList.Reverse();
            Console.Write("Your list in descending order is: ");
            Console.WriteLine(string.Join(" ", mixList));
        }
        else if (val == "none")
        {
            Console.Write("Your list as it was given: ");
            Console.WriteLine(string.Join(" ", mixList));
        }
        else
        {
            Console.WriteLine("What you chose does not exist");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n\nThank you for trying this code, please \n\nfollow and like for more such content and suggestions are welsome");
            Console.Write("\n\nEnter either 'asc', 'desc' or 'none' \nto get a list in ascending, descending or none: ");
            string choice = Console.ReadLine();
            SortList(choice);
        }
    }
}
