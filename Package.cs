using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Data.Payment;
using static ConsoleApp1.Data.Payment.PriceFinal;

namespace ConsoleApp1.Data
{
    internal class Package
    {
        public record Product(int Id, Quantity Quantity, PriceFinal PriceFinal,DateTime Date);
        public record Delivery
        {
            private int id;
            private Product[] products;
            private string address;
            private DateTime Date;
            public Delivery(int id, Product[] products)
            {
                this.id = id;
                this.products = products;
            }

            private Delivery(int id, Product[] products, string address, DateTime Date)
            {
                this.address= address;
                this.Date = Date;
            }

            public static Option<Delivery> Create(int id, Product[] products, string address, DateTime Date) =>
                Some(new Delivery(id, products, address,Date));

            private static Option<Delivery> Some(Delivery delivery)
            {
                throw new NotImplementedException();
            }
        }
    }

}

