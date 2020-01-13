using System;
using System.Collections.Generic;

namespace PallindromeTestLib
{
    public class TestPalindrome
    {
        public bool TestPal(string s)
        {
            s = Prepare(s);
            string r = Reverse(s);
            return r.Equals(s); 
        }
        public string Prepare(string s)
        {
            string lower = s.ToLower();
            string trimmed = lower.Trim();
            while(trimmed.IndexOf(' ') != -1)
            {
                trimmed = trimmed.Remove(trimmed.IndexOf(' '),1);
            }
            while (trimmed.IndexOf(',') != -1)
            {
                trimmed = trimmed.Remove(trimmed.IndexOf(','),1);
            }
            while (trimmed.IndexOf('.') != -1)
            {
                trimmed = trimmed.Remove(trimmed.IndexOf('.'),1);
            }
            return trimmed;
        }
        public string Reverse(string s)
        {
            char[] a = new char[s.Length];
            for(int i =0; i < s.Length; i++)
            {
                a[i] = s[s.Length - i - 1];
            }
            string r = new string(a);
            return r;
        }
    }
}
