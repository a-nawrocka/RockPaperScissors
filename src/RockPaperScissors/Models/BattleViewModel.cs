using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class BattleViewModel
    {
        public string PlayerWeapon { get; set; }
        public string AIWeapon { get; set; }
        public string BattleResult { get; set; }
    }
}
