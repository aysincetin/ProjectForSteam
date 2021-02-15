using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign(Game game);
        void UpdateCampaign(Game game);
        void DeleteCampaign(Game game);
    }
}
