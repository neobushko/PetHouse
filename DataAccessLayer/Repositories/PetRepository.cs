using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class PetRepository : IPetRepository
    {
        private PetHouseContext _context;

        public PetRepository(PetHouseContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddPetAsync(Pet pet)
        {
            await _context.Pets.AddAsync(pet);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? pet.Id : Guid.Empty;
        }

        public async Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            return _context.Pets;
        }

        public async Task<Pet?> GetPetAsync(Guid id)
        {
            return await _context.Pets.FirstOrDefaultAsync(pet => pet.Id == id);
        }

        public async Task<bool> UpdatePetAsync(Pet pet)
        {
            //var petDb = await _context.Pets.FirstOrDefaultAsync(petDb => petDb.Id == pet.Id);
            //if (petDb != null)
            //{
            //    petDb.MStatus = pet.MStatus;
            //    petDb.AClass = pet.AClass;
            //    petDb.Name = pet.Name;

            //    _context.Update(petDb);
            //    await _context.SaveChangesAsync();
            //    return petDb;
            //}
            //return new Pet();

            _context.Update(pet);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeletePet(Guid id)
        {
            var pet = await _context.Pets.FirstAsync(x => x.Id == id);

            pet.IsActive = false;
            _context.Update(pet);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
