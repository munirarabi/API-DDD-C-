using Domain.Interfaces;
using Entityes.Entityes;
using Infra.Configurations;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infra.Repository
{
    public class RepositoryNews : RepositoryGenerics<News>, INews
    {
        private readonly DbContextOptions<Context> _optionsBuilder;

        public RepositoryNews()
        {
            _optionsBuilder = new DbContextOptions<Context>();
        }

        public async Task<List<News>> ListNews(Expression<Func<News, bool>> exNews)
        {
            using (var banco = new Context(_optionsBuilder))
            {
                return await banco.News.Where(exNews).AsNoTracking().ToListAsync();
            }
        }
    }
}
