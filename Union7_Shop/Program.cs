using System;
using Subjects;

namespace Union7_Shop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Книга
            Book book = new Book("Иванов С.П.", "Новая Заря", 2021, "Прекрасный день");

            Console.WriteLine(book.ShortName);
            Console.WriteLine(book.FullName);

            book.GetPrice = 165.26;

            if (book.GetPrice > 0)
                Console.WriteLine("Стоимость книги " + book.GetPrice);
            else
                Console.WriteLine("Стоимость книги не определена");

            // уменьшаем количество книг на 1
            book.QuantityDec();

            // Клиент
            Customer customer = new Customer("Соколова Ирина", "Москва, ул. Солнечная, д.37, кв.15", "(915)101-78-52");

            customer.CreateCardNumber<string>("нет");
            customer.CreateCardNumber<int>(123);

            Console.WriteLine(customer.GetDeliveryAddress);

            // Продавец

            Employee employee = new Employee("Мышкин Андрей", 26, "младший кассир");
            employee.SetSalary = 10000;


            Console.WriteLine("Ваш продавец " + employee.GetName);

            // Минимальная сумма заказа

            Console.WriteLine("Минимальная сумма заказа - " + Order<string>.MinSumma + "рублей");

            // Заказ

            Order<string> order = new Order<string>("V-001");

            order.PrintOrder();

            PickPointDelivery ppDelivery = new PickPointDelivery();
            ppDelivery.Print();

            HomeDelivery hDelivery = new HomeDelivery();
            hDelivery.Print();


            Console.ReadKey();
        }
    }
}
