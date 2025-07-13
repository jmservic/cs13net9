using System.Text.RegularExpressions; // To use Regex.

namespace Packt.Shared;

public static class StringExtensions
{
    public static bool IsValidXmlTag(this string input)
    {
        return Regex.IsMatch(input,
        @"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s\s+\/>)$");
    }

    public static bool IsValidPassword(this string input)
    {
        // Minmum of eight valid characters.
        return Regex.IsMatch(input, "^[a-zA-Z9-9_-]{8,}$");
    }
}