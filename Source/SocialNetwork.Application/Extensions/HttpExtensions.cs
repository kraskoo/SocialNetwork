namespace SocialNetwork.Application.Extensions
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Models.ApplicationEntities;

    public static class HttpExtensions
    {
        public static SignInManager<User> SignInManager(this HttpContext context)
        {
            return context.RequestServices.GetRequiredService<SignInManager<User>>();
        }
    }
}