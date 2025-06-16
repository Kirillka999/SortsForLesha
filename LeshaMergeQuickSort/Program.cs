namespace LeshaMergeQuickSort;

class Program
{
    static void Main(string[] args)
    {
        List<int> testArray = new List<int>(300);
        for (var i = 0; i < 300; i++)
        {
            testArray.Add(Random.Shared.Next(1, 21));
        }
        
        Print(testArray);
        Console.WriteLine();
        Console.WriteLine();
        var sortedArr = MySorts.LeshaMergeQuickSort(testArray);
        Print(sortedArr);

    }

    static void Print(List<int> arrayToPrint)
    {
        foreach (var i in arrayToPrint)
        {
            Console.Write($"{i} ");
        }
    }
}