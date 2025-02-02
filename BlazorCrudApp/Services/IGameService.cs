using BlazorCrudApp.Entity;

namespace BlazorCrudApp.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGamesAsync();
        Task<Game> AddGame(Game game);
    }
}
