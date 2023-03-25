using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<int> myList = new List<int>{1, 3, 7, -9, -3, 7, 8, 9, 3, 5};
        var result = SumZero(myList);
        Console.WriteLine(result);
    }

    static Tuple<int, int> SumZero(List<int> lst) {
        int smallValueOne = lst[0];
        int bigValueTwo = lst[1];
        var finalPair = new List<Tuple<int, int>> { Tuple.Create(smallValueOne, bigValueTwo) };

        for (int i = 2; i < lst.Count; i++) {
            if (Math.Abs(lst[i]) < Math.Abs(smallValueOne)) {
                bigValueTwo = smallValueOne;
                smallValueOne = lst[i];
                finalPair = new List<Tuple<int, int>> { Tuple.Create(smallValueOne, bigValueTwo) };
            } else if (Math.Abs(lst[i]) < Math.Abs(bigValueTwo)) {
                bigValueTwo = lst[i];
                finalPair.Add(Tuple.Create(smallValueOne, bigValueTwo));
            }
        }

        return finalPair.Min(pair => Tuple.Create(Math.Abs(pair.Item1 + pair.Item2), pair.Item1, pair.Item2));
    }
}
