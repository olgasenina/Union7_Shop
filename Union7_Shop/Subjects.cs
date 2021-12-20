using System;

namespace Subjects
{
    abstract class Subjects
    {
        protected string Name;

        public Subjects(string Name)
        {
            this.Name = Name;
        }

        public string GetName
        {
            get
            {
                return Name;
            }
        }
    }
    /// <summary>
    /// Клиенты
    /// </summary>
    class Customer : Subjects
    {
        private string DeliveryAddress;
        private string PhoneNumber;

        public Customer(string Name, string DeliveryAddress, string PhoneNumber) : base(Name)
        {
            this.DeliveryAddress = DeliveryAddress;
            this.PhoneNumber = PhoneNumber;
        }

        public string GetDeliveryAddress
        {
            get
            {
                return "Адрес доставки: " + DeliveryAddress;
            }
        }

        public void CreateCardNumber<T>(T Number)
        {
            Console.WriteLine("Номер карты постоянного клиента - " + Number + ".");
        }

    }
    /// <summary>
    /// Поставщик товара
    /// </summary>
    class ProductSupplier : Subjects
    {
        private string ManagerName;
        public string PriceList;

        public ProductSupplier(string Name, string ManagerName):base(Name)
        {
            this.ManagerName = ManagerName;
        }
        
    }
    /// <summary>
    /// Сотрудники
    /// </summary>
    class Employee : Subjects
    {
        private double Age;      // возраст
        private string Post;     // должность
        private double Salary;   // оклад

        public Employee(string Name, double Age, string Post) : base(Name)
        {
            this.Age = Age;
            this.Post = Post;
        }

        public double SetSalary
        {
            set
            {
                if (value > 0)
                    Salary = value;
                else
                    Console.WriteLine("Оклад должен быть больше 0!");
            }
        }
    }
}
