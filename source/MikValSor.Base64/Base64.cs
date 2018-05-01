namespace MikValSor.Encoding
{
	/// <summary>
	///		This class is a immutable representation of a Base64 encoding.
	/// </summary>
	public class Base64
	{
		private readonly byte[] ByteArray;
		private readonly string Value;

		/// <summary>
		///		Encoding for mat of the Base64 value.
		/// </summary>
		public readonly Base64Format Format;

		private Base64(byte[] byteArray, string value, Base64Format format)
		{
			ByteArray = byteArray;
			Value = value;
			Format = format;
		}


		/// <summary>
		///		Constructs a Base64 value from a byte array.
		/// </summary>
		/// <param name="byteArray">
		///		Source byte array for the Base64 value.
		/// </param>
		/// <param name="format">
		///		Specifies the Base64 encoding format.
		/// </param>
		public Base64(byte[] byteArray, Base64Format format = Base64Format.RFC4648)
		{
			ByteArray = byteArray;
			Value = System.Convert.ToBase64String(ByteArray);
			Format = format;
		}


		/// <summary>
		///		Converts the Base64 value to byte array.
		/// </summary>
		/// <returns>
		///		Returns byte array value presentation of the Base64 encoding.
		/// </returns>
		public byte[] ToByteArray()
		{
			return (byte[])ByteArray.Clone();
		}
		/// <summary>
		///		Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">
		///		The object to compare with the current object.
		/// </param>
		/// <returns>
		///		True if the specified object is equal to the current object; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			var objBase64 = obj as Base64;
			if (objBase64 == null) return false;
			if (Format != objBase64.Format) return false;
			return Value.Equals(objBase64.Value);
		}

		/// <summary>
		///		Returns a string that represents the Base64 value.
		/// </summary>
		/// <returns>
		///		A string that represents the Base64 value.
		/// </returns>
		public override string ToString()
		{
			return Value;
		}

		/// <summary>
		///		Return hash value of the Base64 value.
		/// </summary>
		/// <returns>
		///		A hash code for the current Base64 value.
		/// </returns>
		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		/// <summary>
		///		Parses a Base64 formated string to Base64 object.
		/// </summary>
		/// <param name="base64">
		///		Base64 formated string.
		/// </param>
		/// <param name="format">
		///		Specify the Base64 encoding format.
		/// </param>
		/// <returns>
		///		A Base64 representation of the Base64 formated string.
		/// </returns>
		public static Base64 Parse(string base64, Base64Format format = Base64Format.RFC4648)
		{
			if (base64 == null) throw new System.ArgumentNullException(nameof(base64));
			var byteArray = System.Convert.FromBase64String(base64);
			return new Base64(byteArray, base64, format);
		}


		/// <summary>
		///		Tryies to parses a Base64 formated string to Base64 object.
		/// </summary>
		/// <param name="base64string">
		///		Base64 formates string.
		/// </param>
		/// <param name="base64">
		///		Return Base64 representation of the Base64 formated string.
		/// </param>
		/// <param name="format">
		///		Specify the Base64 encoding format.
		/// </param>
		/// <returns>
		///		True if Parse of string was successful.
		/// </returns>
		public static bool TryParse(string base64string, out Base64 base64, Base64Format format = Base64Format.RFC4648)
		{
			try
			{
				base64 = Parse(base64string, format);
				return true;
			}
			catch (System.Exception)
			{
				base64 = null;
				return false;
			}
		}
	}
}
