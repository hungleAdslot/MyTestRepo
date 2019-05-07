using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Create an array of all supported standard date and time format specifiers.
            string[] formats = {"D"};
            // Create an array of four cultures.                                 
            CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("de-DE"),
                                CultureInfo.CreateSpecificCulture("en-US"),
                                CultureInfo.CreateSpecificCulture("es-ES"),
                                CultureInfo.CreateSpecificCulture("zh-CN"),
                                CultureInfo.CreateSpecificCulture("fr-FR")};
            // Define date to be displayed.
            DateTime dateToDisplay = DateTime.Now;

            // Iterate each standard format specifier.
            foreach (string formatSpecifier in formats)
            {
                foreach (CultureInfo culture in cultures)
                    Console.WriteLine("{0} Format Specifier {1, 10} Culture {2, 40} {3}",
                                      formatSpecifier, culture.Name,
                                      dateToDisplay.ToString(formatSpecifier, culture),
                                      culture.DateTimeFormat.GetDayName(dateToDisplay.DayOfWeek));
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
