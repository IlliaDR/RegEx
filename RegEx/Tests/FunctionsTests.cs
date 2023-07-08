using BLL;

namespace Tests
{
	public class FunctionsTests
	{
		[Fact]
		public void ValidateString_InputTooShort_ReturnsFalse()
		{
			string testString = "T1#";
			Assert.False(Functions.ValidateString(testString, 4));
		}

		[Fact]
		public void ValidateString_InputTooLong_ReturnsFalse()
		{
			string testString = "AbC1@XyzEfg#AbC1@XyzEfg";
			Assert.False(Functions.ValidateString(testString, 10));
		}

		[Fact]
		public void ValidateString_InputLengthMatching_ReturnsTrue()
		{
			string testString = "Test123#";
			Assert.True(Functions.ValidateString(testString, 8));
		}

		[Fact]
		public void ValidateString_MissingUppercase_ReturnsFalse()
		{
			string testString = "test123#";
			Assert.False(Functions.ValidateString(testString, 10));
		}

		[Fact]
		public void ValidateString_MissingLowercase_ReturnsFalse()
		{
			string testString = "TEST123#";
			Assert.False(Functions.ValidateString(testString, 10));
		}

		[Fact]
		public void ValidateString_MissingDigit_ReturnsFalse()
		{
			string testString = "Test@#Test";
			Assert.False(Functions.ValidateString(testString, 10));
		}

		[Fact]
		public void ValidateString_MissingSpecialCharacter_ReturnsFalse()
		{
			string testString = "Test123Test";
			Assert.False(Functions.ValidateString(testString, 12));
		}

		[Fact]
		public void ValidateString_WhitespaceInVariousPositions_ReturnsFalse()
		{
			string testString1 = " Test123#";
			string testString2 = "Test 123#";
			string testString3 = "Test123# ";
			Assert.False(Functions.ValidateString(testString1, 9));
			Assert.False(Functions.ValidateString(testString2, 9));
			Assert.False(Functions.ValidateString(testString3, 9));
		}
	}

}