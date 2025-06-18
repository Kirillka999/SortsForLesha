using System.Diagnostics;

namespace LeshaMergeQuickSort;

public class AlgorithmsTester
{
    public static (double, double) TestAlgorithms(Stopwatch stopwatch)
    {
        //List<int> testArray = new List<int>() { 7, 2, 11, 4, 9, 1, 13, 6, 3, 12, 5, 10, 8 };

        List<int> testArray = new List<int>(1000);
        for (var i = 0; i < 1000; i++)
        {
            testArray.Add(Random.Shared.Next());
        }
        
        
        var array1 = new List<int>(testArray);
        stopwatch.Restart();
        var newSort1 = MySorts2.LeshaStalinInsertionSort(array1);
        var newSort2 = MySorts2.LeshaBubbleSort(array1);
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