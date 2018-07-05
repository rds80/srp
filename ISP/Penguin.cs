using static System.Console;
using srp.ISP.Interfaces;

namespace srp.ISP
{
    public class Penguin : IEat, IWalkable
    {
        public void Eat(string food)
        {
            WriteLine($"Penguin is eating {food}");
        }

        public void Walk(int distance)
        {
            WriteLine($"Penguin walking in a funny way for {distance} miles");
        }
    }
}