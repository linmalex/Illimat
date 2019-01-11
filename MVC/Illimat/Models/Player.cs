using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Illimat.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IllimatCard> Hand { get; set; }
        public int IllimatWinCount { get; set; }
    }
}