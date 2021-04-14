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
        //private readonly HotelDbContext _context;
        IRoomRepository _roomRepository;

        public RoomsController(IRoomRepository roomRepository)
        {
            //_context = context;
            //this.roomRepository = roomRepository;
            _roomRepository = roomRepository;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetAllRooms()
        {
            var room = await _roomRepository.GetAllRooms();
            return Ok(room);
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _roomRepository.GetRoom(id);

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

            if (!await _roomRepository.UpdateRoom(room))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost] //post means to add
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            await _roomRepository.CreateRoom(room);

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomRepository.DeleteRoom(id);
            
                return NotFound();
        }



        // ====== Adding Amenities to Hotel ======

        // TODO: Create 2 routes. 1 for POST and 1 for DELETE
        //[Route("{roomId}/Amenity/{amenityId}")] // check keiths code on the repo


        [HttpPost("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> AddAmenityToRoom(int roomId, int amenityId)
        {
            if (!await _roomRepository.AddAmenityToRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }


        //[Route("{roomId}/Amenity/{amenityId}")] // check keiths code on the repo

        [HttpDelete("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> DeleteAmenityFromRoom(int roomId, int amenityId)
        {
            if (!await _roomRepository.RemoveAmenityFromRoom(roomId, amenityId))
            {
                return NotFound();
            }

            return NoContent();
        }


    }
}
