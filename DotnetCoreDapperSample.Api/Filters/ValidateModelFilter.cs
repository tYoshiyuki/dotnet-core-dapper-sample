using System.Linq;
using DotnetCoreDapperSample.Api.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCoreDapperSample.Api.Filters
{
    public class ValidateModelFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                // TODO 適切な形式で返却するようにする
                var msg = context.ModelState.SelectMany(x => x.Value.Errors)
                    .Select(x => x.ErrorMessage)
                    .Aggregate((x, y) => x + "," + y);
                throw new AppException(msg);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
