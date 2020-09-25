using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace PrintScanCode
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var k = Console.ReadKey(true);
                    var kname = Enum.GetName(typeof(ConsoleKey), k.Key);

                    Console.WriteLine($"{kname}");
                }
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
