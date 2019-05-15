using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;

namespace DAL_core.Repositories
{
    class UserRepository : Repository<User>, IUserRepository
    {
        private readonly EBooksContext _context;
        public UserRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
    }
}