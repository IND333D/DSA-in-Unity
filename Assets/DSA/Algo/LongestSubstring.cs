using System.Collections.Generic;
using UnityEngine;

public class LongestSubstring : MonoBehaviour
{
    public string s;
    private void Start()
    {
        Debug.Log(LengthOfLongestSubstring(s));
    }

    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;
        int maxlength = 0;
        Dictionary<char, int> seen = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];

            if (seen.ContainsKey(current) && seen[current] >= left)
            {
                left = seen[current] + 1;
            }

            seen[current] = i;
            if (i - left+1 > maxlength)
            {
                maxlength = i - left+1;
            }
        }

        return maxlength;
    }
}
