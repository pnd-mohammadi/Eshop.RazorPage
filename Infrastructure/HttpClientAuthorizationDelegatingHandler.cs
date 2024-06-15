using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net;

namespace Eshop.RazorPage.Infrastructure;

public class HttpClientAuthorizationDelegatingHandler : DelegatingHandler
{

    private readonly IHttpContextAccessor _httpContextAccessor;

    public HttpClientAuthorizationDelegatingHandler(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (_httpContextAccessor.HttpContext != null)
        {
            var token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

            if (string.IsNullOrWhiteSpace(token) == false)
            {
                request.Headers.Add("Authorization", token);
            }

        }

        return await base.SendAsync(request, cancellationToken);
    }
    //private readonly IHttpContextAccessor _httpContextAccessor;

    //public HttpClientAuthorizationDelegatingHandler(IHttpContextAccessor httpContextAccessor)
    //{
    //    _httpContextAccessor = httpContextAccessor;
    //}

    //protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    //{


    //    if (_httpContextAccessor.HttpContext != null)
    //    {
    //        var token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

    //        if (string.IsNullOrWhiteSpace(token) == false)
    //        {
    //            request.Headers.Add("Authorization", token);

    //           // request.Headers.Authorization.Parameter.Contains("Authorization");
    //        }
    //        //if (string.IsNullOrWhiteSpace(token))

    //        //    return new HttpResponseMessage(HttpStatusCode.Unauthorized);

    //    }
    //    return await base.SendAsync(request, cancellationToken);
    //}
}

