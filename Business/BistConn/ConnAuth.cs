using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BistConn
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    abstract public class ConnAuth : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var auth = context.HttpContext.Request.Headers["Authorization"].ToString();

            if (string.IsNullOrWhiteSpace(auth))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            var decodeUserAndPass = auth.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries)[1]?.Trim();
            var encodeUser = Encoding.UTF8.GetString(Convert.FromBase64String(decodeUserAndPass));

            var user = encodeUser.Split(':');

            if (user[0].Equals("root") && user[1].Equals("root"))
                Console.WriteLine("");
            else
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
   

