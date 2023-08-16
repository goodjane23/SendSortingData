using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SendSortingData;
public class SortingService
{
    public void Sort(int[] array)
    {
        if (DateTime.Now.Second % 2 == 0)
            BubleSort(array);
        else
            QuickSort(array, 0, array.Length - 1);
    }

    private void BubleSort(int[] array)
    {
        for (var i = 1; i < array.Count(); i++)
        {
            for (var j = 0; j < array.Count() - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    private void QuickSort(int[] array, int start, int end)
    {
        if (start >= end)
            return;

        int pivot = Partition(array, start, end);
        QuickSort(array, start, pivot - 1);
        QuickSort(array, pivot + 1, end);

    }

    private int Partition(int[] array, int start, int end)
    {
        int temp;
        int marker = start;
        for (int i = start; i < end; i++)
        {
            if (array[i] < array[end])
            {
                temp = array[marker];
                array[marker] = array[i];
                array[i] = temp;
                marker += 1;
            }
        }
        temp = array[marker];
        array[marker] = array[end];
        array[end] = temp;
        return marker;
    }
}
