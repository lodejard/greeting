using Example.Hello;

namespace Example.World
{
    public class Greeting : IGreeting
    {
        public string CreateGreeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
