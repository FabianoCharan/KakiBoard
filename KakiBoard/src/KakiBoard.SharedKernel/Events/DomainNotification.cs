using System;
using KakiBoard.SharedKernel.Events.Contracts;

namespace KakiBoard.SharedKernel.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DataOcorrencia { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.DataOcorrencia = DateTime.Now;
        }
    }
}
