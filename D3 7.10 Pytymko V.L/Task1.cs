using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace D3_7._10_Pytymko_V.L
{

    internal class Task1
    //        Завдання 1
    //В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
    //інформацію про кількість працівників.Виконайте навантаження:
    //+ (для збільшення кількості працівників на вказану кількість)
    //— (для зменшення кількості працівників на вказану кількість),
    //== (перевірка на рівність кількості працівників),
    //< і > (перевірка на меншу чи більшу кількість працівників),
    //!= і Equals.Використовуйте механізм властивостей полів класу.
    {
        public class Journal  

        {
            private string _title;
            private int _yearFounded;
            private string _discription;
            private string _contactPhone;
            private string _email;
            private int _personal;

       
            public Journal(string title, int yearFounded, string discription, string contactPhone, string email, int personal)
            {
                _title = title;
                _yearFounded = yearFounded;
                _discription = discription;
                _contactPhone = contactPhone;
                _email = email;
                _personal = personal;
            }

            public void CreatedJournal()
            {
                Console.WriteLine("Введіть назву журналу:");
                _title = Console.ReadLine();

                bool isValidYear = false;
                do
                {
                    Console.WriteLine("Введіть рік заснування:");
                    try
                    {
                        _yearFounded = int.Parse(Console.ReadLine());
                        isValidYear = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Помилка: Введіть правильний формат року (ціле число).");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Помилка: Введіть рік в межах допустимого діапазону.");
                    }
                } while (!isValidYear);

                Console.WriteLine("Введіть опис журналу:");
                _discription = Console.ReadLine();

                Console.WriteLine("Введіть контактний телефон:");
                _contactPhone = Console.ReadLine();

                Console.WriteLine("Введіть email:");
                _email = Console.ReadLine();



                bool isValidValue = false;
                do
                {
                    Console.WriteLine("Вкажiть кількість працівників:");
                    try
                    {
                        _personal = int.Parse(Console.ReadLine());
                        isValidValue = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Помилка: Введіть правильну кількість працівників (ціле число).");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Помилка: Введіть кількість працівників в межах допустимого діапазону.");
                    }
                } while (!isValidValue);
            }

            public void PrintJournal()
            {
                Console.WriteLine($"Назва сайту:" + _title);
                Console.WriteLine($"Pік заснування:" + _yearFounded);
                Console.WriteLine($"Опис сайту:" + _discription);
                Console.WriteLine($"Kонтактний телефон:" + _contactPhone);
                Console.WriteLine($"emailу:" + _email);
                Console.WriteLine($"Kількість працівників :" + _personal);
            }

            public string GetTitle() { return _title; }
            public int GetYear() { return _yearFounded; }
            public string GetDiscription() { return _discription; }
            public string GetPhone() { return _contactPhone; }
            public string GetEmail() { return _email; }
            public int GetPersonal() { return _personal; }


            public void SetTitle(string newTitle) { _title = newTitle; }
            public void SetYear(int newYear) { _yearFounded = newYear; }
            public void SetDescription(string newDiscription) { _discription = newDiscription; }
            public void SetPhone(string newPhone) { _contactPhone = newPhone; }
            public void SetEmail(string newEmail) { _email = newEmail; }
            public void SetPersonal(int newPersonal) { _personal = newPersonal; }

            public static Journal operator +(Journal a, int b)
            {
                    a._personal += b;

                    return a;
            }
            public static Journal operator -(Journal a, int b)
            {
                a._personal -= b;
                
                return a;
            }
            public static bool operator ==(Journal a,Journal b)
            {
                if (a._personal == b._personal)
                
                    return true;
                
                else  return  false;
            }

            public static bool operator !=(Journal a, Journal b)
            {
                if (a._personal != b._personal)

                    return true;

                else return false;
            }
            public static bool operator >(Journal a, Journal b)
            {
                if (a._personal > b._personal)

                    return true;

                else return false;
            }
            public static bool operator <(Journal a, Journal b)
            {
                if (a._personal < b._personal)

                    return true;

                else return false;
            }
            public static bool Equals(Journal a)
            {
                if (a is Journal b)
                {
                    return a._personal == b._personal;
                }
                return false;

            }

            
        }

    }
}
