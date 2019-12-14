using System;
using System.Text.RegularExpressions;

namespace Exercise16
{
    /// <summary>
    /// Write a program that replaces all hyperlinks in a HTML document consisting of <a href="…">…</a> and hyperlinks in "forum" style, which look like [URL=…]…[/URL].
    /// </summary>
    class ReplaceHTMLTags
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://google.com\">our site</a> to choose a training course. Also visit <a href= \"http://forum.softuni.org\">our forum</a> to discuss the courses.</p>";
            string newText = Regex.Replace(text, @"<a href=""","[URL=]");
            newText = Regex.Replace(newText, @""">", "]");
            newText = Regex.Replace(newText, @"</a>", "[/URL]");
            Console.WriteLine(newText);
            Console.ReadKey();
        }
    }
}
