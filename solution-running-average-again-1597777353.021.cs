using System;

using System.Linq;
using static System.Console;
public class Solution
{
    public static void Main(string[] args)
    {
		    string l;
            while ((l= ReadLine())!= null)
            {
                string[] s= l.Split(new char[] { ' ' }, StringSplitOptions.None);
                int q = Int32.Parse(s[0]);
                string l2;
                while((l2=ReadLine())!= null)
                {
                     string[] s2 = l2.Split(new char[] { ' ' }, StringSplitOptions.None);
                    double[] n = new double[q];
                    float[] a = new float[q];
                    double sum = 0;
                    for (int i = 0; i < q; i++) n[i] = Int32.Parse(s2[i]);
                    for (int i = 0; i < q; i++) { sum += n[i];a[i] = ((float)sum / (1 + i)); }
                    WriteLine(string.Join("\n", a));
				}
			}
        
    }
}
