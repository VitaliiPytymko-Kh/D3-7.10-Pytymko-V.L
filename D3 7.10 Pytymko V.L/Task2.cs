using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D3_7._10_Pytymko_V.L.Task1;

namespace D3_7._10_Pytymko_V.L
{
    internal class Task2
    {
//        Додайте до вже створеного класу
//        інформацію про площу магазину.
//        Виконайте навантаження + (для збільшення площі магазину на вказаний розмір),
//        — (для зменшення площі магазину на вказаний розмір),
//        == (перевірка на рівність площ магазинів),
//        < і > (перевірка магазинів менших або більших за площею),
//        != і Equals.Використовуйте механізм властивостей полів класу.
        public class Store
        {
            private string _nameS;
            private string _adress;
            private string _profildescriptionS;
            private string _phones;
            private string _emailS;
            private int _area;

            public Store(string nameS, string adress, string profildescriptionS, string phones, string emailS, int area)
            {
                _nameS = nameS;
                _adress = adress;
                _profildescriptionS = profildescriptionS;
                _phones = phones;
                _emailS = emailS;
                _area = area;
            }

            public string NameS { get { return _nameS; } }
            public string Adress { get { return _adress; } }
            public string Profil { get { return _profildescriptionS; } }
            public string Phones { get { return _phones; } }

            public string EmaiS { get { return _emailS; } }
            public int Area { get { return _area; } }

            public void SetNameS(string newNames) { _nameS = newNames; }
            public void SetAdress(string newAdress) { _adress = newAdress; }
            public void SetProfil(string newProfil) { _profildescriptionS = newProfil; }
            public void SetPhones(string newPhonees) { _phones = newPhonees; }
            public void SetEmail(string newEmails) { _emailS = newEmails; }
            public void SetArea(int newArea) {  _area = newArea; }

            public void InputDataStore()
            {
                Console.Write("Введіть назву магазину: ");
                _nameS = Console.ReadLine();

                Console.Write("Введіть адресу магазину: ");
                _adress = Console.ReadLine();

                Console.Write("Введіть опис профілю магазину: ");
                _profildescriptionS = Console.ReadLine();

                Console.Write("Введіть контактний телефон: ");
                _phones = Console.ReadLine();

                Console.Write("Введіть email: ");
                _emailS = Console.ReadLine();

                Console.WriteLine("ВВудіть площу магазину м2");
            }

            public void ShowStore()
            {
                Console.WriteLine("Інформація про магазин:");
                Console.WriteLine("" + _nameS);
                Console.WriteLine("" + _adress);
                Console.WriteLine("" + _profildescriptionS);
                Console.WriteLine("" + _phones);
                Console.WriteLine("" + _emailS);
                Console.WriteLine("" +_area);
            }

            public static Store operator +(Store a,int b)
            {
                a._area += b;
                return a;
            }
            public static Store operator -(Store a,int b)
            {
                a._area -= b;
                return a;
            }

            public static bool operator ==(Store a, Store b)
            {
                if (a._area == b._area)

                    return true;

                else return false;
            }

            public static bool operator !=(Store a, Store b)
            {
                if (a._area != b._area)

                    return true;

                else return false;
            }
            public static bool operator >(Store a, Store b)
            {
                if (a._area > b._area)

                    return true;

                else return false;
            }
            public static bool operator <(Store a, Store b)
            {
                if (a._area < b._area)

                    return true;

                else return false;
            }
            public static bool Equals(Store a)
            {
                if (a is Store b)
                {
                    return a._area == b._area;
                }
                return false;

            }

        }
    }
}
