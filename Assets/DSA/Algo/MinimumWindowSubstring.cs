using System.Collections.Generic;
using UnityEngine;

public class MinimumWindowSubstring : MonoBehaviour
{
    public string s;
    public string t;

    void Start()
    {
        Debug.Log(MinWindow1(s, t));
    }

    #region Soln 1

    public string MinWindow1(string s, string t)
    {
        if (s == "" || t == "")
        {
            return "";
        }

        Dictionary<char, int> required = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!required.ContainsKey(c))
            {
                required[c] = 0;
            }
            required[c]--;
        }

        int left = 0;
        int right = 0;
        int minSubstringLength = s.Length;
        int minIndex = 0;
        int missingTypes = required.Count;

        while (right < s.Length)
        {
            char c = s[right];
            if (required.ContainsKey(c))
            {
                required[c]++;
                if (required[c] == 0)
                {
                    missingTypes--;
                }
            }
            

            while (missingTypes ==0)
            {
                if (right - left < minSubstringLength)
                {
                    minSubstringLength = right - left;
                    minIndex = left;
                }
                char c2 = s[left];
                if (required.ContainsKey(c2))
                {
                    if (required[c2] == 0)
                    {
                        missingTypes++;
                    }
                    required[c2]--;
                }
                
                left++;

            }
            right++;

        }

        return minSubstringLength >= s.Length ? "" : s.Substring(minIndex, minSubstringLength + 1);
    }

    bool requirementMet(Dictionary<char, int> required)
    {
        foreach (char key in required.Keys)
        {
            //Debug.Log(key + " requiered : " + required[key] + " has : " + cpunt);
            if (required[key] < 0)
            {
                return false;
            }
        }
        return true;
    }

    #endregion


    #region Soln 2

    public string MinWindow(string s, string t)
    {
        if (s == "" || t == "")
        {
            return "";
        }

        Dictionary<char, int> required = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!required.ContainsKey(c))
            {
                required[c] = 0;
            }
            required[c]++;
        }

        int left = 0;
        int right = 0;
        int minSubstringLength = s.Length;
        int minIndex = 0;

        Dictionary<char, int> current = new Dictionary<char, int>();

        while (right < s.Length)
        {
            if (!current.ContainsKey(s[right]))
            {
                current[s[right]] = 0;
            }
            current[s[right]]++;

            while (requirementMet(required, current))
            {
                if (right - left < minSubstringLength)
                {
                    minSubstringLength = right - left;
                    minIndex = left;
                }
                current[s[left]]--;
                left++;

            }
            right++;

            if (left > s.Length || right > s.Length)
            {
                //Debug.Log("Breaked" + "left " + left + "right " + right + requirementMet(required, current));
                break;
            }
            //Debug.Log("left " + left + "right " + right + "length " + minSubstringLength + " index : " + minIndex);
        }

        return minSubstringLength >= s.Length ? "" : s.Substring(minIndex, minSubstringLength + 1);
    }

    bool requirementMet(Dictionary<char, int> required, Dictionary<char, int> current)
    {

        foreach (char key in required.Keys)
        {
            int cpunt = current.ContainsKey(key) == true ? current[key] : 0;
            //Debug.Log(key + " requiered : " + required[key] + " has : " + cpunt);
            if (cpunt < required[key])
            {
                return false;
            }
        }
        return true;
    }

    #endregion
}
