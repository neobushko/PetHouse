using Core.Enums;

namespace BissnessLayer.DTOs;

public class PetDTO
{
    public Guid Id { get; set; }

    public AnimalClasses AClass { get; set; }

    public string Name { get; set; }

    public MedicalStatuses MStatus { get; set; }

    public IEnumerable<MedicalCardDTO> MedicalCards { get; set; }

    public IEnumerable<VolunteerPetDTO> VolunteerPets { get; set; }
}
