using ProjectForSteam.Abstract;
using ProjectForSteam.Adapters;
using ProjectForSteam.Concrete;
using ProjectForSteam.Entities;
using System;


namespace ProjectForSteam
{
    class Program
    {
        static void Main(string[] args)
        {

            BasePlayerManager playerManager = new PlayerManager(new KPSPublicServiceAdapter());
            playerManager.SaveInfo(new Player { DateOfBirth = new DateTime(1996, 10, 10), FirstName = "YOUR_NAME", LastName = "YOUR_LASTNAME", IdendityNumber = 12345678 });
            playerManager.UpdateInfo(new Player { DateOfBirth = new DateTime(1996, 10, 10), FirstName = "YOUR_NAME", LastName = "YOUR_LASTNAME", IdendityNumber = 12345678 });
            playerManager.DeleteInfo(new Player { DateOfBirth = new DateTime(1996, 10, 10), FirstName = "YOUR_NAME", LastName = "YOUR_LASTNAME", IdendityNumber = 12345678 });
            
            Console.WriteLine("________________________________________");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(new Game {Id=1,GameName= "Assassin's Creed", UnitPrice = 80});
            campaignManager.UpdateCampaign(new Game { Id = 2, GameName = "The Witcher", UnitPrice = 12 });
            campaignManager.DeleteCampaign(new Game { Id = 2, GameName = "The Witcher", UnitPrice = 12 });

            Console.WriteLine("________________________________________");

            GameManager gameManager = new GameManager();
            gameManager.Order(new Player {Id=1,FirstName="Aysin",LastName= "Çetin",DateOfBirth=new DateTime(1996,10,10), IdendityNumber=12345678});

           Console.ReadLine();
        }
    }
}
