using System.Reflection;

var Separator = new String('_', 112);
WriteLine(Separator);
WriteLine($"{"Type",-10}{"Bytes(s) of memory"}{"Min",42}{"Max",42}");
WriteLine(Separator);
unsafe
{
WriteLine($"{typeof(sbyte).Name,-10}{sizeof(sbyte),18}{sbyte.MinValue,42}{sbyte.MaxValue,42}");
WriteLine($"{typeof(byte).Name,-10}{sizeof(byte),18}{byte.MinValue,42}{byte.MaxValue,42}");
WriteLine($"{typeof(short).Name,-10}{sizeof(short),18}{short.MinValue,42}{short.MaxValue,42}");
WriteLine($"{typeof(ushort).Name,-10}{sizeof(ushort),18}{ushort.MinValue,42}{ushort.MaxValue,42}");
WriteLine($"{typeof(int).Name,-10}{sizeof(int),18}{int.MinValue,42}{int.MaxValue,42}");
WriteLine($"{typeof(uint).Name,-10}{sizeof(uint),18}{uint.MinValue,42}{uint.MaxValue,42}");
WriteLine($"{typeof(long).Name,-10}{sizeof(long),18}{long.MinValue,42}{long.MaxValue,42}");
WriteLine($"{typeof(ulong).Name,-10}{sizeof(ulong),18}{ulong.MinValue,42}{ulong.MaxValue,42}");
WriteLine($"{typeof(Int128).Name,-10}{sizeof(Int128),18}{Int128.MinValue,42}{Int128.MaxValue,42}");
WriteLine($"{typeof(UInt128).Name,-10}{sizeof(UInt128),18}{UInt128.MinValue,42}{UInt128.MaxValue,42}");
WriteLine($"{typeof(Half).Name,-10}{sizeof(Half),18}{Half.MinValue,42}{Half.MaxValue,42}");
WriteLine($"{typeof(float).Name,-10}{sizeof(float),18}{float.MinValue,42}{float.MaxValue,42}");
WriteLine($"{typeof(double).Name,-10}{sizeof(double),18}{double.MinValue,42}{double.MaxValue,42}");
WriteLine($"{typeof(decimal).Name,-10}{sizeof(decimal),18}{decimal.MinValue,42}{decimal.MaxValue,42}");
}

WriteLine(Environment.Version);
WriteLine(typeof(object).Assembly.ImageRuntimeVersion);