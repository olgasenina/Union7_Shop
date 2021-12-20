using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union7_Shop
{
    /// <summary>
    /// Товар для продажи
    /// </summary>
    abstract class Product
    {
        protected string Name;
        protected double Price; // цена
        protected int Quantity;

        public Product(string Name)
        {
            this.Name = Name;
        }

        public abstract string FullName
        {
            get;
        }

        public double GetPrice
        {
            get
            {
                return Price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Цена должна быть больше 0!");
                }
                else
                {
                    Price = value;
                }
            }
        }

        public void QuantityInc()
        {
            Quantity++;
            Console.WriteLine("Осталось {0}.", Quantity);
        }

        public void QuantityDec()
        {
            Quantity--;
            Console.WriteLine("Осталось {0}.", Quantity);
        }

    }
    /// <summary>
    /// Книги
    /// </summary>
    class Book : Product
    {
        private string AuthorName;
        private string Publisher;       // Издатель
        private int YearOfPublication;  // год издания
        private BookType Type;          // жанр книги

        public Book(string AuthorName, string Publisher, int YearOfPublication, string Name) : base(Name) // вызывается конструктор базового класса
        {
            this.AuthorName = AuthorName;
            this.Publisher = Publisher;
            this.YearOfPublication = YearOfPublication;

            Quantity = 100;
        }

        public void BType(BookType Type)
        {
            this.Type = Type;
        }

        public string ShortName
        {
            get
            {
                return Name;
            }
        }

        public override string FullName
        {
            get
            {
                return AuthorName + " \"" + Name + "\", издательство \"" + Publisher + "\", " + YearOfPublication + " год";
            }
        }
        
    }

    enum BookType
    {
        FairyTales, // сказки
        Adventures, // приключения
        Novel,      // роман
        Detective   // детектив
    }
}
