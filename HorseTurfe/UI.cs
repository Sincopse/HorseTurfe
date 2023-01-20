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
        public static void DrawBox(Horse horse)
        {
            int length = 23;

            if (horse.ToString().Length > length)
            {
                length = horse.ToString().Length;
            }

            //Cavalo Árabe 22 anos 3500€
            //╔═════════════════════════╗
            //║ - Cavalos Árabe 22 anos ║
            //║ Velocidade:  ▰▰▰▰▰▰▱▱▱▱ ║
            //║ Resistência: ▰▰▰▰▱▱▱▱▱▱ ║
            //║ Controlo:    ▰▰▰▰▰▱▱▱▱▱ ║
            //╚═════════════════════════╝

            Console.WriteLine($" ╔{new String('═', length + 4)}╗");
            Console.WriteLine($" ║ {horse.ToString()}{new String(' ', length - horse.ToString().Length + 2)} ║");
            Console.WriteLine($" ║ - Velocidade:  {new String('\u25A0', horse.Speed / 2)}{new String('\u25A1', length - 13 - horse.Speed / 2)} ║");
            Console.WriteLine($" ║ - Resistência: {new String('\u25A0', horse.Toughness / 2)}{new String('\u25A1', length - 13 - horse.Toughness / 2)} ║");
            Console.WriteLine($" ║ - Controlo:    {new String('\u25A0', horse.Control / 2)}{new String('\u25A1', length - 13 - horse.Control / 2)} ║");
            Console.WriteLine($" ╚{new String('═', length + 4)}╝");
        }

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
                Console.WriteLine($"{new String(' ', (horse.Distance > 200 ? 200:horse.Distance) / 4) + asciihorse + (horse.Distance <= 200 ? new String(' ', 50 - horse.Distance / 4):"")}|");
            }
            Console.WriteLine("═══════════════════════════════════════════════════════════");
        }
    }
}
