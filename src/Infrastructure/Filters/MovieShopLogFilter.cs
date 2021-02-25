using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Infrastructure.Filters
{
    public class MovieShopLogFilter : IActionFilter
    {
        private readonly ICurrentUserService _currentUserService;

        public MovieShopLogFilter(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // context.HttpContext.Response.Headers.Add("ipaddress", _currentUserService.RemoteIpAddress);
            //var feature = context.HttpContext.Features.Get<IHttpConnectionFeature>();
            //var LocalIPAddr = feature?.LocalIpAddress?.ToString();

            // Log Remote address
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}