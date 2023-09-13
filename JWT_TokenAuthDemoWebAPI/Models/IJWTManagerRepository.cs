namespace JWT_TokenAuthDemoWebAPI.Models
{
    public interface IJWTManagerRepository
    {
    
            Tokens Authenticate(Users users);
 
    }
}
