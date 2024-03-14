using ApiNet6.Interfaces;
using Domain.Models;
using Domain.Repository;

namespace ApiNet6.Services
{
    public class AlquilerServices : BaseRepository<Alquiler>, IAlquilerServices
    {
        public AlquilerServices(IRepository<Alquiler> repository) : base(repository)
        {

        }
    }
}
