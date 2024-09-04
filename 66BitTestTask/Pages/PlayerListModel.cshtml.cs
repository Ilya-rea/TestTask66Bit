using _66BitTestTask.Data;
using _66BitTestTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _66BitTestTask.Pages
{
    public class PlayerListModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public PlayerListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Player> Players { get; set; }

        public async Task OnGetAsync()
        {
            Players = await _context.Players.Include(p => p.Team).ToListAsync();
        }

        
    }
}
