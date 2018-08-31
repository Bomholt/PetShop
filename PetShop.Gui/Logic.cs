using Bomholt.PetShop.UI.InterF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bomholt.PetShop.UI
{
    class Logic : ILogic 
    {
        public void Exit()
        {
            Console.Clear();
            for (int i = 0; i < 327; i++)
            {
                Console.Write("       EXIT");
                Thread.Sleep(1);
            }
        }
    }
}
