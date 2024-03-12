namespace DataAccessLayer.Models
{
    public class Position
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float SalaryRate { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<VolunteerDTO> Volunteers { get; set; }
    }
}
