using System;

namespace Exercise04
{
    /// <summary>
    /// 4. How many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash? Ans: 1
    /// </summary>
    internal class BackslashSplit
    {
        private static void Main(string[] args)
        {
            string str = "one/two/three/four/five//six//seven////eight";
            string[] newString = str.Split('/', StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in newString)
            {
                Console.WriteLine(s);
            }
        }
    }
}