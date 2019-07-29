namespace LoggingKata
{
    public class TacoBell : ITrackable

    {
        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
//From TacoParser to ITRackable and Point