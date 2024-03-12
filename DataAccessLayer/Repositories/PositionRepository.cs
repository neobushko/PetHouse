using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class PositionRepository : IRepository<Position>
{
    private PetHouseContext _context;

    public PositionRepository(PetHouseContext context)
    {
        _context = context;
    }

    public async Task<Guid> AddAsync(Position position)
    {
        await _context.Positions.AddAsync(position);
        var result = await _context.SaveChangesAsync();
        return result > 0 ? position.Id : Guid.Empty;
    }

    public async Task<IEnumerable<Position>> GetAllAsync()
    {
        return _context.Positions;
    }

    public async Task<Position?> GetAsync(Guid id)
    {
        return await _context.Positions.FirstOrDefaultAsync(position => position.Id == id);
    }

    public async Task<bool> UpdateAsync(Position position)
    {
        _context.Update(position);

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Delete(Guid id)
    {
        var position = await _context.Positions.FirstAsync(x => x.Id == id);

        position.IsActive = false;
        _context.Update(position);
        var result = await _context.SaveChangesAsync();
        return result > 0;
    }
}
