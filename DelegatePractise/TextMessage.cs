using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DelegatePractise
{
    public delegate void GetMessage(string message);
    class TextMessage
    {
        public static void PrintMessageLine(string message) => Console.WriteLine(message);
        public static void PrintMessage(string message) => Console.Write(message);
        public static void PrintMessageBackwards(string message)
        {
            char[] cArray = message.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine(reverse); 
        }

    }
}
