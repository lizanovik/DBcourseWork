using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;

namespace DAL_core.Repositories
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
