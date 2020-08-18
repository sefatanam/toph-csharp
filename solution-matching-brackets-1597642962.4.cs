using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
 
public class Solution
{
    public static void Main(string[] args)
    {
		 string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                string a = split[0];
                WriteLine(IsValid(a)? "Yes":"No");
               
            }

        
    }
	 public static bool IsValid (string s)
        {
            var k = new Stack<char>();
		 foreach (char c in s)
            {
               
                if (c == '(') { k.Push(')'); continue; }
                if (c == '{') { k.Push('}'); continue; }
                if (c == '[') { k.Push(']'); continue; }
                if (k.Count == 0 || c != k.Pop()) return false;
            }
            return k.Count == 0;
        }
}