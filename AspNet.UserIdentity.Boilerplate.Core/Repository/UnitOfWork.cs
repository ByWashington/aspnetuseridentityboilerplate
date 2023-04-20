using AspNet.UserIdentity.Boilerplate.Core.IRepository;
using AspNet.UserIdentity.Boilerplate.Data;

namespace AspNet.UserIdentity.Boilerplate.Core.Repository
{
	public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
