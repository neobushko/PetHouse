using AutoMapper;
using BissnessLayer.DTOs;
using DataAccessLayer.Models;

namespace PetHouseAPI.Profilers;

public class AutoMapperProfiler : Profile
{
    public AutoMapperProfiler()
    {
        CreateMap<Pet, PetDTO>().ReverseMap();
        CreateMap<MedicalCard, MedicalCardDTO>().ReverseMap();
        CreateMap<VolunteerPet, VolunteerPetDTO>().ReverseMap();
    }
}
