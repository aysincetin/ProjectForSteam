using ProjectForSteam.Abstract;
using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Concrete
{
    class GovernmentValidationManager : IGovernmentValidationService
    {
        public bool GovernmentValidation(Player player)
        {
            return true;
        }
    }


}
