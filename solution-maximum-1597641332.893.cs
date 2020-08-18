using System;
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
                long a = Int64.Parse(split[0]);
                string line2;
                while ((line2 = Console.ReadLine()) != null)
                {
                    string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int[] n = new int[a];
                    for (int i = 0; i < a; i++)
                    {
                        n[i] = Int32.Parse(split2[i]);
                    }
                    Array.Sort(n);
                    WriteLine(n.LastOrDefault());
                   
                }
            }
    }
}