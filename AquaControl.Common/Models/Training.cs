namespace AquaControl.Common.Models
{
    public class Training
    {
        public int Id { get; set; }

        public int CoachId { get; set; }

        public string TrainingType { get; set; }

        public DateTime TrainingDate { get; set; }

        public int PoolLaneNumber { get; set; }
    }
}