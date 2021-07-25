namespace RockPaperScissors.Services
{
    public class Dueler : IDueler
    {
        private const string Draw = "Draw";
        private const string Victory = "Victory";
        private const string Defeat = "Defeat";

        public string Duel(string playerWeapon, string aiWeapon)
        {
            if (playerWeapon == aiWeapon)
                return Draw;
            else if (playerWeapon == "rock" && aiWeapon == "scissors")
                return Victory;
            else if (playerWeapon == "paper" && aiWeapon == "rock")
                return Victory;
            else if (playerWeapon == "scissors" && aiWeapon == "paper")
                return Victory;
            else
                return Defeat;
        }
    }
}
