using AutoMapper;
using BissnessLayer.DTOs;
using BissnessLayer.Handlers.PetHandler.PetAdd;
using BissnessLayer.Handlers.PetHandler.PetChangeName;
using BissnessLayer.Handlers.PetHandler.PetChangeStatus;
using BissnessLayer.Interfaces;
using BissnessLayer.Responses;
using Core.Exceptions;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BissnessLayer.Handlers.PetHandler;

public class PetService : IPetService
{
    private readonly IMapper _mapper;
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository, IMapper mapper)
    {
        _petRepository = petRepository;
        _mapper = mapper;
    }

    public async Task<Guid> AddPetAsync(PetAddRequest pet)
    {
        var petDb = new Pet()
        {
            Id = Guid.NewGuid(),
            Name = pet.Name,
            AClass = pet.AnimalClass,
            MStatus = pet.MedicalStatus,
        };

        return await _petRepository.AddPetAsync(petDb);
    }

    public async Task<bool> ChangeNameAsync(PetChangeNameRequest request)
    {
        var pet = await _petRepository.GetPetAsync(request.PetId)
            ?? throw new EntityNotFoundException($"Pet with provided Id: {request.PetId} not found");

        pet.Name = request.NewName;
        return await _petRepository.UpdatePetAsync(pet);
    }

    public async Task<bool> ChangeStatusAsync(PetChangeStatusRequest request)
    {
        var pet = await _petRepository.GetPetAsync(request.PetId)
            ?? throw new EntityNotFoundException($"Pet with provided Id: {request.PetId} not found");

        pet.MStatus = request.Status;
        return await _petRepository.UpdatePetAsync(pet);
    }

    public async Task<IEnumerable<PetGetAllResponse>> GetAllPetsAsync()
    {
        var allPets = await _petRepository.GetAllPetsAsync();
        if(allPets == null)
        {
            return new List<PetGetAllResponse>();
        }
        var s = _mapper.Map<IEnumerable<PetGetAllResponse>>(allPets);
        return s;
    }

    public async Task<PetDTO> GetPetAsync(Guid petId)
    {
        var pet = await _petRepository.GetPetAsync(petId);
        if (pet == null)
        {
            throw new EntityNotFoundException($"Pet with id: {petId} was not found");
        }

        var petDTO = _mapper.Map<PetDTO>(pet);

        return petDTO;
    }
}
