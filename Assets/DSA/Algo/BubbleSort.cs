using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    public int[] ints;

    private void Start()
    {
        SortArray(ints);
    }

    public int[] SortArray(int[] _ints)
    {
        for (int i = 0; i < ints.Length - 1; i++)
        {
            for(int j = 0; j < ints.Length - i - 1; j++)
            {
                if(ints[j] > _ints[j + 1])
                {
                    int temp = ints[j];
                    ints[j] = ints[j + 1];
                    ints[j + 1] = temp;
                }
            }
        }
        return ints;
    }
}
