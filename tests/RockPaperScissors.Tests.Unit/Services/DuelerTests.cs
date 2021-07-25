using NUnit.Framework;
using RockPaperScissors.Services;

namespace RockPaperScissors.Tests.Unit.Services
{
    public class DuelerTests
    {
        private IDueler _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Dueler();
        }

        [TestCase("rock", "scissors", "Victory")]
        [TestCase("paper", "rock", "Victory")]
        [TestCase("scissors", "paper", "Victory")]
        [TestCase("rock", "rock", "Draw")]
        [TestCase("scissors", "scissors", "Draw")]
        [TestCase("paper", "paper", "Draw")]
        [TestCase("scissors", "rock", "Defeat")]
        [TestCase("rock", "paper", "Defeat")]
        [TestCase("paper", "scissors", "Defeat")]
        public void GivenPlayerWeaponAndAIWeapon_WhenDuelIsCalled_ThenCorrectResultIsReturned(string playerWeapon, string aiWeapon, string expectedResult)
        {
            var actual = _sut.Duel(playerWeapon, aiWeapon);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
