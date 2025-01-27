namespace ClassLibrary1;

public class LoginResponse
{
    public LoginResponse(string token, string message)
    {
        this.Token = token;
        this.Message = message;
    }
    string Token { get; set; }
    string Message { get; set; }
}