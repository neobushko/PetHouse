using AutoMapper;
using BissnessLayer.DTOs;
using BissnessLayer.Interfaces;
using BissnessLayer.Services.PetChangeName;
using Core.Enums;
using Core.Exceptions;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;

namespace BissnessLayer.Services;

public class PetService : IPetService
{
    private readonly IMapper _mapper;
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository, IMapper mapper)
    {
        _petRepository = petRepository;
        _mapper = mapper;
    }

    public async Task<Guid> AddPet(PetDTO petDTO)
    {
        petDTO.Id = Guid.NewGuid();
        petDTO.MedicalCards = null;
        petDTO.VolunteerPets = null;

        var pet = _mapper.Map<Pet>(petDTO);

        return await _petRepository.AddPetAsync(pet);
    }

    public async Task<bool> ChangeName(ChangeNameRequest request)
    {
        var pet = await _petRepository.GetPetAsync(request.PetId)
            ?? throw new EntityNotFoundException($"Pet with provided Id: {request.PetId} not found");

        pet.Name = request.NewName;
        return await _petRepository.UpdatePetAsync(pet);
    }

    public Task<bool> ChangeStatus(Guid petId, MedicalStatuses newStatus)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PetDTO>> GetAllPets()
    {
        throw new NotImplementedException();
    }

    public async Task<PetDTO> GetPet(Guid petId)
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
