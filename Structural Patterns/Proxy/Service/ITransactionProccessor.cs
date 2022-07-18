using Proxy.Model;

namespace Proxy.Service
{
    public interface ITransactionProccessor
    {
        Task<string> ProcessAsync(TransactionItem transactionItem);
    }
}
