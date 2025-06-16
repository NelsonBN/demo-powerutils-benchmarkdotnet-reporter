namespace Demo;

public static class StringProcessor
{
    private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    public static string Generate()
    {
        var count = Random.Shared.Next(1_000, 10_000);

        var result = "";
        for(var i = 0; i < count; i++)
        {
            result += CHARS[Random.Shared.Next(CHARS.Length)];
        }

        return result;
    }
}
