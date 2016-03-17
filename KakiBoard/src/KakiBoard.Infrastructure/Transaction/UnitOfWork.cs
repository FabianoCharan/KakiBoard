using KakiBoard.Infrastructure.Context;
using KakiBoard.SharedKernel.Repositories;

namespace KakiBoard.Infrastructure.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private KakiBoardContext _context;

        public UnitOfWork(KakiBoardContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_context != null)
                {
                    //_context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
