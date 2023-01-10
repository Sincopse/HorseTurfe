using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTurfe
{
    public static class Calendar
    {
        static string month = "January";
        static string calendar = "\n╔════════════════════╗" +
                                 "\n║ "+month+" ░░░░░ 2023 ║" +
                                 "\n╟──┬──┬──┬──┬──┬──┬──╢" +
                                 "\n║░░│░░│░░│░░│░░│░░│░░║" +
                                 "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                                 "\n║01│02│03│04│05│06│07║" +
                                 "\n╟──┼──╔══╗──┼──┼──┼──╢" +
                                 "\n║08│09║10║11│12│13│14║" +
                                 "\n╟──┼──╚══╝──┼──┼──┼──╢" +
                                 "\n║15│16│17│18│19│20│21║" +
                                 "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                                 "\n║22│23│24│25│26│27│28║" +
                                 "\n╟──┼──┼──┼──┼──┼──┼──╢" +
                                 "\n║29│30│31│░░│░░│░░│░░║" +
                                 "\n╚══╧══╧══╧══╧══╧══╧══╝";

        public static void ShowCalendar()
        {
            Console.WriteLine(calendar);
        }
    }
}
