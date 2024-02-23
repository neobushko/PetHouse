using Core.Enums;

namespace DataAccessLayer.Models
{
    public class Pet
    {
        public Guid Id { get; set; }

        public AnimalClasses AClass { get; set; }

        public string Name { get; set; }

        public MedicalStatuses MStatus { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<MedicalCard> MedicalCards { get; set; }

        public IEnumerable<VolunteerPet> VolunteerPets { get; set; }
    }
}
