using Application.Interfaces;
using Application.Interfaces.Generics;
using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Entityes.Entityes;

namespace Application.Applications
{
    public class ApplicationNews : IApplicationNews
    {
        INews _INews;
        IServiceNews _IServiceNews;

        public ApplicationNews(INews INews, IServiceNews IServiceNews)
        {
            _INews = INews;
            _IServiceNews = IServiceNews;
        }

        public async Task Delete(News Objeto)
        {
            await _INews.Delete(Objeto);
        }

        public async Task Insert(News Objeto)
        {
            await _INews.Insert(Objeto);
        }

        public async Task InsertNews(News news)
        {
            await _IServiceNews.InsertNews(news);
        }

        public async Task<List<News>> List()
        {
            return await _INews.List();
        }

        public async Task<List<News>> ListNewsActive()
        {
            return await _IServiceNews.ListNewsActive();
        }

        public async Task<News> SearhById(int Id)
        {
            return await _INews.SearhById(Id);
        }

        public async Task Update(News Objeto)
        {
            await _INews.Update(Objeto);
        }

        public async Task UpdateNews(News news)
        {
            await _IServiceNews.UpdateNews(news);
        }

        Task IGenericApplication<News>.SearhById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
