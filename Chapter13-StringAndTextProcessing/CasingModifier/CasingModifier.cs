using System;

namespace Exercise06
{
    /// <summary>
    /// 6. A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags.
    /// Tags cannot be nested.
    /// </summary>
    internal class CasingModifier
    {
        private static void Main(string[] args)
        {
            string shortText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            //Find the first text between two tags <upcase></upcase>
            int startIndex = shortText.IndexOf("<upcase>");
            int endIndex = shortText.IndexOf("</upcase>");

            while (startIndex != -1 && endIndex != -1)
            {
                int subLength = endIndex + 9 - startIndex;
                string subText = shortText.Substring(startIndex, subLength);
                //Replace the subtext with new Uppercase subtext
                shortText = shortText.Remove(startIndex, subLength).Insert(startIndex, ToUpperCase(subText));
                startIndex = shortText.IndexOf("<upcase>");
                endIndex = shortText.IndexOf("</upcase>");
            }

            Console.WriteLine(shortText);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Replace substring between <upcase></upcase> with a Uppercase substring and remove "<upcase>", "</upcase>" tags
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string ToUpperCase(string str)
        {
            if (str.StartsWith("<upcase>") && str.EndsWith("</upcase>"))
            {
                str = str.Remove(str.LastIndexOf("</upcase>")).Remove(0, 8);
                str = str.ToUpper();
            }
            return str;
        }
    }
}