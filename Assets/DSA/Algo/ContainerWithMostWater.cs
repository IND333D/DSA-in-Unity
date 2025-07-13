using UnityEngine;

public class ContainerWithMostWater : MonoBehaviour
{
    public int[] segments;

    void Start()
    {
        Debug.Log(MaxArea(segments));
    }

    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int areaMax = Min(height[left], height[right]) * (right -left);

        while (left < right)
        {
            int area = Min(height[left], height[right]) * (right - left);

            if(area > areaMax)
            {
                areaMax = area;
            }
            if(height[left] <= height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return areaMax;
    }

    int Min(int a, int b)
    {
        if(a <= b)
        {
            return a;
        }
        return b;
    }
}
