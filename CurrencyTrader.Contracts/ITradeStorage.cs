using System.Collections.Generic;

namespace CurrencyTrader.Contracts
{
    public interface ITradeStorage
    {
        void Persist(IEnumerable<TradeRecord> trades);
    }
}