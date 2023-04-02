using System.Linq;
using System.Collections.Generic;


 class Program
{
    private static void Main(string[] args)
    {
        List<int> lst = new List<int>();

        Console.WriteLine("How many numbers do you have : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i < number)
        {
            Console.WriteLine("Enter your value : ");
            int item = Convert.ToInt32(Console.ReadLine());
            lst.Add(item);
            i++;
        }

        Console.WriteLine("Mean : "+MeanMethod(lst));
        double v = Convert.ToDouble(StandardDev(lst));
 
        Console.WriteLine("Standard Deviation : " + v);

    }
     static double MeanMethod(List<int> lst)
        {
            int ans = lst.Sum();
            double mean = ans / lst.Count();
            return mean;

        }
   static double StandardDev(List<int> values)
    {
        double stddev = 0;
        int count = values.Count();
        if (count>1)

        {
            double avg = values.Average();
            double sum = values.Sum(d =>(d - avg) * (d - avg));
            stddev = Math.Sqrt(sum/(count-1));
            
        }
        return stddev;
    }
}

// Console.WriteLine("Here is your list" +lst);