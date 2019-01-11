using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Illimat.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime DatePlayed { get; set; }
        public string Name { get; set; }
        public Player ActivePlayer { get; set; }

        public virtual List<Player> PlayerList { get; set; }

    }
}