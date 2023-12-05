using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class ExemploTimeSpan
    {
        public void ShowTimeSpan()
        {
            Console.WriteLine(new TimeSpan(2, 30, 0)); // 02:30:00
            Console.WriteLine(TimeSpan.FromHours(2.5)); // 02:30:00
            Console.WriteLine(TimeSpan.FromHours(-2.5)); // -02:30:00

            TimeSpan nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);
            Console.WriteLine(nearlyTenDays.Days); // 9
            Console.WriteLine(nearlyTenDays.Hours); // 23
            Console.WriteLine(nearlyTenDays.Minutes); // 59
            Console.WriteLine(nearlyTenDays.Seconds); // 59
            Console.WriteLine(nearlyTenDays.Milliseconds); // 0

        }
    }
}
