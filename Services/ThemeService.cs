
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace portfolio_v2.Services;

public class ThemeService(IJSRuntime jsRuntime)
{
    private readonly IJSRuntime _jsRuntime = jsRuntime;
    public string CurrentTheme { get; private set; } = "darkVS";
    public event Action? OnChange;

    public async Task SetTheme(string theme)
    {
        CurrentTheme = theme;
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "theme", theme);
        OnChange?.Invoke();
    }
}