using srp.ISP.Interfaces;
using static System.Console;

namespace srp.ISP
{
    public class Eagle : IEat, IWalkable, IFlyable
    {
        private int maxAlt = 2000;

        public void Eat(string food)
        {
            WriteLine($"Mighty eagle is eating {food}");
        }

        public void Fly(int distance, int altitude)
        {
            if (altitude < maxAlt)
            {
                WriteLine($"The eagle spreads its wings and flies up to {altitude} feet for {distance} miles");
            }
            else
            {
                WriteLine("Even eagles can't fly that high");
            }
        }

        public void Walk(int distance)
        {
            WriteLine($"Eagle is walking for {distance} miles");
        }
    }
}