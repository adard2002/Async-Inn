using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsyncWeb.Data;
using AsyncWeb.Models;
using AsyncWeb.Models.Interfaces;

namespace AsyncWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly HotelDbContext _context;
        private readonly IRoomRepository roomRepository;

        public RoomsController(HotelDbContext context, IRoomRepository roomRepository)
        {
            _context = context;
            this.roomRepository = roomRepository;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRoom()
        {
            return await _context.Rooms.ToListAsync();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")] // put means to update
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost] //post means to add
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return NoContent();
        }




        // ====== Adding Amenities to Hotel ======

        // TODO: Create 2 routes. 1 for POST and 1 for DELETE
        [Route("{roomId}/Amenity/{amenityId}")] // check keiths code on the repo


        [HttpPost]
        public async Task<ActionResult> AddAmenityToRoom(int roomId, int amenityId)
        {
            if (!await roomRepository.AddAmenityToRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }


        [Route("{roomId}/Amenity/{amenityId}")] // check keiths code on the repo

        [HttpDelete]
        public async Task<ActionResult> DeleteAmenityFromRoom(int roomId, int amenityId)
        {
            if (!await roomRepository.RemoveAmenityFromRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }

        private bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }


    }
}
