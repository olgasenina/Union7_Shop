using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union7_Shop
{
    /// <summary>
    /// Доставка
    /// </summary>
    abstract class Delivery
    {
        protected Address address;

        protected Delivery()
        {
            address = new Address();
        }

        public virtual void Print()
        {
            Console.WriteLine("Адрес доставки ");
        }
        
    }
    /// <summary>
    /// Доставка на дом
    /// </summary>
    class HomeDelivery : Delivery
    {
        public HomeDelivery()
        {
            address.City = "Москва";
            address.Street = "Хорошая";
            address.House = "1";
            address.Apartment = "7";
        }

        public override void Print()
        {
            Console.WriteLine("Курьер выехал по адресу: " + address.City + ", улица " + address.Street + ", дом " + address.House + ", квартира " + address.Apartment);
        }
    }
    /// <summary>
    ///  Доставка в пункт выдачи
    /// </summary>
    class PickPointDelivery : Delivery
    {
        public PickPointDelivery()
        {
            address.City = "Москва";
            address.Street = "Маяковская";
            address.House = "17";
            address.Apartment = "146";
        }

        public override void Print()
        {
            Console.WriteLine("Адрес пункта выдачи: " + address.City + ", улица " + address.Street + ", дом " + address.House + ", квартира " + address.Apartment);
        }
    }

    class Address
    {
        public string City;
        public string Street;
        public string House;
        public string Apartment;

        public string GetCity
        {
            set
            {
                City = value;
            }
        }

        public string GetStreet
        {
            set
            {
                Street = value;
            }
        }

        public string GetHouse
        {
            set
            {
                House = value;
            }
        }

        public string GetApartment
        {
            set
            {
                Apartment = value;
            }
        }
    }
}
