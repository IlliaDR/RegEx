using System.Text.RegularExpressions;

namespace BLL
{
	public class Functions
	{
		public static bool ValidateString(string str, int maxLength)
		{
			//Check length
			if (str.Length > maxLength)
				return false;

			//Check lowercase, uppercase, digit, special character
			string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])";

			//Check whitespace
			pattern += @"[^\s]{" + str.Length + "}$";

			return Regex.IsMatch(str, pattern);
		}
	}
}
