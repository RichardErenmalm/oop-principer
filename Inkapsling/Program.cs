namespace Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("username", "password");

            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
        }
    }
}
