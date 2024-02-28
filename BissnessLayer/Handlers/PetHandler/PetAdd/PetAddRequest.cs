using Core.Enums;

namespace BissnessLayer.Handlers.PetHandler.PetAdd;

public record PetAddRequest(string Name, AnimalClasses AnimalClass, MedicalStatuses MedicalStatus);
