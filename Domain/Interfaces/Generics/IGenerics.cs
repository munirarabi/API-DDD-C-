namespace Domain.Interfaces.Generics
{
    public interface IGenerics<T> where T : class
    {
        Task Insert(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task SearhById(int Id);
        Task<List<T>> List();
    }
}
