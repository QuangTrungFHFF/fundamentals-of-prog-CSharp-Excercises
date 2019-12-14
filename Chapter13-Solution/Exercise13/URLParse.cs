using System;

namespace Exercise13
{
    /// <summary>
    /// Write a program that parses an URL in following format: [protocol]://[server]/[resource]
    /// The program should extract from the URL the protocol, server and resource parts.
    /// </summary>
    internal class URLParse
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter an URL!");
            string url = Console.ReadLine();
            if (CheckUrl(url))
            {
                Console.WriteLine("Protocol: " + GetProtocol(url));
                Console.WriteLine("Server: " + GetServer(url));
                Console.WriteLine("Resource: " + GetResource(url));
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
            Console.ReadKey(true);
        }

        /// <summary>
        /// Get Protocol part of the URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetProtocol(string url)
        {
            string protocol = url.Remove(url.IndexOf("://"));
            return protocol;
        }

        /// <summary>
        /// Get Resource part of the URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetResource(string url)
        {
            string resource;
            if ((GetProtocol(url).Length + GetServer(url).Length + 4) <= url.Length)
            {
                resource = url.Substring(GetProtocol(url).Length + GetServer(url).Length + 4); // 4 is for "://" + "/" that get remove from protocol name and server name
            }
            else
            {
                resource = "No resource found!";
            }
            return resource;
        }

        /// <summary>
        /// Get Server part of the URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetServer(string url)
        {
            string server = url.Substring(url.IndexOf("://") + 3);
            //Check if there is resource part
            if (server.IndexOf('/') != -1)
            {
                server = server.Substring(0, server.IndexOf('/'));
            }
            return server;
        }

        /// <summary>
        /// Check if URL is valid
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static bool CheckUrl(string url)
        {
            if (!url.Contains("://"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}