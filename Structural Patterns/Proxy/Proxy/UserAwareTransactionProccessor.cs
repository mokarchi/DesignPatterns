using Proxy.Model;
using Proxy.Service;

namespace Proxy.Proxy
{
    public class UserAwareTransactionProccessor : ITransactionProccessor
    {
        private readonly ITransactionProccessor _transactionProccessor;
        private readonly IUserContext _userContext;

        public UserAwareTransactionProccessor(ITransactionProccessor transactionProccessor, IUserContext userContext)
        {
            _transactionProccessor = transactionProccessor;
            _userContext = userContext;
        }

        public async Task<string> ProcessAsync(TransactionItem transactionItem)
        {
            if (_userContext.CurrentUser.AcceptanceLevel < AcceptanceLevel.Level2)
            {
                return "Current user has not sufficient privileges";
            }
            return await _transactionProccessor.ProcessAsync(transactionItem);
        }
    }

    public interface IUserContext
    {
        AppUser CurrentUser { get; }
    }

    public class UserContext : IUserContext
    {
        public AppUser CurrentUser => new() { AcceptanceLevel = AcceptanceLevel.Level3 };
    }

    public class AppUser
    {
        public AcceptanceLevel AcceptanceLevel { get; set; }
    }
}
