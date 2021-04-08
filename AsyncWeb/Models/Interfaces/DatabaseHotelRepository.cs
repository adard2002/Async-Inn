using AsyncWeb.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public class DatabaseHotelRepository : IHotelRepository
    {
        private readonly HotelDbContext _context;


        public DatabaseHotelRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteHotel(int id)
        {
            Hotel hotel = await GetHotel(id);
            if (hotel == null)
            {
                return false;
            }
            await DeleteHotel(hotel);
            return true;
        }

        private Task DeleteHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Hotel>> GetAllHotel()
        {
            /*
            return new[]
            {
            new Hotel{ City = "City of Mysteries", Country = "Country of Mystery", Id = 1, Name = "The uhhh room", Phone = "123 345 7442", State = "ScoobySnack", StreetAddress = "123 Mystery Street" },
            new Hotel{ City = "JOJOOO", Country = "Girly teen girl", Id = 2, Name = "Niceu Niceu Very Niceu", Phone = "109 876 5432", State = "Adventure of Bizarre", StreetAddress = "321 sesame street"},
            new Hotel{ City = "NightmareFun", Country = "La La Land", Id = 3, Name = "Chimkin of Nightmares", Phone = "111 222 3334", State = "fshh", StreetAddress = "456 elm street"}
            };
            */

            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotel(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

        public Task PutHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateHotel(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(hotel.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
        private bool HotelExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
