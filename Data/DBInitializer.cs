using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CashDrawer.Models;

namespace CashDrawer.Data
{
    public static class DbInitializer
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CashDrawerContext(serviceProvider.GetRequiredService<DbContextOptions<CashDrawerContext>>()))
            {
              // Look for any products.
              if (context.Product.Any())
              {
                  return;   // DB has been seeded
              }
              var orders = new Order[]
              {
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 25, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 25, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.16482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 26, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 26, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 27, 1, 38, 20, TimeSpan.FromHours(-6)),
                        SubTotal = 6.27,
                        Tax = 0.579975
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 27, 6, 16, 54, TimeSpan.FromHours(-6)),
                        SubTotal = 11.24,
                        Tax = 1.0397
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 28, 6, 16, 06, TimeSpan.FromHours(-6)),
                        SubTotal = 11.48,
                        Tax = 1.0619
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 28, 6, 16, 13, TimeSpan.FromHours(-6)),
                        SubTotal = 5.380000000000001,
                        Tax = 0.49765000000000004
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 29, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 29, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.16482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 30, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2016, 12, 30, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 01, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 01, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.17482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 01, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 01, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 01, 1, 38, 20, TimeSpan.FromHours(-6)),
                        SubTotal = 6.27,
                        Tax = 0.579975
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 02, 7, 16, 54, TimeSpan.FromHours(-6)),
                        SubTotal = 11.24,
                        Tax = 1.0397
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 02, 7, 17, 06, TimeSpan.FromHours(-6)),
                        SubTotal = 11.48,
                        Tax = 1.0619
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 02, 7, 17, 13, TimeSpan.FromHours(-6)),
                        SubTotal = 5.380000000000001,
                        Tax = 0.49765000000000004
                    }, 
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 03, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 03, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.17482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 03, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 03, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 03, 1, 38, 20, TimeSpan.FromHours(-6)),
                        SubTotal = 6.27,
                        Tax = 0.579975
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 04, 7, 16, 54, TimeSpan.FromHours(-6)),
                        SubTotal = 11.24,
                        Tax = 1.0397
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 04, 7, 17, 06, TimeSpan.FromHours(-6)),
                        SubTotal = 11.48,
                        Tax = 1.0619
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 04, 7, 17, 13, TimeSpan.FromHours(-6)),
                        SubTotal = 5.380000000000001,
                        Tax = 0.49765000000000004
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 05, 7, 16, 54, TimeSpan.FromHours(-6)),
                        SubTotal = 11.24,
                        Tax = 1.0397
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 05, 7, 17, 06, TimeSpan.FromHours(-6)),
                        SubTotal = 11.48,
                        Tax = 1.0619
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 05, 7, 17, 13, TimeSpan.FromHours(-6)),
                        SubTotal = 5.380000000000001,
                        Tax = 0.49765000000000004
                    },  
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 06, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 06, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.17482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 06, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 06, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 06, 1, 38, 20, TimeSpan.FromHours(-6)),
                        SubTotal = 6.27,
                        Tax = 0.579975
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 07, 0, 04, 31, TimeSpan.FromHours(-6)),
                        SubTotal = 2.25,
                        Tax = 0.208125
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 07, 0, 13, 59, TimeSpan.FromHours(-6)),
                        SubTotal = 1.89,
                        Tax = 0.17482499999999998
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 07, 0, 49, 47, TimeSpan.FromHours(-6)),
                        SubTotal = 2.49,
                        Tax = 0.23032500000000003
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 07, 0, 53, 37, TimeSpan.FromHours(-6)),
                        SubTotal = 7.67,
                        Tax = 0.7094750000000001
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 07, 1, 38, 20, TimeSpan.FromHours(-6)),
                        SubTotal = 6.27,
                        Tax = 0.579975
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 09, 7, 16, 54, TimeSpan.FromHours(-6)),
                        SubTotal = 11.24,
                        Tax = 1.0397
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 09, 7, 17, 06, TimeSpan.FromHours(-6)),
                        SubTotal = 11.48,
                        Tax = 1.0619
                    },
                    new Order {
                        TimeStamp = new DateTimeOffset(2017, 01, 09, 7, 17, 13, TimeSpan.FromHours(-6)),
                        SubTotal = 5.380000000000001,
                        Tax = 0.49765000000000004
                    }
              };

              foreach (Order o in orders)
              {
                  context.Order.Add(o);
              }
              context.SaveChanges();

              var products = new Product[]
              {
                  new Product { 
                      Name = "Frito-Lay Chips Snack Size",
                      Price = 1.99,
                      Cost = 0.95,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Pepperoni Pizza Slice",
                      Price = 2.25,
                      Cost = 0.75,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Pepperoni Pizza Whole",
                      Price = 8.99,
                      Cost = 3.75,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Coke Products 20oz",
                      Price = 1.89,
                      Cost = 0.75,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Pepsi Products 20oz",
                      Price = 1.89,
                      Cost = 0.75,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Monster Energy 16oz",
                      Price = 2.49,
                      Cost = 1.19,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  },
                  new Product { 
                      Name = "Rockstar Energy 20oz",
                      Price = 2.89,
                      Cost = 1.25,
                      IsTaxable = true,
                      TaxRate = 0.0925,
                      Quantity = 100
                  }
                  
              };

              foreach (Product i in products)
              {
                  context.Product.Add(i);
              }
              context.SaveChanges();
          }
       }
    }
}