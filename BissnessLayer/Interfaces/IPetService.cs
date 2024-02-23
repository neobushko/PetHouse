using BissnessLayer.DTOs;
using BissnessLayer.Services.PetChangeName;
using Core.Enums;

namespace BissnessLayer.Interfaces;

public interface IPetService
{
    public Task<PetDTO> GetPet(Guid petId);

    public Task<IEnumerable<PetDTO>> GetAllPets();

    public Task<bool> ChangeStatus(Guid petId, MedicalStatuses newStatus);

    public Task<bool> ChangeName(ChangeNameRequest request);

    public Task<Guid> AddPet(PetDTO petDTO);
}
