using AsyncWeb.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public interface IAmenityRepository
    {

        Task<IEnumerable<Amenity>> GetAllAmenities();
        Task CreateAmenity(Amenity amenity);
        Task<Amenity> GetAmenity(int id);
        Task<bool> UpdateAmenity(Amenity amenity);
    }


    public class DatabaseAmenityRepository : IAmenityRepository
    {
        private readonly SchoolDbContext _context;

        public DatabaseAmenityRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(IAmenityRepository amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Amenity>> GetAllAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenity> GetAmenity(int id)
        {
            return await _context.Amenities.FindAsync(id);
        }

        public async Task<bool> UpdateAmenity(IAmenityRepository amenity)
        {
            _context.Entry(amenity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenityExists(amenity.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

        }

        private bool AmenityExists(object id)
        {
            throw new NotImplementedException();
        }
    }










}
