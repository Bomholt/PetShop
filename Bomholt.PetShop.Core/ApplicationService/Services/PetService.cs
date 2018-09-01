using System.Linq;
using System.Collections.Generic;
using Bomholt.PetShop.Core.DomainService;
using Bomholt.PetShop.Core.Entities;

namespace Bomholt.PetShop.Core.ApplicationService.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _PetRepo;

        public PetService(IPetRepository PetRepo)
        {
            _PetRepo = PetRepo;
        }

        public List<Pet> GetAllPets()
        {
            return _PetRepo.GetAllPets().ToList();
        }
    }
}
