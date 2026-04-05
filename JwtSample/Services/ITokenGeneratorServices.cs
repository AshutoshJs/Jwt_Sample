namespace JwtSample.Services
{
    public interface ITokenGeneratorServices
    {
        string GenerateToken(Users user, string password);
    }
}
