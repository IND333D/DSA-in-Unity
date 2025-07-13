using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TwoSum : MonoBehaviour
{
    public int[] nums;
    public int target;

    private void Start()
    {
        Debug.Log(TwoSums(nums, target).First() + ", " + TwoSums(nums, target).Last());
    }

    
    public int[] TwoSums(int[] nums, int target)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for (int i = 0; i <= nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                return new int[] { map[target - nums[i]], i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}
