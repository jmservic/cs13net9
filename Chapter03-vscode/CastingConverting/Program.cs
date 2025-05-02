#region Casting numbers implicitly and explicitly
int a = 10;
double b = a; // An int can be safely cast into a double
WriteLine($"a is {a}, b is {b}");
double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = 5_000_000_000;// long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
#endregion

#region How negative numbers are represented in binary
#endregion