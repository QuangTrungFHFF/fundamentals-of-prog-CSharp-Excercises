using System;

namespace Exercise09
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            HashedSet<string> testSet = new HashedSet<string>();
            testSet.Add("Trump");
            testSet.Add("Obama");
            testSet.Add("Clinton");
            testSet.Add("Obama");
            PrintSet(testSet);
            testSet.Remove("Trump");
            PrintSet(testSet);

        }
        private static void PrintSet(HashedSet<string> set)
        {
            foreach(string s in set)
            {
                Console.Write(s + "   ");
            }
            Console.WriteLine("");
        }
    }
}
