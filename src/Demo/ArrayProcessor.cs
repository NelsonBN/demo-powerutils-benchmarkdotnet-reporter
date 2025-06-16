namespace Demo;

public static class ArrayProcessor
{
    public static int[] Generate()
    {
        var count = Random.Shared.Next(1_000, 10_000);
        var result = new int[count];

        for(var i = 0; i < count; i++)
        {
            result[i] = Random.Shared.Next(1, 1_000_000);
        }

        return result;
    }
}
