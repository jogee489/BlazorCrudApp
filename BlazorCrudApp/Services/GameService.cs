using BlazorCrudApp.Data;
using BlazorCrudApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudApp.Services
{
    public class GameService :IGameService
    {

        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}
