
namespace portfolio_v2.Services;

public class ThemeService
{
    public string CurrentTheme { get; private set; } = "darkVS";
    public event Action? OnChange;

    public void SetTheme(string theme)
    {
        CurrentTheme = theme;
        OnChange?.Invoke();
    }
}