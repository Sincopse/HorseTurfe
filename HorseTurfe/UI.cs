using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public static class UI
    {
        /// <summary>
        /// Receives a string splitted by semicolons and draws a Ascii Box
        /// </summary>
        /// <param name="content"></param>
        public static void DrawBox(string content)
        {
            List<string> list = content.Split(';').ToList();

            int length = 0;

            foreach (string item in list)
            {
                if (item.Length > length)
                {
                    length = item.Length;
                }
            }
            
            Console.WriteLine($" ╔{new String('═', length + 2)}╗");
            foreach (string item in list)
            {
                Console.WriteLine($" ║ {item + new String(' ', length - item.Length)} ║");
            }
            Console.WriteLine($" ╚{new String('═', length + 2)}╝");
        }
    }
}
