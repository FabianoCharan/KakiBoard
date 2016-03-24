using System;

namespace KakiBoard.SharedKernel.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
