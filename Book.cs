using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaskWithClass
{
    internal class Book
    {
        /// <summary>
        /// Опишите, используя Класс, каталог книг в библиотеке.Составьте программу, выдающую список книг А.Дюма, хранящихся в библиотеке
        /// </summary>
        
        private string title;
        private string writer;

        public void Library(string title, string writer)
        {
            this.title = title;
            this.writer = writer;

            if (this.writer == "А.Дюма")
            {
                Print();
            }
        }
        public string Print()
        {
            Console.Write("В библиотеке есть следующие книги А.Дюма:");
            Console.WriteLine($"{title}, {writer}");
            return writer;
        }

    }
}
