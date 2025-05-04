int max = 500;

if(max > byte.MaxValue)
{
    WriteLine($"{max} is too large for a byte. Use a value less than or equal to {byte.MaxValue}.");
    return;
}
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}