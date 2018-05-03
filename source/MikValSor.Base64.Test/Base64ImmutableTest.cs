using NUnit.Framework;

namespace MikValSor.Base32.Test
{
	[TestFixture]
	public class Base64ImmutableTest
	{
		[Test]
		public void ImmutableTest()
		{
			//Arrange
			var validator = new MikValSor.Immutable.ImmutableValidator();
			var target = typeof(MikValSor.Encoding.Base64);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}
