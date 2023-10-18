using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D3_7._10_Pytymko_V.L.Task1;
using static D3_7._10_Pytymko_V.L.Task2;

namespace D3_7._10_Pytymko_V.L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Journal MyJournal = new Journal("dtryh", 2000, "rtyrty", "1111", "sdtyrty", 200);
            MyJournal.PrintJournal();

            MyJournal += 11;
            MyJournal.PrintJournal();

            MyJournal -= 25;
            MyJournal.PrintJournal();

            Journal MyJournal1 = new Journal("dtryh", 2000, "rtyrty", "1111", "sdtyrty", 200);
            Console.WriteLine($" Equals (MyJournal,MyJournal1)={Equals(MyJournal.GetPersonal(), MyJournal1.GetPersonal())}");
            Journal A = new Journal("fgh", 6666, "hjkjh", "566574-567465", "jkljk@fgjh", 186);
            A.PrintJournal();
            Console.WriteLine($" Equals (MyJournal,A)={Equals(MyJournal.GetPersonal(), A.GetPersonal())}");
            Console.WriteLine();

            //Task2
            Store myStore = new Store(" БТА", "Адреса магазину - Ненацьк ", "БАвовнятко ", "Телефон: Mi", " Bavovna@nenack.com", 300);

            myStore.ShowStore();

            Console.WriteLine();

            myStore.SetNameS($"Нова назва ");

            myStore.ShowStore();

            myStore+=200;
            Console.WriteLine(myStore.Area);
            myStore-=50;
            Console.WriteLine(myStore.Area);

            Store s2 = new Store("xfgh", "dutyuy5667", "dfghfgh54bnm", "65465-65464", "zdfgdf@zxdfgh.com", 450);
            s2.ShowStore();
            Console.WriteLine($"myStore ==,<,>,!= s2,");
            Console.WriteLine($"{myStore.Area == s2.Area}");
            Console.WriteLine($"{myStore.Area < s2.Area}");
            Console.WriteLine($"{myStore.Area > s2.Area}");
            Console.WriteLine($"{myStore.Area != s2.Area}");
            Console.WriteLine($" Equals (myStore,s2)={Equals(myStore.Area,s2.Area)}");


            Console.WriteLine();

        }
    }
}
