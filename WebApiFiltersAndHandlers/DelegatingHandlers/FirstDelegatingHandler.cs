using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApiFiltersAndHandlers.DelegatingHandlers
{
    public class FirstDelegatingHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // 1. Stuff you do here happens before request reaches controller - and filters
            Debug.WriteLine("First delegating handler - before filters and controller");

            // 2. Call the next link in the chain
            var response = await base.SendAsync(request, cancellationToken);

            // 3. Stuff you do here happens after request reaches controller - and filters
            Debug.WriteLine("First delegating handler - after filters and controller");

            // 4. Return a response to client
            return response;
        }
    }
}