namespace RockPaperScissors.Extensions
{
    public static class StringExtensions
    {
        public static string ToCapital(this string str)
        {
            return str[0].ToString().ToUpper() + str[1..];
        }
    }
}
