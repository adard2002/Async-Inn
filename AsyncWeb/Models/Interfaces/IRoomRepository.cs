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

    }


}
