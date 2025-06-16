namespace LeshaMergeQuickSort;

public class MySorts
{
    static public List<int> LeshaMergeQuickSort(List<int> arrayToSort)
    {
        if (arrayToSort.Count <= 100)
        {
            return LeshaQuickSort(arrayToSort);
        }
        
        int middleIndex = arrayToSort.Count / 2;
        List<int> leftPart = arrayToSort.GetRange(0, middleIndex);
        List<int> rightPart = arrayToSort.GetRange(middleIndex, arrayToSort.Count - middleIndex);

        leftPart = LeshaMergeQuickSort(leftPart);
        rightPart = LeshaMergeQuickSort(rightPart);

        int leftPartIndex = 0;
        int rightPartIndex = 0;
        List<int> result = new List<int>();

        while (leftPartIndex < leftPart.Count && rightPartIndex < rightPart.Count)
        {
            if (leftPart[leftPartIndex] < rightPart[rightPartIndex])
            {
                result.Add(leftPart[leftPartIndex]);
                leftPartIndex++;
            }
            else
            {
                result.Add(rightPart[rightPartIndex]);
                rightPartIndex++;
            }
        }

        while (leftPartIndex < leftPart.Count)
        {
            result.Add(leftPart[leftPartIndex]);
            leftPartIndex++;
        }

        while (rightPartIndex < rightPart.Count)
        {
            result.Add(rightPart[rightPartIndex]);
            rightPartIndex++;
        }

        return result;
    }
    
    static public List<int> LeshaQuickSort(List<int> arrayToSort)
    {
        if (arrayToSort.Count <= 1)
        {
            return arrayToSort;
        }
        
        int pivot = arrayToSort[arrayToSort.Count / 2];
        List<int> leftPart = new List<int>();
        List<int> rightPart = new List<int>();
        List<int> pivotPart = new List<int>();
        for (int i = 0; i < arrayToSort.Count; i++)
        {
            if (arrayToSort[i] < pivot)
            {
                leftPart.Add(arrayToSort[i]);
            }
            else if (arrayToSort[i] > pivot)
            {
                rightPart.Add(arrayToSort[i]);
            }
            else
            {
                pivotPart.Add(arrayToSort[i]);
            }
        }

        leftPart = LeshaQuickSort(leftPart);
        rightPart = LeshaQuickSort(rightPart);
        
        List<int> result = new List<int>();
        foreach (var lp in leftPart)
        {
            result.Add(lp);
        }

        foreach (var pv in pivotPart)
        {
            result.Add(pv);
        }

        foreach (var rp in rightPart)
        {
            result.Add(rp);
        }

        return result;
    }
}