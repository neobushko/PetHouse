using Core.Enums;

namespace BissnessLayer.DTOs;

public class MedicalCardDTO
{
    public Guid Id { get; set; }

    public Guid PetId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public MedicalInsitutions MedicalInstitution { get; set; }

    public PetDTO Pet { get; set; }
}
