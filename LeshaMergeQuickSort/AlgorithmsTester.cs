using System.Diagnostics;

namespace LeshaMergeQuickSort;

public class AlgorithmsTester
{
    public static (double, double) TestAlgorithms(Stopwatch stopwatch)
    {
        List<int> testArray = new List<int>() { 1, 2, 3, 13, 5, 6, 7, 11, 9, 10, 8, 12, 4 };

        // List<int> testArray = new List<int>(1000);
        // for (var i = 0; i < 1000; i++)
        // {
        //     testArray.Add(Random.Shared.Next());
        // }
        
        
        var array1 = new List<int>(testArray);
        stopwatch.Restart();
        var newSort1 = MySorts2.LeshaStalinInsertionSort(array1);
        stopwatch.Stop();
        var time1 = stopwatch.Elapsed.TotalMilliseconds;
        
        stopwatch.Reset();

        var array2 = new List<int>(testArray);
        stopwatch.Restart();
        var newSort3 = MySorts2.LeshaBubbleSort(array2);
        stopwatch.Stop();

        var time2 = stopwatch.Elapsed.TotalMilliseconds;
        
        
        
        return (time1, time2);
    }
}