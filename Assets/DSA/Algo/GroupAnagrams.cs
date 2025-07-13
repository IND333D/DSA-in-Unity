using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GroupAnagrams : MonoBehaviour
{
    public string[] strs;

    public List<List<string>> list = new List<List<string>>();

    public void Start()
    {
        list = Anagrams(strs);
        Debug.Log(list.Count);
        foreach (List<string> s in list)
        {
            foreach (string s2 in s)
            {
                Debug.Log(s2 + ",");
            }
            Debug.Log("??");
        }

    }

    public List<List<string>> Anagrams(string[] strs)
    {
        Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!keyValuePairs.ContainsKey(key))
            {
                keyValuePairs[key] = new List<string>();
            }

            keyValuePairs[key].Add(str);
        }

        return keyValuePairs.Values.ToList<List<string>>();
    }
}
