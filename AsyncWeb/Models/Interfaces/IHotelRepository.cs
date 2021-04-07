using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotel();

        Task CreateHotel(Hotel hotel);

        Task<Hotel> GetHotel(int id);
        Task DeleteHotel(int id);

        Task PutHotel(Hotel hotel);
        Task<bool> UpdateHotel(Hotel hotel);
    }
}
