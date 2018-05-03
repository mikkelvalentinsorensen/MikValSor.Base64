using NUnit.Framework;

namespace MikValSor.Base32.Test
{
	[TestFixture]
	public class Base64SerializableTest
	{
		[Test]
		public void SerializableTest()
		{
			var validator = new MikValSor.Runtime.Serialization.SerializableValidator();
			var target = typeof(MikValSor.Encoding.Base64);

			//Act
			validator.EnsureSerializable(target);

			//Assert
		}
	}
}
