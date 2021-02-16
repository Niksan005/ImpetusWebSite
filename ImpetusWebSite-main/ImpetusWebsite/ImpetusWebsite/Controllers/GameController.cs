using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ImpetusWebsite.Areas.Identity.Data;
using ImpetusWebsite.Data;

namespace ImpetusWebsite.Controllers
{
    public class GameController : Controller
    {
        private readonly ImpetusContext _context;

        public GameController(ImpetusContext context)
        {
            _context = context;
        }

        // GET: Game
        public async Task<IActionResult> Index()
        {
            return View(await _context.Matchs.ToListAsync());
        }

    }
}
