using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Practical.Application.Interfaces;
using Practical.Application.Interfaces.Auth;
using Practical.Application.Services;
using Practical.Application.Services.Auth;
using PracticalApplication.Domain.Auth;
using PracticalApplication.Domain.Interfaces;
using PracticalApplication.Domain.Interfaces.Auth;
using PracticalApplication.Domain.Services;
using System.Text;

namespace Practical.Application
{
    public static class DependenciInjeccionProfile
    {
        public static IServiceCollection AddServiceApplication(this IServiceCollection service)
        {
            service.AddTransient<ICustomerPolicyApplication, CustomerPolicyApplication>();
            service.AddTransient<IAuthLogin, AuthLogin>();
            return service;
        }

        public static IServiceCollection AddServiceDomain(this IServiceCollection service)
        {
            service.AddTransient<ICustomerPolicyDomain, CustomerPolicyDomain>();
            service.AddTransient<IAuthentication, Authentication>();
            return service;
        }

        public static IServiceCollection AddServiceMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return service;
        }

        public static IServiceCollection AddAuthenticationService(this IServiceCollection service, IConfiguration config)
        {

            var key = Encoding.ASCII.GetBytes(config.GetSection("keyToken").Value!);

            service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {

                options.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });

            return service;
        }

    }
}
