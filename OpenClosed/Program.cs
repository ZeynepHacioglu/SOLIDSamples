using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesneye yeni bir özellik kazandırmak istediğinizde o nesne kodunu değiştirmek zorunda kalıyorsanız OCP'yi ihlal ediyorsunuz.
             */

            Customer customer = new Customer { CardType = new Premium() };
            OrderManagement orderManagement = new OrderManagement();
            orderManagement.Customer = customer;
            var result = orderManagement.GetDiscountedPrice(1000);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public abstract class Card
        {
            public abstract double DiscountedPrice(double price);
            
        }
        public class Standart : Card
        {
            public override double DiscountedPrice(double price)
            {
                return price * 0.95;
            }
        }

        public class Silver : Card
        {
            public override double DiscountedPrice(double price)
            {
                return price * 0.9;
            }
        }
        public class Gold : Card
        {
            public override double DiscountedPrice(double price)
            {
                return price * 0.85;
            }
        }

        public class Premium : Card
        {
            public override double DiscountedPrice(double price)
            {
                return price * 0.80;
            }
        }

        public class Customer
        {
            public Card CardType { get; set; }
        }

        public class OrderManagement
        {
            public Customer Customer { get; set; }

            public double GetDiscountedPrice(double price)
            {
                return Customer.CardType.DiscountedPrice(price);
            }
        }
    }
}
