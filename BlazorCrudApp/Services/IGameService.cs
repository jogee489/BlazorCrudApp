using BlazorCrudApp.Entity;

namespace BlazorCrudApp.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGamesAsync();
    }
}
