using System;

namespace Exercise16
{
    class ReplaceHTMLTags
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=\"http://google.com\">our site</a> to choose a training course. Also visit <a href= \"http://forum.softuni.org\">our forum</a> to discuss the courses.</p>";
            Console.WriteLine(text);
        }
    }
}
