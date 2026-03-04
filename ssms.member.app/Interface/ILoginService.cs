public interface ILoginService
{
    Task<bool> ValidateStaff(string username, string password);
}