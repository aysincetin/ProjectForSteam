using ProjectForSteam.Abstract;
using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void AddCampaign(Game game)
        {
            Console.WriteLine("Winter season sale Added : " + game.Id + "-" + game.GameName + "-" + game.UnitPrice  + "TL");
        }

        public void UpdateCampaign(Game game)
        {
            Console.WriteLine("Winter season sale Updated : " + game.Id + "-" + game.GameName + "-" + game.UnitPrice + "TL");
        }

        public void DeleteCampaign(Game game)
        {
            Console.WriteLine("Summer season sale Deleted : " + game.Id + " -" + game.GameName + " -" + game.UnitPrice + "TL");
        }

        public void Order(Player player)
        {
            Console.WriteLine("This order is successful" + player.FirstName + " " + player.LastName);
        }
    }
}
