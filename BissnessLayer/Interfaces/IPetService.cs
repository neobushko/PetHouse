using BissnessLayer.DTOs;
using BissnessLayer.Handlers.PetHandler.PetAdd;
using BissnessLayer.Handlers.PetHandler.PetChangeName;
using BissnessLayer.Handlers.PetHandler.PetChangeStatus;
using BissnessLayer.Responses;

namespace BissnessLayer.Interfaces;

public interface IPetService
{
    public Task<PetDTO> GetPetAsync(Guid petId);

    public Task<IEnumerable<PetGetAllResponse>> GetAllPetsAsync();

    public Task<bool> ChangeStatusAsync(PetChangeStatusRequest request);

    public Task<bool> ChangeNameAsync(PetChangeNameRequest request);

    public Task<Guid> AddPetAsync(PetAddRequest petDTO);
}
