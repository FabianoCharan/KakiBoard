using System;
using System.Collections.Generic;
using KakiBoard.SharedKernel.Events.Contracts;

namespace KakiBoard.SharedKernel.Helpers.Contracts
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
