using System.Numerics;
using System.Text;
namespace Exercise_NumbersAsWordsLib;

public static class NumberExtensions
{
    static string[] bases = ["hundred", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion",
    "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion",
    "quattuordecillion", "quindecillion", "sedecillion", "septendecillion", "octodecillion", "novendecillion", "vigintillion", "unvigintillion", "duovigintillion", "tresvigintillion", "quattuorvigintillion",
    "quinvigintillion", "sesvigintillion", "septemvigintillion",
    "octovigintillion", "novemvigintillion", "trigintillion"];

    static string[] uniqueNums = ["zero", "one", "two", "three", "four", "five",
    "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen",
    "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];

    static string[] tens = ["ten", "twenty", "thirty", "forty", "fifty", "sixty",
    "seventy", "eighty", "ninety"];

    public static string ToWords(this short num)
    {
        return ToWords((BigInteger)num);
    }
    public static string ToWords(this int num)
    {
        return ToWords((BigInteger)num);
    }

    public static string ToWords(this long num)
    {
        return ToWords((BigInteger)num);
    }

        public static string ToWords(this BigInteger num)
    {
        if (num == 0)
            return "zero";

        LinkedList<string> numberParts = new();
        StringBuilder stringBuilder = new();
        BigInteger temp = BigInteger.Abs(num);
        int baseIndex = 0;

        while (temp > 0)
        {
            int segment = (int)(temp % 1000);
            if (segment >= 100)
            {
                int index = segment / 100;
                int remainder = segment % 100;
                stringBuilder.Append($"{uniqueNums[index]} {bases[0]}{((remainder > 0) ? " and " : "")}");
                segment -= index * 100;
            }
            else if (baseIndex == 0 && num > 1000 && segment > 0)
            {
                stringBuilder.Append("and ");
            }

            if (segment >= 20)
            {
                int index = segment / 10;
                int remainder = segment % 10;
                stringBuilder.Append($"{tens[index - 1]}{((remainder > 0) ? $"-{uniqueNums[remainder]}" : "")}");
            }
            else if (segment > 0)
            {
                stringBuilder.Append(uniqueNums[segment]);
            }

            if (baseIndex > 0 && temp % 1000 > 0)
            {
                if (baseIndex >= bases.Length)
                    throw new Exception("WAY TOO LARGE!");

                stringBuilder.Append($" {bases[baseIndex]}");
            }

            if (stringBuilder.Length > 0)
            {
                numberParts.AddFirst(stringBuilder.ToString());
                stringBuilder.Clear();
            }

            ++baseIndex;
            temp /= 1000;
        }

        return $"{((num < 0) ? "negative " : "")}{string.Join(", ", numberParts)}";
    }
}
