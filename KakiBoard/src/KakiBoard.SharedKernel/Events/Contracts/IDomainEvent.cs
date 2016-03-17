using System;

namespace KakiBoard.SharedKernel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DataOcorrencia { get; }
    }
}
