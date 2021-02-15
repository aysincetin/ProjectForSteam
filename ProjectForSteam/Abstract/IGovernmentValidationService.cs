using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Abstract
{
    public interface IGovernmentValidationService
    {
        bool GovernmentValidation(Player player);
    }
}
