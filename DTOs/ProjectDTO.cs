using portfolio_v2.Enums;

namespace portfolio_v2.DTOs;

public class ProjectDTO
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public List<ETech> Techs { get; set; } = new();
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? DeployUrl { get; set; }
}