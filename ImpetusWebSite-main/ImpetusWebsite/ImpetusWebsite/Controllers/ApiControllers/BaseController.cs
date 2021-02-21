using ImpetusWebsite.Areas.Identity.Data;
using ImpetusWebsite.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpetusWebsite.Controllers.ApiControllers
{
    public class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;

        protected readonly ImpetusContext _context;

        public BaseController(ILogger<BaseController> logger, ImpetusContext context)
        {
            _logger = logger;
            _context = context;
        }
        protected AppUser GetUserByString(string name)
        {
            AppUser user = _context.Users.FirstOrDefault(x => x.UserName.Any(y => y.Equals(name)));
            return user;
        }
    }
}
