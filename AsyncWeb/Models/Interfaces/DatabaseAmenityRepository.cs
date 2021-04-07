using AsyncWeb.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public class DatabaseAmenityRepository : IAmenityRepository
    {
        private readonly SchoolDbContext _context;

        public DatabaseAmenityRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenities amenities)
        {
            _context.Amenities.Add(amenities);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Amenities>> GetAllAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenities> GetAmenity(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task<bool> UpdateAmenity(Amenities amenities)
        {
            _context.Entry(amenities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmentityExists(amenities.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool AmentityExists(int id)
        {
            return _context.Amenities.Any(e => e.Id == id);
        }
    }
}
