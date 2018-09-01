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

        public bool CreateNewPet(Pet newPet)
        {
           return _PetRepo.CreateNewPet(newPet);
        }

        public bool DeletePetById(int v)
        {
            return _PetRepo.DeletePetById(v);
        }

        public List<Pet> GetAllPets()
        {
            return _PetRepo.GetAllPets().ToList();
        }

        public bool UpdatePet(Pet updatedPet)
        {
            return _PetRepo.UpdatePet(updatedPet);
        }
    }
}
