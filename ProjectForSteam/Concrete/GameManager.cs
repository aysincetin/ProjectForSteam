using ProjectForSteam.Abstract;
using ProjectForSteam.Adapters;
using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Concrete
{
    class GameManager : IGameService
    {
        public void Order(Player player)
        {
            Console.WriteLine( "Game is ordered: " + player.FirstName +" "+ player.LastName);
        }
    }
}
