namespace Logify
{
    public interface IAuthenticate
    {
        string GetFullName();
        bool isValidPassword(string password);
        bool isValidUserName(string userName);
    }
}