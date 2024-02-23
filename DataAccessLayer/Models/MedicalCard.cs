using Core.Enums;

namespace DataAccessLayer.Models
{
    public class MedicalCard
    {
        public Guid Id { get; set; }

        public Guid PetId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public MedicalInsitutions MedicalInstitution { get; set; }

        public Pet Pet { get; set; }
    }
}
