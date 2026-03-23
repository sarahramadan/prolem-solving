using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.PriorityQueue;

public class MinHeap
{
    public int[] arr;

    public MinHeap(int capacity)
    {
        arr = new int[capacity];
    }
    public int ParentIndex(int givenIndex)
    {
        return (givenIndex - 1) / 2;
    }
    public int LeftIndex(int givenIndex) {
        return (2 * givenIndex) + 1;
    } 
    public int RightIndex(int givenIndex)
    {
        return 2 * givenIndex + 2;
    }

}
