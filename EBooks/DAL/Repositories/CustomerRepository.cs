using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly EBooksContext _context;
        public CustomerRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
    }
}
