using System.Collections.Generic;
using UnityEngine;

public class MaxAreaRectangle : MonoBehaviour
{
    public int[] heights;
    public int answer;

    void Start()
    {
        answer = LargestRectangleArea(heights);
    }

    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> min = new Stack<int>();
        int maxArea = 0;
        
        for (int i = 0; i<= heights.Length; i++)
        {
            int currentheight = 0;
            if (i < heights.Length)
            {
                currentheight = heights[i];
            }

            while(min.Count > 0 && currentheight < heights[min.Peek()])
            {
                int height = heights[min.Pop()];
                int width = min.Count == 0 ? i: i - min.Peek() -1;

                maxArea = Max(maxArea, height*width);
            }
            min.Push(i);
        }
        return maxArea;

        int Max(int a, int b)
        {
            if(a<b)
                return b;
            return a;
        }
    }
}
