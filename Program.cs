﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaskWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            string numberTask=Console.ReadLine();   
            bool result = int.TryParse(numberTask,out int resultNumber);

            if (result)
            {
                if (resultNumber == 1)
                {
                    Book bookOne = new Book();
                    bookOne.Library("Повести Белкина", "А.С. Пушкин");
                    Book bookTwo = new Book();
                    bookTwo.Library("Три мушкетера", "А.Дюма"); 
                    Book bookThird = new Book();
                    bookThird.Library("Мцири", "М.Ю. Лермонтов"); 
                    Book bookFour = new Book();
                    bookFour.Library("Граф Монте-Кристо", "А.Дюма"); 
                    Book bookFive = new Book();
                    bookFive.Library("Война и мир", "Л.Н. Толстой"); 
                    Book bookSix = new Book();
                    bookSix.Library("Преступление и наказание", "Ф.М. Достоевский"); 
                    Book bookSeven = new Book();
                    bookSeven.Library("Мещанин в дворянстве", "Ж.Б. Мольер");
                }
                if (resultNumber == 2)
                {
                    History historyOne = new History(1945, " - ВОВ");
                    History historyTwo = new History(1812, " - ОВ");
                    History historyThird = new History(1861, " - Отмена крепостного права");
                    History historyFour = new History(1917, " - Великая октябрьская революция"); 
                    History historyFive = new History(1961, " - Полет в космос");
                    History historySix = new History(1812, " - ОВ"); 
                    History historySeven = new History(1945, " - ВОВ");                    
                }
                if (resultNumber == 3)
                {
                    School learnerOne= new School();
                    learnerOne.List("Lukin", 11, "February",1983);
                    School learnerTwo = new School();
                    learnerTwo.List("Petrov", 06, "July", 1983);
                    School learnerThird = new School();
                    learnerThird.List("Sidorov", 17, "May", 1982);
                    School learnerFour = new School();
                    learnerFour.List("Rodionova", 06, "May", 1988);
                    School learnerFive = new School();
                    learnerFive.List("Dryagina", 04, "February", 1990);
                    School learnerSix = new School();
                    learnerSix.List("Parshakova", 11, "September",1986);
                    School learnerSeven = new School();
                    learnerSeven.List("Nikonova",17, "October",1986);
                    School learnerEight = new School();
                    learnerEight.List("Alueva", 07, "July", 1983);
                }
                if (resultNumber == 4)
                {

                }
                if (resultNumber == 5)
                {

                }
                if (resultNumber == 6)
                {

                }
                if (resultNumber == 7)
                {

                }
                if (resultNumber == 8)
                {

                }
                if (resultNumber == 9)
                {

                }
                if (resultNumber == 10)
                {

                }
                if (resultNumber == 11)
                {

                }
                if (resultNumber == 12)
                {

                }
                if (resultNumber == 13)
                {

                }
                if (resultNumber == 14)
                {

                }
                if (resultNumber == 15)
                {

                }
            }
            else
            {
                Console.WriteLine("Номер задачи не введен!");
            }
            Console.ReadLine();

        }
    }
}
