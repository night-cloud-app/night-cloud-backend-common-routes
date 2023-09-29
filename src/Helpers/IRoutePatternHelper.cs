using Microsoft.AspNetCore.Routing;

namespace NightCloud.Common.Routes.Helpers;

public interface IRoutePatternHelper
{
    RouteValueDictionary GetRouteValues(string routePattern, string route);
    string SetRouteValuesIntoPattern(string routePattern, RouteValueDictionary routeValues);
}