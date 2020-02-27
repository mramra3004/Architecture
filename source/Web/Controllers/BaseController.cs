using Architecture.CrossCutting.Enums;
using Architecture.Model.Sign;
using DotNetCore.AspNetCore;
using DotNetCore.Extensions;
using DotNetCore.Results;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Web.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected SignedInModel SignedInModel => new SignedInModel
        {
            UserId = User.Id(),
            Roles = User.RolesFlag<Roles>()
        };

        public static IActionResult Result(IResult result)
        {
            return ApiResult.Create(result);
        }

        public static IActionResult Result(object data)
        {
            return ApiResult.Create(data);
        }
    }
}
