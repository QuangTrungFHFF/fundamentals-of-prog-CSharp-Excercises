using System;
using System.Text;

namespace SubStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "0123456789abcdefgh";
            var sb = new StringBuilder(text);
            Console.WriteLine(sb.SubString(1, 5));
            
            
        }
    }
    public static class StringBuilderExtensions
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            var result = new StringBuilder();
            try
            {
                for (int i = index; i < index + length; i++)
                {
                    result.Append(sb[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException(" startIndex plus length is larger than total length of the original string!");
            }
            return result;
        }
    }
}
