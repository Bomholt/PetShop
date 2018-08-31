using Bomholt.PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bomholt.Petshop.Infrastructure.Data.Repositories
{
    public class FakeDb
    {
        //public List<Pet> MyProperty { get; set; }
        public List<Pet> pets = new List<Pet>();
    }
}
