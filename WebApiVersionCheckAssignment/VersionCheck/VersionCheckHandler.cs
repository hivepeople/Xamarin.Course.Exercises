using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;

namespace WebApiVersionCheckAssignment.VersionCheck
{
    public class VersionCheckHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;

            // Do we have any X-Version headers?
            if (request.Headers.Any(h => h.Key == "X-Version"))
            {
                // Grab first X-Version header
                var versionHeader = request.Headers.First(h => h.Key == "X-Version");

                // Grab first value of that X-Version header
                var version = versionHeader.Value.FirstOrDefault();

                // Is that value equal to our magic version value?
                if (version != null && version == "42")
                {
                    // Execute remainder of chain, thus generating a response
                    response = await base.SendAsync(request, cancellationToken);
                }
            }

            // If we get here, the version header was incorrect or missing, so create
            // a response saying "I'm a teapot" (we like confusing errors)
            if (response == null)
            {
                // Create a response by using the built-in StatusCodeResult class
                var result = new StatusCodeResult((HttpStatusCode)418, request);
                response = await result.ExecuteAsync(cancellationToken);
            }

            // Return response, which will either be result of invoking rest of chain
            // or our error response
            return response;
        }
    }
}