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
        public static void DrawBox(List<Horse> horses, string footer)
        {
            int length = 0, i = 1;

            foreach (Horse horse in horses)
            {
                if (horse.ToString().Length > length)
                {
                    length = horse.ToString().Length;
                }
            }
            if (footer.Length > length)
            {
                length = footer.Length;
            }

            Console.WriteLine($" ╔{new String('═', length + 6)}╗");
            foreach (Horse horse in horses)
            {
                Console.WriteLine($" ║ {i} - {horse.ToString() + new String(' ', length - horse.ToString().Length)} ║");
                i++;
            }
            Console.WriteLine($" ║ {footer + new String(' ', length - footer.Length)} ║");
            Console.WriteLine($" ╚{new String('═', length + 6)}╝");
        }
        //public static void DrawBox(Horse horse)
        //{
        //    int length = 0;

        //    foreach (Horse horse in horses)
        //    {
        //        if (horse.ToString().Length > length)
        //        {
        //            length = horse.ToString().Length;
        //        }
        //    }

        //    Console.WriteLine($" ╔{new String('═', length + 2)}╗");
        //    foreach (Horse horse in horses)
        //    {
        //        Console.WriteLine($" ║ {horse.ToString() + new String(' ', length - horse.ToString().Length)} ║");
        //    }
        //    Console.WriteLine($" ╚{new String('═', length + 2)}╝");
        //}

        public static void DrawRace(List<Horse> horses)
        {
            const string asciihorse = "-C=0>";
            // Race Sample
            //"Start                                             Finish" +
            //"\r\n════════════════════════════════════════════════════════" +
            //"\r\n                     -C=0>                       |" +
            //"\r\n         -C=0>                                   |" +
            //"\r\n                                           -C=0> |" +
            //"\r\n-C=0>                                            |" +
            //"\r\n════════════════════════════════════════════════════════";

            Console.WriteLine(" Start                                              Finish" +
                               "\n═══════════════════════════════════════════════════════════");
            foreach (Horse horse in horses)
            {
                Console.WriteLine($"{new String(' ', (horse.Distance > 100 ? 100:horse.Distance) / 2) + asciihorse + (horse.Distance <= 100 ? new String(' ', 50 - horse.Distance / 2):"")}|");
            }
            Console.WriteLine("═══════════════════════════════════════════════════════════");
        }
    }
}
