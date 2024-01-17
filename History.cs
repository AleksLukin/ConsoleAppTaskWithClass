using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaskWithClass
{
    /// <summary>
    /// Опишите, используя Класс, таблицу дат и событий русской истории.Составьте программу, выдающую список событий XIX века
    /// </summary>
    internal class History
    {
        private int dateOfHistory;
        private string eventOfHistory;

        public History(int dateOfHistory, string eventOfHistory)
        {
            this.dateOfHistory = dateOfHistory;
            this.eventOfHistory = eventOfHistory;

            if (dateOfHistory >= 1801 && dateOfHistory <= 1901)
            {
                PrintEvent();
            }
        }
        private void PrintEvent()
        {
            Console.WriteLine(dateOfHistory+eventOfHistory);
        }
    }
}
