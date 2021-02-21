using ImpetusWebsite.Areas.Identity.Data;
using ImpetusWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpetusWebsite.Controllers.ApiControllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchResultController : BaseController
    {
        public MatchResultController(ILogger<BaseController> logger, ImpetusContext context)
            : base(logger, context)
        { }

        [HttpPost("result")]
        public void ChatUpdate(ICollection<string> players)
        {
            _context.Matchs.Add(new Match());
            var _match = _context.Matchs.Last();
            foreach (string player in players) {
                _context.UserMatchRelations.Add(new UserMatchRelation { 
                    ModelUser = GetUserByString(player),
                    ModelMatch = _match
                });
                var _rellation = _context.UserMatchRelations.Last();
                _context.Users.FirstOrDefault(x => x.Equals(player)).MatchHistory.Add(_rellation);
                _match.Players.Add(_rellation);
            }
        }


    }
}