using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Numeric_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            //Console.WriteLine(string.Format("{index:intvalue.deximalvalue}", firstindex, secondindex, thirdandsoon));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D; //3.33333

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-R$10 / R$3 = R${0:0.00}", money));

            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("jp-JP")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("de-CH")));

            Console.ReadLine();
        }
    }
}
