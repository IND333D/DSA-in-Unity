using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Windows;

public class ValidPalindrome : MonoBehaviour
{
    public string palindrome;
    public bool isPalindrome;

    void Start()
    {
        isPalindrome = ValidPalindromeCheck2(palindrome);
    }

    public bool ValidPalindromeCheck(string s)
    {
        char[] refined = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().ToCharArray();

        Debug.Log(new string(refined));
        for(int i = 0; i < refined.Length/2; i++)
        {
            if(refined[i] != refined[refined.Length -1 - i] )
            {
                return false;
            }
        }

        return true;
    }

    public bool ValidPalindromeCheck2(string s)
    {
        int right = s.Length -1;
        int left = 0;

        while(left < right)
        {
            //Debug.Log(left + " " + right);
            while (left<right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {   
                Debug.Log(s[left] + " False " + s[right]);
                return false;
            }
            left++;
            right--;

        }
        return true;
    }

}
