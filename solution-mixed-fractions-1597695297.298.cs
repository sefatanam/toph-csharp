using System;
using static System.Console;
public class Solution
{
    public static void Main(string[] args)
    {
		 string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                long q = Int64.Parse(split[0]);
                long w = Int64.Parse(split[1]);

                WriteLine($"{q / w} {q % w} {w}");
			}
        
    }
}