using System.ComponentModel.DataAnnotations;

namespace Cavex.Principal.Common.Transfer
{
    public class RequestWrapper<T>
    {
        [Required]
        public T ? Body { get; set; }
    }
}
