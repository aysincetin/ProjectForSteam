using ProjectForSteam.Abstract;
using ProjectForSteam.Entities;
using System;

namespace ProjectForSteam.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private IGovernmentValidationService _governmentValidationService;
        public PlayerManager(IGovernmentValidationService governmentValidationService)
        {
            _governmentValidationService = governmentValidationService;
        }
        public override void SaveInfo(Player player)
        {
            if (_governmentValidationService.GovernmentValidation(player))
            {
                base.SaveInfo(player);
            }
            else
            {
                Console.WriteLine("This person cannot be saved because it is not valid");
               // throw new Exception("Not a valid person");
            }

        }

        public override void UpdateInfo(Player player)
        {
            if (_governmentValidationService.GovernmentValidation(player))
            {
                base.UpdateInfo(player);
            }
            else
            {
                Console.WriteLine("This person cannot be updated because it is not valid");
              // throw new Exception("Not a valid person");
            }
        }

        public override void DeleteInfo(Player player)
        {
            if (_governmentValidationService.GovernmentValidation(player))
            {
                base.DeleteInfo(player);
            }
            else
            {
                Console.WriteLine("This person cannot be deleted because it is not valid");
               // throw new Exception("Not a valid person");
            }
        }
    }
}
