using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

[ApiController]
[Route("api/[controller]/[action]")]
public class LoginController : ControllerBase
{
    private readonly ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost("ValidateStaff")]
    public async Task<IActionResult> ValidateStaffAsync()
    {
        bool isSuccess = true;

        try
        {
            return Ok(new
            {
                isSuccess
            });
        }
        catch(Exception ex)
        {
            isSuccess = false;
            return Ok(new { isSuccess });
        }
    }
}