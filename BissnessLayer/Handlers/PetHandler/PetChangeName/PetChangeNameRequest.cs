namespace BissnessLayer.Handlers.PetHandler.PetChangeName;

public record PetChangeNameRequest(Guid PetId, string NewName);
