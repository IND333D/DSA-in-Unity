using System.Collections.Generic;
using UnityEngine;

public class DailyTemperature : MonoBehaviour
{
    public int[] dailyTemp;

    public int[] answer;

    void Start()
    {
        answer = DailyTemperatures2(dailyTemp);
    }

    public int[] DailyTemperatures2(int[] temperatures)
    {
        Stack<int> dayIndex = new Stack<int>();
        int[] ints = new int[temperatures.Length];
        int index = 0;

        for (int i = temperatures.Length - 1; i >= 0; i--)
        {

            while(dayIndex.Count != 0 && temperatures[i] > temperatures[dayIndex.Peek()])
            {
                index = dayIndex.Pop();
            }

            if (dayIndex.Count > 0)
            {
                ints[i] = dayIndex.Peek() - i;
            }
            dayIndex.Push(i);

        }

        return ints;

    }






    public int[] DailyTemperatures(int[] temperatures)
    {
        
        int[] dailyWaits = new int[temperatures.Length];
        dailyWaits[temperatures.Length-1] = 0;

        for (int i = 0; i < temperatures.Length-1; i++)
        {
            for (int j = i+1; j < temperatures.Length; j++)
            {
                if(temperatures[j] > temperatures[i])
                {
                    dailyWaits[i] = j - i;
                    break;
                }
            }
        }

        return dailyWaits;

    }
}
