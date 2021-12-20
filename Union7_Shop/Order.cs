using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union7_Shop
{
    public class Order<T>
    {
        public T Number;
        public static double MinSumma = 1000; // минимальная сумма заказа

        public Order(T Number)
        {
            this.Number = Number;
        }

        public void PrintOrder()
        {
            Console.WriteLine("\n\n------------------------------");
            Console.WriteLine("Ваш заказ № " + Number);
        }
        
    }
}
