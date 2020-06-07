using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it 
//the [protocol], [server] and [resource] elements.

//Input

//On the only line you will receive an address
//Output

//Print the protocol, server and resource as shown below
namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string Url = Console.ReadLine();
            int first = Url.IndexOf(":");
            int second = Url.IndexOf('/', first + 3);
            int third = Url.IndexOf('/', second);
            string protocol = "[protocol] = " + Url.Substring(0, first);
            string server = "[server] = " + Url.Substring(first + 3, second - (first + 3));
            string resource = "[resource] = " + Url.Substring(second);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
        }
    }
}
