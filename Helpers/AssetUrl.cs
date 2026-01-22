namespace portfolio_v2.Helpers;

public static class AssetUrl
{
    public static string NoCache(string path)
        => $"{path}?v={DateTime.UtcNow.Ticks}";

}