﻿using Bomholt.PetShop.Core.DomainService;
using Bomholt.PetShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomholt.Petshop.Infrastructure.Data.Repositories
{
    public class PetRepository : IPetRepository

    {
        private static int id = 1;
        public static IEnumerable<Pet> _pets = new List<Pet>();
        //Initislizing list in teh constructor
        public PetRepository()
        {
            var temp = _pets.ToList();
            temp.Add(new Pet() { Name = "Iben",Type = "Stray", Color = "Black", Birthdate = new DateTime(2011,05,15), PreviousOwner = "Hans Hansen", Price = 100 , ID = id++ });
            temp.Add(new Pet() { Name = "Lars", Type = "Pecker", Color = "Pink", Birthdate = new DateTime(2017, 11, 22), PreviousOwner = "Birthe Hansen", Price = 1000, ID = id++ });
            temp.Add(new Pet() { Name = "Misser", Type = "Snoop", Color = "White", Birthdate = new DateTime(2015, 01, 09), PreviousOwner = "Hans Ipsen", Price = 150.5, ID = id++ });
            temp.Add(new Pet() { Name = "Garfield", Type = "Fancy", Color = "Orange", Birthdate = new DateTime(2018, 09, 05), PreviousOwner = "Jens Jensen", Price = 1559.95, ID = id++ });
            _pets = temp;
        }

        public IEnumerable<Pet> GetAllPets()
        {
            
            return _pets;
        }

        public bool DeletePetById(int v)
        {
            bool success = false;
            var tempList = _pets.ToList();
            Pet DelPet = null;
            foreach (var item in tempList)
            {
                if (item.ID == v)
                {
                    DelPet = item;
                    success = true;
                }
            }
            if (DelPet != null)
            {
                tempList.Remove(DelPet);
            }
            
            _pets = tempList;
            return success;
        }
    }
}
