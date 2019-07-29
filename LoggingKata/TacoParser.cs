using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            //logger.LogInfo("Begin parsing");
            TacoBell trackableTacoBell = new TacoBell();
            Point Location = new Point();
            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                return null;
            }

            
            
            Location.Latitude = double.Parse(cells[0]);
            Location.Longitude = double.Parse(cells[1]);
            string name = cells[2];

            trackableTacoBell.Name = name;
            trackableTacoBell.Location = Location;
            
            return trackableTacoBell;
        }
    }
}