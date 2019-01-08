using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(20, 50);
            Console.WriteLine(money.GetMoney());
            Console.WriteLine(money.CanYouBuy(500));
            Console.WriteLine(money.HowMuchCanYouBuy(50));
            money.SetCount(100);
            Console.WriteLine(money.GetSumm());

            Console.ReadLine();
        }
    }

}
