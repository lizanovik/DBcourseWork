using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
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