using Core.Enums;

namespace BissnessLayer.Handlers.PetHandler.PetChangeStatus;

public record PetChangeStatusRequest(Guid PetId, MedicalStatuses Status);
