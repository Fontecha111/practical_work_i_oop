using System;

namespace practicalwork
{
    public class Station
    {
        private List<Train> trains;
        private List<Platform> platforms;

        public Station(int numberOfPlatforms)
        {
            trains = new List<Train>();
            platforms = new List<Platform>();

            for (int i = 1; i <= numberOfPlatforms; i++)
            {
                platforms.Add(new Platform("P" + i));
            }
        }

        public void LoasTrainsFromFile()
        {

        }

        public void AdvanceTick()
        {
            foreach (var train in trains)
            {
                if (train.getStatus() == Status.EnRoute)
                {

                }
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine("----Train Status----");
            foreach (var train in trains)
            {
                Console.WriteLine(train.ShowInfo());
            }

            Console.WriteLine("----Platform Status----");
            foreach (var platform in platforms)
            {
                Console.WriteLine(platform.ShowInfo());
            }
        }
    }
}