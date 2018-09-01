using Bomholt.PetShop.Core.ApplicationService;
using Bomholt.PetShop.Core.Entities;
using Bomholt.PetShop.UI.InterF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bomholt.PetShop.UI
{
    class Logic : ILogic 
    {
        private IPetService _petService;

        public Logic(IPetService petService)
        {
            _petService = petService;
        }

        public void Exit()
        {
            Console.Clear();
            for (int i = 0; i < 327; i++)
            {
                Console.Write("       EXIT");
                Thread.Sleep(1);
            }
        }

        public void ShowAllPests()
        {
            var list = _petService.GetAllPets();
            PrintListOfPets(list);

        }

        private void PrintListOfPets(List<Pet> list)
        {
            Console.WriteLine("\nPESTS:\n");
            Console.WriteLine(" | {0}| {1}| {2}| {3}| {4}| {5}| {6}| {7}| ", "ID", "NAME", "TYPE", "COLOR", "BIRTHDATE", "SOLDDATE", "PREVIOUSOWNER", "PRICE");
            //Console.WriteLine("| {0,-20}| {1,-10}| {2,2}|", "NAME", "COLOR", "ID");
            //Console.WriteLine("+---------------------+-----------+---+");
            foreach (var item in list)
            {
                Console.WriteLine("| {0}| {1}| {2}| {3}| {4}| {5}| {6}| {7}|", item.ID, item.Name, item.Type, item.Color, item.Birthdate, item.Solddate, item.PreviousOwner, item.Price);
                //Console.WriteLine("| {0,-20}| {1,-10}| {2,2}|", item.Name, item.Color, item.ID);
                //Console.WriteLine("+---------------------+-----------+---+");
            }
        }
    }
}
