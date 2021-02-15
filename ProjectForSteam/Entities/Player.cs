using System;
using System.Collections.Generic;
using System.Text;
using ProjectForSteam.Abstract;

namespace ProjectForSteam.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public long IdendityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
