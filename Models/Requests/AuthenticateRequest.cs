using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Requests
{
    public class AuthenticateRequest
    {
        [MinLength(5)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(256)]
        [MinLength(8)]
        public string Password { get; set; }
    }
}