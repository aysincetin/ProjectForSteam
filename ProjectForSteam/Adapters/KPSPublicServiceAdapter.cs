using ProjectForSteam.Abstract;
using ProjectForSteam.Entities;
using ProjectForSteam.KPSPublicServiceReference;
using System;

namespace ProjectForSteam.Adapters
{
    class KPSPublicServiceAdapter : IGovernmentValidationService
    {
        public bool GovernmentValidation(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.IdendityNumber), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year);
        }
    }
}
