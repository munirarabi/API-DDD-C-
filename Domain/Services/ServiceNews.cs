using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using Entityes.Entityes;

namespace Domain.Services
{
    public class ServiceNews : IServiceNews
    {
        private readonly INews _INews;

        public ServiceNews(INews INews)
        {
            _INews = INews;
        }

        public async Task InsertNews(News news)
        {
            var validateTitle = news.ValidatePropertyString(news.Title, "Title");
            var validateInformation = news.ValidatePropertyString(news.Information, "Information");

            if(validateTitle && validateInformation)
            {
                news.DateRegister = DateTime.Now;
                news.DateUpdate = DateTime.Now;
                news.Active = true;
                await _INews.Insert(news);
            }
        }

        public async Task UpdateNews(News news)
        {
            var validateTitle = news.ValidatePropertyString(news.Title, "Title");
            var validateInformation = news.ValidatePropertyString(news.Information, "Information");

            if (validateTitle && validateInformation)
            {
                news.DateRegister = DateTime.Now;
                news.DateUpdate = DateTime.Now;
                news.Active = true;
                await _INews.Update(news);
            }
        }

        public async Task<List<News>> ListNewsActive()
        {
            return await _INews.ListNews(n => n.Active);
        }
    }
}
