using Entityes.Entityes;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceNews
    {
        Task InsertNews(News news);
        Task UpdateNews(News news);
        Task<List<News>> ListNewsActive();
    }
}
