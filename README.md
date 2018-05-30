.NET Standard Library for Base64 value type in a style equivalent to MikValSor.Base32

Nuget package: [https://www.nuget.org/packages/MikValSor.Base64](https://www.nuget.org/packages/MikValSor.Base64)

## Value Type Encode Example:
```cs
void ValueTypeEncodeExample()
{
	var bytearray = new byte[] { 0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11 };
	MikValSor.Encoding.Base64 base64 = new MikValSor.Encoding.Base64(bytearray);
	
	System.Console.WriteLine($"base64: {base64}");
}
/**
	Output:
	base64: AAECBAUGBwgJCgs=
**/
```

## Value Type Parse Example:
```cs
void ValueTypeParseExample()
{
	var base64string = "AAECBAUGBwgJCgs=";
	MikValSor.Encoding.Base64 base64 = MikValSor.Encoding.Base64.Parse(base64string);
	var bytearray = base64.ToByteArray();

	for (var i = 0; i < bytearray.Length; i++)
	{
		System.Console.WriteLine($"bytearray[{i}]: {bytearray[i]}");
	}
}
/**
	Output:
	bytearray[0]: 0
	bytearray[1]: 1
	bytearray[2]: 2
	bytearray[3]: 4
	bytearray[4]: 5
	bytearray[5]: 6
	bytearray[6]: 7
	bytearray[7]: 8
	bytearray[8]: 9
	bytearray[9]: 10
	bytearray[10]: 11
**/
```