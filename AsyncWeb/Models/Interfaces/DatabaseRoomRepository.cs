using AsyncWeb.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public class DatabaseRoomRepository : IRoomRepository
    {
        private readonly HotelDbContext _context;

        public DatabaseRoomRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task<bool> UpdateRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(room.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        private bool RoomExists(int id)
        {
            throw new NotImplementedException();
        }



        // ====== Amenities ======

        // Add the logic for the methods (add/remove amenities) into your RoomRepository.cs Service
        public Task RemoveAmenityFromRoom(int roomId, int amenityId)
        {
            throw new NotImplementedException();
        }

        public Task AddAmenityToRoom(int roomId, int amenityId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }
    }
}



