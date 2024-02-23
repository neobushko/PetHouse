namespace BissnessLayer.Services.PetChangeName;

public record ChangeNameRequest(Guid PetId, string NewName);
