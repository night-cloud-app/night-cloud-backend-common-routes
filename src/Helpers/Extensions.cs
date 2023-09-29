using Microsoft.Extensions.DependencyInjection;

namespace NightCloud.Common.Routes.Helpers;

public static class Extensions
{
    public static void AddRoutePatternHelper(this IServiceCollection services)
    {
        services.AddScoped<IRoutePatternHelper, RoutePatternHelper>();
    }
}