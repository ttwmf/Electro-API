using ElectroECommerce.Application.Contracts;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ElectroECommerce.Application.Implimentations
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserName => _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "name").Value;

        //public string AccessToken => _httpContextAccessor.HttpContext?.User?.FindFirstValue("access_token");
    }
}
