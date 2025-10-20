// null namespace to merge with auto-generated Program.

partial class Program
{
    private static void SectionTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"**** {title} ****");
        ForegroundColor = previousColor;
    }

    private static void DictionaryToTable(IDictionary dictionary)
    {
        Table table = new();
        table.AddColumn("Key");
        table.AddColumn("Value");

        foreach (string key in dictionary.Keys)
        {
            // Some env var values are being interpreted as markup
            try
            {
                table.AddRow(key, dictionary[key]!.ToString()!);
            }
            catch (Exception ex)
            {
                table.AddRow(key, ex.Message);
                WriteLine($"{key} - {dictionary[key]}");
            }
        }

        AnsiConsole.Write(table);
    }
}