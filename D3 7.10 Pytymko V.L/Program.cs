using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D3_7._10_Pytymko_V.L.Class1;

namespace D3_7._10_Pytymko_V.L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Journal MyJournal = new Journal("dtryh", 2000, "rtyrty", "1111", "sdtyrty",200);
            MyJournal.PrintJournal();

            MyJournal += 11;
            MyJournal.PrintJournal();

            MyJournal -= 25;
            MyJournal.PrintJournal();

            Journal MyJournal1 = new Journal("dtryh", 2000, "rtyrty", "1111", "sdtyrty", 200);
            Console.WriteLine($" Equals (MyJournal,MyJournal1)={Equals(MyJournal.GetPersonal(),MyJournal1.GetPersonal())}");
            Journal A = new Journal("fgh",6666,"hjkjh","566574-567465","jkljk@fgjh",186);
            A.PrintJournal();
            Console.WriteLine($" Equals (MyJournal,A)={Equals(MyJournal.GetPersonal(), A.GetPersonal())}");
            
        }
    }
}
