#region Exploring unary operators

int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");

#endregion

#region Exploring binary arithmetic operators

int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion

#region Null-coalescing operators
//string? authorName = GetAuthorName(); //A fictional function.

// The maxLength variable will be the length of authorName if it is not null,
// or 30 if authorName is null.
// int maxLength = authorName?.Length ?? 30;

// The authorName variable will be "unknown" if authorName was null.
//author ??= "unknown"; 
#endregion

