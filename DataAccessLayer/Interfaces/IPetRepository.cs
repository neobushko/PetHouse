using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IPetRepository
    {
        public Task<Guid> AddPetAsync(Pet pet);

        public Task<bool> UpdatePetAsync(Pet pet);

        public Task<Pet?> GetPetAsync(Guid id);

        public Task<IEnumerable<Pet>> GetAllPetsAsync();

        public Task<bool> DeletePet(Guid id);
    }
}
