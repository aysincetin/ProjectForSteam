using ProjectForSteam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForSteam.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void SaveInfo(Player player)
        {
            Console.WriteLine("Saved this player : " + player.FirstName + " " + player.LastName);
        }

        public virtual void UpdateInfo(Player player)
        {
            Console.WriteLine("Updated this player : " + player.FirstName + " " + player.LastName);
        }

        public virtual void DeleteInfo(Player player)
        {
            Console.WriteLine("Deleted this player : " + player.FirstName + " " + player.LastName);
        }

      

       
    }
}
