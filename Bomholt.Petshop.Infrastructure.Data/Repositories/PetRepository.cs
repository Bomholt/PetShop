using Bomholt.PetShop.Core.DomainService;
using Bomholt.PetShop.Core.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Bomholt.Petshop.Infrastructure.Data.Repositories
{
    class PetRepository : IPetRepository

    {
        private static int id = 1;
        private List<Pet> _pets = new List<Pet>();

        public PetRepository()
        {
            _pets.Add(new Pet() { Name = "Iben", Color = "Black" });
            _pets.Add(new Pet() { Name = "Lars", Color = "Pink" });
            _pets.Add(new Pet() { Name = "Misser", Color = "White" });
            _pets.Add(new Pet() { Name = "Garfield", Color = "Orange" });
        }

        public IEnumerable<Pet> GetAllPets()
        {
            FakeDb.
            return _pets;
        }
    }
}
