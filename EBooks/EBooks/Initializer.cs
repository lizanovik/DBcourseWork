using System.Linq;
using DAL.Entities;
using DAL.EntityFramework;

namespace EBooks
{
    public class Initializer
    {
        public static void Initialize(EBooksContext context)
        {
            if (!context.Suppliers.Any())
            {
                context.Suppliers.Add(
                    new Supplier()
                    {
                        CompanyName = "IBook",
                        Description = "One of the best seller for e-books",
                        Phone = "+375447682231",
                        Email = "lizanovik9873@gmail.com",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}