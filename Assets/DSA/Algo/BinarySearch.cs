using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    public int[] arr;
    public int target;
    public int answer;

    void Start()
    {
        answer = Search(arr, target);
    }
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;


        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int t =  nums[mid];

            if (t == target)
            {
                return mid;
            }

            if(t < target)
            {
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }

        return -1;
    }
}
