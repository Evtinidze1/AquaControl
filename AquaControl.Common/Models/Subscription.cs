namespace AquaControl.Common.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int VisitsCount { get; set; }
    }
}