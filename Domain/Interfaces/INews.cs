using Domain.Interfaces.Generics;
using Entityes.Entityes;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface INews : IGenerics<News>
    {
        Task<List<News>> ListNews(Expression<Func<News, bool>> exNews);
    }
}
