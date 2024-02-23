namespace DataAccessLayer.Models
{
    public class VolunteerPet
    {
        public Guid Id { get; set; }

        public Guid PetId { get; set; }

        public Guid Volunteer { get; set; }
    }
}
