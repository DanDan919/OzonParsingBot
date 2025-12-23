namespace Core;

public static class RateLimiter
{
    public static async Task RandomDelay()
    {
        await Task.Delay(Random.Shared.Next(3000, 8000));
    }
}