using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public static class Calendar
    {
        static DateTime date = DateTime.Now;
        static string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static string[] daysOfWeek = { "Domingo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" };

        public static string DayOfWeek()
        {
            return daysOfWeek[(int)date.DayOfWeek];
        }

        public static void ShowCalendar()
        {
            Console.WriteLine("\n╔════════════════════╗" +
                             "\n║ " + months[date.Month - 1] + " ░░░░░ " + date.Year + " ║" +
                             "\n╟──┬──┬──┬──┬──┬──┬──╢" +
                             "\n║01│02│03│04│05│06│07║" +
                             "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                             "\n║08│09│10│11│12│13│14║" +
                             "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                             "\n║15│16│17│18│19│20│21║" +
                             "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                             "\n║22│23│24│25│26│27│28║" +
                             "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                             "\n║29│30│31│  │  │  │  ║" +
                             "\n╚══╧══╧══╧══╧══╧══╧══╝");
            Console.WriteLine("\nToday is " + DayOfWeek() + " " + months[date.Month - 1] + " " + date.Day + ", " + date.Year);

            if (Calendar.DayOfWeek() == "Domingo")
            {
                Console.WriteLine("Lipem os cascos! É dia de corrida >:)");
            }
            if (Calendar.DayOfWeek() == "Sexta-Feira")
            {
                Console.WriteLine("UUUUUUuuuuUUU um  mercante chegou à cidade com descontos e itens manhosos");
            }
        }
    }
}