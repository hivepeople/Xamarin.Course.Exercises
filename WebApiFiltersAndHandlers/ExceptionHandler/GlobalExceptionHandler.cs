using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace WebApiFiltersAndHandlers.ExceptionHandler
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public Task HandleAsync(
            ExceptionHandlerContext context,
            CancellationToken cancellationToken)
        {
            // 1. Check the exception type using context.Exception

            // 2. Set appropriate response using context.Result
            // (use helper classes like StatusCodeResponse)

            // 3. Return a finished task
            return Task.FromResult(1);  // <-- the result does not matter
        }
    }
}
