using System.Globalization;
using System.Security.Cryptography;

namespace LeshaMergeQuickSort;

public class MySorts2
{

    static public List<int> LeshaStalinInsertionSort(List<int> listToSort)
    {
        List<int> killedList = new List<int>();
        List<int> emptyIndexes = new List<int>();
        
        int lastAccepted = listToSort[0];
        
        for (var i = 1; i < listToSort.Count; i++)
        {
            if (listToSort[i] < lastAccepted)
            {
                killedList.Add(listToSort[i]);
                emptyIndexes.Add(i);
            }
            else
            {
                lastAccepted = listToSort[i];
            }
        }

        var sortedList = LeshaInsertionSort(killedList);
        
        for (var i = 0; i < emptyIndexes.Count; i++)
        {
            listToSort[emptyIndexes[i]] = sortedList[i];
        }
        

        return listToSort;
    }
    
    
    static public List<int> LeshaInsertionSort(List<int> listToSort)
    {
        for (var i = 1; i < listToSort.Count; i++)
        {
            int key = listToSort[i];
            int index = i;
            while (index > 0 && listToSort[index - 1] > key)
            {
                listToSort[index] = listToSort[index - 1];
                //listToSort[index - 1] = key;
                index--;
            }

            listToSort[index] = key;
        }

        return listToSort;
    }

    static public List<int> LeshaBubbleSort(List<int> listToSort)
    {
        bool exchangeHappened;
        int iterator = 0;
        for (var i = 0; i < listToSort.Count; i++)
        {
            exchangeHappened = false;
            for (var i1 = 0; i1 < listToSort.Count - 1 - i; i1++)
            {
                if (listToSort[i1 + 1] < listToSort[i1])
                {
                    int c;
                    c = listToSort[i1];
                    listToSort[i1] = listToSort[i1 + 1];
                    listToSort[i1 + 1] = c;
                    exchangeHappened = true;
                    iterator++;
                }
            }
            if (!exchangeHappened)
            {
                //Console.WriteLine($"\n{iterator} exchanges happened in bubble sort");
                break;
            }
            
        }

        return listToSort;
    }
}