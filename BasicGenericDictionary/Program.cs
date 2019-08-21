using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BasicGenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("An element with key \"txt\" already exists"); 
            }
            Console.WriteLine("The key for \"rtf\", value = {0}.", openWith["rtf"]);
            //Console.ReadLine();
        }
    }
}
