using DataAccessLayer.Models;

namespace BissnessLayer.DTOs;

public class PositionDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public float SalaryRate { get; set; }

    public IEnumerable<VolunteerDTO> Volunteers { get; set; }
}
