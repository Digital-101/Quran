namespace Quran.Data;

public class Verse
{
    public int Number { get; set; }
    public string ArabicText { get; set; } = string.Empty;
    public string Transliteration { get; set; } = string.Empty;
    public string Translation { get; set; } = string.Empty;
    public string Zulu { get; set; } = string.Empty;

}

public class Surah
{
    public int Number { get; set; }
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string Translation { get; set; } = string.Empty;
    public string Meaning { get; set; } = string.Empty;
    public string? Transliteration { get; set; }
    public List<Verse> Verses { get; set; } = new();
}
