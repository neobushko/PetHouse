using BissnessLayer.DTOs;
using BissnessLayer.Handlers.PositionHandler.PositionAdd;
using BissnessLayer.Handlers.PositionHandler.PositionChangeDescription;
using BissnessLayer.Handlers.PositionHandler.PositionChangeName;
using BissnessLayer.Handlers.PositionHandler.PositionChangeSalary;

namespace BissnessLayer.Interfaces;

public interface IPositionService
{
    public Task<Guid> AddPositionAsync(PositionAddRequest request);
    public Task<PositionDTO> GetPositionAsync(Guid positionId);
    public Task<IEnumerable<PositionDTO>> GetAllPositionsAsync();
    public Task<bool> ChangeSalaryRate(PositionChangeSalaryRateRequest request);
    public Task<bool> ChangeName(PositionChangeDescriptionRequest request);
    public Task<bool> ChangeDescription(PositionChangeNameRequest request);
}
