using System;
using System.Linq;
 
 public class Program
{
    public static bool IsAnagram(string a , string b)
    {
       int count = 0;

       int secondCount = 0;

       bool anagram = false;

       for( int i = 0; i < a.Length -1; i++)
       {
        count++;
        secondCount = b.Length - 1;

        if(b.Contains(a[i]) && count == secondCount )
        {
            anagram = true;
        }
       } 
    }
}