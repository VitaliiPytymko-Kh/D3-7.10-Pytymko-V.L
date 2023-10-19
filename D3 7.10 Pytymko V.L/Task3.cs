using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_7._10_Pytymko_V.L
{
//    Створіть додаток «Список книг до прочитання». Додаток
//    має дозволяти додавати книги до списку, видаляти книги
//    зі списку, перевіряти чи є книга у списку, і т.д
//    Використовуйте механізм властивостей, навантаження операторів,індексаторів.

    internal class Task3
    {
        internal class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }
            public override string ToString()
            {
                return $"{Title} by {Author}";
            }
        }
       internal class ReadingList
        {
            private List<Book> books = new List<Book>();
            public void Add(Book book)
            {
                books.Add(book);
            }
            public bool RemoveBook(string title)
            {
                Book bookToRemove = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    return true;
                }
                return false;
            }
            public bool Contains(string title)
            {
                return books.Exists(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            }

            public Book this[int index]
            {
                get
                {
                    if (index >= 0 && index < books.Count)
                    {
                        return books[index];
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }

            public int Count
            {
                get
                {
                    return books.Count;
                }
            }

            public void PrintAllBooks()
            {
                Console.WriteLine("Books in the reading list:");
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"Book {i + 1}: {books[i]}");
                }
            }

        }
    }
}

