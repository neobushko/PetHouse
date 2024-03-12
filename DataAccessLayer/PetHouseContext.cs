using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class PetHouseContext : DbContext
    {
        public DbSet<MedicalCard> MedicalCards { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<VolunteerDTO> Volunteers { get; set; }
        public DbSet<VolunteerPet> VolunteerPets { get; set; }

        public PetHouseContext(DbContextOptions<PetHouseContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
