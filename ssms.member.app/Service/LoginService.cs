public class LoginService : ILoginService
{
    public LoginService()
    {}

    public async Task<bool> ValidateStaff(string username, string password)
    {
       return true;
    }
}