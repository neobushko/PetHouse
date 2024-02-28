using AutoMapper;
using BissnessLayer.DTOs;
using BissnessLayer.Responses;
using DataAccessLayer.Models;

namespace PetHouseAPI.Profilers;

public class AutoMapperProfiler : Profile
{
    public AutoMapperProfiler()
    {
        CreateMap<Pet, PetDTO>().ReverseMap();
        CreateMap<MedicalCard, MedicalCardDTO>().ReverseMap();
        CreateMap<VolunteerPet, VolunteerPetDTO>().ReverseMap();
        CreateMap<Pet, PetGetAllResponse>()
            .ConstructUsing(pet => new PetGetAllResponse(pet.Id, pet.Name, pet.AClass));
    }
}
