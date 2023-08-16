using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSortingData;
public class ArrayService
{
    Random random = new Random();

    public int[] CreateArray()
    {
        var count = random.Next(20, 100);
        int[] randNumList = new int[count];
        Console.WriteLine("Array:\n");
        for (int i = 0; i < count; i++)
        {
            var num = random.Next(-100, 100);
            randNumList[i] = num;
            Console.Write($"{num} ");
        }
        return randNumList;
    }
}
