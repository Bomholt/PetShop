﻿using Bomholt.PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bomholt.PetShop.Core.ApplicationService
{
    public interface IPetService
    {
        //Read
        List<Pet> GetAllPets();
    }
}