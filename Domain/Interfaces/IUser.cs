namespace Domain.Interfaces
{
    public interface IUser
    {
        Task<bool> InsertUser(string email, string password, int age, string phone);
    }
}
