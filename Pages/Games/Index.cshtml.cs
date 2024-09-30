using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesGame.Data;
using VideoGameDatabase.Models;

namespace VideoGameDatabase.Pages_Games
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGame.Data.RazorPagesGameContext _context;

        public IndexModel(RazorPagesGame.Data.RazorPagesGameContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
