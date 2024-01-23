using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaskWithClass
{
    internal class School
    {
        private string name;
        private int date;
        private string month;
        private int year;

        public void List(string name, int date, string month, int year)
        {
            this.name = name;
            this.date = date;
            this.month = month;
            this.year = year;


            if (month == "May")
            {
                Console.WriteLine(name + " "+ date+ " " + month+" "+" "+year);
            }
        }
    }
}

//Опишите, используя Класс, школьный класс (Фамилия и инициалы, дата рождения, месяц рождения, год рождения).
//Составьте программу, выдающую список учеников, рожденных в мае месяце.
