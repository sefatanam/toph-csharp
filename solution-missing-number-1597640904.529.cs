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
                long a = Int64.Parse(split[0]);
                string line2;
                while ((line2 = Console.ReadLine()) != null)
                {
                    string[] split2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                    int[] n = new int[3];
                    n[0] = Int32.Parse(split2[0]);
                    n[1] = Int32.Parse(split2[1]);
                    n[2] = Int32.Parse(split2[2]);
                    WriteLine(a - sum(n));
                    ReadKey();
                }
            }
    }
	public static int sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++){sum += arr[i];}
            return sum;
        }
}