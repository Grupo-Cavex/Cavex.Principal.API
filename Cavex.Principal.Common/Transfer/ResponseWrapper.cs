using System.Net;

namespace Cavex.Principal.Common.Transfer
{
    public class ResponseWrapper<T>
    {
        public HttpStatusCode StatusCode { get; set; }

        public string? Message { get; set; }

        public T? Data { get; set; }
    }
}
