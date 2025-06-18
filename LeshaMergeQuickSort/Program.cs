namespace LeshaMergeQuickSort;

class Program
{
    static void Main(string[] args)
    {
        // List<int> testArray = new List<int>(300);
        // for (var i = 0; i < 300; i++)
        // {
        //     testArray.Add(Random.Shared.Next(1, 21));
        // }
        //List<int> testArray = new List<int>() { 1, 2, 11, 4, 5, 9, 7, 8, 6, 10, 3, 12, 13 };
        //List<int> testArray = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        
        List<int> testArray = new List<int>() { 7, 2, 11, 4, 9, 1, 13, 6, 3, 12, 5, 10, 8 };

        Print(testArray);
        Console.WriteLine();
        Console.WriteLine();
        var sortedArr = MySorts2.LeshaStalinInsertionSort(testArray);
        Print(sortedArr);
        Console.WriteLine();
        var sortedArr2 = MySorts2.LeshaBubbleSort(testArray);
        Print(sortedArr2);


        
    }

    static void Print(List<int> arrayToPrint)
    {
        foreach (var i in arrayToPrint)
        {
            Console.Write($"{i} ");
        }
    }
    
}