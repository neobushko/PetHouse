namespace DataAccessLayer.Models
{
    public class Volunteer
    {
        public Guid Id { get; set; }

        public Guid PositionId { get; set; }

        public string Name { get; set; }

        public Position Position { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<VolunteerPet> VolunteerPets { get; set; }
    }
}
