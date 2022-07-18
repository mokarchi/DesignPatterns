using Proxy.Model;
using Proxy.Service;

namespace Proxy.Middleware
{
    public class ClientCodeMiddleware
    {
        public ClientCodeMiddleware(RequestDelegate next) { }

        public async Task InvokeAsync(HttpContext context, ITransactionProccessor proccessor)
        {
            var transactionItem = new TransactionItem { Amount = 100 };
            var message = await proccessor.ProcessAsync(transactionItem);
            await context.Response.WriteAsync(message);
        }
    }
}
