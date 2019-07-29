using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized");

            var lines = File.ReadAllLines(csvPath);

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable TacoBell1 = null;
            ITrackable TacoBell2 = null;
            double distance = 0;
            for (int i = 0; i < 237; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    ITrackable LocationA = locations[i];
                    var corA = new GeoCoordinate(LocationA.Location.Latitude, LocationA.Location.Longitude);
                    ITrackable LocationB = locations[k];
                    var corB = new GeoCoordinate(LocationB.Location.Latitude, LocationB.Location.Longitude);
                    double distanceTest = corA.GetDistanceTo(corB);

                    if (distanceTest > distance)
                    {
                        TacoBell1 = LocationA;
                        TacoBell2 = LocationB;
                        distance = distanceTest;
                    }
                }
            }
            Console.WriteLine(TacoBell1.Name, TacoBell2.Name);

            // TODO:  Find the two Taco Bells in Alabama that are the furthest from one another.
            // HINT:  You'll need two nested forloops
        }   

    }
}