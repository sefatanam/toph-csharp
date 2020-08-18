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
                long q = Int64.Parse(split[0]);
                string line2;
                while((line2= ReadLine()) != null)
                {
                    string[] splict2 = line2.Split(new char[] { ' ' }, StringSplitOptions.None);
                    long[] n = new long[q];
                    float[] avr = new float[q];
                    for (int i = 0; i < q; i++)
                    {
                        n[i] = Int64.Parse(splict2[i]);

                        avr[i] =((float) n.Sum() / (1+i));
                    }

                    for (int i = 0; i < avr.Length; i++)
                    {
                        WriteLine($"{avr[i]}");

                    }

				}  
                }
        
    }
}