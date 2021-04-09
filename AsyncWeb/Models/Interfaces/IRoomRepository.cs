using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task CreateRoom(Room room);
        Task<Room> GetRoom(int id);
        Task<bool> UpdateRoom(Room room);




        // AddAmenityToRoom(int roomId, int amenityId)
        Task CreateAmenity(int roomId, int amenityId);


        // RemoveAmentityFromRoom(int roomId, int amenityId)
        Task DeleteAmenity(int roomId, int amenityId);







    }


}
