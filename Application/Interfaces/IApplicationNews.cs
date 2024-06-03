using Application.Interfaces.Generics;
using Entityes.Entityes;

namespace Application.Interfaces
{
    public interface IApplicationNews : IGenericApplication<News>
    {
        Task InsertNews(News news);
        Task UpdateNews(News news);
        Task<List<News>> ListNewsActive();
    }
}
