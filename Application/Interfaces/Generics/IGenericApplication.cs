namespace Application.Interfaces.Generics
{
    public interface IGenericApplication <T> where T : class
    {
        Task Insert(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task SearhById(int Id);
        Task<List<T>> List();
    }
}
