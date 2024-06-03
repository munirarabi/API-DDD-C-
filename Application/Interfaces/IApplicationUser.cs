namespace Application.Interfaces
{
    public interface IApplicationUser
    {
        Task<bool> InsertUser(
                              string email, 
                              string password, 
                              int age, 
                              string phone);
    }
}
