using System.IdentityModel.Tokens.Jwt;
using ClassLibrary1;
using ClassLibrary1.Repo;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentLogin:ControllerBase
{
    private readonly IStudentRepo _student;
    private readonly IConfiguration _configuration;
    private readonly JwtService _jwtService;
    public StudentLogin(IStudentRepo student,IConfiguration configuration,JwtService jwtService)
    {
        _student = student;
        _configuration = configuration;
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public ActionResult<LoginResponse> Login(string username, string password)
    {
        if (username == "admin" && password == "admin")
        {
            var token = _jwtService.GenerateToken(username);

            return Ok( new{token  = new JwtSecurityTokenHandler().WriteToken(token)});
        }
        else
        {
            throw new Exception("Invalid username or password");
 
        }
        
    }
    
}