using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameBackend.Entities
{
   public class Player
    {
        public int PlayerId { get; set; }
        public string NationaltyId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Boolean IsStudent { get; set; }
        public DateTime KayıtOlmaTarihi { get; set; }

    }
}
