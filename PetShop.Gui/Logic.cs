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

        public void Test()
        {
            DateTime dateTime;
            while (!DateTime.TryParse(AskQuestion("Type In DateTime"), out dateTime))
            {
                Console.WriteLine("WRONG!!!!");
            }
            Console.WriteLine("DateTime: {0}", dateTime);

            //bool TryParse(string s, out DateTime result);
        }

        public void CreateNewPet()
        {

            Pet newPet = new Pet()
            {
                Name = AskQuestion("Type Name Please:"),
                Type = AskQuestion("Type Type Please:"),
                Color = AskQuestion("Type Color Please:"),
                Birthdate = AskForDate("Type pets birthdate:"),
                Solddate = AskForDate("Type sold date"),
                PreviousOwner = AskQuestion("Type Name of former owner Please:"),
                Price = Convert.ToDouble(AskQuestion("Type in prize please:"))
            };
            bool success = _petService.CreateNewPet(newPet);
        }

        public void DeletePetById()
        {
            int petId;
            string q = "Type the id of the pet to delete:";

            while (!int.TryParse(AskQuestion(q), out petId))
            {
                Console.WriteLine("A number please!");
            }
            bool Succes = _petService.DeletePetById(petId);
            if (Succes)
            {
                Console.WriteLine("\nThe Pet was successfully deleted!");
            }
            else
            {
                Console.WriteLine("\nNo Pet with that id found!");
            }
            
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

        private string AskQuestion(string quest)
        {
            Console.Write(" {0} ", quest);
            return Console.ReadLine();
        }

        public DateTime AskForDate(string q)
        {
            Console.WriteLine(q);
            DateTime dateTime;
            while (!DateTime.TryParse(AskQuestion("Type In Date in format: DD/MM/YY "), out dateTime))
            {
                Console.WriteLine("WRONG!!!!");
            }
            return dateTime;
        }

        private int AskForInt(string q)
        {
            int number;
            while (!int.TryParse(AskQuestion(q), out number))
            {
                Console.WriteLine("A number please!");
            }
            return number;
        }

        private double AskForDouble(string q)
        {
            double number;
            while (!double.TryParse(AskQuestion(q), out number))
            {
                Console.WriteLine("A double please!");
            }
            return number;
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

        public void UpdatePet()
        {
            Pet UpdatedPet = new Pet()
            {
                ID = AskForInt("Type the id of the pet you want to update"),
                Name = AskQuestion("Type new Name Please:"),
                Type = AskQuestion("Type new Type Please:"),
                Color = AskQuestion("Type new Color Please:"),
                Birthdate = AskForDate("Type pets birthdate:"),
                Solddate = AskForDate("Type sold date"),
                PreviousOwner = AskQuestion("Type Name of former owner Please:"),
                Price = AskForDouble("Type in prize please:")
                //Price = Convert.ToDouble(AskQuestion("Type in prize please:"))
            };
            bool success = _petService.UpdatePet(UpdatedPet);
            Console.WriteLine(success?"Pet updated successsfuly":"No pet with that id found");
        }
    }
}
