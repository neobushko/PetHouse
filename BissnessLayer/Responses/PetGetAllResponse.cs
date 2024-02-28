using Core.Enums;

namespace BissnessLayer.Responses;

public record PetGetAllResponse(Guid Id, string Name, AnimalClasses AnimalClass);
