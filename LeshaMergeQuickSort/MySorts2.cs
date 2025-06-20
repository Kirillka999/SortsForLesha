using System.Globalization;
using System.Security.Cryptography;

namespace LeshaMergeQuickSort;

public class MySorts2
{

    static public List<int> LeshaStalinInsertionSort(List<int> listToSort)
    {
        List<int> killedList = new List<int>();
        List<int> pardonedList = new List<int>();
         
        int lastAccepted = listToSort[0];
        pardonedList.Add(lastAccepted);
        
        for (var i = 1; i < listToSort.Count; i++)
        {
            if (listToSort[i] < lastAccepted)
            {
                killedList.Add(listToSort[i]);
            }
            else
            {
                lastAccepted = listToSort[i];
                pardonedList.Add(lastAccepted);
            }
        }

        var sortedList = LeshaModifiedInsertionSort(pardonedList, killedList);
        
        return sortedList;
    }
    
    
    static public List<int> LeshaModifiedInsertionSort(List<int> listToSort, List<int> killedList)
    {
        for (var i = 0; i < killedList.Count; i++)
        {
            int index = listToSort.Count - 1;
            listToSort.Add(0);

            while (index >= 0 && listToSort[index] > killedList[i])
            {
                listToSort[index + 1] = listToSort[index];
                index--;
            }

            listToSort[index + 1] = killedList[i];
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