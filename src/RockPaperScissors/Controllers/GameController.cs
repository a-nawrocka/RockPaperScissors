using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Extensions;
using RockPaperScissors.Models;
using RockPaperScissors.Services;
using System;

namespace RockPaperScissors.Controllers
{
    public class GameController : Controller
    {
        private readonly IDueler _dueler;

        public GameController(IDueler dueler)
        {
            _dueler = dueler;
        }

        public IActionResult Weapons()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Battle(string weapon)
        {
            var aiWeapon = GetAIWeapon();

            var model = new BattleViewModel
            {
                PlayerWeapon = weapon.ToCapital(),
                AIWeapon = aiWeapon.ToCapital(),
                BattleResult = _dueler.Duel(weapon, aiWeapon)
            };

            return View(model);
        }

        private string GetAIWeapon()
        {
            var weapons = new string[] { "rock", "paper", "scissors" };
            var rand = new Random();
            int index = rand.Next(weapons.Length);
            return weapons[index];
        }
    }
}
