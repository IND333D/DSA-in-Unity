using UnityEngine;

public class QuickSort : MonoBehaviour
{
    public int[] ints;

    void Start()
    {
        SortArray(ints,0,ints.Length-1);
    }

    public int[] SortArray(int[] _ints, int low, int high)
    {
        if(low < high)
        {
            int pivot = Partition(_ints, low, high);
            SortArray(_ints, low, pivot -1);   
            SortArray(ints, pivot+1, high);

        }


        return ints;
    }

    public int Partition(int[] _ints, int low, int high)
    {
        int pivot = _ints[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if(_ints[j] < pivot)
            {
                i++;

                int temp = _ints[j];
                _ints[j] = _ints[i];
                _ints[i] = temp;
            }
        }

        i++;
        int temp2 = _ints[i];
        _ints[i] = _ints[high];
        _ints[high] = temp2;

        return i;
    }

}
