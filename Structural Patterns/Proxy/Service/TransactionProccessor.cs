using Proxy.Model;

namespace Proxy.Service
{
    public class TransactionProccessor : ITransactionProccessor
    {
        public async Task<string> ProcessAsync(TransactionItem transactionItem)
        {
            // complex code responsible for processing...
            return "Transaction item has been processed!";
        }
    }
}
