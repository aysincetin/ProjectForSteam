using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSteam.Abstract
{
    public interface IPlayerService
    {
        void SaveInfo(Player player);
        void UpdateInfo(Player player);
        void DeleteInfo(Player player);
    }
}
