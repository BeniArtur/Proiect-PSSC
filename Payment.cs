using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt;
using PayPal.Api;
using static LanguageExt.Prelude;

namespace ConsoleApp1.Data
{
    public class Payment
    {
        public record Product(int Id, Quantity Quantity, PriceFinal PriceFinal, uint Price, DateTime Date);

        public record PriceFinal
        {
            public uint Final { get; }

            private PriceFinal(uint final)
            {
                Final = final;

            }
        }
            public record Invoice
            {
                private int id;
                private Product[] products;
                private double Total;
            private DateTime Date;

                private Invoice(int id, Product[] products)
                {
                    this.id = id;
                    this.products = products;
                }

                private Invoice(int id, Product[] products,double Total, DateTime Date)
                {
                    this.Total = Total;
                this.Date = Date;
                }

                public static Option<Invoice> Create(int id, Product[] products,double Total, DateTime Date) =>
                    Some(new Invoice(id, products,Total,Date));

            internal static object Create(int v1, Product[] products, int v2)
            {
                throw new NotImplementedException();
            }

            internal static object Create(int v1, Product[] products, int v2, int v3, int v4, int v5)
            {
                throw new NotImplementedException();
            }
        }
        }
    }

