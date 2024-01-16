using System;
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

                }
                if (resultNumber == 3)
                {

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
