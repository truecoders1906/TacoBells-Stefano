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
            logger.LogInfo("Begin parsing");
            var cells = line.Split(',');
            if (cells.Length < 3)
            {
            return null; // TODO Implement  
            // Do not fail if one record parsing fails, return null
            }
            else if()
            double latitude, longitude;
            double.TryParse(cells[0], out latitude);
            double.TryParse(cells[1], out longitude);
            string name = cells[2];
        }
    }
}