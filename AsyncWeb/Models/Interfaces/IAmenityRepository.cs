using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncWeb.Models.Interfaces
{
    public interface IAmenityRepository
    {

        Task<IEnumerable<Amenities>> GetAllAmenities();
        Task CreateAmenity(Amenities amenities);
        Task<Amenities> GetAmenity(int id);
        Task<bool> AddAmenityToRoom(Amenities amenities);
    }
}
